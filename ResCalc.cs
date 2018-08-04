using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ResistanceSelectionTool
{
    public class ResCalc
    {
        #region 字段
        private double[] _ArrayResData;
        private double _ResValue;
        private int _ResCount;

        private Thread ThreadResCalcProcess;
        private bool isRun = false;
        #endregion

        #region 属性
        public double[] ArrayResData { get => _ArrayResData; set => _ArrayResData = value; }
        public double ResValue { get => _ResValue; set => _ResValue = value; }
        public int ResCount
        {
            get
            {
                return _ResCount;
            }
            set
            {
                if (value < 2)
                {
                    value = 2;
                }
                _ResCount = value;
            }
        }
        #endregion

        #region 事件
        /// <summary>
        /// 电阻计算结果事件委托
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="message">消息内容</param>
        /// <param name="value">完成进度/阻值结果</param>
        public delegate void DelegateResCalcReturn(EnumResCalcStatus status, string message, double percent, double[] value);

        /// <summary>
        /// 电阻计算结果事件
        /// </summary>
        public event DelegateResCalcReturn EventResCalcReturn;
        #endregion

        #region 构造函数
        public ResCalc(double[] data, double value, int count)
        {
            ArrayResData = data;
            ResValue = value;
            ResCount = count;
            ThreadResCalcProcess = new Thread(new ThreadStart(ThreadResCalcProcess_Event));
            ThreadResCalcProcess.IsBackground = true;
        }
        #endregion

        #region 公共函数
        public void Start()
        {
            isRun = true;
            ThreadResCalcProcess.Start();
        }

        public void Stop()
        {
            isRun = false;
        }

        public static double CalcParallel(params double[] arrValue)
        {
            double ret = 1 / arrValue[0];
            for (int i = 1; i < arrValue.Length; i++) 
            {
                ret = ret + (1 / arrValue[i]);
            }
            return 1 / ret;
        }
        #endregion

        #region 计算处理方法
        private void ThreadResCalcProcess_Event()
        {
            int num = 0;
            double percent = 0;
            double percentCnt = 0;
            double[] realRes = ArrayResData;
            double[] arrBestResValue = new double[ArrayResData.Length];

            Stopwatch Watch = new Stopwatch();
            Watch.Start();

            //一周目
            for (int i = 0; i < ArrayResData.Length; i++)
            {
                if (Math.Abs(ArrayResData[i] - ResValue) < Math.Abs(ArrayResData[num] - ResValue))
                {
                    num = i;
                }
            }
            arrBestResValue[0] = ArrayResData[num];
            Console.WriteLine("1周目，最接近的结果在第 " + num + " 位置，结果为" + ArrayResData[num]);

            //二周目及其以后
            percentCnt = ArrayResData.Length;
            for (int cnt = 1; cnt < ResCount; cnt++)
            {
                if (realRes.Length * ArrayResData.Length > 100000000)
                {
                    Console.WriteLine("计算量太大，无法完成，提前结束运算。");
                    EventResCalcReturn(EnumResCalcStatus.Error, "计算量太大，无法完成，提前结束运算。", 100, new double[0]);
                    return;
                }
                num = 0;
                List<double> listResData = new List<double>();
                for (int i = 0; i < realRes.Length; i++)
                {
                    if (i % (ArrayResData.Length * 500) == 1)
                    {
                        percent = percentCnt / Math.Pow(ArrayResData.Length, ResCount) * 96;
                        EventResCalcReturn(EnumResCalcStatus.Run, (Math.Pow(ArrayResData.Length, cnt - 1) + i).ToString() + "运行中。。。" , percent, new double[0]);
                    }
                    for (int j = 0; j < ArrayResData.Length; j++)
                    {
                        percentCnt++;
                        double result = CalcParallel(realRes[i], ArrayResData[j]);
                        listResData.Add(result);
                        if (Math.Abs(result - ResValue) < Math.Abs(listResData[num] - ResValue))
                        {
                            num = listResData.Count - 1;
                        }
                    }
                }
                realRes = listResData.ToArray();
                arrBestResValue[cnt] = realRes[num];
                Console.WriteLine((cnt + 1) + "周目，最接近的结果在第 " + num + " 位置，结果为" + realRes[num]);
                GetParallelResult(cnt, num, out double[] arrResData);
                if (ResCount == cnt + 1)
                {
                    Watch.Stop();
                    long watchTime = Watch.ElapsedMilliseconds;//花费时间
                    EventResCalcReturn(EnumResCalcStatus.Done, string.Format("计算完成，用时：{0:0.###}秒", Watch.Elapsed.TotalSeconds), 100, arrResData);
                }
                else
                {
                    EventResCalcReturn(EnumResCalcStatus.Done, "阶段性完成", percent, arrResData);
                }
            }
        }

        /// <summary>
        /// 获取并联结果
        /// </summary>
        /// <param name="loopCnt">循环次数</param>
        /// <param name="num">位置</param>
        /// <param name="ret">返回数组</param>
        private void GetParallelResult(int loopCnt, int num, out double[] ret)
        {
            string log = "并联结果：";
            ret = new double[loopCnt + 1];
            for (int i = 0; i < loopCnt + 1; i++)
            {
                ret[i] = ArrayResData[num % ArrayResData.Length];
                num = num / ArrayResData.Length;
                log += string.Format("{0:#.##}\t", ret[i]);
            }
            Console.WriteLine(log);
        }
        #endregion

    }

    public enum EnumResCalcStatus
    {
        Start,
        Run,
        Done,
        Wait,
        Error
    }
}

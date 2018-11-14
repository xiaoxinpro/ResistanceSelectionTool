using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResistanceSelectionTool
{
    public class ResBoostMode
    {

        #region 字段
        private Task TaskResBoost;
        #endregion

        #region 属性
        public double VolFB { get; set; }
        public double VolPWM { get; set; }
        public double VolOutMin { get; set; }
        public double VolOutMax { get; set; }
        public double VolBias { get; set; }
        public double[] ArrayResData { get; set; }
        #endregion

        #region 构造函数
        public ResBoostMode(double[] data, double Vfb = 0.6, double Vpwm = 3.3, double VoutMin = 3, double VoutMax = 20, double Vbias = 2)
        {
            ArrayResData = data;
            VolFB = Vfb;
            VolPWM = Vpwm;
            VolOutMin = VoutMin;
            VolOutMax = VoutMax;
            VolBias = Vbias;
            TaskResBoost = new Task(() => ThreadResBoostModeProcess_Event());
        }
        #endregion

        #region 事件
        /// <summary>
        /// 电阻计算结果事件委托
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="message">消息内容</param>
        /// <param name="value">完成进度/阻值结果</param>
        public delegate void DelegateResBoostModeReturn(EnumResCalcStatus status, string message, double percent, double[] value);

        /// <summary>
        /// 电阻计算结果事件
        /// </summary>
        public event DelegateResBoostModeReturn EventResBoostModeReturn;
        #endregion

        #region 公共函数
        public void Start()
        {
            TaskResBoost.Start();
        }

        public void Stop()
        {
            TaskResBoost.Dispose();
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

        #region 计算处理函数
        public void ThreadResBoostModeProcess_Event()
        {
            int cntResult = 0;
            double cntPercent = 0;
            double sumPercent = Math.Pow(ArrayResData.Length, 3);

            //开始计时
            Stopwatch Watch = new Stopwatch();
            Watch.Start();

            foreach (double RW1 in ArrayResData)
            {
                foreach (double RW2 in ArrayResData)
                {
                    foreach (double RW3 in ArrayResData)
                    {
                        double[] arrVout = CalculateOutputVoltage(RW1, RW2, RW3);
                        double VoutMin = arrVout[0];
                        double VoutMax = arrVout[1];
                        cntPercent++;
                        if (VoutMax <= VolOutMax + VolBias && VoutMax >=VolOutMax - VolBias && VoutMin <= VolOutMin + VolBias && VoutMin >= VolOutMin - VolBias)
                        {
                            double percent = cntPercent / sumPercent * 100;
                            EventResBoostModeReturn(EnumResCalcStatus.Done, "阶段性完成", percent, new double[] { RW1, RW2, RW3, VoutMin, VoutMax });
                            cntResult++;
                            //Console.WriteLine(string.Format("RW1={0}, RW2={1}, RW3={2}, VoutMax={3:F3}, VoutMin={4:F3}", RW1, RW2, RW3, VoutMax, VoutMin));
                        }
                    }
                }
            }
            Watch.Stop();
            long watchTime = Watch.ElapsedMilliseconds;//花费时间
            EventResBoostModeReturn(EnumResCalcStatus.Done, string.Format("计算完成，用时：{0:0.###}秒，得出{1}种方案。", Watch.Elapsed.TotalSeconds, cntResult), 100, new double[0] { });
        }

        private double[] CalculateOutputVoltage(double RW1, double RW2, double RW3)
        {
            double RW23 = CalcParallel(RW2, RW3);
            double RW13 = CalcParallel(RW1, RW3);
            double VoutMin = (VolFB - RW13 * VolPWM / (RW13 + RW2)) * (RW23 + RW1) / RW23;
            double VoutMax = (VolFB - 0) * (RW23 + RW1) / RW23;
            if (VoutMax < VoutMin)
            {
                return new double[] { VoutMax, VoutMin };
            }
            else
            {
                return new double[] { VoutMin, VoutMax };
            }
        }
        #endregion
    }

    public enum EnumResBoostModeStatus
    {
        Start,
        Run,
        Done,
        Wait,
        Error
    }
}

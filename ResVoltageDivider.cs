using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistanceSelectionTool
{
    public class ResVoltageDivider
    {
        #region 字段
        private Task TaskRes;
        #endregion

        #region 属性
        public bool IsResultVolOut { get; set; }
        public double VolIn { get; set; }
        public double VolOut { get; set; }
        public double VolBias { get; set; }
        public double[] ArrayResData { get; set; }
        #endregion

        #region 构造函数
        public ResVoltageDivider(double[] arrResData, double volIn = 3.3, double volOut = 1.2, double volBias = 0.1, bool isVolOut = true)
        {
            this.VolIn = volIn;
            this.VolOut = volOut;
            this.VolBias = volBias;
            this.ArrayResData = arrResData;
            this.IsResultVolOut = isVolOut;
            TaskRes = new Task(() => ThreadResVoltageDividerProcess_Event());
        }
        #endregion

        #region 公共函数
        public void Start()
        {
            TaskRes.Start();
        }

        public void Stop()
        {
            TaskRes.Dispose();
        }

        #endregion

        #region 事件
        /// <summary>
        /// 电阻计算结果事件委托
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="message">消息内容</param>
        /// <param name="value">完成进度/阻值结果</param>
        public delegate void DelegateResVoltageDividerReturn(EnumResCalcStatus status, string message, double percent, double[] value);

        /// <summary>
        /// 电阻计算结果事件
        /// </summary>
        public event DelegateResVoltageDividerReturn EventResVoltageDividerReturn;
        #endregion

        #region 计算处理函数

        private void ThreadResVoltageDividerProcess_Event()
        {
            int cntResult = 0;
            double cntPercent = 0;
            double sumPercent = Math.Pow(ArrayResData.Length, 3);

            //开始计时
            Stopwatch Watch = new Stopwatch();
            Watch.Start();

            double volMin, volMax;
            if (IsResultVolOut)
            {
                volMin = VolOut - VolBias;
                volMax = VolOut + VolBias;
            }
            else
            {
                volMin = VolIn - VolBias;
                volMax = VolIn + VolBias;
            }

            foreach (double RW1 in ArrayResData)
            {
                foreach (double RW2 in ArrayResData)
                {
                    double vol;
                    if (IsResultVolOut)
                    {
                        vol = RW1 / (RW1 + RW2) * VolIn;
                    }
                    else 
                    {
                        vol = (RW1 + RW2)/ RW1 * VolOut;
                    }
                    cntPercent++;
                    if (vol <= volMax && vol >= volMin)
                    {
                        double percent = cntPercent / sumPercent * 100;
                        EventResVoltageDividerReturn?.Invoke(EnumResCalcStatus.Done, "阶段性完成", percent, new double[] { RW1, RW2, vol });
                        cntResult++;
                    }
                }
            }

            Watch.Stop();
            long watchTime = Watch.ElapsedMilliseconds;//花费时间
            EventResVoltageDividerReturn?.Invoke(EnumResCalcStatus.Done, string.Format("计算完成，用时：{0:0.###}秒，得出{1}种方案。", Watch.Elapsed.TotalSeconds, cntResult), 100, new double[0] { });
        }


        #endregion

    }
}

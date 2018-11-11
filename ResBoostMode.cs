using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ResistanceSelectionTool
{
    public class ResBoostMode
    {

        #region 字段
        private Thread ThreadResBoostModeProcess;
        private bool isRun = false;
        #endregion

        #region 属性
        public double VolFB { get; set; }
        public double VolPWM { get; set; }
        public double VolOutMin { get; set; }
        public double VolOutMax { get; set; }
        public double[] ArrayResData { get; set; }
        #endregion

        #region 构造函数
        public ResBoostMode(double[] data, double Vfb = 0.6, double Vpwm = 0, double VoutMin = 3, double VoutMax = 9)
        {
            ArrayResData = data;
            VolFB = Vfb;
            VolPWM = Vpwm;
            VolOutMin = VoutMin;
            VolOutMax = VoutMax;
            ThreadResBoostModeProcess = new Thread(new ThreadStart(ThreadResBoostModeProcess_Event));
            ThreadResBoostModeProcess.IsBackground = true;
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
            isRun = true;
            ThreadResBoostModeProcess.Start();
        }

        public void Stop()
        {
            isRun = false;
        }
        #endregion

        #region 计算处理函数
        public void ThreadResBoostModeProcess_Event()
        {

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

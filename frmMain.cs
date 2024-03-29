﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ResistanceSelectionTool
{
    public partial class frmMain : Form
    {
        #region 字段
        string FilePathResList;
        string FileNameResList;
        List<double> ResListData = new List<double>();
        #endregion

        #region 初始化

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text += @" V" + System.Windows.Forms.Application.ProductVersion.ToString();
            FilePathResList = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            FileNameResList = @"Res.list";
            comboBoxResUnit.SelectedIndex = 0;
            ListFileHelper.OutputResFile(FilePathResList + FileNameResList, "ResistanceSelectionTool.Res.list");
            InitResList(listViewRes);
        }

        private void InitResList(ListView listView)
        {
            //基本属性设置
            listView.CheckBoxes = true;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.View = View.Details;

            //绑定菜单
            //listView.ContextMenuStrip = contextMenuListView;

            //创建列表头
            listView.Columns.Add("阻值", 70, HorizontalAlignment.Left);
            listView.Columns.Add("欧姆值", 90, HorizontalAlignment.Left);

            //添加数据
            listView.BeginUpdate();
            GetResListFileToListView(FilePathResList + FileNameResList, listViewRes);
            listView.EndUpdate();
        }

        #endregion

        #region 阻值列表方法
        /// <summary>
        /// 获取阻值列表中选中项
        /// </summary>
        /// <param name="listView">阻值列表控件</param>
        /// <param name="listData">返回表格</param>
        private void GetResSelectList(ListView listView, List<double> listData, double resValue = 0)
        {
            listData.Clear();
            for (int i = 0; i < listView.CheckedItems.Count; i++)
            {
                listData.Add(Convert.ToDouble(listView.CheckedItems[i].SubItems[1].Text));
            }
            listData.Sort();
            if (resValue > 0)
            {
                int i;
                for (i = 0; i < listData.Count; i++)
                {
                    if (listData[i] > resValue)
                    {
                        break;
                    }
                }
                if (i < listData.Count)
                {
                    listData.RemoveRange(0, i);
                }
                else
                {
                    listData.Clear();
                }
            }
        }

        /// <summary>
        /// 获取阻值列表到表格中
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="listView">表格控件</param>
        private void GetResListFileToListView(string path, ListView listView)
        {
            if (File.Exists(path))
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                ListFileHelper.ReadFile(path, dic);
                if (dic.Count > 0)
                {
                    listView.Items.Clear();
                    foreach (KeyValuePair<string, string> item in dic)
                    {
                        bool isCheck = Convert.ToBoolean(item.Value);
                        double resValue = Convert.ToDouble(item.Key);
                        if (resValue > 0)
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem.Text = ResValueFormat(resValue);
                            listViewItem.SubItems.Add(resValue.ToString());
                            listViewItem.Checked = isCheck;
                            listView.Items.Add(listViewItem);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 保存列表数据
        /// </summary>
        /// <param name="path"></param>
        /// <param name="listView"></param>
        private void SaveListViewToResListFile(string path, ListView listView)
        {
            if (listView.Items.Count > 0)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                foreach (ListViewItem item in listView.Items)
                {
                    dic.Add(item.SubItems[1].Text, item.Checked.ToString());
                }
                ListFileHelper.WriteFile(path, dic);
            }
        }

        /// <summary>
        /// 阻值格式化
        /// </summary>
        /// <param name="value">阻值大小</param>
        /// <returns></returns>
        private string ResValueFormat(double value)
        {
            string ret;
            if (value > 1000000)
            {
                ret = string.Format("{0:0.###}MΩ", value / 1000000);
            }
            else if (value > 1000)
            {
                ret = string.Format("{0:0.###}KΩ", value / 1000);
            }
            else
            {
                ret = string.Format("{0:0.###}Ω", value);
            }
            return ret;
        }

        /// <summary>
        /// 电流格式化
        /// </summary>
        /// <param name="value">电流大小</param>
        /// <returns></returns>
        private string CurValueFormat(double value)
        {
            string ret;
            if (value < 0.000001)
            {
                ret = string.Format("{0:0.###}nA", value * 1000 * 1000 * 1000);
            }
            else if (value < 0.001)
            {
                ret = string.Format("{0:0.###}uA", value * 1000 * 1000);
            }
            else if(value < 1)
            {
                ret = string.Format("{0:0.###}mA", value * 1000);
            }
            else
            {
                ret = string.Format("{0:0.###}A", value);
            }
            return ret;
        }
        #endregion

        #region 阻值并联计算方法
        /// <summary>
        /// 获取设定的阻值
        /// </summary>
        /// <param name="value">阻值控件</param>
        /// <param name="unit">单位控件</param>
        /// <returns></returns>
        private double GetSiteResValue(TextBox value, ComboBox unit)
        {
            try
            {
                return Convert.ToDouble(value.Text) * Math.Pow(1000, unit.SelectedIndex);
            }
            catch (Exception error)
            {
                Console.WriteLine("GetSiteResValue出错：" + error);
                return 0;
            }
        }

        /// <summary>
        /// 计算按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double resValue = GetSiteResValue(txtResValue, comboBoxResUnit);
            if (resValue > 0)
            {
                txtOutput.Clear();
                GetResSelectList(listViewRes, ResListData, resValue);
                ResCalc resCalc = new ResCalc(ResListData.ToArray(), resValue, Convert.ToInt32(numResCount.Value));
                resCalc.EventResCalcReturn += new ResCalc.DelegateResCalcReturn(ResCalcReturn_Event);
                resCalc.Start();
            }
            else
            {
                MessageBox.Show("输入的阻值有误，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResValue.Focus();
            }
        }

        /// <summary>
        /// 计算结果返回事件
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="message">信息</param>
        /// <param name="percent">百分比</param>
        /// <param name="value">具体数据数组</param>
        private void ResCalcReturn_Event(EnumResCalcStatus status, string message, double percent, double[] value)
        {
            if (status == EnumResCalcStatus.Done)
            {
                this.Invoke(new EventHandler(delegate
                {
                    int len = value.Length;
                    string log = string.Format("{0}个电阻并联最佳方案：{1}", len, ResValueFormat(value[0]));
                    for (int i = 1; i < len; i++)
                    {
                        log += @" // " + ResValueFormat(value[i]);
                    }
                    log += string.Format(" = {0:#.###}", ResValueFormat(ResCalc.CalcParallel(value)));
                    txtOutput.AppendText(log + "\r\n");
                    if (percent >= 100)
                    {
                        txtOutput.AppendText(message);
                    }
                }));
            }
            else if (status == EnumResCalcStatus.Error)
            {
                this.Invoke(new EventHandler(delegate
                {
                    txtOutput.AppendText(message);
                }));
            }

            this.Invoke(new EventHandler(delegate
            {
                progressBarResCalc.Value = Convert.ToInt32(percent) % (progressBarResCalc.Maximum + 1);
            }));
        }
        #endregion

        #region 分压电阻计算方法
        private ResVoltageDivider resVoltageDivider;

        /// <summary>
        /// 分压电阻计算按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVDCalc_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            GetResSelectList(listViewRes, ResListData);
            resVoltageDivider = new ResVoltageDivider(ResListData.ToArray());
            resVoltageDivider.EventResVoltageDividerReturn += ResVoltageDivider_EventResVoltageDividerReturn;
            resVoltageDivider.VolIn = Convert.ToDouble(txtVDVolInput.Text);
            resVoltageDivider.VolOut = Convert.ToDouble(txtVDVolOutput.Text);
            resVoltageDivider.VolBias = Convert.ToDouble(txtVDVolBias.Text);
            resVoltageDivider.IsResultVolOut = radioVDVout.Checked;
            if (resVoltageDivider.VolIn <= resVoltageDivider.VolOut)
            {
                MessageBox.Show("输入电压应大于输出电压！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            resVoltageDivider.Start();
        }

        /// <summary>
        /// 分压电阻事件
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="message">信息</param>
        /// <param name="percent">百分比</param>
        /// <param name="value">固体数据数组</param>
        /// <exception cref="NotImplementedException"></exception>
        private void ResVoltageDivider_EventResVoltageDividerReturn(EnumResCalcStatus status, string message, double percent, double[] value)
        {
            this.Invoke(new EventHandler(delegate
            {
                switch (status)
                {
                    case EnumResCalcStatus.Start:
                        break;
                    case EnumResCalcStatus.Run:
                        break;
                    case EnumResCalcStatus.Done:
                        int len = value.Length;
                        if (len >= 4)
                        {
                            string log = "分压电阻计算结果：";
                            log += string.Format("RW1={0}， ", ResValueFormat(value[0]));
                            log += string.Format("RW2={0}， ", ResValueFormat(value[1]));
                            if (resVoltageDivider.IsResultVolOut)
                            {
                                log += string.Format("Vout={0:0.###}V， ", value[2]);
                            }
                            else
                            {
                                log += string.Format("Vin={0:0.###}V， ", value[2]);
                            }
                            log += string.Format("I={0}。", CurValueFormat(value[3]));
                            txtOutput.AppendText(log + "\r\n");
                        }
                        if (percent >= 100)
                        {
                            txtOutput.AppendText(message);
                            GC.Collect();
                        }
                        break;
                    case EnumResCalcStatus.Wait:
                        break;
                    case EnumResCalcStatus.Error:
                        txtOutput.AppendText(message);
                        break;
                    default:
                        break;
                }
                progressBarResCalc.Value = Convert.ToInt32(percent) % (progressBarResCalc.Maximum + 1);
            }));
        }

        #endregion

        #region 升压模块阻值计算方法
        /// <summary>
        /// 计算按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private ResBoostMode resBoostMode;
        private void btnCalcBoostRes_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            GetResSelectList(listViewRes, ResListData);
            resBoostMode = new ResBoostMode(ResListData.ToArray());
            resBoostMode.EventResBoostModeReturn += ResBoostMode_EventResBoostModeReturn;
            resBoostMode.VolFB = Convert.ToDouble(txtVolFB.Text);
            resBoostMode.VolPWM = Convert.ToDouble(txtVolPWM.Text);
            resBoostMode.VolOutMin = Convert.ToDouble(txtVolOutMin.Text);
            resBoostMode.VolOutMax = Convert.ToDouble(txtVolOutMax.Text);
            if (resBoostMode.VolOutMin > resBoostMode.VolOutMax)
            {
                double tmp = resBoostMode.VolOutMin;
                resBoostMode.VolOutMin = resBoostMode.VolOutMax;
                resBoostMode.VolOutMax = tmp;
            }
            resBoostMode.VolBias = Convert.ToDouble(txtVolBias.Text);
            resBoostMode.Start();
        }

        /// <summary>
        /// 升压模块电阻事件
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="message">信息</param>
        /// <param name="percent">百分比</param>
        /// <param name="value">具体数据数组</param>
        private void ResBoostMode_EventResBoostModeReturn(EnumResCalcStatus status, string message, double percent, double[] value)
        {
            this.Invoke(new EventHandler(delegate
            {
                switch (status)
                {
                    case EnumResCalcStatus.Start:
                        break;
                    case EnumResCalcStatus.Run:
                        break;
                    case EnumResCalcStatus.Done:
                        int len = value.Length;
                        if (len >= 5)
                        {
                            string log = "升压模块电阻计算结果：";
                            log += string.Format("RW1={0:#.###}， ", ResValueFormat(value[0]));
                            log += string.Format("RW2={0:#.###}， ", ResValueFormat(value[1]));
                            log += string.Format("RW3={0:#.###}， ", ResValueFormat(value[2]));
                            log += string.Format("VoutMin={0:#.###}V， ", (value[3]));
                            log += string.Format("VoutMax={0:#.###}V。", (value[4]));
                            txtOutput.AppendText(log + "\r\n");
                        }
                        if (percent >= 100)
                        {
                            txtOutput.AppendText(message);
                        }
                        break;
                    case EnumResCalcStatus.Wait:
                        break;
                    case EnumResCalcStatus.Error:
                        txtOutput.AppendText(message);
                        break;
                    default:
                        break;
                }
                progressBarResCalc.Value = Convert.ToInt32(percent) % (progressBarResCalc.Maximum + 1);
            }));
        }

        #endregion

        #region 按钮方法
        /// <summary>
        /// 编辑按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResEdit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer", "/select," + FilePathResList  + FileNameResList);
        }

        /// <summary>
        /// 全选按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListAllSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewRes.Items.Count; i++)
            {
                listViewRes.Items[i].Checked = true;
            }
        }

        /// <summary>
        /// 反选按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListRevSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewRes.Items.Count; i++)
            {
                listViewRes.Items[i].Checked = !listViewRes.Items[i].Checked;
            }
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveListViewToResListFile(FilePathResList + FileNameResList, listViewRes);
                MessageBox.Show("保存完成", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 默认选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListDefault_Click(object sender, EventArgs e)
        {
            listViewRes.BeginUpdate();
            GetResListFileToListView(FilePathResList + FileNameResList, listViewRes);
            listViewRes.EndUpdate();
        }
        #endregion


    }
}

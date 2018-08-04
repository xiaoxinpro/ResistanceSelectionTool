using System;
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
        public frmMain()
        {
            InitializeComponent();
        }

        #region 初始化

        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBoxResUnit.SelectedIndex = 0;
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
            GetResListFileToListView(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Res.list", listViewRes);
            listView.EndUpdate();
        }

        #endregion

        #region 阻值列表方法
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
        /// 阻值格式化
        /// </summary>
        /// <param name="value">阻值大小</param>
        /// <returns></returns>
        private string ResValueFormat(double value)
        {
            string ret;
            if (value > 1000000)
            {
                ret = string.Format("{0:#.###}MΩ", value / 1000000);
            }
            else if (value > 1000)
            {
                ret = string.Format("{0:#.###}KΩ", value / 1000);
            }
            else
            {
                ret = string.Format("{0:#.###}Ω", value);
            }
            return ret;
        }
        #endregion

    }
}

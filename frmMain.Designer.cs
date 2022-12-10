namespace ResistanceSelectionTool
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBoxResSelect = new System.Windows.Forms.GroupBox();
            this.btnListDefault = new System.Windows.Forms.Button();
            this.btnListRevSelect = new System.Windows.Forms.Button();
            this.btnListAllSelect = new System.Windows.Forms.Button();
            this.btnResSave = new System.Windows.Forms.Button();
            this.btnResEdit = new System.Windows.Forms.Button();
            this.listViewRes = new System.Windows.Forms.ListView();
            this.tabResCalc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxResUnit = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtResValue = new System.Windows.Forms.TextBox();
            this.checkBoxAllShow = new System.Windows.Forms.CheckBox();
            this.numResCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcBoostRes = new System.Windows.Forms.Button();
            this.txtVolBias = new System.Windows.Forms.TextBox();
            this.txtVolPWM = new System.Windows.Forms.TextBox();
            this.txtVolOutMax = new System.Windows.Forms.TextBox();
            this.txtVolOutMin = new System.Windows.Forms.TextBox();
            this.txtVolFB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.progressBarResCalc = new System.Windows.Forms.ProgressBar();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnVDCalc = new System.Windows.Forms.Button();
            this.txtVDVolBias = new System.Windows.Forms.TextBox();
            this.txtVDVolOutput = new System.Windows.Forms.TextBox();
            this.txtVDVolInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioVDVin = new System.Windows.Forms.RadioButton();
            this.radioVDVout = new System.Windows.Forms.RadioButton();
            this.groupBoxResSelect.SuspendLayout();
            this.tabResCalc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxResSelect
            // 
            this.groupBoxResSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxResSelect.Controls.Add(this.btnListDefault);
            this.groupBoxResSelect.Controls.Add(this.btnListRevSelect);
            this.groupBoxResSelect.Controls.Add(this.btnListAllSelect);
            this.groupBoxResSelect.Controls.Add(this.btnResSave);
            this.groupBoxResSelect.Controls.Add(this.btnResEdit);
            this.groupBoxResSelect.Controls.Add(this.listViewRes);
            this.groupBoxResSelect.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxResSelect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxResSelect.Name = "groupBoxResSelect";
            this.groupBoxResSelect.Size = new System.Drawing.Size(200, 436);
            this.groupBoxResSelect.TabIndex = 0;
            this.groupBoxResSelect.TabStop = false;
            this.groupBoxResSelect.Text = "可选电阻选择";
            // 
            // btnListDefault
            // 
            this.btnListDefault.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnListDefault.Location = new System.Drawing.Point(123, 20);
            this.btnListDefault.Name = "btnListDefault";
            this.btnListDefault.Size = new System.Drawing.Size(71, 23);
            this.btnListDefault.TabIndex = 2;
            this.btnListDefault.Text = "默认选择";
            this.btnListDefault.UseVisualStyleBackColor = true;
            this.btnListDefault.Click += new System.EventHandler(this.btnListDefault_Click);
            // 
            // btnListRevSelect
            // 
            this.btnListRevSelect.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnListRevSelect.Location = new System.Drawing.Point(65, 20);
            this.btnListRevSelect.Name = "btnListRevSelect";
            this.btnListRevSelect.Size = new System.Drawing.Size(52, 23);
            this.btnListRevSelect.TabIndex = 2;
            this.btnListRevSelect.Text = "反选";
            this.btnListRevSelect.UseVisualStyleBackColor = true;
            this.btnListRevSelect.Click += new System.EventHandler(this.btnListRevSelect_Click);
            // 
            // btnListAllSelect
            // 
            this.btnListAllSelect.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnListAllSelect.Location = new System.Drawing.Point(7, 20);
            this.btnListAllSelect.Name = "btnListAllSelect";
            this.btnListAllSelect.Size = new System.Drawing.Size(52, 23);
            this.btnListAllSelect.TabIndex = 2;
            this.btnListAllSelect.Text = "全选";
            this.btnListAllSelect.UseVisualStyleBackColor = true;
            this.btnListAllSelect.Click += new System.EventHandler(this.btnListAllSelect_Click);
            // 
            // btnResSave
            // 
            this.btnResSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResSave.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnResSave.Location = new System.Drawing.Point(104, 407);
            this.btnResSave.Name = "btnResSave";
            this.btnResSave.Size = new System.Drawing.Size(90, 23);
            this.btnResSave.TabIndex = 1;
            this.btnResSave.Text = "保存";
            this.btnResSave.UseVisualStyleBackColor = true;
            this.btnResSave.Click += new System.EventHandler(this.btnResSave_Click);
            // 
            // btnResEdit
            // 
            this.btnResEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResEdit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnResEdit.Location = new System.Drawing.Point(7, 407);
            this.btnResEdit.Name = "btnResEdit";
            this.btnResEdit.Size = new System.Drawing.Size(90, 23);
            this.btnResEdit.TabIndex = 1;
            this.btnResEdit.Text = "编辑";
            this.btnResEdit.UseVisualStyleBackColor = true;
            this.btnResEdit.Click += new System.EventHandler(this.btnResEdit_Click);
            // 
            // listViewRes
            // 
            this.listViewRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewRes.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewRes.HideSelection = false;
            this.listViewRes.Location = new System.Drawing.Point(7, 49);
            this.listViewRes.Name = "listViewRes";
            this.listViewRes.Size = new System.Drawing.Size(187, 352);
            this.listViewRes.TabIndex = 0;
            this.listViewRes.UseCompatibleStateImageBehavior = false;
            // 
            // tabResCalc
            // 
            this.tabResCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabResCalc.Controls.Add(this.tabPage1);
            this.tabResCalc.Controls.Add(this.tabPage3);
            this.tabResCalc.Controls.Add(this.tabPage2);
            this.tabResCalc.Location = new System.Drawing.Point(0, 0);
            this.tabResCalc.Name = "tabResCalc";
            this.tabResCalc.SelectedIndex = 0;
            this.tabResCalc.Size = new System.Drawing.Size(453, 181);
            this.tabResCalc.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxResUnit);
            this.tabPage1.Controls.Add(this.btnCalc);
            this.tabPage1.Controls.Add(this.txtResValue);
            this.tabPage1.Controls.Add(this.checkBoxAllShow);
            this.tabPage1.Controls.Add(this.numResCount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(445, 155);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "电阻并联";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxResUnit
            // 
            this.comboBoxResUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResUnit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxResUnit.Items.AddRange(new object[] {
            "Ω",
            "KΩ",
            "MΩ"});
            this.comboBoxResUnit.Location = new System.Drawing.Point(177, 45);
            this.comboBoxResUnit.Name = "comboBoxResUnit";
            this.comboBoxResUnit.Size = new System.Drawing.Size(60, 25);
            this.comboBoxResUnit.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalc.Location = new System.Drawing.Point(339, 117);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 32);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtResValue
            // 
            this.txtResValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResValue.Location = new System.Drawing.Point(103, 45);
            this.txtResValue.Name = "txtResValue";
            this.txtResValue.Size = new System.Drawing.Size(68, 23);
            this.txtResValue.TabIndex = 3;
            this.txtResValue.Text = "1234";
            // 
            // checkBoxAllShow
            // 
            this.checkBoxAllShow.AutoSize = true;
            this.checkBoxAllShow.Checked = true;
            this.checkBoxAllShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllShow.Enabled = false;
            this.checkBoxAllShow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxAllShow.Location = new System.Drawing.Point(177, 15);
            this.checkBoxAllShow.Name = "checkBoxAllShow";
            this.checkBoxAllShow.Size = new System.Drawing.Size(63, 21);
            this.checkBoxAllShow.TabIndex = 2;
            this.checkBoxAllShow.Text = "全列举";
            this.checkBoxAllShow.UseVisualStyleBackColor = true;
            // 
            // numResCount
            // 
            this.numResCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numResCount.Location = new System.Drawing.Point(102, 11);
            this.numResCount.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numResCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numResCount.Name = "numResCount";
            this.numResCount.Size = new System.Drawing.Size(58, 23);
            this.numResCount.TabIndex = 1;
            this.numResCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numResCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "并联数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "期望阻值：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnCalcBoostRes);
            this.tabPage2.Controls.Add(this.txtVolBias);
            this.tabPage2.Controls.Add(this.txtVolPWM);
            this.tabPage2.Controls.Add(this.txtVolOutMax);
            this.tabPage2.Controls.Add(this.txtVolOutMin);
            this.tabPage2.Controls.Add(this.txtVolFB);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(445, 155);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "升压芯片电阻";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "-";
            // 
            // btnCalcBoostRes
            // 
            this.btnCalcBoostRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcBoostRes.Location = new System.Drawing.Point(362, 116);
            this.btnCalcBoostRes.Name = "btnCalcBoostRes";
            this.btnCalcBoostRes.Size = new System.Drawing.Size(77, 33);
            this.btnCalcBoostRes.TabIndex = 6;
            this.btnCalcBoostRes.Text = "计算";
            this.btnCalcBoostRes.UseVisualStyleBackColor = true;
            this.btnCalcBoostRes.Click += new System.EventHandler(this.btnCalcBoostRes_Click);
            // 
            // txtVolBias
            // 
            this.txtVolBias.Location = new System.Drawing.Point(86, 102);
            this.txtVolBias.Name = "txtVolBias";
            this.txtVolBias.Size = new System.Drawing.Size(100, 21);
            this.txtVolBias.TabIndex = 5;
            this.txtVolBias.Text = "2";
            // 
            // txtVolPWM
            // 
            this.txtVolPWM.Location = new System.Drawing.Point(86, 40);
            this.txtVolPWM.Name = "txtVolPWM";
            this.txtVolPWM.Size = new System.Drawing.Size(100, 21);
            this.txtVolPWM.TabIndex = 2;
            this.txtVolPWM.Text = "3.3";
            // 
            // txtVolOutMax
            // 
            this.txtVolOutMax.Location = new System.Drawing.Point(150, 71);
            this.txtVolOutMax.Name = "txtVolOutMax";
            this.txtVolOutMax.Size = new System.Drawing.Size(36, 21);
            this.txtVolOutMax.TabIndex = 4;
            this.txtVolOutMax.Text = "20";
            // 
            // txtVolOutMin
            // 
            this.txtVolOutMin.Location = new System.Drawing.Point(86, 71);
            this.txtVolOutMin.Name = "txtVolOutMin";
            this.txtVolOutMin.Size = new System.Drawing.Size(36, 21);
            this.txtVolOutMin.TabIndex = 3;
            this.txtVolOutMin.Text = "3.5";
            // 
            // txtVolFB
            // 
            this.txtVolFB.Location = new System.Drawing.Point(86, 9);
            this.txtVolFB.Name = "txtVolFB";
            this.txtVolFB.Size = new System.Drawing.Size(100, 21);
            this.txtVolFB.TabIndex = 1;
            this.txtVolFB.Text = "0.6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "PWM电压：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "偏差电压：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "目标电压：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "FB电压：";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.Controls.Add(this.progressBarResCalc);
            this.groupBoxOutput.Controls.Add(this.txtOutput);
            this.groupBoxOutput.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxOutput.Location = new System.Drawing.Point(0, -1);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(453, 245);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "结果输出";
            // 
            // progressBarResCalc
            // 
            this.progressBarResCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarResCalc.Location = new System.Drawing.Point(6, 216);
            this.progressBarResCalc.Name = "progressBarResCalc";
            this.progressBarResCalc.Size = new System.Drawing.Size(441, 23);
            this.progressBarResCalc.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOutput.Location = new System.Drawing.Point(6, 20);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(441, 190);
            this.txtOutput.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(218, 20);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabResCalc);
            this.splitContainer1.Panel1MinSize = 180;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOutput);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(453, 428);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioVDVout);
            this.tabPage3.Controls.Add(this.radioVDVin);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.btnVDCalc);
            this.tabPage3.Controls.Add(this.txtVDVolBias);
            this.tabPage3.Controls.Add(this.txtVDVolOutput);
            this.tabPage3.Controls.Add(this.txtVDVolInput);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(445, 155);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "分压电阻";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnVDCalc
            // 
            this.btnVDCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVDCalc.Location = new System.Drawing.Point(362, 114);
            this.btnVDCalc.Name = "btnVDCalc";
            this.btnVDCalc.Size = new System.Drawing.Size(77, 33);
            this.btnVDCalc.TabIndex = 13;
            this.btnVDCalc.Text = "计算";
            this.btnVDCalc.UseVisualStyleBackColor = true;
            this.btnVDCalc.Click += new System.EventHandler(this.btnVDCalc_Click);
            // 
            // txtVDVolBias
            // 
            this.txtVDVolBias.Location = new System.Drawing.Point(86, 61);
            this.txtVDVolBias.Name = "txtVDVolBias";
            this.txtVDVolBias.Size = new System.Drawing.Size(100, 21);
            this.txtVDVolBias.TabIndex = 12;
            this.txtVDVolBias.Text = "0.1";
            // 
            // txtVDVolOutput
            // 
            this.txtVDVolOutput.Location = new System.Drawing.Point(86, 34);
            this.txtVDVolOutput.Name = "txtVDVolOutput";
            this.txtVDVolOutput.Size = new System.Drawing.Size(100, 21);
            this.txtVDVolOutput.TabIndex = 10;
            this.txtVDVolOutput.Text = "1.2";
            // 
            // txtVDVolInput
            // 
            this.txtVDVolInput.Location = new System.Drawing.Point(86, 7);
            this.txtVDVolInput.Name = "txtVDVolInput";
            this.txtVDVolInput.Size = new System.Drawing.Size(100, 21);
            this.txtVDVolInput.TabIndex = 8;
            this.txtVDVolInput.Text = "3.3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "输出电压：                    V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "允许误差：                    V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "输入电压：                    V";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::ResistanceSelectionTool.Properties.Resources.VoltageDivider;
            this.pictureBox2.Location = new System.Drawing.Point(203, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ResistanceSelectionTool.Properties.Resources.BoostCircuit;
            this.pictureBox1.Location = new System.Drawing.Point(192, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "输出结果：";
            // 
            // radioVDVin
            // 
            this.radioVDVin.AutoSize = true;
            this.radioVDVin.Location = new System.Drawing.Point(86, 89);
            this.radioVDVin.Name = "radioVDVin";
            this.radioVDVin.Size = new System.Drawing.Size(41, 16);
            this.radioVDVin.TabIndex = 15;
            this.radioVDVin.Tag = "0";
            this.radioVDVin.Text = "Vin";
            this.radioVDVin.UseVisualStyleBackColor = true;
            // 
            // radioVDVout
            // 
            this.radioVDVout.AutoSize = true;
            this.radioVDVout.Checked = true;
            this.radioVDVout.Location = new System.Drawing.Point(133, 89);
            this.radioVDVout.Name = "radioVDVout";
            this.radioVDVout.Size = new System.Drawing.Size(47, 16);
            this.radioVDVout.TabIndex = 15;
            this.radioVDVout.TabStop = true;
            this.radioVDVout.Tag = "1";
            this.radioVDVout.Text = "Vout";
            this.radioVDVout.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 456);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBoxResSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 320);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电阻选择工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxResSelect.ResumeLayout(false);
            this.tabResCalc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResSelect;
        private System.Windows.Forms.Button btnResEdit;
        private System.Windows.Forms.ListView listViewRes;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.CheckBox checkBoxAllShow;
        private System.Windows.Forms.NumericUpDown numResCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox comboBoxResUnit;
        private System.Windows.Forms.TextBox txtResValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListDefault;
        private System.Windows.Forms.Button btnListRevSelect;
        private System.Windows.Forms.Button btnListAllSelect;
        private System.Windows.Forms.Button btnResSave;
        private System.Windows.Forms.ProgressBar progressBarResCalc;
        private System.Windows.Forms.TabControl tabResCalc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCalcBoostRes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtVolPWM;
        private System.Windows.Forms.TextBox txtVolOutMin;
        private System.Windows.Forms.TextBox txtVolFB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVolOutMax;
        private System.Windows.Forms.TextBox txtVolBias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnVDCalc;
        private System.Windows.Forms.TextBox txtVDVolBias;
        private System.Windows.Forms.TextBox txtVDVolOutput;
        private System.Windows.Forms.TextBox txtVDVolInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioVDVout;
        private System.Windows.Forms.RadioButton radioVDVin;
        private System.Windows.Forms.Label label11;
    }
}


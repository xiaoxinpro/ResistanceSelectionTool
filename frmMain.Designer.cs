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
            this.groupBoxResSelect = new System.Windows.Forms.GroupBox();
            this.btnListDefault = new System.Windows.Forms.Button();
            this.btnListRevSelect = new System.Windows.Forms.Button();
            this.btnListAllSelect = new System.Windows.Forms.Button();
            this.btnResSave = new System.Windows.Forms.Button();
            this.btnResEdit = new System.Windows.Forms.Button();
            this.listViewRes = new System.Windows.Forms.ListView();
            this.groupBoxSite = new System.Windows.Forms.GroupBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.groupBoxResSelect.SuspendLayout();
            this.groupBoxSite.SuspendLayout();
            this.tabResCalc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
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
            this.listViewRes.Location = new System.Drawing.Point(7, 49);
            this.listViewRes.Name = "listViewRes";
            this.listViewRes.Size = new System.Drawing.Size(187, 352);
            this.listViewRes.TabIndex = 0;
            this.listViewRes.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxSite
            // 
            this.groupBoxSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSite.Controls.Add(this.tabResCalc);
            this.groupBoxSite.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxSite.Location = new System.Drawing.Point(218, 12);
            this.groupBoxSite.Name = "groupBoxSite";
            this.groupBoxSite.Size = new System.Drawing.Size(453, 196);
            this.groupBoxSite.TabIndex = 1;
            this.groupBoxSite.TabStop = false;
            this.groupBoxSite.Text = "配置选项";
            // 
            // tabResCalc
            // 
            this.tabResCalc.Controls.Add(this.tabPage1);
            this.tabResCalc.Controls.Add(this.tabPage2);
            this.tabResCalc.Location = new System.Drawing.Point(6, 24);
            this.tabResCalc.Name = "tabResCalc";
            this.tabResCalc.SelectedIndex = 0;
            this.tabResCalc.Size = new System.Drawing.Size(441, 166);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 134);
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
            this.comboBoxResUnit.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalc.Location = new System.Drawing.Point(327, 90);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 32);
            this.btnCalc.TabIndex = 3;
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
            this.txtResValue.TabIndex = 4;
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
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.txtVolBias);
            this.tabPage2.Controls.Add(this.txtVolPWM);
            this.tabPage2.Controls.Add(this.txtVolOutMax);
            this.tabPage2.Controls.Add(this.txtVolOutMin);
            this.tabPage2.Controls.Add(this.txtVolFB);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "升压芯片电阻";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "-";
            // 
            // btnCalcBoostRes
            // 
            this.btnCalcBoostRes.Location = new System.Drawing.Point(350, 89);
            this.btnCalcBoostRes.Name = "btnCalcBoostRes";
            this.btnCalcBoostRes.Size = new System.Drawing.Size(77, 33);
            this.btnCalcBoostRes.TabIndex = 5;
            this.btnCalcBoostRes.Text = "计算";
            this.btnCalcBoostRes.UseVisualStyleBackColor = true;
            this.btnCalcBoostRes.Click += new System.EventHandler(this.btnCalcBoostRes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResistanceSelectionTool.Properties.Resources.BoostCircuit;
            this.pictureBox1.Location = new System.Drawing.Point(192, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtVolBias
            // 
            this.txtVolBias.Location = new System.Drawing.Point(86, 102);
            this.txtVolBias.Name = "txtVolBias";
            this.txtVolBias.Size = new System.Drawing.Size(100, 25);
            this.txtVolBias.TabIndex = 3;
            this.txtVolBias.Text = "2";
            // 
            // txtVolPWM
            // 
            this.txtVolPWM.Location = new System.Drawing.Point(86, 40);
            this.txtVolPWM.Name = "txtVolPWM";
            this.txtVolPWM.Size = new System.Drawing.Size(100, 25);
            this.txtVolPWM.TabIndex = 3;
            this.txtVolPWM.Text = "3.3";
            // 
            // txtVolOutMax
            // 
            this.txtVolOutMax.Location = new System.Drawing.Point(150, 71);
            this.txtVolOutMax.Name = "txtVolOutMax";
            this.txtVolOutMax.Size = new System.Drawing.Size(36, 25);
            this.txtVolOutMax.TabIndex = 3;
            this.txtVolOutMax.Text = "20";
            // 
            // txtVolOutMin
            // 
            this.txtVolOutMin.Location = new System.Drawing.Point(86, 71);
            this.txtVolOutMin.Name = "txtVolOutMin";
            this.txtVolOutMin.Size = new System.Drawing.Size(36, 25);
            this.txtVolOutMin.TabIndex = 3;
            this.txtVolOutMin.Text = "3.5";
            // 
            // txtVolFB
            // 
            this.txtVolFB.Location = new System.Drawing.Point(86, 9);
            this.txtVolFB.Name = "txtVolFB";
            this.txtVolFB.Size = new System.Drawing.Size(100, 25);
            this.txtVolFB.TabIndex = 3;
            this.txtVolFB.Text = "0.6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "PWM电压：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "偏差电压：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "目标电压：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
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
            this.groupBoxOutput.Location = new System.Drawing.Point(218, 214);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(453, 234);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "结果输出";
            // 
            // progressBarResCalc
            // 
            this.progressBarResCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarResCalc.Location = new System.Drawing.Point(6, 205);
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
            this.txtOutput.Size = new System.Drawing.Size(441, 179);
            this.txtOutput.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 456);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxSite);
            this.Controls.Add(this.groupBoxResSelect);
            this.MinimumSize = new System.Drawing.Size(580, 320);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电阻并联选择工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxResSelect.ResumeLayout(false);
            this.groupBoxSite.ResumeLayout(false);
            this.tabResCalc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResSelect;
        private System.Windows.Forms.Button btnResEdit;
        private System.Windows.Forms.ListView listViewRes;
        private System.Windows.Forms.GroupBox groupBoxSite;
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
    }
}


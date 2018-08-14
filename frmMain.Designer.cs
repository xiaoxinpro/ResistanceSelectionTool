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
            this.comboBoxResUnit = new System.Windows.Forms.ComboBox();
            this.txtResValue = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.checkBoxAllShow = new System.Windows.Forms.CheckBox();
            this.numResCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.progressBarResCalc = new System.Windows.Forms.ProgressBar();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBoxResSelect.SuspendLayout();
            this.groupBoxSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResCount)).BeginInit();
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
            this.groupBoxResSelect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxResSelect.Name = "groupBoxResSelect";
            this.groupBoxResSelect.Size = new System.Drawing.Size(200, 400);
            this.groupBoxResSelect.TabIndex = 0;
            this.groupBoxResSelect.TabStop = false;
            this.groupBoxResSelect.Text = "可选电阻选择";
            // 
            // btnListDefault
            // 
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
            this.btnResSave.Location = new System.Drawing.Point(104, 371);
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
            this.btnResEdit.Location = new System.Drawing.Point(7, 371);
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
            this.listViewRes.Size = new System.Drawing.Size(187, 316);
            this.listViewRes.TabIndex = 0;
            this.listViewRes.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxSite
            // 
            this.groupBoxSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSite.Controls.Add(this.comboBoxResUnit);
            this.groupBoxSite.Controls.Add(this.txtResValue);
            this.groupBoxSite.Controls.Add(this.btnCalc);
            this.groupBoxSite.Controls.Add(this.checkBoxAllShow);
            this.groupBoxSite.Controls.Add(this.numResCount);
            this.groupBoxSite.Controls.Add(this.label2);
            this.groupBoxSite.Controls.Add(this.label1);
            this.groupBoxSite.Location = new System.Drawing.Point(218, 12);
            this.groupBoxSite.Name = "groupBoxSite";
            this.groupBoxSite.Size = new System.Drawing.Size(453, 126);
            this.groupBoxSite.TabIndex = 1;
            this.groupBoxSite.TabStop = false;
            this.groupBoxSite.Text = "配置选项";
            // 
            // comboBoxResUnit
            // 
            this.comboBoxResUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResUnit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxResUnit.Items.AddRange(new object[] {
            "Ω",
            "KΩ",
            "MΩ"});
            this.comboBoxResUnit.Location = new System.Drawing.Point(216, 52);
            this.comboBoxResUnit.Name = "comboBoxResUnit";
            this.comboBoxResUnit.Size = new System.Drawing.Size(60, 25);
            this.comboBoxResUnit.TabIndex = 5;
            // 
            // txtResValue
            // 
            this.txtResValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResValue.Location = new System.Drawing.Point(142, 52);
            this.txtResValue.Name = "txtResValue";
            this.txtResValue.Size = new System.Drawing.Size(68, 23);
            this.txtResValue.TabIndex = 4;
            this.txtResValue.Text = "1234";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Font = new System.Drawing.Font("宋体", 11F);
            this.btnCalc.Location = new System.Drawing.Point(347, 88);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 32);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // checkBoxAllShow
            // 
            this.checkBoxAllShow.AutoSize = true;
            this.checkBoxAllShow.Checked = true;
            this.checkBoxAllShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllShow.Enabled = false;
            this.checkBoxAllShow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxAllShow.Location = new System.Drawing.Point(216, 22);
            this.checkBoxAllShow.Name = "checkBoxAllShow";
            this.checkBoxAllShow.Size = new System.Drawing.Size(63, 21);
            this.checkBoxAllShow.TabIndex = 2;
            this.checkBoxAllShow.Text = "全列举";
            this.checkBoxAllShow.UseVisualStyleBackColor = true;
            // 
            // numResCount
            // 
            this.numResCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numResCount.Location = new System.Drawing.Point(141, 18);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "期望阻值：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "并联数量：";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.Controls.Add(this.progressBarResCalc);
            this.groupBoxOutput.Controls.Add(this.txtOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(218, 144);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(453, 268);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "结果输出";
            // 
            // progressBarResCalc
            // 
            this.progressBarResCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarResCalc.Location = new System.Drawing.Point(6, 239);
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
            this.txtOutput.Size = new System.Drawing.Size(441, 213);
            this.txtOutput.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 420);
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
            this.groupBoxSite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResCount)).EndInit();
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
    }
}


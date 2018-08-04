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
            this.listViewRes = new System.Windows.Forms.ListView();
            this.btnResEdit = new System.Windows.Forms.Button();
            this.groupBoxSite = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numResCount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAllShow = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBoxResSelect.SuspendLayout();
            this.groupBoxSite.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxResSelect
            // 
            this.groupBoxResSelect.Controls.Add(this.btnResEdit);
            this.groupBoxResSelect.Controls.Add(this.listViewRes);
            this.groupBoxResSelect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxResSelect.Name = "groupBoxResSelect";
            this.groupBoxResSelect.Size = new System.Drawing.Size(200, 400);
            this.groupBoxResSelect.TabIndex = 0;
            this.groupBoxResSelect.TabStop = false;
            this.groupBoxResSelect.Text = "可选电阻选择";
            // 
            // listViewRes
            // 
            this.listViewRes.Location = new System.Drawing.Point(7, 21);
            this.listViewRes.Name = "listViewRes";
            this.listViewRes.Size = new System.Drawing.Size(187, 344);
            this.listViewRes.TabIndex = 0;
            this.listViewRes.UseCompatibleStateImageBehavior = false;
            // 
            // btnResEdit
            // 
            this.btnResEdit.Location = new System.Drawing.Point(7, 371);
            this.btnResEdit.Name = "btnResEdit";
            this.btnResEdit.Size = new System.Drawing.Size(187, 23);
            this.btnResEdit.TabIndex = 1;
            this.btnResEdit.Text = "编辑";
            this.btnResEdit.UseVisualStyleBackColor = true;
            // 
            // groupBoxSite
            // 
            this.groupBoxSite.Controls.Add(this.btnCalc);
            this.groupBoxSite.Controls.Add(this.checkBoxAllShow);
            this.groupBoxSite.Controls.Add(this.numResCount);
            this.groupBoxSite.Controls.Add(this.label1);
            this.groupBoxSite.Location = new System.Drawing.Point(218, 12);
            this.groupBoxSite.Name = "groupBoxSite";
            this.groupBoxSite.Size = new System.Drawing.Size(500, 200);
            this.groupBoxSite.TabIndex = 1;
            this.groupBoxSite.TabStop = false;
            this.groupBoxSite.Text = "配置选项";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.txtOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(218, 218);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(500, 194);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "结果输出";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 20);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(488, 168);
            this.txtOutput.TabIndex = 0;
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
            // numResCount
            // 
            this.numResCount.Font = new System.Drawing.Font("宋体", 9F);
            this.numResCount.Location = new System.Drawing.Point(141, 20);
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
            this.numResCount.Size = new System.Drawing.Size(48, 21);
            this.numResCount.TabIndex = 1;
            this.numResCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numResCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // checkBoxAllShow
            // 
            this.checkBoxAllShow.AutoSize = true;
            this.checkBoxAllShow.Location = new System.Drawing.Point(216, 22);
            this.checkBoxAllShow.Name = "checkBoxAllShow";
            this.checkBoxAllShow.Size = new System.Drawing.Size(60, 16);
            this.checkBoxAllShow.TabIndex = 2;
            this.checkBoxAllShow.Text = "全列举";
            this.checkBoxAllShow.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("宋体", 11F);
            this.btnCalc.Location = new System.Drawing.Point(394, 162);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 32);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 420);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxSite);
            this.Controls.Add(this.groupBoxResSelect);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电阻并联选择工具";
            this.groupBoxResSelect.ResumeLayout(false);
            this.groupBoxSite.ResumeLayout(false);
            this.groupBoxSite.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResCount)).EndInit();
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
    }
}


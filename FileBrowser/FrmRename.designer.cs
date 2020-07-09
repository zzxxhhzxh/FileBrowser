namespace FileBrowser
{
    partial class FrmRename
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwFile = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNewName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDirectory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.cobFormat = new System.Windows.Forms.ComboBox();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.nuIncrease = new System.Windows.Forms.NumericUpDown();
            this.nuStart = new System.Windows.Forms.NumericUpDown();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.rdoFile3 = new System.Windows.Forms.RadioButton();
            this.rdoFile2 = new System.Windows.Forms.RadioButton();
            this.rdoFile1 = new System.Windows.Forms.RadioButton();
            this.grpExt = new System.Windows.Forms.GroupBox();
            this.rdoExt2 = new System.Windows.Forms.RadioButton();
            this.rdoExt1 = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStart)).BeginInit();
            this.grpFile.SuspendLayout();
            this.grpExt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwFile
            // 
            this.lvwFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colNewName,
            this.colDirectory,
            this.colSize,
            this.colTime});
            this.lvwFile.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwFile.FullRowSelect = true;
            this.lvwFile.HideSelection = false;
            this.lvwFile.Location = new System.Drawing.Point(13, 134);
            this.lvwFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwFile.MultiSelect = false;
            this.lvwFile.Name = "lvwFile";
            this.lvwFile.Size = new System.Drawing.Size(908, 361);
            this.lvwFile.TabIndex = 0;
            this.lvwFile.UseCompatibleStateImageBehavior = false;
            this.lvwFile.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colNewName
            // 
            this.colNewName.Text = "New Name";
            this.colNewName.Width = 200;
            // 
            // colDirectory
            // 
            this.colDirectory.Text = "Directory";
            this.colDirectory.Width = 300;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 80;
            // 
            // colTime
            // 
            this.colTime.Text = "Modified Time";
            this.colTime.Width = 100;
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.cobFormat);
            this.grpOrder.Controls.Add(this.lblTemplate);
            this.grpOrder.Controls.Add(this.txtTemplate);
            this.grpOrder.Controls.Add(this.lblFormat);
            this.grpOrder.Controls.Add(this.nuIncrease);
            this.grpOrder.Controls.Add(this.nuStart);
            this.grpOrder.Location = new System.Drawing.Point(324, 14);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(516, 110);
            this.grpOrder.TabIndex = 8;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "By Order";
            // 
            // cobFormat
            // 
            this.cobFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFormat.FormattingEnabled = true;
            this.cobFormat.Items.AddRange(new object[] {
            "0",
            "00",
            "000",
            "0000",
            "00000"});
            this.cobFormat.Location = new System.Drawing.Point(312, 18);
            this.cobFormat.Name = "cobFormat";
            this.cobFormat.Size = new System.Drawing.Size(121, 21);
            this.cobFormat.TabIndex = 9;
            this.cobFormat.SelectedIndexChanged += new System.EventHandler(this.Parameters_ValueChanged);
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(7, 21);
            this.lblTemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(52, 52);
            this.lblTemplate.TabIndex = 0;
            this.lblTemplate.Text = "Template\r\n\r\n\r\nStart from";
            this.lblTemplate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(67, 18);
            this.txtTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(168, 20);
            this.txtTemplate.TabIndex = 7;
            this.txtTemplate.TextChanged += new System.EventHandler(this.Parameters_ValueChanged);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(243, 21);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(62, 52);
            this.lblFormat.TabIndex = 6;
            this.lblFormat.Text = "Format\r\n\r\n\r\nIncrease by";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nuIncrease
            // 
            this.nuIncrease.Location = new System.Drawing.Point(313, 58);
            this.nuIncrease.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuIncrease.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuIncrease.Name = "nuIncrease";
            this.nuIncrease.Size = new System.Drawing.Size(120, 20);
            this.nuIncrease.TabIndex = 5;
            this.nuIncrease.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuIncrease.ValueChanged += new System.EventHandler(this.Parameters_ValueChanged);
            // 
            // nuStart
            // 
            this.nuStart.Location = new System.Drawing.Point(67, 58);
            this.nuStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuStart.Name = "nuStart";
            this.nuStart.Size = new System.Drawing.Size(120, 20);
            this.nuStart.TabIndex = 3;
            this.nuStart.ValueChanged += new System.EventHandler(this.Parameters_ValueChanged);
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.rdoFile3);
            this.grpFile.Controls.Add(this.rdoFile2);
            this.grpFile.Controls.Add(this.rdoFile1);
            this.grpFile.Location = new System.Drawing.Point(13, 14);
            this.grpFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFile.Name = "grpFile";
            this.grpFile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFile.Size = new System.Drawing.Size(304, 48);
            this.grpFile.TabIndex = 0;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "File Name";
            // 
            // rdoFile3
            // 
            this.rdoFile3.AutoSize = true;
            this.rdoFile3.Location = new System.Drawing.Point(187, 19);
            this.rdoFile3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoFile3.Name = "rdoFile3";
            this.rdoFile3.Size = new System.Drawing.Size(98, 17);
            this.rdoFile3.TabIndex = 2;
            this.rdoFile3.Text = "Sentence Case";
            this.rdoFile3.UseVisualStyleBackColor = true;
            this.rdoFile3.CheckedChanged += new System.EventHandler(this.rdoFile_CheckedChanged);
            // 
            // rdoFile2
            // 
            this.rdoFile2.AutoSize = true;
            this.rdoFile2.Location = new System.Drawing.Point(106, 19);
            this.rdoFile2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoFile2.Name = "rdoFile2";
            this.rdoFile2.Size = new System.Drawing.Size(73, 17);
            this.rdoFile2.TabIndex = 1;
            this.rdoFile2.Text = "lowercase";
            this.rdoFile2.UseVisualStyleBackColor = true;
            this.rdoFile2.CheckedChanged += new System.EventHandler(this.rdoFile_CheckedChanged);
            // 
            // rdoFile1
            // 
            this.rdoFile1.AutoSize = true;
            this.rdoFile1.Checked = true;
            this.rdoFile1.Location = new System.Drawing.Point(8, 19);
            this.rdoFile1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoFile1.Name = "rdoFile1";
            this.rdoFile1.Size = new System.Drawing.Size(90, 17);
            this.rdoFile1.TabIndex = 0;
            this.rdoFile1.TabStop = true;
            this.rdoFile1.Text = "UPPERCASE";
            this.rdoFile1.UseVisualStyleBackColor = true;
            this.rdoFile1.CheckedChanged += new System.EventHandler(this.rdoFile_CheckedChanged);
            // 
            // grpExt
            // 
            this.grpExt.Controls.Add(this.rdoExt2);
            this.grpExt.Controls.Add(this.rdoExt1);
            this.grpExt.Location = new System.Drawing.Point(13, 72);
            this.grpExt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpExt.Name = "grpExt";
            this.grpExt.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpExt.Size = new System.Drawing.Size(304, 52);
            this.grpExt.TabIndex = 1;
            this.grpExt.TabStop = false;
            this.grpExt.Text = "Extension";
            // 
            // rdoExt2
            // 
            this.rdoExt2.AutoSize = true;
            this.rdoExt2.Location = new System.Drawing.Point(106, 23);
            this.rdoExt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoExt2.Name = "rdoExt2";
            this.rdoExt2.Size = new System.Drawing.Size(73, 17);
            this.rdoExt2.TabIndex = 4;
            this.rdoExt2.TabStop = true;
            this.rdoExt2.Text = "lowercase";
            this.rdoExt2.UseVisualStyleBackColor = true;
            this.rdoExt2.CheckedChanged += new System.EventHandler(this.rdoExt_CheckedChanged);
            // 
            // rdoExt1
            // 
            this.rdoExt1.AutoSize = true;
            this.rdoExt1.Location = new System.Drawing.Point(8, 23);
            this.rdoExt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoExt1.Name = "rdoExt1";
            this.rdoExt1.Size = new System.Drawing.Size(90, 17);
            this.rdoExt1.TabIndex = 3;
            this.rdoExt1.TabStop = true;
            this.rdoExt1.Text = "UPPERCASE";
            this.rdoExt1.UseVisualStyleBackColor = true;
            this.rdoExt1.CheckedChanged += new System.EventHandler(this.rdoExt_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(846, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(846, 27);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(846, 85);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Clear";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 503);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvwFile);
            this.Controls.Add(this.grpExt);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpFile);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmRename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Rename";
            this.Load += new System.EventHandler(this.Frm_Rename_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStart)).EndInit();
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.grpExt.ResumeLayout(false);
            this.grpExt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvwFile;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colNewName;
        private System.Windows.Forms.ColumnHeader colDirectory;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.NumericUpDown nuIncrease;
        private System.Windows.Forms.NumericUpDown nuStart;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.RadioButton rdoFile3;
        private System.Windows.Forms.RadioButton rdoFile2;
        private System.Windows.Forms.RadioButton rdoFile1;
        private System.Windows.Forms.GroupBox grpExt;
        private System.Windows.Forms.RadioButton rdoExt2;
        private System.Windows.Forms.RadioButton rdoExt1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cobFormat;
        private System.Windows.Forms.Button btnExit;
    }
}


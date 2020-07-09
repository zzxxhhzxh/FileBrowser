namespace FileBrowser
{
    partial class FrmAttribute
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtFileCreateTime = new System.Windows.Forms.TextBox();
            this.txtFileModifyTime = new System.Windows.Forms.TextBox();
            this.txtFileAccessTime = new System.Windows.Forms.TextBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(217, 199);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Enter";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(95, 17);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(197, 20);
            this.txtFileName.TabIndex = 6;
            // 
            // txtFileCreateTime
            // 
            this.txtFileCreateTime.Location = new System.Drawing.Point(95, 121);
            this.txtFileCreateTime.Name = "txtFileCreateTime";
            this.txtFileCreateTime.ReadOnly = true;
            this.txtFileCreateTime.Size = new System.Drawing.Size(197, 20);
            this.txtFileCreateTime.TabIndex = 5;
            // 
            // txtFileModifyTime
            // 
            this.txtFileModifyTime.Location = new System.Drawing.Point(95, 147);
            this.txtFileModifyTime.Name = "txtFileModifyTime";
            this.txtFileModifyTime.ReadOnly = true;
            this.txtFileModifyTime.Size = new System.Drawing.Size(197, 20);
            this.txtFileModifyTime.TabIndex = 4;
            // 
            // txtFileAccessTime
            // 
            this.txtFileAccessTime.Location = new System.Drawing.Point(95, 173);
            this.txtFileAccessTime.Name = "txtFileAccessTime";
            this.txtFileAccessTime.ReadOnly = true;
            this.txtFileAccessTime.Size = new System.Drawing.Size(197, 20);
            this.txtFileAccessTime.TabIndex = 3;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(95, 95);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.ReadOnly = true;
            this.txtFileSize.Size = new System.Drawing.Size(197, 20);
            this.txtFileSize.TabIndex = 2;
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Location = new System.Drawing.Point(95, 69);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(197, 20);
            this.txtFileLocation.TabIndex = 1;
            // 
            // txtFileType
            // 
            this.txtFileType.Location = new System.Drawing.Point(95, 43);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.ReadOnly = true;
            this.txtFileType.Size = new System.Drawing.Size(197, 20);
            this.txtFileType.TabIndex = 0;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(12, 20);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(77, 176);
            this.lblFileName.TabIndex = 7;
            this.lblFileName.Text = "Name\r\n\r\nType\r\n\r\nLocation\r\n\r\nSize\r\n\r\nCreate Time\r\n\r\nModify Time\r\n\r\nVisit Time";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 234);
            this.Controls.Add(this.txtFileType);
            this.Controls.Add(this.txtFileLocation);
            this.Controls.Add(this.txtFileSize);
            this.Controls.Add(this.txtFileAccessTime);
            this.Controls.Add(this.txtFileModifyTime);
            this.Controls.Add(this.txtFileCreateTime);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnConfirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAttribute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attribute Form";
            this.Load += new System.EventHandler(this.FrmAttribute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtFileCreateTime;
        private System.Windows.Forms.TextBox txtFileModifyTime;
        private System.Windows.Forms.TextBox txtFileAccessTime;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.Label lblFileName;
    }
}
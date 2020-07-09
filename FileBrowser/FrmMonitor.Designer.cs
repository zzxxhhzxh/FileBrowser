namespace FileBrowser
{
    partial class FrmMonitor
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.chkSubDir = new System.Windows.Forms.CheckBox();
            this.rtxLog = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(497, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(497, 33);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(416, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(85, 6);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(406, 20);
            this.txtFolder.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(67, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Monitor Path";
            // 
            // chkSubDir
            // 
            this.chkSubDir.AutoSize = true;
            this.chkSubDir.Checked = true;
            this.chkSubDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubDir.Location = new System.Drawing.Point(312, 37);
            this.chkSubDir.Name = "chkSubDir";
            this.chkSubDir.Size = new System.Drawing.Size(98, 17);
            this.chkSubDir.TabIndex = 12;
            this.chkSubDir.Text = "Sub Directories";
            this.chkSubDir.UseVisualStyleBackColor = true;
            // 
            // rtxLog
            // 
            this.rtxLog.Location = new System.Drawing.Point(12, 62);
            this.rtxLog.Name = "rtxLog";
            this.rtxLog.Size = new System.Drawing.Size(560, 258);
            this.rtxLog.TabIndex = 13;
            this.rtxLog.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(416, 326);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 14;
            this.btnRead.Text = "Read Log";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(497, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save Log";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.rtxLog);
            this.Controls.Add(this.chkSubDir);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Monitor";
            this.Load += new System.EventHandler(this.FrmMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox chkSubDir;
        private System.Windows.Forms.RichTextBox rtxLog;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
    }
}


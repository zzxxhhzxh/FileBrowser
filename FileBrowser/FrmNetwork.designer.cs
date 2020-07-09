namespace FileBrowser
{
    partial class FrmNetwork
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
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.btnReadLog = new System.Windows.Forms.Button();
            this.txtHostIP = new System.Windows.Forms.TextBox();
            this.btnViewHost = new System.Windows.Forms.Button();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.rtxLog = new System.Windows.Forms.RichTextBox();
            this.nud5 = new System.Windows.Forms.NumericUpDown();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.nud4 = new System.Windows.Forms.NumericUpDown();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(497, 283);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLog.TabIndex = 0;
            this.btnSaveLog.Text = "Save Log";
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // btnReadLog
            // 
            this.btnReadLog.Location = new System.Drawing.Point(416, 282);
            this.btnReadLog.Name = "btnReadLog";
            this.btnReadLog.Size = new System.Drawing.Size(75, 23);
            this.btnReadLog.TabIndex = 0;
            this.btnReadLog.Text = "Read Log";
            this.btnReadLog.Click += new System.EventHandler(this.btnReadLog_Click);
            // 
            // txtHostIP
            // 
            this.txtHostIP.Location = new System.Drawing.Point(22, 285);
            this.txtHostIP.Name = "txtHostIP";
            this.txtHostIP.Size = new System.Drawing.Size(149, 20);
            this.txtHostIP.TabIndex = 2;
            // 
            // btnViewHost
            // 
            this.btnViewHost.Location = new System.Drawing.Point(177, 283);
            this.btnViewHost.Name = "btnViewHost";
            this.btnViewHost.Size = new System.Drawing.Size(75, 23);
            this.btnViewHost.TabIndex = 0;
            this.btnViewHost.Text = "View Host";
            this.btnViewHost.Click += new System.EventHandler(this.btnViewHost_Click);
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(22, 246);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(149, 20);
            this.txtHostName.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(177, 140);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Query";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(177, 77);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // rtxLog
            // 
            this.rtxLog.Location = new System.Drawing.Point(258, 6);
            this.rtxLog.Name = "rtxLog";
            this.rtxLog.Size = new System.Drawing.Size(314, 270);
            this.rtxLog.TabIndex = 4;
            this.rtxLog.Text = "";
            // 
            // nud5
            // 
            this.nud5.Location = new System.Drawing.Point(199, 51);
            this.nud5.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.nud5.Name = "nud5";
            this.nud5.Size = new System.Drawing.Size(53, 20);
            this.nud5.TabIndex = 8;
            this.nud5.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(22, 25);
            this.nud1.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(53, 20);
            this.nud1.TabIndex = 6;
            this.nud1.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(81, 25);
            this.nud2.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(53, 20);
            this.nud2.TabIndex = 6;
            // 
            // nud3
            // 
            this.nud3.Location = new System.Drawing.Point(140, 25);
            this.nud3.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(53, 20);
            this.nud3.TabIndex = 7;
            // 
            // nud4
            // 
            this.nud4.Location = new System.Drawing.Point(199, 25);
            this.nud4.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.nud4.Name = "nud4";
            this.nud4.Size = new System.Drawing.Size(53, 20);
            this.nud4.TabIndex = 8;
            this.nud4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(75, 273);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Scan Host\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nQuery Remote\r\n\r\n\r\n\r\n\r\n\r\nLocal Host\r\n\r\nHost Name\r\n\r\n\r\nI" +
    "P Address";
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(22, 142);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(149, 20);
            this.txtRemoteIP.TabIndex = 2;
            // 
            // FrmNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.btnViewHost);
            this.Controls.Add(this.txtHostIP);
            this.Controls.Add(this.txtRemoteIP);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.rtxLog);
            this.Controls.Add(this.nud5);
            this.Controls.Add(this.btnReadLog);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud3);
            this.Controls.Add(this.nud4);
            this.Controls.Add(this.lblInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNetwork";
            this.Text = "Network Scan";
            ((System.ComponentModel.ISupportInitialize)(this.nud5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtHostIP;
        private System.Windows.Forms.Button btnViewHost;
        private System.Windows.Forms.RichTextBox rtxLog;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.NumericUpDown nud4;
        private System.Windows.Forms.NumericUpDown nud5;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.Button btnReadLog;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtRemoteIP;
    }
}

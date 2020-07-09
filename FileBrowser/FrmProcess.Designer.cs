namespace FileBrowser
{
    partial class FrmProcess
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
            this.components = new System.ComponentModel.Container();
            this.lvwProcess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEndThread = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblProcNum = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwProcess
            // 
            this.lvwProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwProcess.FullRowSelect = true;
            this.lvwProcess.HideSelection = false;
            this.lvwProcess.Location = new System.Drawing.Point(12, 12);
            this.lvwProcess.Name = "lvwProcess";
            this.lvwProcess.Size = new System.Drawing.Size(948, 432);
            this.lvwProcess.TabIndex = 0;
            this.lvwProcess.UseCompatibleStateImageBehavior = false;
            this.lvwProcess.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进程名称";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "进程ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "专用内存大小";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "虚拟内存大小";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "启动时间";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "基本优先级";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "路径";
            this.columnHeader7.Width = 250;
            // 
            // btnEndThread
            // 
            this.btnEndThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndThread.Location = new System.Drawing.Point(885, 453);
            this.btnEndThread.Name = "btnEndThread";
            this.btnEndThread.Size = new System.Drawing.Size(75, 23);
            this.btnEndThread.TabIndex = 1;
            this.btnEndThread.Text = "End Thread";
            this.btnEndThread.UseVisualStyleBackColor = true;
            this.btnEndThread.Click += new System.EventHandler(this.btnEndThread_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(804, 453);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblProcNum
            // 
            this.lblProcNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProcNum.AutoSize = true;
            this.lblProcNum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcNum.Location = new System.Drawing.Point(12, 456);
            this.lblProcNum.Name = "lblProcNum";
            this.lblProcNum.Size = new System.Drawing.Size(173, 17);
            this.lblProcNum.TabIndex = 3;
            this.lblProcNum.Text = "Current Number of Threads:";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 10000;
            this.tmrRefresh.Tick += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(723, 453);
            this.btnThread.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(75, 23);
            this.btnThread.TabIndex = 5;
            this.btnThread.Text = "Thread";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.BtnThread_Click);
            // 
            // FrmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 487);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.lblProcNum);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEndThread);
            this.Controls.Add(this.lvwProcess);
            this.MaximizeBox = false;
            this.Name = "FrmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Management";
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwProcess;
        private System.Windows.Forms.Button btnEndThread;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblProcNum;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Button btnThread;
    }
}
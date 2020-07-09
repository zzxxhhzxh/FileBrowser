namespace FileBrowser
{
    partial class FrmThread
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
            this.lvwThrd = new System.Windows.Forms.ListView();
            this.colHdrID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrPri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrCurPri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrSta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrMem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEndThrd = new System.Windows.Forms.Button();
            this.lblThrdNum = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDes = new System.Windows.Forms.Label();
            this.tmrThread = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lvwThrd
            // 
            this.lvwThrd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHdrID,
            this.colHdrPri,
            this.colHdrCurPri,
            this.colHdrSta,
            this.colHdrTime,
            this.colHdrMem});
            this.lvwThrd.FullRowSelect = true;
            this.lvwThrd.HideSelection = false;
            this.lvwThrd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwThrd.Location = new System.Drawing.Point(12, 25);
            this.lvwThrd.Name = "lvwThrd";
            this.lvwThrd.Size = new System.Drawing.Size(817, 424);
            this.lvwThrd.TabIndex = 0;
            this.lvwThrd.UseCompatibleStateImageBehavior = false;
            this.lvwThrd.View = System.Windows.Forms.View.Details;
            // 
            // colHdrID
            // 
            this.colHdrID.Text = "Thread ID";
            this.colHdrID.Width = 90;
            // 
            // colHdrPri
            // 
            this.colHdrPri.Text = "Priority";
            this.colHdrPri.Width = 90;
            // 
            // colHdrCurPri
            // 
            this.colHdrCurPri.Text = "Current Priority";
            this.colHdrCurPri.Width = 90;
            // 
            // colHdrSta
            // 
            this.colHdrSta.Text = "State";
            this.colHdrSta.Width = 270;
            // 
            // colHdrTime
            // 
            this.colHdrTime.Text = "Start Time";
            this.colHdrTime.Width = 130;
            // 
            // colHdrMem
            // 
            this.colHdrMem.Text = "Memory Address";
            this.colHdrMem.Width = 130;
            // 
            // btnEndThrd
            // 
            this.btnEndThrd.Location = new System.Drawing.Point(754, 455);
            this.btnEndThrd.Name = "btnEndThrd";
            this.btnEndThrd.Size = new System.Drawing.Size(75, 23);
            this.btnEndThrd.TabIndex = 1;
            this.btnEndThrd.Text = "End Thread";
            this.btnEndThrd.UseVisualStyleBackColor = true;
            this.btnEndThrd.Click += new System.EventHandler(this.btnEndThrd_Click);
            // 
            // lblThrdNum
            // 
            this.lblThrdNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblThrdNum.AutoSize = true;
            this.lblThrdNum.Location = new System.Drawing.Point(12, 460);
            this.lblThrdNum.Name = "lblThrdNum";
            this.lblThrdNum.Size = new System.Drawing.Size(101, 13);
            this.lblThrdNum.TabIndex = 2;
            this.lblThrdNum.Text = "Number of Threads:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(673, 455);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(12, 9);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(56, 13);
            this.lblDes.TabIndex = 5;
            this.lblDes.Text = "Thread of:";
            // 
            // tmrThread
            // 
            this.tmrThread.Enabled = true;
            this.tmrThread.Interval = 10000;
            this.tmrThread.Tick += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 487);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblThrdNum);
            this.Controls.Add(this.btnEndThrd);
            this.Controls.Add(this.lvwThrd);
            this.MaximizeBox = false;
            this.Name = "FrmThread";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thread Management";
            this.Load += new System.EventHandler(this.FrmThread_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwThrd;
        private System.Windows.Forms.Button btnEndThrd;
        private System.Windows.Forms.Label lblThrdNum;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.ColumnHeader colHdrID;
        private System.Windows.Forms.ColumnHeader colHdrPri;
        private System.Windows.Forms.ColumnHeader colHdrCurPri;
        private System.Windows.Forms.ColumnHeader colHdrSta;
        private System.Windows.Forms.ColumnHeader colHdrTime;

        private System.Windows.Forms.Timer tmrThread;
        private System.Windows.Forms.ColumnHeader colHdrMem;
    }
}
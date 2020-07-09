namespace FileBrowser
{
    partial class FrmPicPlay
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
            this.ssrStatus = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.picFile = new System.Windows.Forms.PictureBox();
            this.ssrStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            this.SuspendLayout();
            // 
            // ssrStatus
            // 
            this.ssrStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.ssrStatus.Location = new System.Drawing.Point(0, 648);
            this.ssrStatus.Name = "ssrStatus";
            this.ssrStatus.Size = new System.Drawing.Size(1079, 22);
            this.ssrStatus.TabIndex = 0;
            this.ssrStatus.Text = "ssrStatus";
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(30, 17);
            this.tssLabel.Text = "0 / 0";
            // 
            // txtFolder
            // 
            this.txtFolder.BackColor = System.Drawing.Color.White;
            this.txtFolder.Location = new System.Drawing.Point(279, 12);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(707, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(992, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lstFile
            // 
            this.lstFile.Location = new System.Drawing.Point(12, 12);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(261, 628);
            this.lstFile.TabIndex = 0;
            this.lstFile.SelectedIndexChanged += new System.EventHandler(this.lstFile_SelectedIndexChanged);
            // 
            // picFile
            // 
            this.picFile.Location = new System.Drawing.Point(279, 45);
            this.picFile.Name = "picFile";
            this.picFile.Size = new System.Drawing.Size(800, 600);
            this.picFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFile.TabIndex = 2;
            this.picFile.TabStop = false;
            // 
            // FrmPicPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 670);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picFile);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.ssrStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPicPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pic Player";
            this.ssrStatus.ResumeLayout(false);
            this.ssrStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssrStatus;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.PictureBox picFile;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
    }
}
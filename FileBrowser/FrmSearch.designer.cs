namespace FileBrowser
{
    partial class FrmSearch
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvwSearch = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDirectory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(72, 53);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(619, 20);
            this.txtFile.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(54, 39);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Folder\r\n\r\nFile Name";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(697, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvwSearch
            // 
            this.lvwSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDirectory,
            this.colSize,
            this.colTime});
            this.lvwSearch.FullRowSelect = true;
            this.lvwSearch.HideSelection = false;
            this.lvwSearch.Location = new System.Drawing.Point(12, 84);
            this.lvwSearch.Name = "lvwSearch";
            this.lvwSearch.Size = new System.Drawing.Size(760, 465);
            this.lvwSearch.TabIndex = 5;
            this.lvwSearch.UseCompatibleStateImageBehavior = false;
            this.lvwSearch.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colDirectory
            // 
            this.colDirectory.Text = "Directory";
            this.colDirectory.Width = 320;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 90;
            // 
            // colTime
            // 
            this.colTime.Text = "Modified Time";
            this.colTime.Width = 115;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(697, 24);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(72, 24);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(619, 20);
            this.txtFolder.TabIndex = 7;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lvwSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvwSearch;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDirectory;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFolder;
    }
}


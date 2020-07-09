namespace FileBrowser
{
    partial class FrmSplit
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
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.btnSplitUnite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "1 MB",
            "5 MB",
            "10 MB",
            "50 MB",
            "100 MB",
            "200 MB",
            "500 MB",
            "1000 MB"});
            this.cmbSize.Location = new System.Drawing.Point(84, 5);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(75, 21);
            this.cmbSize.TabIndex = 6;
            // 
            // btnSplitUnite
            // 
            this.btnSplitUnite.Location = new System.Drawing.Point(84, 32);
            this.btnSplitUnite.Name = "btnSplitUnite";
            this.btnSplitUnite.Size = new System.Drawing.Size(75, 23);
            this.btnSplitUnite.TabIndex = 3;
            this.btnSplitUnite.Text = "Split";
            this.btnSplitUnite.UseVisualStyleBackColor = true;
            this.btnSplitUnite.Click += new System.EventHandler(this.btnSplitUnite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section Size\r\n\r\nFile to Save";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frm_SplitUnite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 67);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSplitUnite);
            this.Controls.Add(this.cmbSize);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SplitUnite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Split and Unite";
            this.Load += new System.EventHandler(this.Frm_SplitUnite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Button btnSplitUnite;
        private System.Windows.Forms.Label label1;
    }
}
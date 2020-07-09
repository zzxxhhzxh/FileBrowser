namespace FileBrowser
{
    partial class FrmPrivilege
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Full Control");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Modify");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Read and Execute");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Read");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Write");
            this.lvwPrivilege = new System.Windows.Forms.ListView();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblObj = new System.Windows.Forms.Label();
            this.lblPvg = new System.Windows.Forms.Label();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lvwPrivilege
            // 
            this.lvwPrivilege.CheckBoxes = true;
            this.lvwPrivilege.FullRowSelect = true;
            this.lvwPrivilege.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            this.lvwPrivilege.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lvwPrivilege.Location = new System.Drawing.Point(258, 51);
            this.lvwPrivilege.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwPrivilege.Name = "lvwPrivilege";
            this.lvwPrivilege.Size = new System.Drawing.Size(180, 186);
            this.lvwPrivilege.TabIndex = 1;
            this.lvwPrivilege.UseCompatibleStateImageBehavior = false;
            this.lvwPrivilege.View = System.Windows.Forms.View.List;
            this.lvwPrivilege.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LvwPrivilege_ItemCheck);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(363, 241);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblObj
            // 
            this.lblObj.AutoSize = true;
            this.lblObj.Location = new System.Drawing.Point(12, 9);
            this.lblObj.Name = "lblObj";
            this.lblObj.Size = new System.Drawing.Size(73, 39);
            this.lblObj.TabIndex = 6;
            this.lblObj.Text = "Object Name:\r\n\r\nGroups/Users";
            // 
            // lblPvg
            // 
            this.lblPvg.AutoSize = true;
            this.lblPvg.Location = new System.Drawing.Point(255, 35);
            this.lblPvg.Name = "lblPvg";
            this.lblPvg.Size = new System.Drawing.Size(52, 13);
            this.lblPvg.TabIndex = 7;
            this.lblPvg.Text = "Privileges";
            // 
            // lstUser
            // 
            this.lstUser.FormattingEnabled = true;
            this.lstUser.Location = new System.Drawing.Point(12, 51);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(240, 186);
            this.lstUser.TabIndex = 9;
            this.lstUser.SelectedIndexChanged += new System.EventHandler(this.LstUser_SelectedIndexChanged);
            // 
            // FrmPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 275);
            this.Controls.Add(this.lstUser);
            this.Controls.Add(this.lblPvg);
            this.Controls.Add(this.lblObj);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lvwPrivilege);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Privilege Form";
            this.Load += new System.EventHandler(this.PrivilegeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListView lvwPrivilege;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.Label lblPvg;
        private System.Windows.Forms.ListBox lstUser;
    }
}
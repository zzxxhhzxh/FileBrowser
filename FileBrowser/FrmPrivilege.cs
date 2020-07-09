using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace FileBrowser
{
    public partial class FrmPrivilege : Form
    {
        AuthorizationRuleCollection AuthRules;
        string file;
        string[] privileges = { "FullControl", "Modify", "ReadAndExecute", "Read", "Write" };
        List<FileSystemRights> lSysRights = new List<FileSystemRights> { FileSystemRights.FullControl, FileSystemRights.Modify,
            FileSystemRights.ReadAndExecute, FileSystemRights.Read, FileSystemRights.Write };

        public FrmPrivilege(string fileName)
        {
            InitializeComponent();
            file = fileName;
        }

        private void PrivilegeForm_Load(object sender, EventArgs e)
        {
            lblObj.Text = $"Object Name: {file}\n\nGroups/Users:";
            var fInfo = new FileInfo(file);
            AuthRules = fInfo.GetAccessControl().GetAccessRules(true, true, typeof(SecurityIdentifier));
            for (int i = 0; i < AuthRules.Count; i++)
                lstUser.Items.Add(GetUserName(i));
            lstUser.SelectedIndex = 0;
            RefreshPrivileges();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPrivileges();
        }

        private void LvwPrivilege_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                ChangeFileSecurity(file, GetUserName(lstUser.SelectedIndex), lSysRights[e.Index], AccessControlType.Allow, true);
            else
                ChangeFileSecurity(file, GetUserName(lstUser.SelectedIndex), lSysRights[e.Index], AccessControlType.Allow, false);
        }

        private void SetPrivilegeList(string privilege)
        {
            foreach (ListViewItem item in lvwPrivilege.Items)
                item.Checked = false;
            switch (privilege)
            {
                case "FullControl":
                    lvwPrivilege.Items[0].Checked = true;
                    lvwPrivilege.Items[1].Checked = true;
                    lvwPrivilege.Items[2].Checked = true;
                    lvwPrivilege.Items[3].Checked = true;
                    lvwPrivilege.Items[4].Checked = true;
                    break;
                case "Modify":
                    lvwPrivilege.Items[1].Checked = true;
                    lvwPrivilege.Items[2].Checked = true;
                    lvwPrivilege.Items[3].Checked = true;
                    lvwPrivilege.Items[4].Checked = true;
                    break;
                case "ReadAndExecute":
                    lvwPrivilege.Items[2].Checked = true;
                    lvwPrivilege.Items[3].Checked = true;
                    break;
                case "Read":
                    lvwPrivilege.Items[3].Checked = true;
                    break;
                case "Write":
                    lvwPrivilege.Items[4].Checked = true;
                    break;
            }
        }

        private string GetUserName(int i)
        {
            return AuthRules[i].IdentityReference.Translate(typeof(NTAccount)).ToString();
        }

        private void RefreshPrivileges()
        {
            string[] fsRights = ((FileSystemAccessRule)AuthRules[lstUser.SelectedIndex]).FileSystemRights.ToString().Split(',');
            for (int i = 0; i < privileges.Length; i++)
            {
                if (fsRights.Contains(privileges[i]))
                    SetPrivilegeList(privileges[i]);
            }
        }

        private void ChangeFileSecurity(string fileName, string account, FileSystemRights rights, AccessControlType controlType, bool toAdd)
        {
            var fInfo = new FileInfo(fileName);
            var fSecurity = fInfo.GetAccessControl();
            if (toAdd)
                fSecurity.AddAccessRule(new FileSystemAccessRule(account, rights, controlType));
            else
                fSecurity.RemoveAccessRule(new FileSystemAccessRule(account, rights, controlType));
            fInfo.SetAccessControl(fSecurity);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;

namespace FileBrowser
{
    public partial class FrmRename : Form
    {
        string[] files;


        public FrmRename(string[] fileList)
        {
            InitializeComponent();
            files = new string[fileList.Length];
            Array.Copy(fileList, files, fileList.Length);
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Frm_Rename_Load(object sender, EventArgs e)
        {
            SetLvwFile();
            cobFormat.SelectedIndex = 0;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ChangeFileName();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwFile.Items.Count; i++)
                lvwFile.Items[i].SubItems[1].Text = lvwFile.Items[i].SubItems[0].Text;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetLvwFile()
        {
            lvwFile.Items.Clear();
            foreach (var file in files)
            {
                var fInfo = new FileInfo(file);
                var info = new string[] { fInfo.Name, fInfo.Name, fInfo.Directory.FullName, $"{fInfo.Length / 1024.0:F1} KB", fInfo.LastWriteTime.ToString() };
                lvwFile.Items.Add(new ListViewItem(info));
            }
        }

        private void rdoFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFile1.Checked)
            {
                for (int i = 0; i < lvwFile.Items.Count; i++)
                {
                    string sName = lvwFile.Items[i].SubItems[1].Text;
                    string tempName = sName.Remove(sName.LastIndexOf(".")).ToUpper();
                    string tempExt = sName.Substring(sName.LastIndexOf("."));
                    lvwFile.Items[i].SubItems[1].Text = tempName + tempExt;
                }
            }
            else if (rdoFile2.Checked)
            {
                for (int i = 0; i < lvwFile.Items.Count; i++)
                {
                    string sName = lvwFile.Items[i].SubItems[1].Text;
                    string tempName = sName.Remove(sName.LastIndexOf(".")).ToLower();
                    string tempExt = sName.Substring(sName.LastIndexOf("."));
                    lvwFile.Items[i].SubItems[1].Text = tempName + tempExt;
                }
            }
            else if (rdoFile3.Checked)
            {
                for (int i = 0; i < lvwFile.Items.Count; i++)
                {
                    string sName = lvwFile.Items[i].SubItems[1].Text;
                    string tempName1 = sName.Remove(sName.LastIndexOf(".")).Substring(0, 1);
                    string tempName2 = sName.Remove(sName.LastIndexOf(".")).Substring(1);
                    string tempExt = sName.Substring(sName.LastIndexOf("."));
                    lvwFile.Items[i].SubItems[1].Text = tempName1.ToUpper() + tempName2.ToLower() + tempExt;
                }
            }
        }

        private void rdoExt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExt1.Checked)
            {
                for (int i = 0; i < lvwFile.Items.Count; i++)
                {
                    string sName = lvwFile.Items[i].SubItems[1].Text;
                    string tempName = sName.Remove(sName.LastIndexOf("."));
                    string tempExt = sName.Substring(sName.LastIndexOf(".")).ToUpper();
                    lvwFile.Items[i].SubItems[1].Text = tempName + tempExt;
                }
            }
            if (rdoExt2.Checked)
            {
                for (int i = 0; i < lvwFile.Items.Count; i++)
                {
                    string sName = lvwFile.Items[i].SubItems[1].Text;
                    string tempName = sName.Remove(sName.LastIndexOf("."));
                    string tempExt = sName.Substring(sName.LastIndexOf(".")).ToLower();
                    lvwFile.Items[i].SubItems[1].Text = tempName + tempExt;
                }
            }
        }

        private void Parameters_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwFile.Items.Count; i++)
            {
                string sName = lvwFile.Items[i].SubItems[1].Text;
                string tempName = txtTemplate.Text + (nuStart.Value + nuIncrease.Value * i).ToString(cobFormat.SelectedItem.ToString());
                string tempExt = sName.Substring(sName.LastIndexOf("."));
                lvwFile.Items[i].SubItems[1].Text = tempName + tempExt;
            }
        }

        private void ChangeFileName()
        {
            try
            {
                for (int i = 0; i < lvwFile.Items.Count; i++)
                {
                    if (lvwFile.Items[i].SubItems[0].Text == lvwFile.Items[i].SubItems[1].Text)
                        continue;
                    string sFile = Path.Combine(lvwFile.Items[i].SubItems[2].Text, lvwFile.Items[i].SubItems[0].Text);
                    string dFile = Path.Combine(lvwFile.Items[i].SubItems[2].Text, lvwFile.Items[i].SubItems[1].Text);
                    string tFile = Path.Combine(lvwFile.Items[i].SubItems[2].Text, "i am a temp.iamatemp");
                    File.Copy(sFile, tFile);
                    File.Delete(sFile);
                    File.Copy(tFile, dFile);
                    File.Delete(tFile);
                    lvwFile.Items[i].SubItems[0].Text = lvwFile.Items[i].SubItems[1].Text;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

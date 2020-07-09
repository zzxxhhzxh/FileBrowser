using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FileBrowser
{
    public partial class FrmSearch : Form
    {
        string name;

        public FrmSearch(string path)
        {
            InitializeComponent();
            txtFolder.Text = path;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                txtFolder.Text = dlg.SelectedPath;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFile.Text == "")
                return;
            lvwSearch.Items.Clear();
            name = txtFile.Text;
            SearchBySingleTask(new DirectoryInfo(txtFolder.Text));
        }

        private void SearchBySingleTask(DirectoryInfo dir)
        {
            var fInfos = dir.GetFiles();
            var dInfos = dir.GetDirectories();

            if (fInfos.Length > 0)
            {
                foreach (var fInfo in fInfos)
                {
                    if (fInfo.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) > -1)
                    {
                        var lvi = new string[] { fInfo.Name, fInfo.Directory.FullName, $"{fInfo.Length / 1024} KB", fInfo.LastWriteTime.ToString() };
                        lvwSearch.Items.Add(new ListViewItem(lvi));
                    }
                }
            }
            if (dInfos.Length > 0)
            {
                foreach (var dInfo in dInfos)
                    SearchBySingleTask(dInfo);
            }
        }
    }
}
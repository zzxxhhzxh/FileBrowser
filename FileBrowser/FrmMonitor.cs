using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileBrowser
{
    public partial class FrmMonitor : Form
    {
        FileSystemWatcher fsw;

        public FrmMonitor(string folderPath)
        {
            InitializeComponent();
            txtFolder.Text = folderPath;
        }

        private void FrmMonitor_Load(object sender, EventArgs e)
        {
            SetFileSystemWatcher();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = dlg.SelectedPath;
                SetFileSystemWatcher();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            fsw.EnableRaisingEvents = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            fsw.EnableRaisingEvents = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void SetFileSystemWatcher()
        {
            fsw = new FileSystemWatcher()
            {
                Path = txtFolder.Text,
                Filter = "*.*",
                EnableRaisingEvents = false,
                SynchronizingObject = this
            };
            if (chkSubDir.Checked)
                fsw.IncludeSubdirectories = true;
            fsw.Deleted += new FileSystemEventHandler(fsWatcher_Changed);
            fsw.Created += new FileSystemEventHandler(fsWatcher_Changed);
            fsw.Changed += new FileSystemEventHandler(fsWatcher_Changed);
            fsw.Renamed += new RenamedEventHandler(fsWatcher_Renamed);
        }

        private void fsWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            rtxLog.AppendText($"{DateTime.Now:F}: {e.FullPath} {e.ChangeType}\n");
        }

        private void fsWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            rtxLog.AppendText($"{DateTime.Now:F}: {e.FullPath} Deleted\n");
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Filter = "Text File (*.txt)|*.txt" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rtxLog.Clear();
                rtxLog.AppendText(File.OpenText(dlg.FileName).ReadToEnd());
                File.OpenText(dlg.FileName).Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                FileName = $"FileEventLog_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}",
                Filter = "Text File (*.txt)|*.txt"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(dlg.FileName))
                    sw.Write(rtxLog.Text);
            }
        }
    }
}
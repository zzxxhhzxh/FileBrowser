using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace FileBrowser
{
    public partial class FrmProcess : Form
    {
        public FrmProcess()
        {
            InitializeComponent();
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            RefreshProcess();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProcess();
        }

        private void btnEndThread_Click(object sender, EventArgs e)
        {
            StopProcess();
        }

        private void BtnThread_Click(object sender, EventArgs e)
        {
            if (lvwProcess.SelectedItems.Count == 0)
                return;
            string process = lvwProcess.SelectedItems[0].Text;
            new FrmThread(process).Show();
        }

        private void RefreshProcess()
        {
            lvwProcess.Items.Clear();
            var ps = Process.GetProcesses();
            lblProcNum.Text = $"Current Number of Threads: {ps.Length}";

            try
            {
                foreach (var p in ps)
                    lvwProcess.Items.Add(new ListViewItem(new string[] { p.ProcessName, p.Id.ToString(),
                        p.PrivateMemorySize64.ToString(), p.VirtualMemorySize64.ToString(), p.StartTime.ToString("F"),
                        p.BasePriority.ToString(), p.MainModule.FileName }));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void StopProcess()
        {
            try
            {
                string pName = lvwProcess.SelectedItems[0].Text;
                Process p = Process.GetProcessesByName(pName)[0];
                p.Kill();
                RefreshProcess();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

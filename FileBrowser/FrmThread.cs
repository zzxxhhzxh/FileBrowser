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
    public partial class FrmThread : Form
    {
        Process process;
        Dictionary<int, ProcessThread> curThreads;

        public FrmThread(string processName)
        {         
            InitializeComponent();
            process = Process.GetProcessesByName(processName)[0];
        }

        private void FrmThread_Load(object sender, EventArgs e)
        {
            lblDes.Text = $"Thread of {process.ProcessName}:";
            RefreshThreads();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshThreads();
        }

        private void btnEndThrd_Click(object sender, EventArgs e)
        {
            if (lvwThrd.SelectedItems.Count > 0)
                EndThread();
        }

        private void RefreshThreads()
        {
            lvwThrd.Items.Clear();
            curThreads = new Dictionary<int, ProcessThread>();
            var thrds = process.Threads;
            lblThrdNum.Text = $"Number of Threads: {thrds.Count}";
            lvwThrd.BeginUpdate();
            try
            {
                foreach (ProcessThread thrd in thrds)
                {
                    curThreads.Add(thrd.Id, thrd);
                    lvwThrd.Items.Add(new ListViewItem(new string[] { thrd.Id.ToString(), thrd.BasePriority.ToString(),
                        thrd.CurrentPriority.ToString(), thrd.ThreadState.ToString(), thrd.StartTime.ToString("F"),
                        thrd.StartAddress.ToString() }));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            lvwThrd.EndUpdate();
        }

        private void EndThread()
        {
            try
            {
                int id = Convert.ToInt32(lvwThrd.SelectedItems[0].Text);
                curThreads[id].Dispose();
                RefreshThreads();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.IO;

namespace FileBrowser
{
    public partial class FrmNetwork : Form
    {
        public FrmNetwork()
        {
            InitializeComponent();
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            string ip1 = $"{nud1.Text}.{nud2.Text}.{nud3.Text}.";
            int min = Convert.ToInt32(nud4.Text);
            int max = Convert.ToInt32(nud5.Text);
            for (int i = min; i <= max; i++)
            {
                string ip = ip1 + i.ToString();
                try
                {
                    rtxLog.AppendText($"{ip} --> {Dns.GetHostEntry(ip).HostName}\n");
                }
                catch (Exception ex)
                {
                    rtxLog.AppendText($"{ip} --> {ex.Message}\n");
                }
            }
        }

        private void btnViewHost_Click(object sender, EventArgs e)
        {
            try
            {
                var myHost = Dns.GetHostEntry(Dns.GetHostName());
                txtHostName.Text = myHost.HostName;
                rtxLog.AppendText($"Local Host Name --> {myHost.HostName}\n");
                for (int i = 0; i < myHost.AddressList.Length; i++)
                {
                    txtHostIP.Text = myHost.AddressList[i].ToString();
                    rtxLog.AppendText($"Local Host IP Address --> {myHost.AddressList[i]}\n");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            rtxLog.Clear();
            var myHost = Dns.GetHostEntry(txtRemoteIP.Text);
            for (int i = 0; i < myHost.AddressList.Length; i++)
                rtxLog.AppendText($"IP Address of {txtRemoteIP.Text} --> {myHost.AddressList[i]}\n");
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                FileName = $"NetworkLog_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}",
                Filter = "Text File (*.txt)|*.txt"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(dlg.FileName))
                    sw.Write(rtxLog.Text);
            }
        }

        private void btnReadLog_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Filter = "Text File (*.txt)|*.txt" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rtxLog.Clear();
                rtxLog.AppendText(File.OpenText(dlg.FileName).ReadToEnd());
                File.OpenText(dlg.FileName).Close();
            }
        }
    }
}
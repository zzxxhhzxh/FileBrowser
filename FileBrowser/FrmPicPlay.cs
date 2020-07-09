using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileBrowser
{
    public partial class FrmPicPlay : Form
    {
        public FrmPicPlay(string path)
        {
            InitializeComponent();
            txtFolder.Text = path;
            SetFileList();
            lstFile.SelectedIndex = 0;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = dlg.SelectedPath;
                SetFileList();
            }
        }

        private void SetFileList()
        {
            lstFile.Items.Clear();           
            var fInfos = new DirectoryInfo(txtFolder.Text).GetFiles();
            foreach (var fInfo in fInfos)
            {
                string fType = fInfo.Extension.ToLower();
                if (fType == ".jpg" || fType == ".png" || fType == ".bmp")
                    lstFile.Items.Add(fInfo.Name);
            }
            tssLabel.Text = $"0 / {lstFile.Items.Count}: {txtFolder.Text}";
        }

        private void lstFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(txtFolder.Text, lstFile.SelectedItem.ToString());
            tssLabel.Text = $"{lstFile.SelectedIndex + 1} / {lstFile.Items.Count}: {path}";
            picFile.Image = Image.FromFile(path);
        }
    }
}

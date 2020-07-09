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
    public partial class FrmAttribute : Form
    {
        string path;

        public FrmAttribute(string filePath)
        {
            InitializeComponent();
            path = filePath;
        }

        private void FrmAttribute_Load(object sender, EventArgs e)
        {
            InitDisplay();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitDisplay()
        {
            if (File.Exists(path))
            {
                var fInfo = new FileInfo(path);
                txtFileName.Text = fInfo.Name;
                txtFileType.Text = fInfo.Extension;
                txtFileLocation.Text = fInfo.DirectoryName;
                txtFileSize.Text = ShowFileSize(fInfo.Length);
                txtFileCreateTime.Text = fInfo.CreationTime.ToString();
                txtFileModifyTime.Text = fInfo.LastWriteTime.ToString();
                txtFileAccessTime.Text = fInfo.LastAccessTime.ToString();
            }
            else if (Directory.Exists(path))
            {
                var dInfo = new DirectoryInfo(path);
                txtFileName.Text = dInfo.Name;
                txtFileType.Text = "Folder";
                txtFileLocation.Text = dInfo.Parent.FullName;
                txtFileSize.Text = ShowFileSize(GetDirLength(path));
                txtFileCreateTime.Text = dInfo.CreationTime.ToString();
                txtFileModifyTime.Text = dInfo.LastWriteTime.ToString();
                txtFileAccessTime.Text = dInfo.LastAccessTime.ToString();
            }
        }

        private long GetDirLength(string fPath)
        {
            long length = 0;
            var dirInfo = new DirectoryInfo(fPath);
            var fInfos = dirInfo.GetFiles();
            var dInfos = dirInfo.GetDirectories();

            if (fInfos.Length > 0)
            {
                foreach (FileInfo fInfo in fInfos)
                    length += fInfo.Length;
            }
            if (dInfos.Length > 0)
            {
                foreach (DirectoryInfo dInfo in dInfos)
                    length += GetDirLength(dInfo.FullName);
            }
            return length;
        }

        private string ShowFileSize(long fSize)
        {
            if (fSize < 1024)
                return $"{fSize} Bytes";
            else if (fSize < 1024 * 1024)
                return $"{Math.Round(fSize * 1.0 / 1024, 2)} KB ({fSize} Bytes)";
            else if (fSize < 1024 * 1024 * 1024)
                return $"{Math.Round(fSize * 1.0 / 1024 / 1024, 2)} MB ({fSize} Bytes)";
            return $"{Math.Round(fSize * 1.0 / 1024 / 1024 / 1024, 2)} GB ({fSize} Bytes)";
        }
    }
}

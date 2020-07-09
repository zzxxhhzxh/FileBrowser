using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileBrowser
{
    public partial class FrmSplit : Form
    {
        string[] fileList;

        public FrmSplit(string[] files)
        {
            InitializeComponent();
            fileList = new string[files.Length];
            Array.Copy(files, fileList, files.Length);
        }

        private void Frm_SplitUnite_Load(object sender, EventArgs e)
        {
            cmbSize.SelectedIndex = 0;
            if (fileList.Length > 1)
            {
                cmbSize.Enabled = false;
                btnSplitUnite.Text = "Unite";
            }
        }

        private void btnSplitUnite_Click(object sender, EventArgs e)
        {
            if (fileList.Length == 1)
            {
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string size = cmbSize.SelectedItem.ToString();
                    SplitFile(Convert.ToInt32(size.Remove(size.Length - 3)) * 1024 * 1024, fileList[0], dlg.SelectedPath);
                }
            }
            else
            {
                string file = fileList[0].Remove(fileList[0].Length - 4);
                var dlg = new SaveFileDialog()
                {
                    FileName = Path.GetFileName(file),
                    Filter = $"All files (*{Path.GetExtension(file)})|*{Path.GetExtension(file)}"
                };
                if (dlg.ShowDialog() == DialogResult.OK)
                    UniteFile(fileList, dlg.FileName);
            }
        }

        public void SplitFile(int size, string file, string path)
        {
            try
            {
                var fInfo = new FileInfo(file);
                using (var splitFS = new FileStream(file, FileMode.Open))
                using (var splitBR = new BinaryReader(splitFS))
                {
                    long fCount = splitFS.Length % size == 0 ? splitFS.Length / size : splitFS.Length / size + 1;
                    for (int i = 1; i <= fCount; i++)
                    {
                        string tempName = Path.Combine(path, fInfo.Name + "_" + i.ToString().PadLeft(3, '0'));
                        using (var tempFS = new FileStream(tempName, FileMode.Create))
                        using (var tempBW = new BinaryWriter(tempFS))
                            tempBW.Write(splitBR.ReadBytes(size));
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void UniteFile(string[] files, string file)
        {
            try
            {
                using (var appendFile = new FileStream(file, FileMode.Append))
                using (var appendBW = new BinaryWriter(appendFile))
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        using (var tempFS = new FileStream(files[i], FileMode.Open))
                        using (var tempBR = new BinaryReader(tempFS))
                            appendBW.Write(tempBR.ReadBytes((int)tempFS.Length));
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
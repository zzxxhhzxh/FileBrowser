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
    public partial class FrmFileTree : Form
    {
        string dirStr = "├─";

        public FrmFileTree(string filePath)
        {
            InitializeComponent();
            rtxDirTree.Text = ShowFileTree(filePath, 0);
        }

        public string ShowFileTree(string path, int layer)
        {
            var sb = new StringBuilder();
            int i = layer + 1;
            var dirs = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path);
            foreach (var dir in dirs)
            {
                sb.Append(dirStr.PadLeft(i * 2, ' ') + $"─ {Path.GetFileName(dir)}\n");
                sb.Append(ShowFileTree(dir, i));
            }
            foreach (var file in files)
                sb.Append(dirStr.PadLeft(i * 2, ' ') + $"─ {Path.GetFileName(file)}\n");
            return sb.ToString();
        }
    }
}
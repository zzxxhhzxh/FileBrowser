using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace FileBrowser
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEINFO
    {
        public IntPtr hIcon;
        public IntPtr iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    }

    public partial class FrmMain : Form
    {
        [DllImport("shell32.dll", EntryPoint = "SHGetFileInfo")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttribute, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint Flags);

        string CurPath = string.Empty;
        public static string[] SelectedFiles;
        static bool IsCopy = true;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            string[] lDrive = Directory.GetLogicalDrives();
            for (int i = 0; i < lDrive.Length; i++)
                tspCboRoot.Items.Add(lDrive[i]);
            tspCboRoot.SelectedIndex = 0;
        }

        private void tspCboRoot_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurPath = tspCboRoot.Text;
            GetListViewItem();
        }

        private void lvwFile_DoubleClick(object sender, EventArgs e)
        {
            if(lvwFile.SelectedItems[0].Text != "...")
                OpenFile(Path.Combine(CurPath, lvwFile.SelectedItems[0].Text));
            else if (CurPath.Length >= 4)
                CurPath = Directory.GetParent(CurPath).FullName;               
            GetListViewItem();
        }

        private void tsipBtnCut_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                return;
            SelectedFiles = new string[lvwFile.SelectedItems.Count];
            for (int i = 0; i < SelectedFiles.Length; i++)
                SelectedFiles[i] = Path.Combine(CurPath, lvwFile.SelectedItems[i].Text);
            IsCopy = false;
        }

        private void tsipBtnCopy_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                return;
            SelectedFiles = new string[lvwFile.SelectedItems.Count];
            for (int i = 0; i < SelectedFiles.Length; i++)
                SelectedFiles[i] = Path.Combine(CurPath, lvwFile.SelectedItems[i].Text);
            IsCopy = true;
        }

        private void tsipBtnPaste_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectedFiles.Length; i++)
                CopyFile(SelectedFiles[i], CurPath);
            if (IsCopy)
                return;
            for (int i = 0; i < SelectedFiles.Length; i++)
                DeleteFile(SelectedFiles[i]);
            GetListViewItem();
        }

        private void tsipBtnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwFile.Items.Count; i++)
                lvwFile.Items[i].Selected = true;
        }

        private void tsipBtnOpen_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(CurPath, lvwFile.SelectedItems[0].Text);
            OpenFile(path);
            GetListViewItem();
        }

        private void tsipBtnRename_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                return;
            SelectedFiles = new string[lvwFile.SelectedItems.Count];
            for (int i = 0; i < SelectedFiles.Length; i++)
                SelectedFiles[i] = Path.Combine(CurPath, lvwFile.SelectedItems[i].Text);
            new FrmRename(SelectedFiles).ShowDialog();
        }

        private void tsipBtnDelete_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                return;
            foreach (ListViewItem i in lvwFile.SelectedItems)
                DeleteFile(Path.Combine(CurPath, i.Text));
            GetListViewItem();
        }

        private void tsipBtnSearch_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                new FrmSearch(CurPath).ShowDialog();
            else
            {
                string folder = Path.Combine(CurPath, lvwFile.SelectedItems[0].Text);
                if (Directory.Exists(folder))
                    new FrmSearch(folder).ShowDialog();
            }
        }

        private void tsipBtnOrgnize_Click(object sender, EventArgs e)
        {
            OrgnizeFile(CurPath);
            GetListViewItem();
        }

        private void tsipBtnSplit_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                return;
            SelectedFiles = new string[lvwFile.SelectedItems.Count];
            for (int i = 0; i < SelectedFiles.Length; i++)
                SelectedFiles[i] = Path.Combine(CurPath, lvwFile.SelectedItems[i].Text);
            new FrmSplit(SelectedFiles).ShowDialog();
        }

        private void TsipBtnMoni_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                new FrmMonitor(CurPath).ShowDialog();
            else
            {
                string folder = Path.Combine(CurPath, lvwFile.SelectedItems[0].Text);
                if (Directory.Exists(folder))
                    new FrmMonitor(folder).ShowDialog();
            }
        }

        private void TsipBtnPic_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                new FrmPicPlay(CurPath).ShowDialog();
            else
            {
                string folder = Path.Combine(CurPath, lvwFile.SelectedItems[0].Text);
                if (Directory.Exists(folder))
                    new FrmPicPlay(folder).ShowDialog();
            }
        }

        private void TsipBtnPriv_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                new FrmPrivilege(CurPath).ShowDialog();
            else
                new FrmPrivilege(Path.Combine(CurPath, lvwFile.SelectedItems[0].Text)).ShowDialog();
        }

        private void TsipBtnAttr_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count != 0)
                new FrmAttribute(Path.Combine(CurPath, lvwFile.SelectedItems[0].Text)).ShowDialog();
        }

        private void TsipBtnProc_Click(object sender, EventArgs e)
        {
            new FrmProcess().ShowDialog();
        }

        private void TsipBtnNet_Click(object sender, EventArgs e)
        {
            new FrmNetwork().ShowDialog();
        }

        private void TsipBtnTree_Click(object sender, EventArgs e)
        {
            if (lvwFile.SelectedItems.Count == 0)
                new FrmFileTree(CurPath).ShowDialog();
            else
            {
                string folder = Path.Combine(CurPath, lvwFile.SelectedItems[0].Text);
                if (Directory.Exists(folder))
                    new FrmFileTree(folder).ShowDialog();
            }     
        }

        private void lvwFile_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            string path1 = Path.Combine(CurPath, lvwFile.SelectedItems[0].Text);
            string path2 = Path.Combine(CurPath, e.Label);
            try
            {
                if (File.Exists(path1))
                    File.Move(path1, path2);
                if (Directory.Exists(path1))
                    Directory.Move(path1, path2);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            GetListViewItem();
        }

        public void CopyFile(string sFile, string dPath)
        {
            try
            {
                if (Directory.Exists(sFile))
                {
                    var dInfo = new DirectoryInfo(sFile);
                    string newPath = Path.Combine(dPath, dInfo.Name);
                    Directory.CreateDirectory(newPath);
                    foreach (var fSysInfo in dInfo.GetFileSystemInfos())
                        CopyFile(fSysInfo.FullName, newPath);
                }
                else if (File.Exists(sFile))
                {
                    var fInfo = new FileInfo(sFile);
                    string dFile = Path.Combine(dPath, fInfo.Name);
                    File.Copy(sFile, dFile);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void DeleteFile(string file)
        {
            try
            {
                if (File.Exists(file))
                    File.Delete(file);
                else if (Directory.Exists(file))
                    Directory.Delete(file, true);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void OpenFile(string file)
        {
            try
            {
                if (File.Exists(file))
                    Process.Start(file);
                else if (Directory.Exists(file))
                    CurPath = file;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void OrgnizeFile(string path)
        {
            try
            {
                var fInfos = new DirectoryInfo(path).GetFiles();
                foreach (var fInfo in fInfos)
                {
                    string dPath = Path.Combine(path, fInfo.Extension);
                    if (!Directory.Exists(dPath))
                        Directory.CreateDirectory(dPath);
                    fInfo.MoveTo(Path.Combine(dPath, fInfo.Name));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void GetListViewItem()
        {
            lvwFile.Items.Clear();

            var sInfo0 = new SHFILEINFO();
            SHGetFileInfo(@"C:\Program Files", 0x80, ref sInfo0, (uint)Marshal.SizeOf(sInfo0), 0x100 | 0x400);
            imgFile.Images.Add("...", (Icon)Icon.FromHandle(sInfo0.hIcon).Clone());
            lvwFile.Items.Add(new ListViewItem(new string[] { "...", "", "", "" }, "..."));

            try
            {
                var dirs = Directory.GetDirectories(CurPath);
                var files = Directory.GetFiles(CurPath);
                foreach (var dir in dirs)
                {
                    try
                    {
                        var dInfo = new DirectoryInfo(dir);
                        var sInfo = new SHFILEINFO();
                        SHGetFileInfo(dir, 0x80, ref sInfo, (uint)Marshal.SizeOf(sInfo), 0x100 | 0x400);
                        imgFile.Images.Add(dInfo.Name, (Icon)Icon.FromHandle(sInfo.hIcon).Clone());
                        lvwFile.Items.Add(new ListViewItem(new string[] { dInfo.Name, "", "Folder", dInfo.LastWriteTime.ToString() }, dInfo.Name));
                    }
                    catch { continue; }
                }
                foreach (var file in files)
                {
                    try
                    {
                        var fInfo = new FileInfo(file);
                        var sInfo = new SHFILEINFO();
                        SHGetFileInfo(file, 0x80, ref sInfo, (uint)Marshal.SizeOf(sInfo), 0x100 | 0x400);
                        imgFile.Images.Add(fInfo.Name, (Icon)Icon.FromHandle(sInfo.hIcon).Clone());
                        lvwFile.Items.Add(new ListViewItem(new string[] { fInfo.Name, $"{fInfo.Length / 1024.0:F1} KB", fInfo.Extension, fInfo.LastWriteTime.ToString() }, fInfo.Name));
                    }
                    catch { continue; }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

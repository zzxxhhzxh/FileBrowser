namespace FileBrowser
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tspFile = new System.Windows.Forms.ToolStrip();
            this.tspCboRoot = new System.Windows.Forms.ToolStripComboBox();
            this.tsipBtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnRename = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnOrgnize = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnSplit = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnMoni = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnPic = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnPriv = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnAttr = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnProc = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnNet = new System.Windows.Forms.ToolStripButton();
            this.tsipBtnTree = new System.Windows.Forms.ToolStripButton();
            this.lvwFile = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgFile = new System.Windows.Forms.ImageList(this.components);
            this.tspFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspFile
            // 
            this.tspFile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tspFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspCboRoot,
            this.tsipBtnCut,
            this.tsipBtnCopy,
            this.tsipBtnPaste,
            this.tsipBtnSelectAll,
            this.tsipBtnTree,
            this.tsipBtnOpen,
            this.tsipBtnRename,
            this.tsipBtnDelete,
            this.tsipBtnSearch,
            this.tsipBtnOrgnize,
            this.tsipBtnSplit,
            this.tsipBtnMoni,
            this.tsipBtnPic,
            this.tsipBtnPriv,
            this.tsipBtnAttr,
            this.tsipBtnProc,
            this.tsipBtnNet});
            this.tspFile.Location = new System.Drawing.Point(0, 0);
            this.tspFile.Name = "tspFile";
            this.tspFile.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tspFile.Size = new System.Drawing.Size(1080, 25);
            this.tspFile.TabIndex = 2;
            this.tspFile.Text = "tspFile";
            // 
            // tspCboRoot
            // 
            this.tspCboRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tspCboRoot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tspCboRoot.Name = "tspCboRoot";
            this.tspCboRoot.Size = new System.Drawing.Size(121, 25);
            this.tspCboRoot.SelectedIndexChanged += new System.EventHandler(this.tspCboRoot_SelectedIndexChanged);
            // 
            // tsipBtnCut
            // 
            this.tsipBtnCut.Name = "tsipBtnCut";
            this.tsipBtnCut.Size = new System.Drawing.Size(30, 22);
            this.tsipBtnCut.Text = "Cut";
            this.tsipBtnCut.ToolTipText = "Cut";
            this.tsipBtnCut.Click += new System.EventHandler(this.tsipBtnCut_Click);
            // 
            // tsipBtnCopy
            // 
            this.tsipBtnCopy.Name = "tsipBtnCopy";
            this.tsipBtnCopy.Size = new System.Drawing.Size(39, 22);
            this.tsipBtnCopy.Text = "Copy";
            this.tsipBtnCopy.Click += new System.EventHandler(this.tsipBtnCopy_Click);
            // 
            // tsipBtnPaste
            // 
            this.tsipBtnPaste.Name = "tsipBtnPaste";
            this.tsipBtnPaste.Size = new System.Drawing.Size(39, 22);
            this.tsipBtnPaste.Text = "Paste";
            this.tsipBtnPaste.Click += new System.EventHandler(this.tsipBtnPaste_Click);
            // 
            // tsipBtnSelectAll
            // 
            this.tsipBtnSelectAll.Name = "tsipBtnSelectAll";
            this.tsipBtnSelectAll.Size = new System.Drawing.Size(59, 22);
            this.tsipBtnSelectAll.Text = "Select All";
            this.tsipBtnSelectAll.Click += new System.EventHandler(this.tsipBtnSelectAll_Click);
            // 
            // tsipBtnOpen
            // 
            this.tsipBtnOpen.Name = "tsipBtnOpen";
            this.tsipBtnOpen.Size = new System.Drawing.Size(40, 22);
            this.tsipBtnOpen.Text = "Open";
            this.tsipBtnOpen.Click += new System.EventHandler(this.tsipBtnOpen_Click);
            // 
            // tsipBtnRename
            // 
            this.tsipBtnRename.Name = "tsipBtnRename";
            this.tsipBtnRename.Size = new System.Drawing.Size(54, 22);
            this.tsipBtnRename.Text = "Rename";
            this.tsipBtnRename.Click += new System.EventHandler(this.tsipBtnRename_Click);
            // 
            // tsipBtnDelete
            // 
            this.tsipBtnDelete.Name = "tsipBtnDelete";
            this.tsipBtnDelete.Size = new System.Drawing.Size(44, 22);
            this.tsipBtnDelete.Text = "Delete";
            this.tsipBtnDelete.Click += new System.EventHandler(this.tsipBtnDelete_Click);
            // 
            // tsipBtnSearch
            // 
            this.tsipBtnSearch.Name = "tsipBtnSearch";
            this.tsipBtnSearch.Size = new System.Drawing.Size(46, 22);
            this.tsipBtnSearch.Text = "Search";
            this.tsipBtnSearch.Click += new System.EventHandler(this.tsipBtnSearch_Click);
            // 
            // tsipBtnOrgnize
            // 
            this.tsipBtnOrgnize.Name = "tsipBtnOrgnize";
            this.tsipBtnOrgnize.Size = new System.Drawing.Size(52, 22);
            this.tsipBtnOrgnize.Text = "Orgnize";
            this.tsipBtnOrgnize.Click += new System.EventHandler(this.tsipBtnOrgnize_Click);
            // 
            // tsipBtnSplit
            // 
            this.tsipBtnSplit.Name = "tsipBtnSplit";
            this.tsipBtnSplit.Size = new System.Drawing.Size(67, 22);
            this.tsipBtnSplit.Text = "Split/Unite";
            this.tsipBtnSplit.Click += new System.EventHandler(this.tsipBtnSplit_Click);
            // 
            // tsipBtnMoni
            // 
            this.tsipBtnMoni.Name = "tsipBtnMoni";
            this.tsipBtnMoni.Size = new System.Drawing.Size(54, 22);
            this.tsipBtnMoni.Text = "Monitor";
            this.tsipBtnMoni.Click += new System.EventHandler(this.TsipBtnMoni_Click);
            // 
            // tsipBtnPic
            // 
            this.tsipBtnPic.Name = "tsipBtnPic";
            this.tsipBtnPic.Size = new System.Drawing.Size(59, 22);
            this.tsipBtnPic.Text = "PicPlayer";
            this.tsipBtnPic.Click += new System.EventHandler(this.TsipBtnPic_Click);
            // 
            // tsipBtnPriv
            // 
            this.tsipBtnPriv.Name = "tsipBtnPriv";
            this.tsipBtnPriv.Size = new System.Drawing.Size(56, 22);
            this.tsipBtnPriv.Text = "Privilege";
            this.tsipBtnPriv.Click += new System.EventHandler(this.TsipBtnPriv_Click);
            // 
            // tsipBtnAttr
            // 
            this.tsipBtnAttr.Name = "tsipBtnAttr";
            this.tsipBtnAttr.Size = new System.Drawing.Size(58, 22);
            this.tsipBtnAttr.Text = "Attribute";
            this.tsipBtnAttr.Click += new System.EventHandler(this.TsipBtnAttr_Click);
            // 
            // tsipBtnProc
            // 
            this.tsipBtnProc.Name = "tsipBtnProc";
            this.tsipBtnProc.Size = new System.Drawing.Size(51, 22);
            this.tsipBtnProc.Text = "Process";
            this.tsipBtnProc.Click += new System.EventHandler(this.TsipBtnProc_Click);
            // 
            // tsipBtnNet
            // 
            this.tsipBtnNet.Name = "tsipBtnNet";
            this.tsipBtnNet.Size = new System.Drawing.Size(56, 22);
            this.tsipBtnNet.Text = "Network";
            this.tsipBtnNet.Click += new System.EventHandler(this.TsipBtnNet_Click);
            // 
            // tsipBtnTree
            // 
            this.tsipBtnTree.Name = "tsipBtnTree";
            this.tsipBtnTree.Size = new System.Drawing.Size(50, 22);
            this.tsipBtnTree.Text = "FileTree";
            this.tsipBtnTree.Click += new System.EventHandler(this.TsipBtnTree_Click);
            // 
            // lvwFile
            // 
            this.lvwFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colExt,
            this.colTime});
            this.lvwFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFile.FullRowSelect = true;
            this.lvwFile.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwFile.HideSelection = false;
            this.lvwFile.LabelEdit = true;
            this.lvwFile.Location = new System.Drawing.Point(0, 25);
            this.lvwFile.Name = "lvwFile";
            this.lvwFile.Size = new System.Drawing.Size(1080, 526);
            this.lvwFile.SmallImageList = this.imgFile;
            this.lvwFile.TabIndex = 3;
            this.lvwFile.UseCompatibleStateImageBehavior = false;
            this.lvwFile.View = System.Windows.Forms.View.Details;
            this.lvwFile.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwFile_AfterLabelEdit);
            this.lvwFile.DoubleClick += new System.EventHandler(this.lvwFile_DoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 219;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 104;
            // 
            // colExt
            // 
            this.colExt.Text = "Extention";
            this.colExt.Width = 94;
            // 
            // colTime
            // 
            this.colTime.Text = "Modified Time";
            this.colTime.Width = 174;
            // 
            // imgFile
            // 
            this.imgFile.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgFile.ImageSize = new System.Drawing.Size(20, 20);
            this.imgFile.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 551);
            this.Controls.Add(this.lvwFile);
            this.Controls.Add(this.tspFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Browser";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.tspFile.ResumeLayout(false);
            this.tspFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tspFile;
        private System.Windows.Forms.ToolStripComboBox tspCboRoot;
        private System.Windows.Forms.ListView lvwFile;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colExt;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ImageList imgFile;
        private System.Windows.Forms.ToolStripButton tsipBtnCut;
        private System.Windows.Forms.ToolStripButton tsipBtnCopy;
        private System.Windows.Forms.ToolStripButton tsipBtnPaste;
        private System.Windows.Forms.ToolStripButton tsipBtnSelectAll;
        private System.Windows.Forms.ToolStripButton tsipBtnOpen;
        private System.Windows.Forms.ToolStripButton tsipBtnRename;
        private System.Windows.Forms.ToolStripButton tsipBtnDelete;
        private System.Windows.Forms.ToolStripButton tsipBtnSearch;
        private System.Windows.Forms.ToolStripButton tsipBtnOrgnize;
        private System.Windows.Forms.ToolStripButton tsipBtnSplit;
        private System.Windows.Forms.ToolStripButton tsipBtnMoni;
        private System.Windows.Forms.ToolStripButton tsipBtnPic;
        private System.Windows.Forms.ToolStripButton tsipBtnPriv;
        private System.Windows.Forms.ToolStripButton tsipBtnAttr;
        private System.Windows.Forms.ToolStripButton tsipBtnProc;
        private System.Windows.Forms.ToolStripButton tsipBtnNet;
        private System.Windows.Forms.ToolStripButton tsipBtnTree;
    }
}
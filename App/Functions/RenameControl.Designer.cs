﻿namespace PDFPatcher.Functions
{
	partial class RenameControl
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent () {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
			System.Windows.Forms.ToolStripDropDownButton _Sort;
			System.Windows.Forms.ToolStripButton _Delete;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
			System.Windows.Forms.ToolStripMenuItem _SelectAll;
			System.Windows.Forms.ToolStripMenuItem _InvertSelect;
			System.Windows.Forms.ToolStripMenuItem _SelectNone;
			System.Windows.Forms.ToolStripMenuItem _Copy;
			System.Windows.Forms.ToolStripMenuItem _RefreshInfo;
			this._MainToolbar = new System.Windows.Forms.ToolStrip();
			this._AddFilesButton = new System.Windows.Forms.ToolStripSplitButton();
			this._RecentFileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._SortMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._SortByNaturalNumberItem = new System.Windows.Forms.ToolStripMenuItem();
			this._SortByAlphaItem = new System.Windows.Forms.ToolStripMenuItem();
			this._RefreshInfoButton = new System.Windows.Forms.ToolStripSplitButton();
			this._RefreshInfoMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._SelectionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._SelectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._ItemList = new BrightIdeasSoftware.ObjectListView();
			this._NameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._PageCountColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._TitleColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._AuthorColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._SubjectColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._KeywordsColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._FolderColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._FileTimeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._ItemListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._FileTypeList = new System.Windows.Forms.ImageList(this.components);
			this._OpenPdfBox = new System.Windows.Forms.OpenFileDialog();
			this._AutoClearListBox = new System.Windows.Forms.CheckBox();
			this._AddDocumentWorker = new System.ComponentModel.BackgroundWorker();
			this._KeepSourceFileBox = new System.Windows.Forms.CheckBox();
			this._TestRenameButton = new System.Windows.Forms.Button();
			this._TargetPdfFile = new PDFPatcher.TargetFileControl();
			this._RenameButton = new EnhancedGlassButton.GlassButton();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			_Sort = new System.Windows.Forms.ToolStripDropDownButton();
			_Delete = new System.Windows.Forms.ToolStripButton();
			toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
			_InvertSelect = new System.Windows.Forms.ToolStripMenuItem();
			_SelectNone = new System.Windows.Forms.ToolStripMenuItem();
			_Copy = new System.Windows.Forms.ToolStripMenuItem();
			_RefreshInfo = new System.Windows.Forms.ToolStripMenuItem();
			this._MainToolbar.SuspendLayout();
			this._SortMenu.SuspendLayout();
			this._SelectionMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._ItemList)).BeginInit();
			this._ItemListMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// _MainToolbar
			// 
			this._MainToolbar.GripMargin = new System.Windows.Forms.Padding(0);
			this._MainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._AddFilesButton,
            toolStripSeparator1,
            _Sort,
            _Delete,
            toolStripSeparator2,
            this._RefreshInfoButton});
			this._MainToolbar.Location = new System.Drawing.Point(0, 0);
			this._MainToolbar.Name = "_MainToolbar";
			this._MainToolbar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this._MainToolbar.Size = new System.Drawing.Size(575, 25);
			this._MainToolbar.TabIndex = 0;
			this._MainToolbar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._MainToolbar_ItemClicked);
			// 
			// _AddFilesButton
			// 
			this._AddFilesButton.DropDown = this._RecentFileMenu;
			this._AddFilesButton.Image = global::PDFPatcher.Properties.Resources.Add;
			this._AddFilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._AddFilesButton.Name = "_AddFilesButton";
			this._AddFilesButton.Size = new System.Drawing.Size(103, 22);
			this._AddFilesButton.Text = "添加文件(&T)";
			this._AddFilesButton.ToolTipText = "添加文件";
			this._AddFilesButton.ButtonClick += new System.EventHandler(this._MainToolbar_ButtonClick);
			// 
			// _RecentFileMenu
			// 
			this._RecentFileMenu.Name = "_RecentFileMenu";
			this._RecentFileMenu.ShowImageMargin = false;
			this._RecentFileMenu.Size = new System.Drawing.Size(36, 4);
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// _Sort
			// 
			_Sort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			_Sort.DropDown = this._SortMenu;
			_Sort.Image = global::PDFPatcher.Properties.Resources.Sort;
			_Sort.ImageTransparentColor = System.Drawing.Color.Magenta;
			_Sort.Name = "_Sort";
			_Sort.Size = new System.Drawing.Size(29, 22);
			_Sort.Text = "排序";
			_Sort.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._SortMenu_ItemClicked);
			// 
			// _SortMenu
			// 
			this._SortMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._SortByNaturalNumberItem,
            this._SortByAlphaItem});
			this._SortMenu.Name = "_SortMenu";
			this._SortMenu.Size = new System.Drawing.Size(217, 48);
			this._SortMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._SortMenu_ItemClicked);
			// 
			// _SortByNaturalNumberItem
			// 
			this._SortByNaturalNumberItem.Image = global::PDFPatcher.Properties.Resources.NaturalSort;
			this._SortByNaturalNumberItem.Name = "_SortByNaturalNumberItem";
			this._SortByNaturalNumberItem.Size = new System.Drawing.Size(216, 22);
			this._SortByNaturalNumberItem.Text = "按数值和字母顺序排序(&M)";
			// 
			// _SortByAlphaItem
			// 
			this._SortByAlphaItem.Image = global::PDFPatcher.Properties.Resources.AlphabeticSort;
			this._SortByAlphaItem.Name = "_SortByAlphaItem";
			this._SortByAlphaItem.Size = new System.Drawing.Size(216, 22);
			this._SortByAlphaItem.Text = "按字母顺序排序(&Z)";
			// 
			// _Delete
			// 
			_Delete.Image = global::PDFPatcher.Properties.Resources.Delete;
			_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			_Delete.Name = "_Delete";
			_Delete.Size = new System.Drawing.Size(76, 22);
			_Delete.Text = "删除文件";
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// _RefreshInfoButton
			// 
			this._RefreshInfoButton.Image = global::PDFPatcher.Properties.Resources.Refresh;
			this._RefreshInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._RefreshInfoButton.Name = "_RefreshInfoButton";
			this._RefreshInfoButton.Size = new System.Drawing.Size(112, 22);
			this._RefreshInfoButton.Text = "刷新文档属性";
			// 
			// _SelectAll
			// 
			_SelectAll.Image = global::PDFPatcher.Properties.Resources.SelectAll;
			_SelectAll.Name = "_SelectAll";
			_SelectAll.Size = new System.Drawing.Size(124, 22);
			_SelectAll.Text = "全部选中";
			// 
			// _InvertSelect
			// 
			_InvertSelect.Name = "_InvertSelect";
			_InvertSelect.Size = new System.Drawing.Size(124, 22);
			_InvertSelect.Text = "反转选择";
			// 
			// _SelectNone
			// 
			_SelectNone.Name = "_SelectNone";
			_SelectNone.Size = new System.Drawing.Size(124, 22);
			_SelectNone.Text = "取消选择";
			// 
			// _Copy
			// 
			_Copy.Image = global::PDFPatcher.Properties.Resources.Copy;
			_Copy.Name = "_Copy";
			_Copy.Size = new System.Drawing.Size(148, 22);
			_Copy.Text = "复制列表内容";
			// 
			// _RefreshInfo
			// 
			_RefreshInfo.DropDown = this._RefreshInfoMenu;
			_RefreshInfo.Image = global::PDFPatcher.Properties.Resources.Refresh;
			_RefreshInfo.Name = "_RefreshInfo";
			_RefreshInfo.Size = new System.Drawing.Size(148, 22);
			_RefreshInfo.Text = "刷新文档属性";
			// 
			// _RefreshInfoMenu
			// 
			this._RefreshInfoMenu.Name = "_RefreshInfoMenu";
			this._RefreshInfoMenu.Size = new System.Drawing.Size(61, 4);
			// 
			// _SelectionMenu
			// 
			this._SelectionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            _SelectAll,
            _InvertSelect,
            _SelectNone});
			this._SelectionMenu.Name = "_SelectionMenu";
			this._SelectionMenu.Size = new System.Drawing.Size(125, 70);
			this._SelectionMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._MainToolbar_ItemClicked);
			// 
			// _SelectionMenuItem
			// 
			this._SelectionMenuItem.DropDown = this._SelectionMenu;
			this._SelectionMenuItem.Image = global::PDFPatcher.Properties.Resources.SelectItem;
			this._SelectionMenuItem.Name = "_SelectionMenuItem";
			this._SelectionMenuItem.Size = new System.Drawing.Size(148, 22);
			this._SelectionMenuItem.Text = "选择文件";
			// 
			// _ItemList
			// 
			this._ItemList.AllColumns.Add(this._NameColumn);
			this._ItemList.AllColumns.Add(this._PageCountColumn);
			this._ItemList.AllColumns.Add(this._TitleColumn);
			this._ItemList.AllColumns.Add(this._AuthorColumn);
			this._ItemList.AllColumns.Add(this._SubjectColumn);
			this._ItemList.AllColumns.Add(this._KeywordsColumn);
			this._ItemList.AllColumns.Add(this._FolderColumn);
			this._ItemList.AllColumns.Add(this._FileTimeColumn);
			this._ItemList.AllowDrop = true;
			this._ItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._ItemList.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this._ItemList.CellEditUseWholeCell = false;
			this._ItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._NameColumn,
            this._PageCountColumn,
            this._TitleColumn,
            this._AuthorColumn,
            this._SubjectColumn,
            this._KeywordsColumn,
            this._FolderColumn,
            this._FileTimeColumn});
			this._ItemList.ContextMenuStrip = this._ItemListMenu;
			this._ItemList.Cursor = System.Windows.Forms.Cursors.Default;
			this._ItemList.GridLines = true;
			this._ItemList.HideSelection = false;
			this._ItemList.Location = new System.Drawing.Point(16, 57);
			this._ItemList.Name = "_ItemList";
			this._ItemList.ShowGroups = false;
			this._ItemList.Size = new System.Drawing.Size(544, 202);
			this._ItemList.SmallImageList = this._FileTypeList;
			this._ItemList.TabIndex = 0;
			this._ItemList.UseCompatibleStateImageBehavior = false;
			this._ItemList.View = System.Windows.Forms.View.Details;
			this._ItemList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this._ImageList_ColumnClick);
			// 
			// _NameColumn
			// 
			this._NameColumn.Text = "源文件名";
			this._NameColumn.Width = 149;
			// 
			// _PageCountColumn
			// 
			this._PageCountColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._PageCountColumn.IsEditable = false;
			this._PageCountColumn.Text = "页数";
			this._PageCountColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._PageCountColumn.Width = 50;
			// 
			// _TitleColumn
			// 
			this._TitleColumn.Text = "标题";
			this._TitleColumn.Width = 58;
			// 
			// _AuthorColumn
			// 
			this._AuthorColumn.Text = "作者";
			// 
			// _SubjectColumn
			// 
			this._SubjectColumn.Text = "主题";
			// 
			// _KeywordsColumn
			// 
			this._KeywordsColumn.Text = "关键词";
			this._KeywordsColumn.Width = 73;
			// 
			// _FolderColumn
			// 
			this._FolderColumn.IsEditable = false;
			this._FolderColumn.Text = "文件夹";
			this._FolderColumn.Width = 96;
			// 
			// _FileTimeColumn
			// 
			this._FileTimeColumn.IsEditable = false;
			this._FileTimeColumn.Text = "修改时间";
			this._FileTimeColumn.Width = 145;
			// 
			// _ItemListMenu
			// 
			this._ItemListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            _Copy,
            _RefreshInfo,
            this._SelectionMenuItem});
			this._ItemListMenu.Name = "_ItemListMenu";
			this._ItemListMenu.Size = new System.Drawing.Size(149, 70);
			this._ItemListMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._MainToolbar_ItemClicked);
			// 
			// _FileTypeList
			// 
			this._FileTypeList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this._FileTypeList.ImageSize = new System.Drawing.Size(16, 16);
			this._FileTypeList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// _OpenPdfBox
			// 
			this._OpenPdfBox.DefaultExt = "pdf";
			this._OpenPdfBox.Filter = "PDF 文件（*.pdf）|*.pdf";
			this._OpenPdfBox.Multiselect = true;
			this._OpenPdfBox.Title = "选择需要处理的 PDF 文件";
			// 
			// _AutoClearListBox
			// 
			this._AutoClearListBox.AutoSize = true;
			this._AutoClearListBox.Checked = true;
			this._AutoClearListBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this._AutoClearListBox.Location = new System.Drawing.Point(16, 29);
			this._AutoClearListBox.Name = "_AutoClearListBox";
			this._AutoClearListBox.Size = new System.Drawing.Size(132, 16);
			this._AutoClearListBox.TabIndex = 4;
			this._AutoClearListBox.Text = "添加文件前清空列表";
			this._AutoClearListBox.UseVisualStyleBackColor = true;
			// 
			// _AddDocumentWorker
			// 
			this._AddDocumentWorker.WorkerReportsProgress = true;
			this._AddDocumentWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this._AddDocumentWorker_DoWork);
			this._AddDocumentWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this._AddDocumentWorker_ProgressChanged);
			this._AddDocumentWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._AddDocumentWorker_RunWorkerCompleted);
			// 
			// _KeepSourceFileBox
			// 
			this._KeepSourceFileBox.AutoSize = true;
			this._KeepSourceFileBox.Checked = true;
			this._KeepSourceFileBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this._KeepSourceFileBox.Location = new System.Drawing.Point(166, 29);
			this._KeepSourceFileBox.Name = "_KeepSourceFileBox";
			this._KeepSourceFileBox.Size = new System.Drawing.Size(96, 16);
			this._KeepSourceFileBox.TabIndex = 12;
			this._KeepSourceFileBox.Text = "保留原始文件";
			this._KeepSourceFileBox.UseVisualStyleBackColor = true;
			// 
			// _TestRenameButton
			// 
			this._TestRenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._TestRenameButton.Location = new System.Drawing.Point(312, 297);
			this._TestRenameButton.Name = "_TestRenameButton";
			this._TestRenameButton.Size = new System.Drawing.Size(119, 23);
			this._TestRenameButton.TabIndex = 11;
			this._TestRenameButton.Text = "测试命名模板(&C)";
			this._TestRenameButton.UseVisualStyleBackColor = true;
			this._TestRenameButton.Click += new System.EventHandler(this._TestRenameButton_Click);
			// 
			// _TargetPdfFile
			// 
			this._TargetPdfFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._TargetPdfFile.Label = "重命名模板(&M)：";
			this._TargetPdfFile.Location = new System.Drawing.Point(13, 265);
			this._TargetPdfFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._TargetPdfFile.Name = "_TargetPdfFile";
			this._TargetPdfFile.Size = new System.Drawing.Size(553, 26);
			this._TargetPdfFile.TabIndex = 7;
			// 
			// _RenameButton
			// 
			this._RenameButton.AlternativeFocusBorderColor = System.Drawing.SystemColors.Highlight;
			this._RenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._RenameButton.AnimateGlow = true;
			this._RenameButton.BackColor = System.Drawing.SystemColors.Highlight;
			this._RenameButton.CornerRadius = 3;
			this._RenameButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this._RenameButton.GlowColor = System.Drawing.Color.White;
			this._RenameButton.Image = global::PDFPatcher.Properties.Resources.Save;
			this._RenameButton.InnerBorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this._RenameButton.Location = new System.Drawing.Point(440, 297);
			this._RenameButton.Name = "_RenameButton";
			this._RenameButton.OuterBorderColor = System.Drawing.SystemColors.ControlLightLight;
			this._RenameButton.ShowFocusBorder = true;
			this._RenameButton.Size = new System.Drawing.Size(123, 29);
			this._RenameButton.TabIndex = 13;
			this._RenameButton.Text = "重命名文件(&C)";
			this._RenameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._RenameButton.Click += new System.EventHandler(this._RenameButton_Click);
			// 
			// RenameControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._RenameButton);
			this.Controls.Add(this._ItemList);
			this.Controls.Add(this._MainToolbar);
			this.Controls.Add(this._TargetPdfFile);
			this.Controls.Add(this._AutoClearListBox);
			this.Controls.Add(this._TestRenameButton);
			this.Controls.Add(this._KeepSourceFileBox);
			this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "RenameControl";
			this.Size = new System.Drawing.Size(575, 342);
			this._MainToolbar.ResumeLayout(false);
			this._MainToolbar.PerformLayout();
			this._SortMenu.ResumeLayout(false);
			this._SelectionMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._ItemList)).EndInit();
			this._ItemListMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView _ItemList;
		private BrightIdeasSoftware.OLVColumn _NameColumn;
		private BrightIdeasSoftware.OLVColumn _FolderColumn;
		private TargetFileControl _TargetPdfFile;
		private System.Windows.Forms.ContextMenuStrip _SortMenu;
		private System.Windows.Forms.ToolStripMenuItem _SortByNaturalNumberItem;
		private System.Windows.Forms.ToolStripMenuItem _SortByAlphaItem;
		private System.Windows.Forms.ContextMenuStrip _SelectionMenu;
		private BrightIdeasSoftware.OLVColumn _PageCountColumn;
		private System.Windows.Forms.ToolStripMenuItem _SelectionMenuItem;
		private System.Windows.Forms.ContextMenuStrip _ItemListMenu;
		private System.Windows.Forms.ToolStripSplitButton _AddFilesButton;
		private System.Windows.Forms.ContextMenuStrip _RecentFileMenu;
		private System.Windows.Forms.OpenFileDialog _OpenPdfBox;
		private System.Windows.Forms.CheckBox _AutoClearListBox;
		private System.ComponentModel.BackgroundWorker _AddDocumentWorker;
		private BrightIdeasSoftware.OLVColumn _TitleColumn;
		private BrightIdeasSoftware.OLVColumn _AuthorColumn;
		private BrightIdeasSoftware.OLVColumn _SubjectColumn;
		private BrightIdeasSoftware.OLVColumn _KeywordsColumn;
		private System.Windows.Forms.CheckBox _KeepSourceFileBox;
		private System.Windows.Forms.Button _TestRenameButton;
		private System.Windows.Forms.ImageList _FileTypeList;
		private System.Windows.Forms.ToolStripSplitButton _RefreshInfoButton;
		private System.Windows.Forms.ContextMenuStrip _RefreshInfoMenu;
		private EnhancedGlassButton.GlassButton _RenameButton;
		private BrightIdeasSoftware.OLVColumn _FileTimeColumn;
		private System.Windows.Forms.ToolStrip _MainToolbar;
	}
}

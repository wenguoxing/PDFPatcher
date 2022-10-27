﻿namespace PDFPatcher.Functions
{
	partial class AutoBookmarkForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
			this._LoadListButton = new System.Windows.Forms.ToolStripMenuItem();
			this._SaveListButton = new System.Windows.Forms.ToolStripMenuItem();
			this._BookmarkConditionBox = new BrightIdeasSoftware.ObjectListView();
			this._ConditionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._LevelColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._BoldColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._ItalicColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._ColorColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._OpenColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._GoToTopColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this._AutoBookmarkButton = new System.Windows.Forms.Button();
			this._MergeAdjacentTitleBox = new System.Windows.Forms.CheckBox();
			this._Toolbar = new System.Windows.Forms.ToolStrip();
			this._SetPatternMenu = new System.Windows.Forms.ToolStripDropDownButton();
			this._RemoveButton = new System.Windows.Forms.ToolStripButton();
			this._KeepExistingBookmarksBox = new System.Windows.Forms.CheckBox();
			toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			((System.ComponentModel.ISupportInitialize)(this._BookmarkConditionBox)).BeginInit();
			this._Toolbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripDropDownButton1
			// 
			toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._LoadListButton,
            this._SaveListButton});
			toolStripDropDownButton1.Image = global::PDFPatcher.Properties.Resources.TextFile;
			toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			toolStripDropDownButton1.Size = new System.Drawing.Size(109, 22);
			toolStripDropDownButton1.Text = "识别条件列表";
			// 
			// _LoadListButton
			// 
			this._LoadListButton.Image = global::PDFPatcher.Properties.Resources.OpenFile;
			this._LoadListButton.Name = "_LoadListButton";
			this._LoadListButton.Size = new System.Drawing.Size(180, 22);
			this._LoadListButton.Text = "加载条件列表...";
			// 
			// _SaveListButton
			// 
			this._SaveListButton.Image = global::PDFPatcher.Properties.Resources.Save;
			this._SaveListButton.Name = "_SaveListButton";
			this._SaveListButton.Size = new System.Drawing.Size(180, 22);
			this._SaveListButton.Text = "保存条件列表...";
			// 
			// _BookmarkConditionBox
			// 
			this._BookmarkConditionBox.AllColumns.Add(this._ConditionColumn);
			this._BookmarkConditionBox.AllColumns.Add(this._LevelColumn);
			this._BookmarkConditionBox.AllColumns.Add(this._BoldColumn);
			this._BookmarkConditionBox.AllColumns.Add(this._ItalicColumn);
			this._BookmarkConditionBox.AllColumns.Add(this._ColorColumn);
			this._BookmarkConditionBox.AllColumns.Add(this._OpenColumn);
			this._BookmarkConditionBox.AllColumns.Add(this._GoToTopColumn);
			this._BookmarkConditionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._BookmarkConditionBox.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this._BookmarkConditionBox.CellEditUseWholeCell = false;
			this._BookmarkConditionBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._ConditionColumn,
            this._LevelColumn,
            this._BoldColumn,
            this._ItalicColumn,
            this._ColorColumn,
            this._OpenColumn,
            this._GoToTopColumn});
			this._BookmarkConditionBox.Cursor = System.Windows.Forms.Cursors.Default;
			this._BookmarkConditionBox.GridLines = true;
			this._BookmarkConditionBox.HideSelection = false;
			this._BookmarkConditionBox.Location = new System.Drawing.Point(14, 24);
			this._BookmarkConditionBox.Name = "_BookmarkConditionBox";
			this._BookmarkConditionBox.ShowGroups = false;
			this._BookmarkConditionBox.Size = new System.Drawing.Size(453, 143);
			this._BookmarkConditionBox.TabIndex = 1;
			this._BookmarkConditionBox.UseCompatibleStateImageBehavior = false;
			this._BookmarkConditionBox.View = System.Windows.Forms.View.Details;
			// 
			// _ConditionColumn
			// 
			this._ConditionColumn.IsEditable = false;
			this._ConditionColumn.Text = "识别条件";
			this._ConditionColumn.Width = 148;
			// 
			// _LevelColumn
			// 
			this._LevelColumn.Text = "书签级别";
			// 
			// _BoldColumn
			// 
			this._BoldColumn.CheckBoxes = true;
			this._BoldColumn.Text = "粗体";
			this._BoldColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this._BoldColumn.Width = 37;
			// 
			// _ItalicColumn
			// 
			this._ItalicColumn.CheckBoxes = true;
			this._ItalicColumn.Text = "斜体";
			this._ItalicColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this._ItalicColumn.Width = 37;
			// 
			// _ColorColumn
			// 
			this._ColorColumn.IsEditable = false;
			this._ColorColumn.Text = "颜色";
			// 
			// _OpenColumn
			// 
			this._OpenColumn.CheckBoxes = true;
			this._OpenColumn.Text = "展开";
			this._OpenColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this._OpenColumn.Width = 37;
			// 
			// _GoToTopColumn
			// 
			this._GoToTopColumn.CheckBoxes = true;
			this._GoToTopColumn.Text = "到页首";
			this._GoToTopColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this._GoToTopColumn.Width = 49;
			// 
			// _AutoBookmarkButton
			// 
			this._AutoBookmarkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._AutoBookmarkButton.Image = global::PDFPatcher.Properties.Resources.AutoBookmark;
			this._AutoBookmarkButton.Location = new System.Drawing.Point(367, 4);
			this._AutoBookmarkButton.Name = "_AutoBookmarkButton";
			this._AutoBookmarkButton.Size = new System.Drawing.Size(101, 23);
			this._AutoBookmarkButton.TabIndex = 4;
			this._AutoBookmarkButton.Text = "生成书签(&K)";
			this._AutoBookmarkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._AutoBookmarkButton.UseVisualStyleBackColor = true;
			this._AutoBookmarkButton.Click += new System.EventHandler(this._AutoBookmarkButton_Click);
			// 
			// _MergeAdjacentTitleBox
			// 
			this._MergeAdjacentTitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._MergeAdjacentTitleBox.AutoSize = true;
			this._MergeAdjacentTitleBox.Checked = true;
			this._MergeAdjacentTitleBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this._MergeAdjacentTitleBox.Location = new System.Drawing.Point(14, 171);
			this._MergeAdjacentTitleBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this._MergeAdjacentTitleBox.Name = "_MergeAdjacentTitleBox";
			this._MergeAdjacentTitleBox.Size = new System.Drawing.Size(168, 16);
			this._MergeAdjacentTitleBox.TabIndex = 5;
			this._MergeAdjacentTitleBox.Text = "合并同字体尺寸的相邻标题";
			this._MergeAdjacentTitleBox.UseVisualStyleBackColor = true;
			// 
			// _Toolbar
			// 
			this._Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripDropDownButton1,
            this._SetPatternMenu,
            this._RemoveButton});
			this._Toolbar.Location = new System.Drawing.Point(0, 0);
			this._Toolbar.Name = "_Toolbar";
			this._Toolbar.Size = new System.Drawing.Size(485, 25);
			this._Toolbar.TabIndex = 6;
			// 
			// _SetPatternMenu
			// 
			this._SetPatternMenu.Enabled = false;
			this._SetPatternMenu.Image = global::PDFPatcher.Properties.Resources.SelectItem;
			this._SetPatternMenu.Name = "_SetPatternMenu";
			this._SetPatternMenu.Size = new System.Drawing.Size(109, 22);
			this._SetPatternMenu.Text = "文本识别模式";
			// 
			// _RemoveButton
			// 
			this._RemoveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._RemoveButton.Enabled = false;
			this._RemoveButton.Image = global::PDFPatcher.Properties.Resources.Delete;
			this._RemoveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._RemoveButton.Name = "_RemoveButton";
			this._RemoveButton.Size = new System.Drawing.Size(23, 22);
			this._RemoveButton.Text = "删除";
			this._RemoveButton.Click += new System.EventHandler(this._RemoveButton_Click);
			// 
			// _KeepExistingBookmarksBox
			// 
			this._KeepExistingBookmarksBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._KeepExistingBookmarksBox.AutoSize = true;
			this._KeepExistingBookmarksBox.Location = new System.Drawing.Point(223, 171);
			this._KeepExistingBookmarksBox.Name = "_KeepExistingBookmarksBox";
			this._KeepExistingBookmarksBox.Size = new System.Drawing.Size(96, 16);
			this._KeepExistingBookmarksBox.TabIndex = 7;
			this._KeepExistingBookmarksBox.Text = "保留原有书签";
			this._KeepExistingBookmarksBox.UseVisualStyleBackColor = true;
			// 
			// AutoBookmarkForm
			// 
			this.AcceptButton = this._AutoBookmarkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 195);
			this.Controls.Add(this._KeepExistingBookmarksBox);
			this.Controls.Add(this._MergeAdjacentTitleBox);
			this.Controls.Add(this._AutoBookmarkButton);
			this.Controls.Add(this._BookmarkConditionBox);
			this.Controls.Add(this._Toolbar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AutoBookmarkForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "自动生成书签";
			((System.ComponentModel.ISupportInitialize)(this._BookmarkConditionBox)).EndInit();
			this._Toolbar.ResumeLayout(false);
			this._Toolbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private BrightIdeasSoftware.ObjectListView _BookmarkConditionBox;
		private BrightIdeasSoftware.OLVColumn _ConditionColumn;
		private System.Windows.Forms.Button _AutoBookmarkButton;
		private BrightIdeasSoftware.OLVColumn _LevelColumn;
		private BrightIdeasSoftware.OLVColumn _BoldColumn;
		private BrightIdeasSoftware.OLVColumn _ItalicColumn;
		private BrightIdeasSoftware.OLVColumn _ColorColumn;
		private BrightIdeasSoftware.OLVColumn _OpenColumn;
		private System.Windows.Forms.CheckBox _MergeAdjacentTitleBox;
		private BrightIdeasSoftware.OLVColumn _GoToTopColumn;
		private System.Windows.Forms.ToolStrip _Toolbar;
		private System.Windows.Forms.ToolStripMenuItem _LoadListButton;
		private System.Windows.Forms.ToolStripMenuItem _SaveListButton;
		private System.Windows.Forms.CheckBox _KeepExistingBookmarksBox;
		private System.Windows.Forms.ToolStripDropDownButton _SetPatternMenu;
		private System.Windows.Forms.ToolStripButton _RemoveButton;
	}
}
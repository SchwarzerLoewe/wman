namespace wman_Builder
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.packageContextMenu = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.newFuncContextItem = new Telerik.WinControls.UI.RadMenuItem();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.mainMenu = new Telerik.WinControls.UI.RadMenu();
            this.fileMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.newMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.openMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.saveMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.exportMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.fileSeperator = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.exitMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.mainDock = new Telerik.WinControls.UI.Docking.RadDock();
            this.packageWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.projectTreeView = new Telerik.WinControls.UI.RadTreeView();
            this.treeImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDock)).BeginInit();
            this.mainDock.SuspendLayout();
            this.packageWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTreeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // packageContextMenu
            // 
            this.packageContextMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.newFuncContextItem});
            this.packageContextMenu.ThemeName = "VisualStudio2012Light";
            // 
            // newFuncContextItem
            // 
            this.newFuncContextItem.AccessibleDescription = "New Function";
            this.newFuncContextItem.AccessibleName = "New Function";
            this.newFuncContextItem.Name = "newFuncContextItem";
            this.newFuncContextItem.Text = "New Function";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.fileMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(839, 20);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "radMenu1";
            this.mainMenu.ThemeName = "VisualStudio2012Light";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.AccessibleDescription = "File";
            this.fileMenuItem.AccessibleName = "File";
            this.fileMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.exportMenuItem,
            this.fileSeperator,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.AccessibleDescription = "radMenuItem1";
            this.newMenuItem.AccessibleName = "radMenuItem1";
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Text = "N&ew";
            // 
            // openMenuItem
            // 
            this.openMenuItem.AccessibleDescription = "radMenuItem2";
            this.openMenuItem.AccessibleName = "radMenuItem2";
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Text = "O&pen";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.AccessibleDescription = "radMenuItem3";
            this.saveMenuItem.AccessibleName = "radMenuItem3";
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Text = "S&ave";
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.AccessibleDescription = "radMenuItem4";
            this.exportMenuItem.AccessibleName = "radMenuItem4";
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.Text = "E&xport";
            // 
            // fileSeperator
            // 
            this.fileSeperator.AccessibleDescription = "radMenuSeparatorItem1";
            this.fileSeperator.AccessibleName = "radMenuSeparatorItem1";
            this.fileSeperator.Name = "fileSeperator";
            this.fileSeperator.Text = "radMenuSeparatorItem1";
            this.fileSeperator.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.AccessibleDescription = "radMenuItem5";
            this.exitMenuItem.AccessibleName = "radMenuItem5";
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Text = "Exit";
            // 
            // mainDock
            // 
            this.mainDock.ActiveWindow = this.packageWindow;
            this.mainDock.CausesValidation = false;
            this.mainDock.Controls.Add(this.toolTabStrip1);
            this.mainDock.Controls.Add(this.documentContainer1);
            this.mainDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDock.IsCleanUpTarget = true;
            this.mainDock.Location = new System.Drawing.Point(0, 20);
            this.mainDock.MainDocumentContainer = this.documentContainer1;
            this.mainDock.Name = "mainDock";
            this.mainDock.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.mainDock.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.mainDock.Size = new System.Drawing.Size(839, 384);
            this.mainDock.SplitterWidth = 2;
            this.mainDock.TabIndex = 1;
            this.mainDock.TabStop = false;
            this.mainDock.Text = "radDock1";
            this.mainDock.ThemeName = "VisualStudio2012Light";
            // 
            // packageWindow
            // 
            this.packageWindow.Caption = null;
            this.packageWindow.Controls.Add(this.projectTreeView);
            this.packageWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.packageWindow.Location = new System.Drawing.Point(4, 24);
            this.packageWindow.Name = "packageWindow";
            this.packageWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.packageWindow.Size = new System.Drawing.Size(185, 356);
            this.packageWindow.Text = "Package";
            // 
            // projectTreeView
            // 
            this.projectTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.projectTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.projectTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTreeView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.projectTreeView.ForeColor = System.Drawing.Color.Black;
            this.projectTreeView.Location = new System.Drawing.Point(0, 0);
            this.projectTreeView.Name = "projectTreeView";
            radTreeNode1.ContextMenu = this.packageContextMenu;
            radTreeNode1.Name = "packageNode";
            radTreeNode1.Text = "Package";
            this.projectTreeView.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1});
            this.projectTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectTreeView.ShowRootLines = false;
            this.projectTreeView.Size = new System.Drawing.Size(185, 356);
            this.projectTreeView.SmallImageList = this.treeImageList;
            this.projectTreeView.TabIndex = 0;
            this.projectTreeView.ThemeName = "VisualStudio2012Light";
            // 
            // treeImageList
            // 
            this.treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImageList.ImageStream")));
            this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImageList.Images.SetKeyName(0, "document.ico");
            this.treeImageList.Images.SetKeyName(1, "function.ico");
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.CausesValidation = false;
            this.toolTabStrip1.Controls.Add(this.packageWindow);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(193, 384);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(193, 200);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-7, 0);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "VisualStudio2012Light";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(626, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(7, 0);
            this.documentContainer1.SplitterWidth = 2;
            this.documentContainer1.TabIndex = 2;
            this.documentContainer1.ThemeName = "VisualStudio2012Light";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.Controls.Add(this.documentWindow);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(644, 384);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "VisualStudio2012Light";
            // 
            // documentWindow
            // 
            this.documentWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.documentWindow.Location = new System.Drawing.Point(4, 29);
            this.documentWindow.Name = "documentWindow";
            this.documentWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow.Size = new System.Drawing.Size(636, 351);
            this.documentWindow.Text = "Document";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "wman file (*.wman)|*.wman";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 404);
            this.Controls.Add(this.mainDock);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wman Builder";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.mainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDock)).EndInit();
            this.mainDock.ResumeLayout(false);
            this.packageWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectTreeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadMenu mainMenu;
        private Telerik.WinControls.UI.Docking.RadDock mainDock;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.RadMenuItem fileMenuItem;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow packageWindow;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.RadTreeView projectTreeView;
        private System.Windows.Forms.ImageList treeImageList;
        private Telerik.WinControls.UI.RadMenuItem newMenuItem;
        private Telerik.WinControls.UI.RadMenuItem openMenuItem;
        private Telerik.WinControls.UI.RadMenuItem saveMenuItem;
        private Telerik.WinControls.UI.RadMenuItem exportMenuItem;
        private Telerik.WinControls.UI.RadMenuSeparatorItem fileSeperator;
        private Telerik.WinControls.UI.RadMenuItem exitMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadContextMenu packageContextMenu;
        private Telerik.WinControls.UI.RadMenuItem newFuncContextItem;
    }
}


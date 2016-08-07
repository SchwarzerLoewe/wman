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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.mainMenu = new Telerik.WinControls.UI.RadMenu();
            this.fileMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.mainDock = new Telerik.WinControls.UI.Docking.RadDock();
            this.packageWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.projectTreeView = new Telerik.WinControls.UI.RadTreeView();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.treeImageList = new System.Windows.Forms.ImageList(this.components);
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
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Text = "File";
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
            this.projectTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTreeView.Location = new System.Drawing.Point(0, 0);
            this.projectTreeView.Name = "projectTreeView";
            this.projectTreeView.Size = new System.Drawing.Size(185, 356);
            this.projectTreeView.SmallImageList = this.treeImageList;
            this.projectTreeView.TabIndex = 0;
            this.projectTreeView.ThemeName = "VisualStudio2012Light";
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
            // treeImageList
            // 
            this.treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImageList.ImageStream")));
            this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImageList.Images.SetKeyName(0, "document.ico");
            this.treeImageList.Images.SetKeyName(1, "function.ico");
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
    }
}


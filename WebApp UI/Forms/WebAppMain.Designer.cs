namespace IMS.WebApp.UI.Forms
{
	partial class WebAppMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebAppMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileNewTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileNewBatchTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileRecentTests = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileRecentBatchTests = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTestRun = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTestPause = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTestStop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTestSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MenuTestStopAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuToolSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuHelpHowDoI = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpKeywords = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuHelpUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.tbNewTest = new System.Windows.Forms.ToolStripButton();
            this.tbNewBatchTest = new System.Windows.Forms.ToolStripButton();
            this.ToolbarSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbOpenDocument = new System.Windows.Forms.ToolStripButton();
            this.ToolbarSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSaveDocument = new System.Windows.Forms.ToolStripButton();
            this.tbSaveDocumentAs = new System.Windows.Forms.ToolStripButton();
            this.tbSaveAllDocuments = new System.Windows.Forms.ToolStripButton();
            this.ToolbarSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbRun = new System.Windows.Forms.ToolStripButton();
            this.tbStop = new System.Windows.Forms.ToolStripButton();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.DocumentArea = new System.Windows.Forms.TabControl();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.MainMenu.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuView,
            this.MenuTest,
            this.MenuTools,
            this.MenuHelp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(882, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Web App Main Menu";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileNew,
            this.MenuFileOpen,
            this.FileMenuSeparator1,
            this.MenuFileSave,
            this.MenuFileSaveAs,
            this.MenuFileSaveAll,
            this.FileMenuSeparator2,
            this.MenuFileClose,
            this.MenuFileCloseAll,
            this.FileMenuSeparator3,
            this.MenuFileRecentTests,
            this.MenuFileRecentBatchTests,
            this.FileMenuSeparator4,
            this.MenuFileExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "&File";
            // 
            // MenuFileNew
            // 
            this.MenuFileNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileNewTest,
            this.MenuFileNewBatchTest});
            this.MenuFileNew.Name = "MenuFileNew";
            this.MenuFileNew.Size = new System.Drawing.Size(195, 22);
            this.MenuFileNew.Text = "&New";
            // 
            // MenuFileNewTest
            // 
            this.MenuFileNewTest.Image = global::IMS.WebApp.UI.Properties.Resources.NewTest;
            this.MenuFileNewTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFileNewTest.Name = "MenuFileNewTest";
            this.MenuFileNewTest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuFileNewTest.Size = new System.Drawing.Size(225, 22);
            this.MenuFileNewTest.Text = "New Test";
            this.MenuFileNewTest.Click += new System.EventHandler(this.MenuFileNewTestClick);
            // 
            // MenuFileNewBatchTest
            // 
            this.MenuFileNewBatchTest.Image = global::IMS.WebApp.UI.Properties.Resources.NewBatch;
            this.MenuFileNewBatchTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFileNewBatchTest.Name = "MenuFileNewBatchTest";
            this.MenuFileNewBatchTest.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.MenuFileNewBatchTest.Size = new System.Drawing.Size(225, 22);
            this.MenuFileNewBatchTest.Text = "New Batch Test";
            this.MenuFileNewBatchTest.Click += new System.EventHandler(this.MenuFileNewBatchTestClick);
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Image = global::IMS.WebApp.UI.Properties.Resources.Open;
            this.MenuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuFileOpen.Size = new System.Drawing.Size(195, 22);
            this.MenuFileOpen.Text = "&Open...";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpenClick);
            // 
            // FileMenuSeparator1
            // 
            this.FileMenuSeparator1.Name = "FileMenuSeparator1";
            this.FileMenuSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // MenuFileSave
            // 
            this.MenuFileSave.Image = global::IMS.WebApp.UI.Properties.Resources.Save;
            this.MenuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFileSave.Name = "MenuFileSave";
            this.MenuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuFileSave.Size = new System.Drawing.Size(195, 22);
            this.MenuFileSave.Text = "&Save";
            this.MenuFileSave.Click += new System.EventHandler(this.MenuFileSaveClick);
            // 
            // MenuFileSaveAs
            // 
            this.MenuFileSaveAs.Image = global::IMS.WebApp.UI.Properties.Resources.SaveAs;
            this.MenuFileSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFileSaveAs.Name = "MenuFileSaveAs";
            this.MenuFileSaveAs.Size = new System.Drawing.Size(195, 22);
            this.MenuFileSaveAs.Text = "Save As...";
            this.MenuFileSaveAs.Click += new System.EventHandler(this.MenuFileSaveAsClick);
            // 
            // MenuFileSaveAll
            // 
            this.MenuFileSaveAll.Image = global::IMS.WebApp.UI.Properties.Resources.SaveAll;
            this.MenuFileSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFileSaveAll.Name = "MenuFileSaveAll";
            this.MenuFileSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuFileSaveAll.Size = new System.Drawing.Size(195, 22);
            this.MenuFileSaveAll.Text = "Save All";
            this.MenuFileSaveAll.Click += new System.EventHandler(this.MenuFileSaveAllClick);
            // 
            // FileMenuSeparator2
            // 
            this.FileMenuSeparator2.Name = "FileMenuSeparator2";
            this.FileMenuSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // MenuFileClose
            // 
            this.MenuFileClose.Name = "MenuFileClose";
            this.MenuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.MenuFileClose.Size = new System.Drawing.Size(195, 22);
            this.MenuFileClose.Text = "&Close";
            this.MenuFileClose.Click += new System.EventHandler(this.MenuFileCloseClick);
            // 
            // MenuFileCloseAll
            // 
            this.MenuFileCloseAll.Name = "MenuFileCloseAll";
            this.MenuFileCloseAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F4)));
            this.MenuFileCloseAll.Size = new System.Drawing.Size(195, 22);
            this.MenuFileCloseAll.Text = "Close All";
            this.MenuFileCloseAll.Click += new System.EventHandler(this.MenuFileCloseAllClick);
            // 
            // FileMenuSeparator3
            // 
            this.FileMenuSeparator3.Name = "FileMenuSeparator3";
            this.FileMenuSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // MenuFileRecentTests
            // 
            this.MenuFileRecentTests.Name = "MenuFileRecentTests";
            this.MenuFileRecentTests.Size = new System.Drawing.Size(195, 22);
            this.MenuFileRecentTests.Text = "Recent Tests";
            // 
            // MenuFileRecentBatchTests
            // 
            this.MenuFileRecentBatchTests.Name = "MenuFileRecentBatchTests";
            this.MenuFileRecentBatchTests.Size = new System.Drawing.Size(195, 22);
            this.MenuFileRecentBatchTests.Text = "Recent Batch Tests";
            // 
            // FileMenuSeparator4
            // 
            this.FileMenuSeparator4.Name = "FileMenuSeparator4";
            this.FileMenuSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.Size = new System.Drawing.Size(195, 22);
            this.MenuFileExit.Text = "E&xit";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExitClick);
            // 
            // MenuView
            // 
            this.MenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuViewStatusBar});
            this.MenuView.Name = "MenuView";
            this.MenuView.Size = new System.Drawing.Size(44, 20);
            this.MenuView.Text = "&View";
            // 
            // MenuViewStatusBar
            // 
            this.MenuViewStatusBar.Checked = true;
            this.MenuViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuViewStatusBar.Name = "MenuViewStatusBar";
            this.MenuViewStatusBar.Size = new System.Drawing.Size(126, 22);
            this.MenuViewStatusBar.Text = "Status Bar";
            this.MenuViewStatusBar.Click += new System.EventHandler(this.MenuViewClick);
            // 
            // MenuTest
            // 
            this.MenuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTestRun,
            this.MenuTestPause,
            this.MenuTestStop,
            this.MenuTestSeparator,
            this.MenuTestStopAll});
            this.MenuTest.Name = "MenuTest";
            this.MenuTest.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuTest.Size = new System.Drawing.Size(39, 20);
            this.MenuTest.Text = "Te&st";
            // 
            // MenuTestRun
            // 
            this.MenuTestRun.Image = global::IMS.WebApp.UI.Properties.Resources.Run;
            this.MenuTestRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuTestRun.Name = "MenuTestRun";
            this.MenuTestRun.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuTestRun.Size = new System.Drawing.Size(117, 22);
            this.MenuTestRun.Text = "Run";
            this.MenuTestRun.Click += new System.EventHandler(this.MenuTestRunClick);
            // 
            // MenuTestPause
            // 
            this.MenuTestPause.Name = "MenuTestPause";
            this.MenuTestPause.Size = new System.Drawing.Size(117, 22);
            this.MenuTestPause.Text = "Pause";
            this.MenuTestPause.Visible = false;
            this.MenuTestPause.Click += new System.EventHandler(this.MenuTestPause_Click);
            // 
            // MenuTestStop
            // 
            this.MenuTestStop.Image = global::IMS.WebApp.UI.Properties.Resources.Stop;
            this.MenuTestStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuTestStop.Name = "MenuTestStop";
            this.MenuTestStop.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.MenuTestStop.Size = new System.Drawing.Size(117, 22);
            this.MenuTestStop.Text = "Stop";
            this.MenuTestStop.Click += new System.EventHandler(this.MenuTestStopClick);
            // 
            // MenuTestSeparator
            // 
            this.MenuTestSeparator.Name = "MenuTestSeparator";
            this.MenuTestSeparator.Size = new System.Drawing.Size(114, 6);
            // 
            // MenuTestStopAll
            // 
            this.MenuTestStopAll.Name = "MenuTestStopAll";
            this.MenuTestStopAll.Size = new System.Drawing.Size(117, 22);
            this.MenuTestStopAll.Text = "Stop All";
            this.MenuTestStopAll.Click += new System.EventHandler(this.MenuTestStopAllClick);
            // 
            // MenuTools
            // 
            this.MenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolSettings});
            this.MenuTools.Name = "MenuTools";
            this.MenuTools.Size = new System.Drawing.Size(46, 20);
            this.MenuTools.Text = "&Tools";
            // 
            // MenuToolSettings
            // 
            this.MenuToolSettings.Name = "MenuToolSettings";
            this.MenuToolSettings.Size = new System.Drawing.Size(125, 22);
            this.MenuToolSettings.Text = "&Settings...";
            this.MenuToolSettings.Click += new System.EventHandler(this.MenuToolSettingsClick);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpIndex,
            this.MenuHelpSeparator1,
            this.MenuHelpHowDoI,
            this.MenuHelpKeywords,
            this.MenuHelpSeparator2,
            this.MenuHelpUpdate,
            this.MenuHelpSeparator3,
            this.MenuHelpAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MenuHelp.Size = new System.Drawing.Size(43, 20);
            this.MenuHelp.Text = "&Help";
            // 
            // MenuHelpIndex
            // 
            this.MenuHelpIndex.Name = "MenuHelpIndex";
            this.MenuHelpIndex.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MenuHelpIndex.Size = new System.Drawing.Size(213, 22);
            this.MenuHelpIndex.Text = "WebApp Test Tool Help";
            this.MenuHelpIndex.Click += new System.EventHandler(this.MenuHelpWebAppTestToolHelpClick);
            // 
            // MenuHelpSeparator1
            // 
            this.MenuHelpSeparator1.Name = "MenuHelpSeparator1";
            this.MenuHelpSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // MenuHelpHowDoI
            // 
            this.MenuHelpHowDoI.Name = "MenuHelpHowDoI";
            this.MenuHelpHowDoI.Size = new System.Drawing.Size(213, 22);
            this.MenuHelpHowDoI.Text = "How Do I";
            this.MenuHelpHowDoI.Click += new System.EventHandler(this.MenuHelpHowDoIClick);
            // 
            // MenuHelpKeywords
            // 
            this.MenuHelpKeywords.Name = "MenuHelpKeywords";
            this.MenuHelpKeywords.Size = new System.Drawing.Size(213, 22);
            this.MenuHelpKeywords.Text = "Keywords";
            this.MenuHelpKeywords.Click += new System.EventHandler(this.MenuHelpKeywordsClick);
            // 
            // MenuHelpSeparator2
            // 
            this.MenuHelpSeparator2.Name = "MenuHelpSeparator2";
            this.MenuHelpSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // MenuHelpUpdate
            // 
            this.MenuHelpUpdate.Name = "MenuHelpUpdate";
            this.MenuHelpUpdate.Size = new System.Drawing.Size(213, 22);
            this.MenuHelpUpdate.Text = "Update...";
            this.MenuHelpUpdate.Click += new System.EventHandler(this.MenuHelpUpdateClick);
            // 
            // MenuHelpSeparator3
            // 
            this.MenuHelpSeparator3.Name = "MenuHelpSeparator3";
            this.MenuHelpSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // MenuHelpAbout
            // 
            this.MenuHelpAbout.Name = "MenuHelpAbout";
            this.MenuHelpAbout.Size = new System.Drawing.Size(213, 22);
            this.MenuHelpAbout.Text = "&About...";
            this.MenuHelpAbout.Click += new System.EventHandler(this.MenuHelpAboutClick);
            // 
            // Toolbar
            // 
            this.Toolbar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNewTest,
            this.tbNewBatchTest,
            this.ToolbarSeparator1,
            this.tbOpenDocument,
            this.ToolbarSeparator2,
            this.tbSaveDocument,
            this.tbSaveDocumentAs,
            this.tbSaveAllDocuments,
            this.ToolbarSeparator3,
            this.tbRun,
            this.tbStop});
            this.Toolbar.Location = new System.Drawing.Point(0, 24);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(882, 25);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.Text = "toolStrip1";
            // 
            // tbNewTest
            // 
            this.tbNewTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNewTest.Image = global::IMS.WebApp.UI.Properties.Resources.NewTest;
            this.tbNewTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNewTest.Name = "tbNewTest";
            this.tbNewTest.Size = new System.Drawing.Size(23, 22);
            this.tbNewTest.Text = "New Test";
            this.tbNewTest.Click += new System.EventHandler(this.ToolNewTestClick);
            // 
            // tbNewBatchTest
            // 
            this.tbNewBatchTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNewBatchTest.Image = global::IMS.WebApp.UI.Properties.Resources.NewBatch;
            this.tbNewBatchTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNewBatchTest.Name = "tbNewBatchTest";
            this.tbNewBatchTest.Size = new System.Drawing.Size(23, 22);
            this.tbNewBatchTest.Text = "New Batch Test";
            this.tbNewBatchTest.Click += new System.EventHandler(this.ToolNewBatchTestClick);
            // 
            // ToolbarSeparator1
            // 
            this.ToolbarSeparator1.Name = "ToolbarSeparator1";
            this.ToolbarSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbOpenDocument
            // 
            this.tbOpenDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpenDocument.Image = global::IMS.WebApp.UI.Properties.Resources.Open;
            this.tbOpenDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpenDocument.Name = "tbOpenDocument";
            this.tbOpenDocument.Size = new System.Drawing.Size(23, 22);
            this.tbOpenDocument.Text = "Open";
            this.tbOpenDocument.Click += new System.EventHandler(this.ToolOpenDocumentClick);
            // 
            // ToolbarSeparator2
            // 
            this.ToolbarSeparator2.Name = "ToolbarSeparator2";
            this.ToolbarSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSaveDocument
            // 
            this.tbSaveDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSaveDocument.Image = global::IMS.WebApp.UI.Properties.Resources.Save;
            this.tbSaveDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSaveDocument.Name = "tbSaveDocument";
            this.tbSaveDocument.Size = new System.Drawing.Size(23, 22);
            this.tbSaveDocument.Text = "Save";
            this.tbSaveDocument.Click += new System.EventHandler(this.ToolSaveDocumentClick);
            // 
            // tbSaveDocumentAs
            // 
            this.tbSaveDocumentAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSaveDocumentAs.Image = global::IMS.WebApp.UI.Properties.Resources.SaveAs;
            this.tbSaveDocumentAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSaveDocumentAs.Name = "tbSaveDocumentAs";
            this.tbSaveDocumentAs.Size = new System.Drawing.Size(23, 22);
            this.tbSaveDocumentAs.Text = "Save As";
            // 
            // tbSaveAllDocuments
            // 
            this.tbSaveAllDocuments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSaveAllDocuments.Image = global::IMS.WebApp.UI.Properties.Resources.SaveAll;
            this.tbSaveAllDocuments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSaveAllDocuments.Name = "tbSaveAllDocuments";
            this.tbSaveAllDocuments.Size = new System.Drawing.Size(23, 22);
            this.tbSaveAllDocuments.Text = "Save All";
            this.tbSaveAllDocuments.Click += new System.EventHandler(this.ToolSaveAllDocumentsClick);
            // 
            // ToolbarSeparator3
            // 
            this.ToolbarSeparator3.Name = "ToolbarSeparator3";
            this.ToolbarSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbRun
            // 
            this.tbRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRun.Image = global::IMS.WebApp.UI.Properties.Resources.Run;
            this.tbRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRun.Name = "tbRun";
            this.tbRun.Size = new System.Drawing.Size(23, 22);
            this.tbRun.Text = "Run";
            this.tbRun.Click += new System.EventHandler(this.ToolRunClick);
            // 
            // tbStop
            // 
            this.tbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbStop.Image = global::IMS.WebApp.UI.Properties.Resources.Stop;
            this.tbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(23, 22);
            this.tbStop.Text = "Stop";
            this.tbStop.Click += new System.EventHandler(this.ToolStopClick);
            // 
            // StatusBar
            // 
            this.StatusBar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.StatusBar.Location = new System.Drawing.Point(0, 539);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusBar.Size = new System.Drawing.Size(882, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // DocumentArea
            // 
            this.DocumentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentArea.Location = new System.Drawing.Point(0, 0);
            this.DocumentArea.Name = "DocumentArea";
            this.DocumentArea.SelectedIndex = 0;
            this.DocumentArea.Size = new System.Drawing.Size(882, 539);
            this.DocumentArea.TabIndex = 2;
            this.DocumentArea.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.DocumentArea_Selecting);
            this.DocumentArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DocumentAreaMouseClick);
            // 
            // OpenFile
            // 
            this.OpenFile.DefaultExt = "imstest";
            this.OpenFile.Filter = "WebApp Test file (*.imstest)|*.imstest|WebApp Batch Test (*.imsbatch)|*.imsbatch|" +
    "All files (*.*)|*.*";
            this.OpenFile.Title = "Open Document";
            // 
            // SaveFile
            // 
            this.SaveFile.DefaultExt = "imstest";
            this.SaveFile.Filter = "WebApp Test file (*.imstest)|*.imstest|WebApp Batch Test (*.imsbatch)|*.imsbatch|" +
    "All files (*.*)|*.*";
            this.SaveFile.Title = "Save Document";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DocumentArea);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.StatusBar);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(882, 561);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 49);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(882, 561);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // WebAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 610);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "WebAppMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web App Test Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebAppMainFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebAppMainFormClosed);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStrip Toolbar;
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.ToolStripMenuItem MenuFile;
		private System.Windows.Forms.ToolStripMenuItem MenuFileNew;
		private System.Windows.Forms.ToolStripMenuItem MenuFileNewTest;
		private System.Windows.Forms.TabControl DocumentArea;
		private System.Windows.Forms.ToolStripMenuItem MenuFileNewBatchTest;
		private System.Windows.Forms.OpenFileDialog OpenFile;
		private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
		private System.Windows.Forms.ToolStripSeparator FileMenuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MenuFileSave;
		private System.Windows.Forms.ToolStripMenuItem MenuFileSaveAs;
		private System.Windows.Forms.ToolStripMenuItem MenuFileSaveAll;
		private System.Windows.Forms.ToolStripSeparator FileMenuSeparator2;
		private System.Windows.Forms.ToolStripMenuItem MenuFileClose;
		private System.Windows.Forms.ToolStripMenuItem MenuFileCloseAll;
		private System.Windows.Forms.ToolStripSeparator FileMenuSeparator3;
		private System.Windows.Forms.ToolStripMenuItem MenuFileRecentTests;
		private System.Windows.Forms.ToolStripMenuItem MenuFileRecentBatchTests;
		private System.Windows.Forms.ToolStripSeparator FileMenuSeparator4;
		private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
		private System.Windows.Forms.ToolStripMenuItem MenuTest;
		private System.Windows.Forms.ToolStripMenuItem MenuTools;
		private System.Windows.Forms.ToolStripMenuItem MenuHelp;
		private System.Windows.Forms.ToolStripMenuItem MenuToolSettings;
		private System.Windows.Forms.ToolStripMenuItem MenuHelpIndex;
		private System.Windows.Forms.ToolStripSeparator MenuHelpSeparator1;
		private System.Windows.Forms.ToolStripButton tbNewTest;
		private System.Windows.Forms.ToolStripButton tbNewBatchTest;
		private System.Windows.Forms.ToolStripSeparator ToolbarSeparator1;
		private System.Windows.Forms.ToolStripButton tbOpenDocument;
		private System.Windows.Forms.ToolStripSeparator ToolbarSeparator2;
		private System.Windows.Forms.ToolStripButton tbSaveDocument;
		private System.Windows.Forms.ToolStripButton tbSaveAllDocuments;
		private System.Windows.Forms.ToolStripMenuItem MenuHelpHowDoI;
		private System.Windows.Forms.ToolStripMenuItem MenuHelpKeywords;
		private System.Windows.Forms.ToolStripSeparator MenuHelpSeparator2;
		private System.Windows.Forms.ToolStripMenuItem MenuHelpUpdate;
		private System.Windows.Forms.ToolStripSeparator MenuHelpSeparator3;
		private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;
		private System.Windows.Forms.ToolStripMenuItem MenuTestRun;
		private System.Windows.Forms.ToolStripMenuItem MenuTestStop;
		private System.Windows.Forms.ToolStripSeparator ToolbarSeparator3;
		private System.Windows.Forms.ToolStripButton tbRun;
		private System.Windows.Forms.ToolStripButton tbStop;
		private System.Windows.Forms.ToolStripMenuItem MenuTestPause;
		private System.Windows.Forms.ToolStripSeparator MenuTestSeparator;
		private System.Windows.Forms.ToolStripMenuItem MenuTestStopAll;
		private System.Windows.Forms.SaveFileDialog SaveFile;
		private System.Windows.Forms.ToolStripButton tbSaveDocumentAs;
		private System.Windows.Forms.ToolStripMenuItem MenuView;
		private System.Windows.Forms.ToolStripMenuItem MenuViewStatusBar;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
	}
}
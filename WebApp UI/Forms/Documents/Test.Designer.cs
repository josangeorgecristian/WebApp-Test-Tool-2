namespace IMS.WebApp.UI.Forms.Documents
{
	partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.MainArea = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.grpTestDetails = new System.Windows.Forms.GroupBox();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTestDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigurationPage = new System.Windows.Forms.TabPage();
            this.ConfigurationArea = new System.Windows.Forms.TabControl();
            this.ServerOptionsPage = new System.Windows.Forms.TabPage();
            this.grpLoginOptions = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpServerAddress = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RuntimePage = new System.Windows.Forms.TabPage();
            this.grpExecutionFlow = new System.Windows.Forms.GroupBox();
            this.panelErrorRadioButtons = new System.Windows.Forms.Panel();
            this.rOnErrorContinue = new System.Windows.Forms.RadioButton();
            this.rOnErrorsStopAll = new System.Windows.Forms.RadioButton();
            this.rOnErrorStopCurrent = new System.Windows.Forms.RadioButton();
            this.panelWarningRadioButtons = new System.Windows.Forms.Panel();
            this.rOnWarningContinue = new System.Windows.Forms.RadioButton();
            this.rOnWarningStopCurrent = new System.Windows.Forms.RadioButton();
            this.rOnWarningStopAll = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.chkClearExecutionLog = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grpExecutionTiming = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nStepDelay = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.nExecutionDelay = new System.Windows.Forms.NumericUpDown();
            this.grpExecutionSettings = new System.Windows.Forms.GroupBox();
            this.labelThreads = new System.Windows.Forms.Label();
            this.nNumberOfThreads = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfThreads = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nCounterStart = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nNumberOfExecutions = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.DataSourcePage = new System.Windows.Forms.TabPage();
            this.grpDataSourceSettings = new System.Windows.Forms.GroupBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.ButtonImages = new System.Windows.Forms.ImageList(this.components);
            this.labelDataFileType = new System.Windows.Forms.Label();
            this.txtDataSourceFilePath = new System.Windows.Forms.TextBox();
            this.rXMLFile = new System.Windows.Forms.RadioButton();
            this.labelDataFileName = new System.Windows.Forms.Label();
            this.rExcelFile = new System.Windows.Forms.RadioButton();
            this.chkUseDataFiles = new System.Windows.Forms.CheckBox();
            this.LoggingPage = new System.Windows.Forms.TabPage();
            this.grpLogOutputSettingsGroup = new System.Windows.Forms.GroupBox();
            this.chkCreateSepateLogs = new System.Windows.Forms.CheckBox();
            this.bSelectLogOutputFolder = new System.Windows.Forms.Button();
            this.txtLogOutputPath = new System.Windows.Forms.TextBox();
            this.chkEnableLogging = new System.Windows.Forms.CheckBox();
            this.labelLogOutputPath = new System.Windows.Forms.Label();
            this.EMailPage = new System.Windows.Forms.TabPage();
            this.grpEmailSettings = new System.Windows.Forms.GroupBox();
            this.txtEMailDisplayName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkSendFromConsoleOnly = new System.Windows.Forms.CheckBox();
            this.chkSendOnFailureOnly = new System.Windows.Forms.CheckBox();
            this.txtEMailAddress = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TabImages = new System.Windows.Forms.ImageList(this.components);
            this.TestUnitsPage = new System.Windows.Forms.TabPage();
            this.TestUnitsList = new System.Windows.Forms.ListView();
            this.colStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpectedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCurrentForm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTestUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TestUnitsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TestUnitContextMenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.TestUnitContextMenuSeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this.TestUnitContextMenuLoadFromText = new System.Windows.Forms.ToolStripMenuItem();
            this.TestUnitContextMenuInsertFromText = new System.Windows.Forms.ToolStripMenuItem();
            this.TestUnitContextMenuExportToText = new System.Windows.Forms.ToolStripMenuItem();
            this.TestUnitContextMenuSeparatorTwo = new System.Windows.Forms.ToolStripSeparator();
            this.TestUnitContextMenuAddTestUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.TestUnitContextMenuEditTestUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.TestUnitContextMenuInsertTestUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.TestUnitContextMenuRemoveTestUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.TestUnitContextMenuSeparatorThree = new System.Windows.Forms.ToolStripSeparator();
            this.TestUnitContextMenuRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.TestUnitsListImages = new System.Windows.Forms.ImageList(this.components);
            this.TestUnitsToolbar = new System.Windows.Forms.ToolStrip();
            this.TestUnitsToolLoad = new System.Windows.Forms.ToolStripButton();
            this.TestUnitsToolSeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this.TestUnitsToolLoadFromText = new System.Windows.Forms.ToolStripButton();
            this.TestUnitsToolInsertFromText = new System.Windows.Forms.ToolStripButton();
            this.TestUnitsToolExportToText = new System.Windows.Forms.ToolStripButton();
            this.TestUnitsToolSeparatorTwo = new System.Windows.Forms.ToolStripSeparator();
            this.TestUnitsToolAddTestUnit = new System.Windows.Forms.ToolStripButton();
            this.TestUnitsToolEditTestUnit = new System.Windows.Forms.ToolStripButton();
            this.TestUnitsToolInsertTestUnit = new System.Windows.Forms.ToolStripButton();
            this.TestUnitsToolRemoveTestUnits = new System.Windows.Forms.ToolStripButton();
            this.TestUnitsToolSeparatorThree = new System.Windows.Forms.ToolStripSeparator();
            this.TestUnitsToolRemoveAll = new System.Windows.Forms.ToolStripButton();
            this.TestUnitsStatusBar = new System.Windows.Forms.StatusStrip();
            this.lblTestUnitsDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.TestUnitsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExecutionPage = new System.Windows.Forms.TabPage();
            this.pnlExecutionArea = new System.Windows.Forms.Panel();
            this.ExecutionArea = new System.Windows.Forms.TabControl();
            this.ExecutionLogsPage = new System.Windows.Forms.TabPage();
            this.ExecutionLogs = new System.Windows.Forms.TabControl();
            this.ExecutionStatisticsPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEndInfo = new System.Windows.Forms.GroupBox();
            this.lblCompletionDateTime = new System.Windows.Forms.Label();
            this.grpEstimatesInfo = new System.Windows.Forms.GroupBox();
            this.lblEstimatedTimeToComplete = new System.Windows.Forms.Label();
            this.lblEstimatedCompletionDateTime = new System.Windows.Forms.Label();
            this.grpRunningInfo = new System.Windows.Forms.GroupBox();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.lblAverageTimeperExecution = new System.Windows.Forms.Label();
            this.lblAverageExecutionsperSecond = new System.Windows.Forms.Label();
            this.grpStartInfo = new System.Windows.Forms.GroupBox();
            this.lblStartDateTime = new System.Windows.Forms.Label();
            this.grpExecutionProgress = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblStepProgress = new System.Windows.Forms.Label();
            this.lblExecutionStatus = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadFromTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertFromTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addTestUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTestUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTestUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTestUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundExecution = new System.ComponentModel.BackgroundWorker();
            this.SelectFileDataSource = new System.Windows.Forms.OpenFileDialog();
            this.SelectFileLogOuputPath = new System.Windows.Forms.FolderBrowserDialog();
            this.LoadTestUnitsFile = new System.Windows.Forms.OpenFileDialog();
            this.MainArea.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.grpTestDetails.SuspendLayout();
            this.ConfigurationPage.SuspendLayout();
            this.ConfigurationArea.SuspendLayout();
            this.ServerOptionsPage.SuspendLayout();
            this.grpLoginOptions.SuspendLayout();
            this.grpServerAddress.SuspendLayout();
            this.RuntimePage.SuspendLayout();
            this.grpExecutionFlow.SuspendLayout();
            this.panelErrorRadioButtons.SuspendLayout();
            this.panelWarningRadioButtons.SuspendLayout();
            this.grpExecutionTiming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nStepDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nExecutionDelay)).BeginInit();
            this.grpExecutionSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCounterStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfExecutions)).BeginInit();
            this.DataSourcePage.SuspendLayout();
            this.grpDataSourceSettings.SuspendLayout();
            this.LoggingPage.SuspendLayout();
            this.grpLogOutputSettingsGroup.SuspendLayout();
            this.EMailPage.SuspendLayout();
            this.grpEmailSettings.SuspendLayout();
            this.TestUnitsPage.SuspendLayout();
            this.TestUnitsContextMenu.SuspendLayout();
            this.TestUnitsToolbar.SuspendLayout();
            this.TestUnitsStatusBar.SuspendLayout();
            this.ExecutionPage.SuspendLayout();
            this.pnlExecutionArea.SuspendLayout();
            this.ExecutionArea.SuspendLayout();
            this.ExecutionLogsPage.SuspendLayout();
            this.ExecutionStatisticsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEndInfo.SuspendLayout();
            this.grpEstimatesInfo.SuspendLayout();
            this.grpRunningInfo.SuspendLayout();
            this.grpStartInfo.SuspendLayout();
            this.grpExecutionProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainArea
            // 
            this.MainArea.Controls.Add(this.GeneralPage);
            this.MainArea.Controls.Add(this.ConfigurationPage);
            this.MainArea.Controls.Add(this.TestUnitsPage);
            this.MainArea.Controls.Add(this.ExecutionPage);
            this.MainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainArea.ImageList = this.TabImages;
            this.MainArea.Location = new System.Drawing.Point(0, 0);
            this.MainArea.Name = "MainArea";
            this.MainArea.SelectedIndex = 1;
            this.MainArea.Size = new System.Drawing.Size(772, 506);
            this.MainArea.TabIndex = 0;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPage.Controls.Add(this.grpTestDetails);
            this.GeneralPage.ImageIndex = 0;
            this.GeneralPage.Location = new System.Drawing.Point(4, 23);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Size = new System.Drawing.Size(764, 479);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "General";
            // 
            // grpTestDetails
            // 
            this.grpTestDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTestDetails.Controls.Add(this.txtTestName);
            this.grpTestDetails.Controls.Add(this.label2);
            this.grpTestDetails.Controls.Add(this.txtTestDescription);
            this.grpTestDetails.Controls.Add(this.label1);
            this.grpTestDetails.Location = new System.Drawing.Point(11, 3);
            this.grpTestDetails.Name = "grpTestDetails";
            this.grpTestDetails.Size = new System.Drawing.Size(742, 465);
            this.grpTestDetails.TabIndex = 0;
            this.grpTestDetails.TabStop = false;
            this.grpTestDetails.Text = "Test Details";
            // 
            // txtTestName
            // 
            this.txtTestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestName.Location = new System.Drawing.Point(90, 20);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(646, 20);
            this.txtTestName.TabIndex = 1;
            this.txtTestName.TextChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTestDescription
            // 
            this.txtTestDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestDescription.Location = new System.Drawing.Point(90, 47);
            this.txtTestDescription.Multiline = true;
            this.txtTestDescription.Name = "txtTestDescription";
            this.txtTestDescription.Size = new System.Drawing.Size(646, 412);
            this.txtTestDescription.TabIndex = 3;
            this.txtTestDescription.TextChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfigurationPage
            // 
            this.ConfigurationPage.Controls.Add(this.ConfigurationArea);
            this.ConfigurationPage.ImageIndex = 1;
            this.ConfigurationPage.Location = new System.Drawing.Point(4, 22);
            this.ConfigurationPage.Name = "ConfigurationPage";
            this.ConfigurationPage.Size = new System.Drawing.Size(192, 74);
            this.ConfigurationPage.TabIndex = 5;
            this.ConfigurationPage.Text = "Configuration";
            // 
            // ConfigurationArea
            // 
            this.ConfigurationArea.Controls.Add(this.ServerOptionsPage);
            this.ConfigurationArea.Controls.Add(this.RuntimePage);
            this.ConfigurationArea.Controls.Add(this.DataSourcePage);
            this.ConfigurationArea.Controls.Add(this.LoggingPage);
            this.ConfigurationArea.Controls.Add(this.EMailPage);
            this.ConfigurationArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationArea.ImageList = this.TabImages;
            this.ConfigurationArea.Location = new System.Drawing.Point(0, 0);
            this.ConfigurationArea.Name = "ConfigurationArea";
            this.ConfigurationArea.SelectedIndex = 4;
            this.ConfigurationArea.Size = new System.Drawing.Size(192, 74);
            this.ConfigurationArea.TabIndex = 0;
            // 
            // ServerOptionsPage
            // 
            this.ServerOptionsPage.Controls.Add(this.grpLoginOptions);
            this.ServerOptionsPage.Controls.Add(this.grpServerAddress);
            this.ServerOptionsPage.ImageIndex = 4;
            this.ServerOptionsPage.Location = new System.Drawing.Point(4, 23);
            this.ServerOptionsPage.Name = "ServerOptionsPage";
            this.ServerOptionsPage.Size = new System.Drawing.Size(184, 47);
            this.ServerOptionsPage.TabIndex = 0;
            this.ServerOptionsPage.Text = "Server Options";
            // 
            // grpLoginOptions
            // 
            this.grpLoginOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLoginOptions.Controls.Add(this.label8);
            this.grpLoginOptions.Controls.Add(this.label7);
            this.grpLoginOptions.Controls.Add(this.label6);
            this.grpLoginOptions.Controls.Add(this.txtPassword);
            this.grpLoginOptions.Controls.Add(this.txtUsername);
            this.grpLoginOptions.Controls.Add(this.label5);
            this.grpLoginOptions.Location = new System.Drawing.Point(10, 76);
            this.grpLoginOptions.Name = "grpLoginOptions";
            this.grpLoginOptions.Size = new System.Drawing.Size(164, 74);
            this.grpLoginOptions.TabIndex = 1;
            this.grpLoginOptions.TabStop = false;
            this.grpLoginOptions.Text = "Login Options";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(-233, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "(use $PASSWORD$ as token in the request)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(-233, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "(use $USER$ as token in the request)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(85, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(0, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(85, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(0, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpServerAddress
            // 
            this.grpServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpServerAddress.Controls.Add(this.label4);
            this.grpServerAddress.Controls.Add(this.txtServerAddress);
            this.grpServerAddress.Controls.Add(this.label3);
            this.grpServerAddress.Location = new System.Drawing.Point(10, 3);
            this.grpServerAddress.Name = "grpServerAddress";
            this.grpServerAddress.Size = new System.Drawing.Size(164, 67);
            this.grpServerAddress.TabIndex = 0;
            this.grpServerAddress.TabStop = false;
            this.grpServerAddress.Text = "Server Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "(Like http://<server name>:<server port>/<application name>/CNHost)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerAddress.Location = new System.Drawing.Point(50, 20);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(96, 20);
            this.txtServerAddress.TabIndex = 1;
            this.txtServerAddress.TextChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Url:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RuntimePage
            // 
            this.RuntimePage.Controls.Add(this.grpExecutionFlow);
            this.RuntimePage.Controls.Add(this.grpExecutionTiming);
            this.RuntimePage.Controls.Add(this.grpExecutionSettings);
            this.RuntimePage.ImageIndex = 5;
            this.RuntimePage.Location = new System.Drawing.Point(4, 23);
            this.RuntimePage.Name = "RuntimePage";
            this.RuntimePage.Size = new System.Drawing.Size(184, 47);
            this.RuntimePage.TabIndex = 0;
            this.RuntimePage.Text = "Runtime";
            // 
            // grpExecutionFlow
            // 
            this.grpExecutionFlow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExecutionFlow.Controls.Add(this.panelErrorRadioButtons);
            this.grpExecutionFlow.Controls.Add(this.panelWarningRadioButtons);
            this.grpExecutionFlow.Controls.Add(this.label23);
            this.grpExecutionFlow.Controls.Add(this.chkClearExecutionLog);
            this.grpExecutionFlow.Controls.Add(this.label18);
            this.grpExecutionFlow.Location = new System.Drawing.Point(10, 198);
            this.grpExecutionFlow.Name = "grpExecutionFlow";
            this.grpExecutionFlow.Size = new System.Drawing.Size(164, 98);
            this.grpExecutionFlow.TabIndex = 2;
            this.grpExecutionFlow.TabStop = false;
            this.grpExecutionFlow.Text = "Execution Flow Control";
            // 
            // panelErrorRadioButtons
            // 
            this.panelErrorRadioButtons.Controls.Add(this.rOnErrorContinue);
            this.panelErrorRadioButtons.Controls.Add(this.rOnErrorsStopAll);
            this.panelErrorRadioButtons.Controls.Add(this.rOnErrorStopCurrent);
            this.panelErrorRadioButtons.Location = new System.Drawing.Point(167, 46);
            this.panelErrorRadioButtons.Name = "panelErrorRadioButtons";
            this.panelErrorRadioButtons.Size = new System.Drawing.Size(341, 23);
            this.panelErrorRadioButtons.TabIndex = 3;
            // 
            // rOnErrorContinue
            // 
            this.rOnErrorContinue.AutoSize = true;
            this.rOnErrorContinue.Location = new System.Drawing.Point(3, 3);
            this.rOnErrorContinue.Name = "rOnErrorContinue";
            this.rOnErrorContinue.Size = new System.Drawing.Size(67, 17);
            this.rOnErrorContinue.TabIndex = 0;
            this.rOnErrorContinue.Text = "Continue";
            this.rOnErrorContinue.UseVisualStyleBackColor = true;
            this.rOnErrorContinue.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // rOnErrorsStopAll
            // 
            this.rOnErrorsStopAll.AutoSize = true;
            this.rOnErrorsStopAll.Checked = true;
            this.rOnErrorsStopAll.Location = new System.Drawing.Point(220, 3);
            this.rOnErrorsStopAll.Name = "rOnErrorsStopAll";
            this.rOnErrorsStopAll.Size = new System.Drawing.Size(116, 17);
            this.rOnErrorsStopAll.TabIndex = 2;
            this.rOnErrorsStopAll.TabStop = true;
            this.rOnErrorsStopAll.Text = "Stop All Executions";
            this.rOnErrorsStopAll.UseVisualStyleBackColor = true;
            this.rOnErrorsStopAll.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // rOnErrorStopCurrent
            // 
            this.rOnErrorStopCurrent.AutoSize = true;
            this.rOnErrorStopCurrent.Location = new System.Drawing.Point(77, 3);
            this.rOnErrorStopCurrent.Name = "rOnErrorStopCurrent";
            this.rOnErrorStopCurrent.Size = new System.Drawing.Size(134, 17);
            this.rOnErrorStopCurrent.TabIndex = 1;
            this.rOnErrorStopCurrent.Text = "Stop Current Execution";
            this.rOnErrorStopCurrent.UseVisualStyleBackColor = true;
            this.rOnErrorStopCurrent.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // panelWarningRadioButtons
            // 
            this.panelWarningRadioButtons.Controls.Add(this.rOnWarningContinue);
            this.panelWarningRadioButtons.Controls.Add(this.rOnWarningStopCurrent);
            this.panelWarningRadioButtons.Controls.Add(this.rOnWarningStopAll);
            this.panelWarningRadioButtons.Location = new System.Drawing.Point(167, 20);
            this.panelWarningRadioButtons.Name = "panelWarningRadioButtons";
            this.panelWarningRadioButtons.Size = new System.Drawing.Size(340, 23);
            this.panelWarningRadioButtons.TabIndex = 1;
            // 
            // rOnWarningContinue
            // 
            this.rOnWarningContinue.AutoSize = true;
            this.rOnWarningContinue.Checked = true;
            this.rOnWarningContinue.Location = new System.Drawing.Point(3, 3);
            this.rOnWarningContinue.Name = "rOnWarningContinue";
            this.rOnWarningContinue.Size = new System.Drawing.Size(67, 17);
            this.rOnWarningContinue.TabIndex = 0;
            this.rOnWarningContinue.TabStop = true;
            this.rOnWarningContinue.Text = "Continue";
            this.rOnWarningContinue.UseVisualStyleBackColor = true;
            this.rOnWarningContinue.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // rOnWarningStopCurrent
            // 
            this.rOnWarningStopCurrent.AutoSize = true;
            this.rOnWarningStopCurrent.Location = new System.Drawing.Point(77, 3);
            this.rOnWarningStopCurrent.Name = "rOnWarningStopCurrent";
            this.rOnWarningStopCurrent.Size = new System.Drawing.Size(134, 17);
            this.rOnWarningStopCurrent.TabIndex = 1;
            this.rOnWarningStopCurrent.Text = "Stop Current Execution";
            this.rOnWarningStopCurrent.UseVisualStyleBackColor = true;
            this.rOnWarningStopCurrent.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // rOnWarningStopAll
            // 
            this.rOnWarningStopAll.AutoSize = true;
            this.rOnWarningStopAll.Location = new System.Drawing.Point(220, 3);
            this.rOnWarningStopAll.Name = "rOnWarningStopAll";
            this.rOnWarningStopAll.Size = new System.Drawing.Size(116, 17);
            this.rOnWarningStopAll.TabIndex = 2;
            this.rOnWarningStopAll.Text = "Stop All Executions";
            this.rOnWarningStopAll.UseVisualStyleBackColor = true;
            this.rOnWarningStopAll.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Behavior On Error:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkClearExecutionLog
            // 
            this.chkClearExecutionLog.AutoSize = true;
            this.chkClearExecutionLog.Location = new System.Drawing.Point(167, 75);
            this.chkClearExecutionLog.Name = "chkClearExecutionLog";
            this.chkClearExecutionLog.Size = new System.Drawing.Size(224, 17);
            this.chkClearExecutionLog.TabIndex = 4;
            this.chkClearExecutionLog.Text = "Clear Execution Log After Each Execution";
            this.chkClearExecutionLog.UseVisualStyleBackColor = true;
            this.chkClearExecutionLog.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Behavior On Warning:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpExecutionTiming
            // 
            this.grpExecutionTiming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExecutionTiming.Controls.Add(this.label13);
            this.grpExecutionTiming.Controls.Add(this.label14);
            this.grpExecutionTiming.Controls.Add(this.label15);
            this.grpExecutionTiming.Controls.Add(this.nStepDelay);
            this.grpExecutionTiming.Controls.Add(this.label16);
            this.grpExecutionTiming.Controls.Add(this.nExecutionDelay);
            this.grpExecutionTiming.Location = new System.Drawing.Point(10, 112);
            this.grpExecutionTiming.Name = "grpExecutionTiming";
            this.grpExecutionTiming.Size = new System.Drawing.Size(164, 80);
            this.grpExecutionTiming.TabIndex = 1;
            this.grpExecutionTiming.TabStop = false;
            this.grpExecutionTiming.Text = "Execution Timing";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "milliseconds";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Delay Between Steps:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Delay Between Executions:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nStepDelay
            // 
            this.nStepDelay.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nStepDelay.Location = new System.Drawing.Point(167, 47);
            this.nStepDelay.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nStepDelay.Name = "nStepDelay";
            this.nStepDelay.Size = new System.Drawing.Size(91, 20);
            this.nStepDelay.TabIndex = 4;
            this.nStepDelay.ValueChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(264, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "milliseconds";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nExecutionDelay
            // 
            this.nExecutionDelay.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nExecutionDelay.Location = new System.Drawing.Point(167, 20);
            this.nExecutionDelay.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nExecutionDelay.Name = "nExecutionDelay";
            this.nExecutionDelay.Size = new System.Drawing.Size(91, 20);
            this.nExecutionDelay.TabIndex = 1;
            this.nExecutionDelay.ValueChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // grpExecutionSettings
            // 
            this.grpExecutionSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExecutionSettings.Controls.Add(this.labelThreads);
            this.grpExecutionSettings.Controls.Add(this.nNumberOfThreads);
            this.grpExecutionSettings.Controls.Add(this.labelNumberOfThreads);
            this.grpExecutionSettings.Controls.Add(this.label11);
            this.grpExecutionSettings.Controls.Add(this.label12);
            this.grpExecutionSettings.Controls.Add(this.nCounterStart);
            this.grpExecutionSettings.Controls.Add(this.label10);
            this.grpExecutionSettings.Controls.Add(this.nNumberOfExecutions);
            this.grpExecutionSettings.Controls.Add(this.label9);
            this.grpExecutionSettings.Location = new System.Drawing.Point(10, 3);
            this.grpExecutionSettings.Name = "grpExecutionSettings";
            this.grpExecutionSettings.Size = new System.Drawing.Size(164, 103);
            this.grpExecutionSettings.TabIndex = 0;
            this.grpExecutionSettings.TabStop = false;
            this.grpExecutionSettings.Text = "Execution Settings";
            // 
            // labelThreads
            // 
            this.labelThreads.AutoSize = true;
            this.labelThreads.Location = new System.Drawing.Point(264, 51);
            this.labelThreads.Name = "labelThreads";
            this.labelThreads.Size = new System.Drawing.Size(48, 13);
            this.labelThreads.TabIndex = 5;
            this.labelThreads.Text = "thread(s)";
            this.labelThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nNumberOfThreads
            // 
            this.nNumberOfThreads.Location = new System.Drawing.Point(167, 47);
            this.nNumberOfThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNumberOfThreads.Name = "nNumberOfThreads";
            this.nNumberOfThreads.Size = new System.Drawing.Size(91, 20);
            this.nNumberOfThreads.TabIndex = 4;
            this.nNumberOfThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNumberOfThreads.ValueChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // labelNumberOfThreads
            // 
            this.labelNumberOfThreads.AutoSize = true;
            this.labelNumberOfThreads.Location = new System.Drawing.Point(20, 51);
            this.labelNumberOfThreads.Name = "labelNumberOfThreads";
            this.labelNumberOfThreads.Size = new System.Drawing.Size(101, 13);
            this.labelNumberOfThreads.TabIndex = 3;
            this.labelNumberOfThreads.Text = "Number of Threads:";
            this.labelNumberOfThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "(use $COUNTER$ as token in the request)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Execution Counter Start:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nCounterStart
            // 
            this.nCounterStart.Location = new System.Drawing.Point(167, 74);
            this.nCounterStart.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nCounterStart.Name = "nCounterStart";
            this.nCounterStart.Size = new System.Drawing.Size(91, 20);
            this.nCounterStart.TabIndex = 7;
            this.nCounterStart.ValueChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "time(s)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nNumberOfExecutions
            // 
            this.nNumberOfExecutions.Location = new System.Drawing.Point(167, 20);
            this.nNumberOfExecutions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNumberOfExecutions.Name = "nNumberOfExecutions";
            this.nNumberOfExecutions.Size = new System.Drawing.Size(91, 20);
            this.nNumberOfExecutions.TabIndex = 1;
            this.nNumberOfExecutions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNumberOfExecutions.ValueChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Number of Executions:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataSourcePage
            // 
            this.DataSourcePage.Controls.Add(this.grpDataSourceSettings);
            this.DataSourcePage.ImageIndex = 6;
            this.DataSourcePage.Location = new System.Drawing.Point(4, 23);
            this.DataSourcePage.Name = "DataSourcePage";
            this.DataSourcePage.Size = new System.Drawing.Size(184, 47);
            this.DataSourcePage.TabIndex = 0;
            this.DataSourcePage.Text = "Data Source";
            // 
            // grpDataSourceSettings
            // 
            this.grpDataSourceSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataSourceSettings.Controls.Add(this.bBrowse);
            this.grpDataSourceSettings.Controls.Add(this.labelDataFileType);
            this.grpDataSourceSettings.Controls.Add(this.txtDataSourceFilePath);
            this.grpDataSourceSettings.Controls.Add(this.rXMLFile);
            this.grpDataSourceSettings.Controls.Add(this.labelDataFileName);
            this.grpDataSourceSettings.Controls.Add(this.rExcelFile);
            this.grpDataSourceSettings.Controls.Add(this.chkUseDataFiles);
            this.grpDataSourceSettings.Location = new System.Drawing.Point(10, 3);
            this.grpDataSourceSettings.Name = "grpDataSourceSettings";
            this.grpDataSourceSettings.Size = new System.Drawing.Size(164, 98);
            this.grpDataSourceSettings.TabIndex = 0;
            this.grpDataSourceSettings.TabStop = false;
            this.grpDataSourceSettings.Text = "Data Source Settings";
            // 
            // bBrowse
            // 
            this.bBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowse.ImageKey = "Open.bmp";
            this.bBrowse.ImageList = this.ButtonImages;
            this.bBrowse.Location = new System.Drawing.Point(125, 43);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(23, 23);
            this.bBrowse.TabIndex = 3;
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.DataSourceFileBrowse);
            // 
            // ButtonImages
            // 
            this.ButtonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ButtonImages.ImageStream")));
            this.ButtonImages.TransparentColor = System.Drawing.Color.Magenta;
            this.ButtonImages.Images.SetKeyName(0, "Open.bmp");
            // 
            // labelDataFileType
            // 
            this.labelDataFileType.AutoSize = true;
            this.labelDataFileType.Location = new System.Drawing.Point(17, 73);
            this.labelDataFileType.Name = "labelDataFileType";
            this.labelDataFileType.Size = new System.Drawing.Size(79, 13);
            this.labelDataFileType.TabIndex = 4;
            this.labelDataFileType.Text = "Data File Type:";
            this.labelDataFileType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDataSourceFilePath
            // 
            this.txtDataSourceFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataSourceFilePath.Location = new System.Drawing.Point(106, 44);
            this.txtDataSourceFilePath.Name = "txtDataSourceFilePath";
            this.txtDataSourceFilePath.Size = new System.Drawing.Size(13, 20);
            this.txtDataSourceFilePath.TabIndex = 2;
            this.txtDataSourceFilePath.TextChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // rXMLFile
            // 
            this.rXMLFile.AutoSize = true;
            this.rXMLFile.Location = new System.Drawing.Point(179, 71);
            this.rXMLFile.Name = "rXMLFile";
            this.rXMLFile.Size = new System.Drawing.Size(63, 17);
            this.rXMLFile.TabIndex = 6;
            this.rXMLFile.Text = "XML file";
            this.rXMLFile.UseVisualStyleBackColor = true;
            this.rXMLFile.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // labelDataFileName
            // 
            this.labelDataFileName.AutoSize = true;
            this.labelDataFileName.Location = new System.Drawing.Point(17, 48);
            this.labelDataFileName.Name = "labelDataFileName";
            this.labelDataFileName.Size = new System.Drawing.Size(83, 13);
            this.labelDataFileName.TabIndex = 1;
            this.labelDataFileName.Text = "Data File Name:";
            this.labelDataFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rExcelFile
            // 
            this.rExcelFile.AutoSize = true;
            this.rExcelFile.Checked = true;
            this.rExcelFile.Location = new System.Drawing.Point(106, 71);
            this.rExcelFile.Name = "rExcelFile";
            this.rExcelFile.Size = new System.Drawing.Size(67, 17);
            this.rExcelFile.TabIndex = 5;
            this.rExcelFile.TabStop = true;
            this.rExcelFile.Text = "Excel file";
            this.rExcelFile.UseVisualStyleBackColor = true;
            this.rExcelFile.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // chkUseDataFiles
            // 
            this.chkUseDataFiles.AutoSize = true;
            this.chkUseDataFiles.Location = new System.Drawing.Point(20, 20);
            this.chkUseDataFiles.Name = "chkUseDataFiles";
            this.chkUseDataFiles.Size = new System.Drawing.Size(90, 17);
            this.chkUseDataFiles.TabIndex = 0;
            this.chkUseDataFiles.Text = "Use Data File";
            this.chkUseDataFiles.UseVisualStyleBackColor = true;
            this.chkUseDataFiles.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // LoggingPage
            // 
            this.LoggingPage.Controls.Add(this.grpLogOutputSettingsGroup);
            this.LoggingPage.ImageIndex = 7;
            this.LoggingPage.Location = new System.Drawing.Point(4, 23);
            this.LoggingPage.Name = "LoggingPage";
            this.LoggingPage.Size = new System.Drawing.Size(184, 47);
            this.LoggingPage.TabIndex = 0;
            this.LoggingPage.Text = "Logging";
            // 
            // grpLogOutputSettingsGroup
            // 
            this.grpLogOutputSettingsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLogOutputSettingsGroup.Controls.Add(this.chkCreateSepateLogs);
            this.grpLogOutputSettingsGroup.Controls.Add(this.bSelectLogOutputFolder);
            this.grpLogOutputSettingsGroup.Controls.Add(this.txtLogOutputPath);
            this.grpLogOutputSettingsGroup.Controls.Add(this.chkEnableLogging);
            this.grpLogOutputSettingsGroup.Controls.Add(this.labelLogOutputPath);
            this.grpLogOutputSettingsGroup.Location = new System.Drawing.Point(10, 3);
            this.grpLogOutputSettingsGroup.Name = "grpLogOutputSettingsGroup";
            this.grpLogOutputSettingsGroup.Size = new System.Drawing.Size(164, 100);
            this.grpLogOutputSettingsGroup.TabIndex = 0;
            this.grpLogOutputSettingsGroup.TabStop = false;
            this.grpLogOutputSettingsGroup.Text = "Log Output Setttings";
            // 
            // chkCreateSepateLogs
            // 
            this.chkCreateSepateLogs.AutoSize = true;
            this.chkCreateSepateLogs.Checked = true;
            this.chkCreateSepateLogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateSepateLogs.Location = new System.Drawing.Point(20, 71);
            this.chkCreateSepateLogs.Name = "chkCreateSepateLogs";
            this.chkCreateSepateLogs.Size = new System.Drawing.Size(311, 17);
            this.chkCreateSepateLogs.TabIndex = 4;
            this.chkCreateSepateLogs.Text = "Create Separate Logs For Each Executions (Recommanded)";
            this.chkCreateSepateLogs.UseVisualStyleBackColor = true;
            this.chkCreateSepateLogs.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // bSelectLogOutputFolder
            // 
            this.bSelectLogOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSelectLogOutputFolder.ImageKey = "Open.bmp";
            this.bSelectLogOutputFolder.ImageList = this.ButtonImages;
            this.bSelectLogOutputFolder.Location = new System.Drawing.Point(125, 43);
            this.bSelectLogOutputFolder.Name = "bSelectLogOutputFolder";
            this.bSelectLogOutputFolder.Size = new System.Drawing.Size(23, 23);
            this.bSelectLogOutputFolder.TabIndex = 3;
            this.bSelectLogOutputFolder.UseVisualStyleBackColor = true;
            this.bSelectLogOutputFolder.Click += new System.EventHandler(this.LogFileOutputPathChoose);
            // 
            // txtLogOutputPath
            // 
            this.txtLogOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogOutputPath.Location = new System.Drawing.Point(121, 44);
            this.txtLogOutputPath.Name = "txtLogOutputPath";
            this.txtLogOutputPath.Size = new System.Drawing.Size(0, 20);
            this.txtLogOutputPath.TabIndex = 2;
            this.txtLogOutputPath.TextChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // chkEnableLogging
            // 
            this.chkEnableLogging.AutoSize = true;
            this.chkEnableLogging.Location = new System.Drawing.Point(20, 20);
            this.chkEnableLogging.Name = "chkEnableLogging";
            this.chkEnableLogging.Size = new System.Drawing.Size(100, 17);
            this.chkEnableLogging.TabIndex = 0;
            this.chkEnableLogging.Text = "Enable Logging";
            this.chkEnableLogging.UseVisualStyleBackColor = true;
            this.chkEnableLogging.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // labelLogOutputPath
            // 
            this.labelLogOutputPath.AutoSize = true;
            this.labelLogOutputPath.Location = new System.Drawing.Point(17, 48);
            this.labelLogOutputPath.Name = "labelLogOutputPath";
            this.labelLogOutputPath.Size = new System.Drawing.Size(88, 13);
            this.labelLogOutputPath.TabIndex = 1;
            this.labelLogOutputPath.Text = "Log Output Path:";
            this.labelLogOutputPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EMailPage
            // 
            this.EMailPage.Controls.Add(this.grpEmailSettings);
            this.EMailPage.ImageIndex = 8;
            this.EMailPage.Location = new System.Drawing.Point(4, 23);
            this.EMailPage.Name = "EMailPage";
            this.EMailPage.Size = new System.Drawing.Size(184, 47);
            this.EMailPage.TabIndex = 0;
            this.EMailPage.Text = "E-Mail  Notifications";
            // 
            // grpEmailSettings
            // 
            this.grpEmailSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEmailSettings.Controls.Add(this.txtEMailDisplayName);
            this.grpEmailSettings.Controls.Add(this.label17);
            this.grpEmailSettings.Controls.Add(this.chkSendFromConsoleOnly);
            this.grpEmailSettings.Controls.Add(this.chkSendOnFailureOnly);
            this.grpEmailSettings.Controls.Add(this.txtEMailAddress);
            this.grpEmailSettings.Controls.Add(this.label24);
            this.grpEmailSettings.Location = new System.Drawing.Point(10, 3);
            this.grpEmailSettings.Name = "grpEmailSettings";
            this.grpEmailSettings.Size = new System.Drawing.Size(164, 129);
            this.grpEmailSettings.TabIndex = 0;
            this.grpEmailSettings.TabStop = false;
            this.grpEmailSettings.Text = "E-Mail Settings";
            // 
            // txtEMailDisplayName
            // 
            this.txtEMailDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEMailDisplayName.Location = new System.Drawing.Point(106, 20);
            this.txtEMailDisplayName.Name = "txtEMailDisplayName";
            this.txtEMailDisplayName.Size = new System.Drawing.Size(35, 20);
            this.txtEMailDisplayName.TabIndex = 1;
            this.txtEMailDisplayName.TextChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Name:";
            // 
            // chkSendFromConsoleOnly
            // 
            this.chkSendFromConsoleOnly.AutoSize = true;
            this.chkSendFromConsoleOnly.Location = new System.Drawing.Point(23, 101);
            this.chkSendFromConsoleOnly.Name = "chkSendFromConsoleOnly";
            this.chkSendFromConsoleOnly.Size = new System.Drawing.Size(239, 17);
            this.chkSendFromConsoleOnly.TabIndex = 5;
            this.chkSendFromConsoleOnly.Text = "Send Mail Only When Running From Console";
            this.chkSendFromConsoleOnly.UseVisualStyleBackColor = true;
            this.chkSendFromConsoleOnly.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // chkSendOnFailureOnly
            // 
            this.chkSendOnFailureOnly.AutoSize = true;
            this.chkSendOnFailureOnly.Location = new System.Drawing.Point(23, 78);
            this.chkSendOnFailureOnly.Name = "chkSendOnFailureOnly";
            this.chkSendOnFailureOnly.Size = new System.Drawing.Size(148, 17);
            this.chkSendOnFailureOnly.TabIndex = 4;
            this.chkSendOnFailureOnly.Text = "Send Mail Only On Failure";
            this.chkSendOnFailureOnly.UseVisualStyleBackColor = true;
            this.chkSendOnFailureOnly.CheckedChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // txtEMailAddress
            // 
            this.txtEMailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEMailAddress.Location = new System.Drawing.Point(106, 47);
            this.txtEMailAddress.Name = "txtEMailAddress";
            this.txtEMailAddress.Size = new System.Drawing.Size(35, 20);
            this.txtEMailAddress.TabIndex = 3;
            this.txtEMailAddress.TextChanged += new System.EventHandler(this.OnTestConfigurationChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "E Mail Address:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabImages
            // 
            this.TabImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabImages.ImageStream")));
            this.TabImages.TransparentColor = System.Drawing.Color.Magenta;
            this.TabImages.Images.SetKeyName(0, "Tab Genral.bmp");
            this.TabImages.Images.SetKeyName(1, "Tab Configuration.bmp");
            this.TabImages.Images.SetKeyName(2, "Tab Test Units.bmp");
            this.TabImages.Images.SetKeyName(3, "Tab Execution.bmp");
            this.TabImages.Images.SetKeyName(4, "Tab Server.bmp");
            this.TabImages.Images.SetKeyName(5, "Tab Runtime.bmp");
            this.TabImages.Images.SetKeyName(6, "Tab Data Source.bmp");
            this.TabImages.Images.SetKeyName(7, "Tab Logging.bmp");
            this.TabImages.Images.SetKeyName(8, "Tab Mail.bmp");
            this.TabImages.Images.SetKeyName(9, "Tab Execution Log.bmp");
            this.TabImages.Images.SetKeyName(10, "Tab Execution Statistics.bmp");
            // 
            // TestUnitsPage
            // 
            this.TestUnitsPage.Controls.Add(this.TestUnitsList);
            this.TestUnitsPage.Controls.Add(this.TestUnitsToolbar);
            this.TestUnitsPage.Controls.Add(this.TestUnitsStatusBar);
            this.TestUnitsPage.ImageIndex = 2;
            this.TestUnitsPage.Location = new System.Drawing.Point(4, 23);
            this.TestUnitsPage.Name = "TestUnitsPage";
            this.TestUnitsPage.Size = new System.Drawing.Size(764, 479);
            this.TestUnitsPage.TabIndex = 0;
            this.TestUnitsPage.Text = "Test Units";
            // 
            // TestUnitsList
            // 
            this.TestUnitsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStep,
            this.colExpectedTime,
            this.colCurrentForm,
            this.colTestUnit});
            this.TestUnitsList.ContextMenuStrip = this.TestUnitsContextMenu;
            this.TestUnitsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestUnitsList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestUnitsList.FullRowSelect = true;
            this.TestUnitsList.Location = new System.Drawing.Point(0, 0);
            this.TestUnitsList.Name = "TestUnitsList";
            this.TestUnitsList.ShowGroups = false;
            this.TestUnitsList.Size = new System.Drawing.Size(636, 457);
            this.TestUnitsList.SmallImageList = this.TestUnitsListImages;
            this.TestUnitsList.TabIndex = 0;
            this.TestUnitsList.UseCompatibleStateImageBehavior = false;
            this.TestUnitsList.View = System.Windows.Forms.View.Details;
            this.TestUnitsList.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.TestUnitsListColumnResize);
            this.TestUnitsList.SelectedIndexChanged += new System.EventHandler(this.TestUnitListSelectionChanged);
            this.TestUnitsList.SizeChanged += new System.EventHandler(this.TestUnitsListResize);
            this.TestUnitsList.DoubleClick += new System.EventHandler(this.TestUnitsListDoubleClick);
            // 
            // colStep
            // 
            this.colStep.Text = "Step";
            this.colStep.Width = 50;
            // 
            // colExpectedTime
            // 
            this.colExpectedTime.Text = "Expected Time";
            this.colExpectedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colExpectedTime.Width = 100;
            // 
            // colCurrentForm
            // 
            this.colCurrentForm.Text = "Current Form";
            this.colCurrentForm.Width = 175;
            // 
            // colTestUnit
            // 
            this.colTestUnit.Text = "Test Unit";
            this.colTestUnit.Width = 308;
            // 
            // TestUnitsContextMenu
            // 
            this.TestUnitsContextMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TestUnitsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestUnitContextMenuLoad,
            this.TestUnitContextMenuSeparatorOne,
            this.TestUnitContextMenuLoadFromText,
            this.TestUnitContextMenuInsertFromText,
            this.TestUnitContextMenuExportToText,
            this.TestUnitContextMenuSeparatorTwo,
            this.TestUnitContextMenuAddTestUnit,
            this.TestUnitContextMenuEditTestUnit,
            this.TestUnitContextMenuInsertTestUnit,
            this.TestUnitContextMenuRemoveTestUnit,
            this.TestUnitContextMenuSeparatorThree,
            this.TestUnitContextMenuRemoveAll});
            this.TestUnitsContextMenu.Name = "TestUnitsContextMenu";
            this.TestUnitsContextMenu.Size = new System.Drawing.Size(163, 242);
            // 
            // TestUnitContextMenuLoad
            // 
            this.TestUnitContextMenuLoad.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitContextMenuLoad.Image")));
            this.TestUnitContextMenuLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitContextMenuLoad.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitContextMenuLoad.Name = "TestUnitContextMenuLoad";
            this.TestUnitContextMenuLoad.Size = new System.Drawing.Size(162, 22);
            this.TestUnitContextMenuLoad.Text = "Load";
            this.TestUnitContextMenuLoad.Click += new System.EventHandler(this.TestUnitsLoad);
            // 
            // TestUnitContextMenuSeparatorOne
            // 
            this.TestUnitContextMenuSeparatorOne.Name = "TestUnitContextMenuSeparatorOne";
            this.TestUnitContextMenuSeparatorOne.Size = new System.Drawing.Size(159, 6);
            // 
            // TestUnitContextMenuLoadFromText
            // 
            this.TestUnitContextMenuLoadFromText.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitContextMenuLoadFromText.Image")));
            this.TestUnitContextMenuLoadFromText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitContextMenuLoadFromText.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitContextMenuLoadFromText.Name = "TestUnitContextMenuLoadFromText";
            this.TestUnitContextMenuLoadFromText.Size = new System.Drawing.Size(162, 22);
            this.TestUnitContextMenuLoadFromText.Text = "Load From Text";
            this.TestUnitContextMenuLoadFromText.Click += new System.EventHandler(this.TestUnitsLoadFromText);
            // 
            // TestUnitContextMenuInsertFromText
            // 
            this.TestUnitContextMenuInsertFromText.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitContextMenuInsertFromText.Image")));
            this.TestUnitContextMenuInsertFromText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitContextMenuInsertFromText.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitContextMenuInsertFromText.Name = "TestUnitContextMenuInsertFromText";
            this.TestUnitContextMenuInsertFromText.Size = new System.Drawing.Size(162, 22);
            this.TestUnitContextMenuInsertFromText.Text = "Insert From Text";
            this.TestUnitContextMenuInsertFromText.Click += new System.EventHandler(this.TestUnitsInsertFromText);
            // 
            // TestUnitContextMenuExportToText
            // 
            this.TestUnitContextMenuExportToText.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitContextMenuExportToText.Image")));
            this.TestUnitContextMenuExportToText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitContextMenuExportToText.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitContextMenuExportToText.Name = "TestUnitContextMenuExportToText";
            this.TestUnitContextMenuExportToText.Size = new System.Drawing.Size(162, 22);
            this.TestUnitContextMenuExportToText.Text = "Export To Text";
            this.TestUnitContextMenuExportToText.Click += new System.EventHandler(this.TestUnitsExportToText);
            // 
            // TestUnitContextMenuSeparatorTwo
            // 
            this.TestUnitContextMenuSeparatorTwo.ForeColor = System.Drawing.Color.Black;
            this.TestUnitContextMenuSeparatorTwo.Name = "TestUnitContextMenuSeparatorTwo";
            this.TestUnitContextMenuSeparatorTwo.Size = new System.Drawing.Size(159, 6);
            // 
            // TestUnitContextMenuAddTestUnit
            // 
            this.TestUnitContextMenuAddTestUnit.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitContextMenuAddTestUnit.Image")));
            this.TestUnitContextMenuAddTestUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitContextMenuAddTestUnit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitContextMenuAddTestUnit.Name = "TestUnitContextMenuAddTestUnit";
            this.TestUnitContextMenuAddTestUnit.Size = new System.Drawing.Size(162, 22);
            this.TestUnitContextMenuAddTestUnit.Text = "Add Test Unit";
            this.TestUnitContextMenuAddTestUnit.Click += new System.EventHandler(this.TestUnitsAddTestUnit);
            // 
            // TestUnitContextMenuEditTestUnit
            // 
            this.TestUnitContextMenuEditTestUnit.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitContextMenuEditTestUnit.Image")));
            this.TestUnitContextMenuEditTestUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitContextMenuEditTestUnit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitContextMenuEditTestUnit.Name = "TestUnitContextMenuEditTestUnit";
            this.TestUnitContextMenuEditTestUnit.Size = new System.Drawing.Size(162, 22);
            this.TestUnitContextMenuEditTestUnit.Text = "Edit Test Unit";
            this.TestUnitContextMenuEditTestUnit.Click += new System.EventHandler(this.TestUnitsEditTestUnit);
            // 
            // TestUnitContextMenuInsertTestUnit
            // 
            this.TestUnitContextMenuInsertTestUnit.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitContextMenuInsertTestUnit.Image")));
            this.TestUnitContextMenuInsertTestUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitContextMenuInsertTestUnit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitContextMenuInsertTestUnit.Name = "TestUnitContextMenuInsertTestUnit";
            this.TestUnitContextMenuInsertTestUnit.Size = new System.Drawing.Size(162, 22);
            this.TestUnitContextMenuInsertTestUnit.Text = "Insert Test Unit";
            this.TestUnitContextMenuInsertTestUnit.Click += new System.EventHandler(this.TestUnitsInsertTestUnit);
            // 
            // TestUnitContextMenuRemoveTestUnit
            // 
            this.TestUnitContextMenuRemoveTestUnit.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitContextMenuRemoveTestUnit.Image")));
            this.TestUnitContextMenuRemoveTestUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitContextMenuRemoveTestUnit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitContextMenuRemoveTestUnit.Name = "TestUnitContextMenuRemoveTestUnit";
            this.TestUnitContextMenuRemoveTestUnit.Size = new System.Drawing.Size(162, 22);
            this.TestUnitContextMenuRemoveTestUnit.Text = "Remove Test Unit";
            this.TestUnitContextMenuRemoveTestUnit.Click += new System.EventHandler(this.TestUnitsRemoveTestUnits);
            // 
            // TestUnitContextMenuSeparatorThree
            // 
            this.TestUnitContextMenuSeparatorThree.Name = "TestUnitContextMenuSeparatorThree";
            this.TestUnitContextMenuSeparatorThree.Size = new System.Drawing.Size(159, 6);
            // 
            // TestUnitContextMenuRemoveAll
            // 
            this.TestUnitContextMenuRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitContextMenuRemoveAll.Image")));
            this.TestUnitContextMenuRemoveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitContextMenuRemoveAll.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitContextMenuRemoveAll.Name = "TestUnitContextMenuRemoveAll";
            this.TestUnitContextMenuRemoveAll.Size = new System.Drawing.Size(162, 22);
            this.TestUnitContextMenuRemoveAll.Text = "Remove All";
            this.TestUnitContextMenuRemoveAll.Click += new System.EventHandler(this.TestUnitsRemoveAll);
            // 
            // TestUnitsListImages
            // 
            this.TestUnitsListImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TestUnitsListImages.ImageStream")));
            this.TestUnitsListImages.TransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsListImages.Images.SetKeyName(0, "01 - Test Unit.png");
            this.TestUnitsListImages.Images.SetKeyName(1, "02 - OK.png");
            this.TestUnitsListImages.Images.SetKeyName(2, "03 - Error.png");
            // 
            // TestUnitsToolbar
            // 
            this.TestUnitsToolbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.TestUnitsToolbar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TestUnitsToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TestUnitsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestUnitsToolLoad,
            this.TestUnitsToolSeparatorOne,
            this.TestUnitsToolLoadFromText,
            this.TestUnitsToolInsertFromText,
            this.TestUnitsToolExportToText,
            this.TestUnitsToolSeparatorTwo,
            this.TestUnitsToolAddTestUnit,
            this.TestUnitsToolEditTestUnit,
            this.TestUnitsToolInsertTestUnit,
            this.TestUnitsToolRemoveTestUnits,
            this.TestUnitsToolSeparatorThree,
            this.TestUnitsToolRemoveAll});
            this.TestUnitsToolbar.Location = new System.Drawing.Point(636, 0);
            this.TestUnitsToolbar.Name = "TestUnitsToolbar";
            this.TestUnitsToolbar.Size = new System.Drawing.Size(128, 457);
            this.TestUnitsToolbar.TabIndex = 1;
            // 
            // TestUnitsToolLoad
            // 
            this.TestUnitsToolLoad.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitsToolLoad.Image")));
            this.TestUnitsToolLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolLoad.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsToolLoad.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolLoad.Name = "TestUnitsToolLoad";
            this.TestUnitsToolLoad.Size = new System.Drawing.Size(118, 20);
            this.TestUnitsToolLoad.Text = "Load";
            this.TestUnitsToolLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolLoad.Click += new System.EventHandler(this.TestUnitsLoad);
            // 
            // TestUnitsToolSeparatorOne
            // 
            this.TestUnitsToolSeparatorOne.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolSeparatorOne.Name = "TestUnitsToolSeparatorOne";
            this.TestUnitsToolSeparatorOne.Size = new System.Drawing.Size(118, 6);
            // 
            // TestUnitsToolLoadFromText
            // 
            this.TestUnitsToolLoadFromText.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitsToolLoadFromText.Image")));
            this.TestUnitsToolLoadFromText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolLoadFromText.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsToolLoadFromText.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolLoadFromText.Name = "TestUnitsToolLoadFromText";
            this.TestUnitsToolLoadFromText.Size = new System.Drawing.Size(118, 20);
            this.TestUnitsToolLoadFromText.Text = "Load From Text";
            this.TestUnitsToolLoadFromText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolLoadFromText.Click += new System.EventHandler(this.TestUnitsLoadFromText);
            // 
            // TestUnitsToolInsertFromText
            // 
            this.TestUnitsToolInsertFromText.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitsToolInsertFromText.Image")));
            this.TestUnitsToolInsertFromText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolInsertFromText.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsToolInsertFromText.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolInsertFromText.Name = "TestUnitsToolInsertFromText";
            this.TestUnitsToolInsertFromText.Size = new System.Drawing.Size(118, 20);
            this.TestUnitsToolInsertFromText.Text = "Insert From Text";
            this.TestUnitsToolInsertFromText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolInsertFromText.Click += new System.EventHandler(this.TestUnitsInsertFromText);
            // 
            // TestUnitsToolExportToText
            // 
            this.TestUnitsToolExportToText.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitsToolExportToText.Image")));
            this.TestUnitsToolExportToText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolExportToText.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsToolExportToText.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolExportToText.Name = "TestUnitsToolExportToText";
            this.TestUnitsToolExportToText.Size = new System.Drawing.Size(118, 20);
            this.TestUnitsToolExportToText.Text = "Export To Text";
            this.TestUnitsToolExportToText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolExportToText.Click += new System.EventHandler(this.TestUnitsExportToText);
            // 
            // TestUnitsToolSeparatorTwo
            // 
            this.TestUnitsToolSeparatorTwo.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolSeparatorTwo.Name = "TestUnitsToolSeparatorTwo";
            this.TestUnitsToolSeparatorTwo.Size = new System.Drawing.Size(118, 6);
            // 
            // TestUnitsToolAddTestUnit
            // 
            this.TestUnitsToolAddTestUnit.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitsToolAddTestUnit.Image")));
            this.TestUnitsToolAddTestUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolAddTestUnit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsToolAddTestUnit.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolAddTestUnit.Name = "TestUnitsToolAddTestUnit";
            this.TestUnitsToolAddTestUnit.Size = new System.Drawing.Size(118, 20);
            this.TestUnitsToolAddTestUnit.Text = "Add Test Unit";
            this.TestUnitsToolAddTestUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolAddTestUnit.Click += new System.EventHandler(this.TestUnitsAddTestUnit);
            // 
            // TestUnitsToolEditTestUnit
            // 
            this.TestUnitsToolEditTestUnit.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitsToolEditTestUnit.Image")));
            this.TestUnitsToolEditTestUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolEditTestUnit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsToolEditTestUnit.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolEditTestUnit.Name = "TestUnitsToolEditTestUnit";
            this.TestUnitsToolEditTestUnit.Size = new System.Drawing.Size(118, 20);
            this.TestUnitsToolEditTestUnit.Text = "Edit Test Unit";
            this.TestUnitsToolEditTestUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolEditTestUnit.Click += new System.EventHandler(this.TestUnitsEditTestUnit);
            // 
            // TestUnitsToolInsertTestUnit
            // 
            this.TestUnitsToolInsertTestUnit.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitsToolInsertTestUnit.Image")));
            this.TestUnitsToolInsertTestUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolInsertTestUnit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsToolInsertTestUnit.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolInsertTestUnit.Name = "TestUnitsToolInsertTestUnit";
            this.TestUnitsToolInsertTestUnit.Size = new System.Drawing.Size(118, 20);
            this.TestUnitsToolInsertTestUnit.Text = "Insert Test Unit";
            this.TestUnitsToolInsertTestUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolInsertTestUnit.Click += new System.EventHandler(this.TestUnitsInsertTestUnit);
            // 
            // TestUnitsToolRemoveTestUnits
            // 
            this.TestUnitsToolRemoveTestUnits.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitsToolRemoveTestUnits.Image")));
            this.TestUnitsToolRemoveTestUnits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolRemoveTestUnits.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsToolRemoveTestUnits.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolRemoveTestUnits.Name = "TestUnitsToolRemoveTestUnits";
            this.TestUnitsToolRemoveTestUnits.Size = new System.Drawing.Size(118, 20);
            this.TestUnitsToolRemoveTestUnits.Text = "Remove Test Units";
            this.TestUnitsToolRemoveTestUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolRemoveTestUnits.ToolTipText = "Remove Selected Test Units";
            this.TestUnitsToolRemoveTestUnits.Click += new System.EventHandler(this.TestUnitsRemoveTestUnits);
            // 
            // TestUnitsToolSeparatorThree
            // 
            this.TestUnitsToolSeparatorThree.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolSeparatorThree.Name = "TestUnitsToolSeparatorThree";
            this.TestUnitsToolSeparatorThree.Size = new System.Drawing.Size(118, 6);
            // 
            // TestUnitsToolRemoveAll
            // 
            this.TestUnitsToolRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("TestUnitsToolRemoveAll.Image")));
            this.TestUnitsToolRemoveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolRemoveAll.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TestUnitsToolRemoveAll.Margin = new System.Windows.Forms.Padding(5, 1, 2, 2);
            this.TestUnitsToolRemoveAll.Name = "TestUnitsToolRemoveAll";
            this.TestUnitsToolRemoveAll.Size = new System.Drawing.Size(118, 20);
            this.TestUnitsToolRemoveAll.Text = "Remove All";
            this.TestUnitsToolRemoveAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestUnitsToolRemoveAll.ToolTipText = "Remove All Test Units";
            this.TestUnitsToolRemoveAll.Click += new System.EventHandler(this.TestUnitsRemoveAll);
            // 
            // TestUnitsStatusBar
            // 
            this.TestUnitsStatusBar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TestUnitsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTestUnitsDisplay,
            this.TestUnitsCount});
            this.TestUnitsStatusBar.Location = new System.Drawing.Point(0, 457);
            this.TestUnitsStatusBar.Name = "TestUnitsStatusBar";
            this.TestUnitsStatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.TestUnitsStatusBar.Size = new System.Drawing.Size(764, 22);
            this.TestUnitsStatusBar.SizingGrip = false;
            this.TestUnitsStatusBar.TabIndex = 2;
            this.TestUnitsStatusBar.Text = "statusStrip1";
            // 
            // lblTestUnitsDisplay
            // 
            this.lblTestUnitsDisplay.Name = "lblTestUnitsDisplay";
            this.lblTestUnitsDisplay.Size = new System.Drawing.Size(35, 17);
            this.lblTestUnitsDisplay.Text = "Tests:";
            // 
            // TestUnitsCount
            // 
            this.TestUnitsCount.Name = "TestUnitsCount";
            this.TestUnitsCount.Size = new System.Drawing.Size(13, 17);
            this.TestUnitsCount.Text = "0";
            // 
            // ExecutionPage
            // 
            this.ExecutionPage.Controls.Add(this.pnlExecutionArea);
            this.ExecutionPage.ImageIndex = 3;
            this.ExecutionPage.Location = new System.Drawing.Point(4, 22);
            this.ExecutionPage.Name = "ExecutionPage";
            this.ExecutionPage.Size = new System.Drawing.Size(192, 74);
            this.ExecutionPage.TabIndex = 7;
            this.ExecutionPage.Text = "Execution";
            // 
            // pnlExecutionArea
            // 
            this.pnlExecutionArea.Controls.Add(this.ExecutionArea);
            this.pnlExecutionArea.Controls.Add(this.grpExecutionProgress);
            this.pnlExecutionArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExecutionArea.Location = new System.Drawing.Point(0, 0);
            this.pnlExecutionArea.Name = "pnlExecutionArea";
            this.pnlExecutionArea.Size = new System.Drawing.Size(192, 74);
            this.pnlExecutionArea.TabIndex = 2;
            // 
            // ExecutionArea
            // 
            this.ExecutionArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecutionArea.Controls.Add(this.ExecutionLogsPage);
            this.ExecutionArea.Controls.Add(this.ExecutionStatisticsPage);
            this.ExecutionArea.ImageList = this.TabImages;
            this.ExecutionArea.Location = new System.Drawing.Point(0, 0);
            this.ExecutionArea.Name = "ExecutionArea";
            this.ExecutionArea.SelectedIndex = 1;
            this.ExecutionArea.Size = new System.Drawing.Size(193, 0);
            this.ExecutionArea.TabIndex = 0;
            // 
            // ExecutionLogsPage
            // 
            this.ExecutionLogsPage.Controls.Add(this.ExecutionLogs);
            this.ExecutionLogsPage.ImageIndex = 9;
            this.ExecutionLogsPage.Location = new System.Drawing.Point(4, 23);
            this.ExecutionLogsPage.Name = "ExecutionLogsPage";
            this.ExecutionLogsPage.Size = new System.Drawing.Size(185, 0);
            this.ExecutionLogsPage.TabIndex = 4;
            this.ExecutionLogsPage.Text = "Execution Log";
            // 
            // ExecutionLogs
            // 
            this.ExecutionLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExecutionLogs.Location = new System.Drawing.Point(0, 0);
            this.ExecutionLogs.Name = "ExecutionLogs";
            this.ExecutionLogs.SelectedIndex = 0;
            this.ExecutionLogs.Size = new System.Drawing.Size(185, 0);
            this.ExecutionLogs.TabIndex = 0;
            // 
            // ExecutionStatisticsPage
            // 
            this.ExecutionStatisticsPage.Controls.Add(this.pictureBox1);
            this.ExecutionStatisticsPage.Controls.Add(this.grpEndInfo);
            this.ExecutionStatisticsPage.Controls.Add(this.grpEstimatesInfo);
            this.ExecutionStatisticsPage.Controls.Add(this.grpRunningInfo);
            this.ExecutionStatisticsPage.Controls.Add(this.grpStartInfo);
            this.ExecutionStatisticsPage.ImageIndex = 10;
            this.ExecutionStatisticsPage.Location = new System.Drawing.Point(4, 23);
            this.ExecutionStatisticsPage.Name = "ExecutionStatisticsPage";
            this.ExecutionStatisticsPage.Size = new System.Drawing.Size(757, 377);
            this.ExecutionStatisticsPage.TabIndex = 0;
            this.ExecutionStatisticsPage.Text = "Execution Statistics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMS.WebApp.UI.Properties.Resources.ExecutionStatistics3;
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // grpEndInfo
            // 
            this.grpEndInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEndInfo.Controls.Add(this.lblCompletionDateTime);
            this.grpEndInfo.Location = new System.Drawing.Point(144, 223);
            this.grpEndInfo.Name = "grpEndInfo";
            this.grpEndInfo.Size = new System.Drawing.Size(598, 41);
            this.grpEndInfo.TabIndex = 3;
            this.grpEndInfo.TabStop = false;
            this.grpEndInfo.Text = "End";
            // 
            // lblCompletionDateTime
            // 
            this.lblCompletionDateTime.AutoSize = true;
            this.lblCompletionDateTime.Location = new System.Drawing.Point(24, 17);
            this.lblCompletionDateTime.Name = "lblCompletionDateTime";
            this.lblCompletionDateTime.Size = new System.Drawing.Size(146, 13);
            this.lblCompletionDateTime.TabIndex = 0;
            this.lblCompletionDateTime.Text = "Completion Date && Time: N/A";
            this.lblCompletionDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpEstimatesInfo
            // 
            this.grpEstimatesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEstimatesInfo.Controls.Add(this.lblEstimatedTimeToComplete);
            this.grpEstimatesInfo.Controls.Add(this.lblEstimatedCompletionDateTime);
            this.grpEstimatesInfo.Location = new System.Drawing.Point(144, 153);
            this.grpEstimatesInfo.Name = "grpEstimatesInfo";
            this.grpEstimatesInfo.Size = new System.Drawing.Size(598, 64);
            this.grpEstimatesInfo.TabIndex = 2;
            this.grpEstimatesInfo.TabStop = false;
            this.grpEstimatesInfo.Text = "Estimates";
            // 
            // lblEstimatedTimeToComplete
            // 
            this.lblEstimatedTimeToComplete.AutoSize = true;
            this.lblEstimatedTimeToComplete.Location = new System.Drawing.Point(24, 41);
            this.lblEstimatedTimeToComplete.Name = "lblEstimatedTimeToComplete";
            this.lblEstimatedTimeToComplete.Size = new System.Drawing.Size(155, 13);
            this.lblEstimatedTimeToComplete.TabIndex = 1;
            this.lblEstimatedTimeToComplete.Text = "Estimed Time to Complete: N/A";
            this.lblEstimatedTimeToComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstimatedCompletionDateTime
            // 
            this.lblEstimatedCompletionDateTime.AutoSize = true;
            this.lblEstimatedCompletionDateTime.Location = new System.Drawing.Point(24, 17);
            this.lblEstimatedCompletionDateTime.Name = "lblEstimatedCompletionDateTime";
            this.lblEstimatedCompletionDateTime.Size = new System.Drawing.Size(195, 13);
            this.lblEstimatedCompletionDateTime.TabIndex = 0;
            this.lblEstimatedCompletionDateTime.Text = "Estimated Completion Date && Time: N/A";
            this.lblEstimatedCompletionDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpRunningInfo
            // 
            this.grpRunningInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRunningInfo.Controls.Add(this.lblTimeElapsed);
            this.grpRunningInfo.Controls.Add(this.lblAverageTimeperExecution);
            this.grpRunningInfo.Controls.Add(this.lblAverageExecutionsperSecond);
            this.grpRunningInfo.Location = new System.Drawing.Point(144, 60);
            this.grpRunningInfo.Name = "grpRunningInfo";
            this.grpRunningInfo.Size = new System.Drawing.Size(598, 87);
            this.grpRunningInfo.TabIndex = 1;
            this.grpRunningInfo.TabStop = false;
            this.grpRunningInfo.Text = "Running";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(24, 63);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(97, 13);
            this.lblTimeElapsed.TabIndex = 2;
            this.lblTimeElapsed.Text = "Time Elapsed: N/A";
            this.lblTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAverageTimeperExecution
            // 
            this.lblAverageTimeperExecution.AutoSize = true;
            this.lblAverageTimeperExecution.Location = new System.Drawing.Point(24, 40);
            this.lblAverageTimeperExecution.Name = "lblAverageTimeperExecution";
            this.lblAverageTimeperExecution.Size = new System.Drawing.Size(167, 13);
            this.lblAverageTimeperExecution.TabIndex = 1;
            this.lblAverageTimeperExecution.Text = "Average Time per Execution: N/A";
            this.lblAverageTimeperExecution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAverageExecutionsperSecond
            // 
            this.lblAverageExecutionsperSecond.AutoSize = true;
            this.lblAverageExecutionsperSecond.Location = new System.Drawing.Point(24, 17);
            this.lblAverageExecutionsperSecond.Name = "lblAverageExecutionsperSecond";
            this.lblAverageExecutionsperSecond.Size = new System.Drawing.Size(186, 13);
            this.lblAverageExecutionsperSecond.TabIndex = 0;
            this.lblAverageExecutionsperSecond.Text = "Average Executions per Second: N/A";
            this.lblAverageExecutionsperSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpStartInfo
            // 
            this.grpStartInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStartInfo.Controls.Add(this.lblStartDateTime);
            this.grpStartInfo.Location = new System.Drawing.Point(144, 13);
            this.grpStartInfo.Name = "grpStartInfo";
            this.grpStartInfo.Size = new System.Drawing.Size(598, 41);
            this.grpStartInfo.TabIndex = 0;
            this.grpStartInfo.TabStop = false;
            this.grpStartInfo.Text = "Start";
            // 
            // lblStartDateTime
            // 
            this.lblStartDateTime.AutoSize = true;
            this.lblStartDateTime.Location = new System.Drawing.Point(24, 17);
            this.lblStartDateTime.Name = "lblStartDateTime";
            this.lblStartDateTime.Size = new System.Drawing.Size(116, 13);
            this.lblStartDateTime.TabIndex = 0;
            this.lblStartDateTime.Text = "Start Date && Time: N/A";
            this.lblStartDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpExecutionProgress
            // 
            this.grpExecutionProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExecutionProgress.Controls.Add(this.label36);
            this.grpExecutionProgress.Controls.Add(this.label35);
            this.grpExecutionProgress.Controls.Add(this.lblStepProgress);
            this.grpExecutionProgress.Controls.Add(this.lblExecutionStatus);
            this.grpExecutionProgress.Controls.Add(this.label28);
            this.grpExecutionProgress.Controls.Add(this.progressBar2);
            this.grpExecutionProgress.Controls.Add(this.progressBar1);
            this.grpExecutionProgress.Controls.Add(this.label26);
            this.grpExecutionProgress.Controls.Add(this.label25);
            this.grpExecutionProgress.Location = new System.Drawing.Point(3, 5);
            this.grpExecutionProgress.Name = "grpExecutionProgress";
            this.grpExecutionProgress.Size = new System.Drawing.Size(186, 66);
            this.grpExecutionProgress.TabIndex = 1;
            this.grpExecutionProgress.TabStop = false;
            this.grpExecutionProgress.Text = "Execution Progress";
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.Location = new System.Drawing.Point(-26, 37);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(206, 16);
            this.label36.TabIndex = 7;
            this.label36.Text = "Warnings: 0";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.Location = new System.Drawing.Point(-26, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(206, 16);
            this.label35.TabIndex = 6;
            this.label35.Text = "Successful: 0";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStepProgress
            // 
            this.lblStepProgress.AutoSize = true;
            this.lblStepProgress.Location = new System.Drawing.Point(347, 39);
            this.lblStepProgress.Name = "lblStepProgress";
            this.lblStepProgress.Size = new System.Drawing.Size(86, 13);
            this.lblStepProgress.TabIndex = 5;
            this.lblStepProgress.Text = "1 of 5 completed";
            this.lblStepProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExecutionStatus
            // 
            this.lblExecutionStatus.AutoSize = true;
            this.lblExecutionStatus.Location = new System.Drawing.Point(347, 20);
            this.lblExecutionStatus.Name = "lblExecutionStatus";
            this.lblExecutionStatus.Size = new System.Drawing.Size(86, 13);
            this.lblExecutionStatus.TabIndex = 2;
            this.lblExecutionStatus.Text = "1 of 5 completed";
            this.lblExecutionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(347, 39);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "1 of 5 completed";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(84, 39);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(257, 13);
            this.progressBar2.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(84, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 13);
            this.progressBar1.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 39);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "Step:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Execution:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // loadFromTextToolStripMenuItem
            // 
            this.loadFromTextToolStripMenuItem.Name = "loadFromTextToolStripMenuItem";
            this.loadFromTextToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.loadFromTextToolStripMenuItem.Text = "Load from text";
            // 
            // insertFromTextToolStripMenuItem
            // 
            this.insertFromTextToolStripMenuItem.Name = "insertFromTextToolStripMenuItem";
            this.insertFromTextToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.insertFromTextToolStripMenuItem.Text = "Insert from text";
            // 
            // exportToTextToolStripMenuItem
            // 
            this.exportToTextToolStripMenuItem.Name = "exportToTextToolStripMenuItem";
            this.exportToTextToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportToTextToolStripMenuItem.Text = "Export to text";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // addTestUnitToolStripMenuItem
            // 
            this.addTestUnitToolStripMenuItem.Name = "addTestUnitToolStripMenuItem";
            this.addTestUnitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addTestUnitToolStripMenuItem.Text = "Add test unit";
            // 
            // insertTestUnitToolStripMenuItem
            // 
            this.insertTestUnitToolStripMenuItem.Name = "insertTestUnitToolStripMenuItem";
            this.insertTestUnitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.insertTestUnitToolStripMenuItem.Text = "Insert test unit";
            // 
            // editTestUnitToolStripMenuItem
            // 
            this.editTestUnitToolStripMenuItem.Name = "editTestUnitToolStripMenuItem";
            this.editTestUnitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editTestUnitToolStripMenuItem.Text = "Edit test unit";
            // 
            // deleteTestUnitToolStripMenuItem
            // 
            this.deleteTestUnitToolStripMenuItem.Name = "deleteTestUnitToolStripMenuItem";
            this.deleteTestUnitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteTestUnitToolStripMenuItem.Text = "Delete test unit";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            // 
            // BackgroundExecution
            // 
            this.BackgroundExecution.WorkerReportsProgress = true;
            this.BackgroundExecution.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartExecution);
            this.BackgroundExecution.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ExecutionProgressReport);
            this.BackgroundExecution.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.StopExecution);
            // 
            // SelectFileDataSource
            // 
            this.SelectFileDataSource.Filter = "All Files|*.*|XML Files|*.xml|Excel Files|*.xls *.xlx";
            this.SelectFileDataSource.FilterIndex = 3;
            this.SelectFileDataSource.Title = "Select Data Source File";
            // 
            // LoadTestUnitsFile
            // 
            this.LoadTestUnitsFile.Title = "Load Test Units From File";
            // 
            // Test
            // 
            this.ClientSize = new System.Drawing.Size(772, 506);
            this.Controls.Add(this.MainArea);
            this.Name = "Test";
            this.Text = "Test";
            this.MainArea.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.grpTestDetails.ResumeLayout(false);
            this.grpTestDetails.PerformLayout();
            this.ConfigurationPage.ResumeLayout(false);
            this.ConfigurationArea.ResumeLayout(false);
            this.ServerOptionsPage.ResumeLayout(false);
            this.grpLoginOptions.ResumeLayout(false);
            this.grpLoginOptions.PerformLayout();
            this.grpServerAddress.ResumeLayout(false);
            this.grpServerAddress.PerformLayout();
            this.RuntimePage.ResumeLayout(false);
            this.grpExecutionFlow.ResumeLayout(false);
            this.grpExecutionFlow.PerformLayout();
            this.panelErrorRadioButtons.ResumeLayout(false);
            this.panelErrorRadioButtons.PerformLayout();
            this.panelWarningRadioButtons.ResumeLayout(false);
            this.panelWarningRadioButtons.PerformLayout();
            this.grpExecutionTiming.ResumeLayout(false);
            this.grpExecutionTiming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nStepDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nExecutionDelay)).EndInit();
            this.grpExecutionSettings.ResumeLayout(false);
            this.grpExecutionSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCounterStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfExecutions)).EndInit();
            this.DataSourcePage.ResumeLayout(false);
            this.grpDataSourceSettings.ResumeLayout(false);
            this.grpDataSourceSettings.PerformLayout();
            this.LoggingPage.ResumeLayout(false);
            this.grpLogOutputSettingsGroup.ResumeLayout(false);
            this.grpLogOutputSettingsGroup.PerformLayout();
            this.EMailPage.ResumeLayout(false);
            this.grpEmailSettings.ResumeLayout(false);
            this.grpEmailSettings.PerformLayout();
            this.TestUnitsPage.ResumeLayout(false);
            this.TestUnitsPage.PerformLayout();
            this.TestUnitsContextMenu.ResumeLayout(false);
            this.TestUnitsToolbar.ResumeLayout(false);
            this.TestUnitsToolbar.PerformLayout();
            this.TestUnitsStatusBar.ResumeLayout(false);
            this.TestUnitsStatusBar.PerformLayout();
            this.ExecutionPage.ResumeLayout(false);
            this.pnlExecutionArea.ResumeLayout(false);
            this.ExecutionArea.ResumeLayout(false);
            this.ExecutionLogsPage.ResumeLayout(false);
            this.ExecutionStatisticsPage.ResumeLayout(false);
            this.ExecutionStatisticsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEndInfo.ResumeLayout(false);
            this.grpEndInfo.PerformLayout();
            this.grpEstimatesInfo.ResumeLayout(false);
            this.grpEstimatesInfo.PerformLayout();
            this.grpRunningInfo.ResumeLayout(false);
            this.grpRunningInfo.PerformLayout();
            this.grpStartInfo.ResumeLayout(false);
            this.grpStartInfo.PerformLayout();
            this.grpExecutionProgress.ResumeLayout(false);
            this.grpExecutionProgress.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TabControl MainArea;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage ConfigurationPage;
        private System.Windows.Forms.TabPage TestUnitsPage;
        private System.Windows.Forms.TabPage ExecutionPage;
		private System.Windows.Forms.TabControl ConfigurationArea;
		private System.Windows.Forms.TabPage ServerOptionsPage;
		private System.Windows.Forms.TabPage RuntimePage;
		private System.Windows.Forms.TabPage DataSourcePage;
		private System.Windows.Forms.TabPage LoggingPage;
		private System.Windows.Forms.TabPage EMailPage;
		private System.Windows.Forms.TabControl ExecutionArea;
        private System.Windows.Forms.TabPage ExecutionLogsPage;
        private System.Windows.Forms.TabPage ExecutionStatisticsPage;
		private System.ComponentModel.BackgroundWorker BackgroundExecution;
		private System.Windows.Forms.ImageList TabImages;
		private System.Windows.Forms.ImageList TestUnitsListImages;
		private System.Windows.Forms.TextBox txtTestDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTestName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpTestDetails;
		private System.Windows.Forms.GroupBox grpServerAddress;
		private System.Windows.Forms.GroupBox grpLoginOptions;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtServerAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox grpExecutionSettings;
		private System.Windows.Forms.GroupBox grpExecutionFlow;
		private System.Windows.Forms.GroupBox grpExecutionTiming;
		private System.Windows.Forms.NumericUpDown nNumberOfExecutions;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown nCounterStart;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown nStepDelay;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown nExecutionDelay;
		private System.Windows.Forms.RadioButton rOnWarningStopAll;
		private System.Windows.Forms.RadioButton rOnWarningContinue;
		private System.Windows.Forms.CheckBox chkClearExecutionLog;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.RadioButton rOnWarningStopCurrent;
		private System.Windows.Forms.GroupBox grpExecutionProgress;
		private System.Windows.Forms.Label labelNumberOfThreads;
		private System.Windows.Forms.NumericUpDown nNumberOfThreads;
		private System.Windows.Forms.Label labelThreads;
		private System.Windows.Forms.CheckBox chkUseDataFiles;
		private System.Windows.Forms.Button bBrowse;
		private System.Windows.Forms.TextBox txtDataSourceFilePath;
		private System.Windows.Forms.Label labelDataFileName;
		private System.Windows.Forms.GroupBox grpDataSourceSettings;
		private System.Windows.Forms.RadioButton rXMLFile;
		private System.Windows.Forms.RadioButton rExcelFile;
		private System.Windows.Forms.Label labelDataFileType;
		private System.Windows.Forms.GroupBox grpLogOutputSettingsGroup;
		private System.Windows.Forms.GroupBox grpEmailSettings;
		private System.Windows.Forms.OpenFileDialog SelectFileDataSource;
		private System.Windows.Forms.Label labelLogOutputPath;
		private System.Windows.Forms.TextBox txtLogOutputPath;
		private System.Windows.Forms.CheckBox chkEnableLogging;
		private System.Windows.Forms.Button bSelectLogOutputFolder;
		private System.Windows.Forms.CheckBox chkCreateSepateLogs;
		private System.Windows.Forms.RadioButton rOnErrorsStopAll;
		private System.Windows.Forms.RadioButton rOnErrorContinue;
		private System.Windows.Forms.RadioButton rOnErrorStopCurrent;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.CheckBox chkSendFromConsoleOnly;
		private System.Windows.Forms.CheckBox chkSendOnFailureOnly;
		private System.Windows.Forms.TextBox txtEMailAddress;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Panel panelErrorRadioButtons;
		private System.Windows.Forms.Panel panelWarningRadioButtons;
		private System.Windows.Forms.ImageList ButtonImages;
		private System.Windows.Forms.StatusStrip TestUnitsStatusBar;
		private System.Windows.Forms.ToolStripStatusLabel lblTestUnitsDisplay;
		private System.Windows.Forms.ToolStripStatusLabel TestUnitsCount;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem loadFromTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertFromTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem addTestUnitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertTestUnitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editTestUnitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteTestUnitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
		private System.Windows.Forms.Panel pnlExecutionArea;
		private System.Windows.Forms.ContextMenuStrip TestUnitsContextMenu;
		private System.Windows.Forms.ToolStripMenuItem TestUnitContextMenuLoad;
		private System.Windows.Forms.ToolStripSeparator TestUnitContextMenuSeparatorOne;
		private System.Windows.Forms.ToolStripMenuItem TestUnitContextMenuLoadFromText;
		private System.Windows.Forms.ToolStripMenuItem TestUnitContextMenuInsertFromText;
		private System.Windows.Forms.ToolStripMenuItem TestUnitContextMenuExportToText;
		private System.Windows.Forms.ToolStripSeparator TestUnitContextMenuSeparatorTwo;
		private System.Windows.Forms.ToolStripMenuItem TestUnitContextMenuAddTestUnit;
		private System.Windows.Forms.ToolStripMenuItem TestUnitContextMenuInsertTestUnit;
		private System.Windows.Forms.ToolStripMenuItem TestUnitContextMenuEditTestUnit;
		private System.Windows.Forms.ToolStripMenuItem TestUnitContextMenuRemoveTestUnit;
		private System.Windows.Forms.ToolStripSeparator TestUnitContextMenuSeparatorThree;
		private System.Windows.Forms.ToolStripMenuItem TestUnitContextMenuRemoveAll;
		private System.Windows.Forms.ListView TestUnitsList;
		private System.Windows.Forms.ToolStrip TestUnitsToolbar;
		private System.Windows.Forms.ToolStripButton TestUnitsToolLoad;
		private System.Windows.Forms.ToolStripSeparator TestUnitsToolSeparatorOne;
		private System.Windows.Forms.ToolStripButton TestUnitsToolLoadFromText;
		private System.Windows.Forms.ToolStripButton TestUnitsToolInsertFromText;
		private System.Windows.Forms.ToolStripButton TestUnitsToolExportToText;
		private System.Windows.Forms.ToolStripSeparator TestUnitsToolSeparatorTwo;
		private System.Windows.Forms.ToolStripButton TestUnitsToolAddTestUnit;
		private System.Windows.Forms.ToolStripButton TestUnitsToolInsertTestUnit;
		private System.Windows.Forms.ToolStripButton TestUnitsToolEditTestUnit;
		private System.Windows.Forms.ToolStripButton TestUnitsToolRemoveTestUnits;
		private System.Windows.Forms.ToolStripSeparator TestUnitsToolSeparatorThree;
		private System.Windows.Forms.ToolStripButton TestUnitsToolRemoveAll;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label lblStepProgress;
		private System.Windows.Forms.Label lblExecutionStatus;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.GroupBox grpEndInfo;
		private System.Windows.Forms.GroupBox grpEstimatesInfo;
		private System.Windows.Forms.GroupBox grpRunningInfo;
		private System.Windows.Forms.GroupBox grpStartInfo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblStartDateTime;
		private System.Windows.Forms.Label lblTimeElapsed;
		private System.Windows.Forms.Label lblAverageTimeperExecution;
		private System.Windows.Forms.Label lblAverageExecutionsperSecond;
		private System.Windows.Forms.Label lblCompletionDateTime;
		private System.Windows.Forms.Label lblEstimatedTimeToComplete;
		private System.Windows.Forms.Label lblEstimatedCompletionDateTime;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.ColumnHeader colStep;
		private System.Windows.Forms.ColumnHeader colCurrentForm;
		private System.Windows.Forms.ColumnHeader colTestUnit;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtEMailDisplayName;
        private System.Windows.Forms.ColumnHeader colExpectedTime;
		private System.Windows.Forms.TabControl ExecutionLogs;
		private System.Windows.Forms.FolderBrowserDialog SelectFileLogOuputPath;
		private System.Windows.Forms.OpenFileDialog LoadTestUnitsFile;
	}
}
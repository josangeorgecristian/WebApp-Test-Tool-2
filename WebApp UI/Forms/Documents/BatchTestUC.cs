using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMS.WebApp.UI.Interfaces;
using IMS.WebApp.Data.Documents.Interfaces;
using IMS.WebApp.Data;

namespace IMS.WebApp.UI.Forms.Documents
{
    public partial class BatchTestUC : UserControl, IDocument
    {
		#region FIELDS

			private string filename = "";
			private BatchTestConfiguration configuration;

			private bool wasSaved = false;
			private bool wasChanged = false;
			private bool constructionChange = false;

			private Engine.IEngine engine;

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Default constructor for BatchTest control document
			/// </summary>
			public BatchTestUC()
			{
				// Initialize the components - mandatory line for UI
				InitializeComponent();

				// Set default tab for main area
				MainArea.SelectedTab = GeneralPage;
				// Set default tab for configuration are
				ConfigurationArea.SelectedTab = ServerOptionsPage;
				// Set default tab for execution area
				switch (IMS.WebApp.Tools.Settings.Settings.DefaultExecutionTab)
				{
					case IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_LOG:
						ExecutionArea.SelectedTab = ExecutionLogPage;
						break;

					case IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_STATISTICS:
						ExecutionArea.SelectedTab = ExecutionStatisticsPage;
						break;
				}

				// Update the visual style for BatchTest document
				//UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

				// Start construction changes
				constructionChange = true;

				// Default BatchTest document configuration
				Configuration = new BatchTestConfiguration();

				// Stop construction changes
				constructionChange = false;
			}


		#endregion


		#region IDocument Members

			public bool CanRun
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			/// <summary>
			/// Gets or sets document configuration
			/// </summary>
			public IDocumentConfiguration Configuration
			{
				get
				{
					// General Settings Tab
					configuration.Name = txtBatchTestName.Text;
					configuration.Description = txtBatchTestDescription.Text;

					// Configuration -> Server Options Tab
					configuration.Url = txtServerAddress.Text;
					configuration.Username = txtUsername.Text;
					configuration.Password = txtPassword.Text;

					// Configuration -> Runtime Tab
					configuration.NumberOfExecutions = (int)nNumberOfExecutions.Value;
					configuration.NumberOfThreads = (int)nNumberOfThreads.Value;

					configuration.ExecutionDelay = (int)nExecutionDelay.Value;
					configuration.TestDelay = (int)nTestDelay.Value;
					configuration.TestExecutionDelay = (int)nTestExecutionDelay.Value;
					configuration.TestStepDelay = (int)nTestStepDelay.Value;

					configuration.OverrideTestExecutionDelay = chkOverrideTestExecutionDelay.Checked;
					configuration.OverrideTestStepDelay = chkOverrideTestStepDelay.Checked;

//					configuration.WarningBehavior = WarningBehavior;
//					configuration.ErrorBehavior = ErrorBehavior;

					configuration.ClearExecutionLog = chkClearExecutionLog.Checked;

					// Configuration -> Logging Tab
					configuration.EnableLogging = chkEnableLogging.Checked;
					configuration.LogOutputPath = txtLogOutputPath.Text;
					configuration.CreateSeparateLogFiles = chkCreateSepateLogs.Checked;

					// Configuration -> E-Mail Settings Tab
					configuration.EmailAddress = txtEMailAddress.Text;
					configuration.SendMailOnFailureOnly = chkSendOnFailureOnly.Checked;
					configuration.SendMailFromConsoleOnly = chkSendFromConsoleOnly.Checked;

					return configuration;
				}

				set
				{
					configuration = value as BatchTestConfiguration;

					// General Settings Tab
					txtBatchTestName.Text = configuration.Name;
					txtBatchTestDescription.Text = configuration.Description;

					// Configuration -> Server Options Tab
					txtServerAddress.Text = configuration.Url;
					txtUsername.Text = configuration.Username;
					txtPassword.Text = configuration.Password;

					// Configuration -> Runtime Tab
					nNumberOfExecutions.Value = configuration.NumberOfExecutions;
					nNumberOfThreads.Value = configuration.NumberOfThreads;

					nExecutionDelay.Value = configuration.ExecutionDelay;
					nTestDelay.Value = configuration.TestDelay;
					nTestExecutionDelay.Value = configuration.TestExecutionDelay;
					nTestStepDelay.Value = configuration.TestStepDelay;

					chkOverrideTestExecutionDelay.Checked = configuration.OverrideTestExecutionDelay;
					chkOverrideTestStepDelay.Checked = configuration.OverrideTestStepDelay;

//					WarningBehavior = configuration.WarningBehavior;
//					ErrorBehavior = configuration.ErrorBehavior;

					chkClearExecutionLog.Checked = configuration.ClearExecutionLog;

					// Configuration -> Logging Tab
					chkEnableLogging.Checked = configuration.EnableLogging;
					txtLogOutputPath.Text = configuration.LogOutputPath;
					chkCreateSepateLogs.Checked = configuration.CreateSeparateLogFiles;

					// Configuration -> E-Mail Settings Tab
					txtEMailAddress.Text = configuration.EmailAddress;
					chkSendOnFailureOnly.Checked = configuration.SendMailOnFailureOnly;
					chkSendFromConsoleOnly.Checked = configuration.SendMailFromConsoleOnly;
				}
			}

			public string FileName
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public bool IsRunning
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public string Title
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public bool WasChanged
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public bool WasSaved
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public event FileDelegates.FileChanged OnConfigurationChanged;
			public event DocumentDelegates.ExecutionStateChanged OnExecutionStateChanged;

			public void LoadFromFile(string filename)
			{
				throw new NotImplementedException();
			}

			public void Save()
			{
				throw new NotImplementedException();
			}

			public void SaveAs(string filename)
			{
				throw new NotImplementedException();
			}

			public void StartExecution()
			{
				throw new NotImplementedException();
			}

			public void StopExecution()
			{
				throw new NotImplementedException();
			}

			public void UpdateControlsState()
			{
				throw new NotImplementedException();
			}

		#endregion
	}
}

using System;
using System.ComponentModel;
using System.Windows.Forms;

using IMS.WebApp.Data;
using IMS.WebApp.Data.Documents.Interfaces;
using IMS.WebApp.Engine;


namespace IMS.WebApp.UI.Forms.Documents
{
	public partial class BatchTest : Form, /*Crownwood.DotNetMagic.Forms.DotNetMagicForm, */IMS.WebApp.UI.Interfaces.IDocument
	{
		#region FIELDS

			private string fileName = "";
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
			public BatchTest()
			{
				// Initialize the components - mandatory line for UI
				InitializeComponent();

				// Set default tab for main area
				MainArea.SelectedTab = GeneralPage;
				// Set default tab for configuration area
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

			/// <summary>
			/// Constructor for BatchTest control document
			/// Used to create a BatchTest document from a BatchTestConfiguration provided
			/// </summary>
			/// <param name="configuration">Provided BatchTest</param>
			public BatchTest(BatchTestConfiguration configuration, string filename)
			{
				// Initialize components - mandatory line for UI
				InitializeComponent();

				// Set the filename
				fileName = filename;

				// Set default tab for main area
				MainArea.SelectedTab = GeneralPage;
				// Set default tab for configuration area
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

				// Update BatchTest document configuration
				Configuration = configuration;

				// Mark the document as having been saved before
				wasSaved = true;

				// Stop construction changes
				constructionChange = false;
			}

		#endregion


		#region STATIC FUNCTIONS
		#endregion


		#region IDocument Members

			public event IMS.WebApp.UI.Interfaces.DocumentDelegates.ExecutionStateChanged OnExecutionStateChanged;

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

					configuration.WarningBehavior = WarningBehavior;
					configuration.ErrorBehavior = ErrorBehavior;

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

					WarningBehavior = configuration.WarningBehavior;
					ErrorBehavior = configuration.ErrorBehavior;

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

			/// <summary>
			/// Returns true if document can be executed, false otherwise
			/// </summary>
			public bool CanRun
			{
				get
				{
					BatchTestConfiguration configuration = Configuration as BatchTestConfiguration;

					return (!BackgroundExecution.IsBusy && configuration.BatchTestUnits != null && configuration.BatchTestUnits.Length > 0);
				}
			}

			/// <summary>
			/// Gets document execution state
			/// </summary>
			public bool IsRunning
			{
				get { return BackgroundExecution.IsBusy; }
			}

			/// <summary>
			/// Function used to update the visual style for a test document (Implementation from IDocument interface)
			/// </summary>
			/// <param name="style">The visual style which test document will adopt.</param>
            //public void UpdateVisualStyle(Crownwood.DotNetMagic.Common.VisualStyle style)
            //{
            //    Style = style;

            //    MainArea.Style = style;
            //    ConfigurationArea.Style = style;
            //    ExecutionArea.Style = style;
            //}

			/// <summary>
			/// 
			/// </summary>
			public void UpdateControlsState()
			{
			}

			public void StartExecution()
			{
				BackgroundExecution.RunWorkerAsync(null);
			}

			public void StopExecution()
			{
			}

		#endregion


		#region IFile Members

			public event IMS.WebApp.UI.Interfaces.FileDelegates.FileChanged OnConfigurationChanged;

			/// <summary>
			/// Indicates if document was changed since the last save
			/// </summary>
			public bool WasChanged
			{
				get { return wasChanged; }
			}

			/// <summary>
			/// Indicates if document was saved previously
			/// </summary>
			public bool WasSaved
			{
				get { return wasSaved; }
			}

			/// <summary>
			/// Gets document title
			/// </summary>
			public string Title
			{
				get
				{
					// Build document title string
					String title = txtBatchTestName.Text.Trim().Length == 0 ? "<Untitled>" : txtBatchTestName.Text;

					// Append " *" if document was changed since last save
					if (wasChanged)
					{
						title += " *";
					}

					// Return title string
					return title;
				}
			}

			/// <summary>
			/// Gets document file name
			/// Returns null if document 
			/// </summary>
			public string FileName
			{
				get { return fileName; }
			}

			/// <summary>
			/// Method used to save document configuration to file
			/// </summary>
			public void Save()
			{
				try
				{
					// Attempt to save document configuration to file
					BatchTestConfiguration.SaveToFile(FileName, Configuration as BatchTestConfiguration);
				}
				catch (Exception exception)
				{
					// Treat any exceptions that may occur at save
					MessageBox.Show(exception.Message, "File save error");
				}
			}

			/// <summary>
			/// Method used to save document configuration to new file
			/// </summary>
			/// <param name="filename">File name where document configuration will be saved</param>
			public void SaveAs(string filename)
			{
				try
				{
					// ATTENTION - Keep this order in code: first attempt to save the file, after update the title
					// Otherwise, if save operation fails, we will have a wrong filename associated with document

					// Attempt to save document configuration to file
					BatchTestConfiguration.SaveToFile(filename, Configuration as BatchTestConfiguration);

					// Update file name where document configuration is saved
					this.fileName = filename;
				}
				catch (Exception exception)
				{
					// Treat any exceptions that my occur at save
					MessageBox.Show(exception.Message, "File save error");
				}
			}

			/// <summary>
			/// Method used to load document configuration from file
			/// </summary>
			/// <param name="filename">File name from where to load document configuration</param>
			void IMS.WebApp.UI.Interfaces.IFile.LoadFromFile(string filename)
			{
				try
				{
					// Load configuration from file
					Configuration = BatchTestConfiguration.LoadFromFile(filename);

					// Mark document as saved
					wasSaved = true;

					// Mark document as not changed (since last save)
					wasChanged = false;


					// Update filename where document configuration was changed
					this.fileName = filename;
				}
				catch (Exception exception)
				{
					// Treat any exceptions that my occur
					MessageBox.Show(exception.Message, "File save error");
				}
			}

		#endregion


		#region GETTER / SETTER

			/// <summary>
			/// 
			/// </summary>
			private BatchTestBehaviourOnWarningError WarningBehavior
			{
				get
				{
					if (rOnWarningContinue.Checked)
						return BatchTestBehaviourOnWarningError.CONTINUE;

					if (rOnWarningExecuteNext.Checked)
						return BatchTestBehaviourOnWarningError.EXECUTENEXT;

					if (rOnWarningStopCurrent.Checked)
						return BatchTestBehaviourOnWarningError.STOPCURRENT;

					if (rOnWarningStopAll.Checked)
						return BatchTestBehaviourOnWarningError.STOPALL;

					if (rOnWarningUserDefined.Checked)
						return BatchTestBehaviourOnWarningError.USERDEFINED;

					return BatchTestBehaviourOnWarningError.CONTINUE;
				}

				set
				{
					switch (value)
					{
						case BatchTestBehaviourOnWarningError.CONTINUE:
							rOnWarningContinue.Checked = true;
							break;

						case BatchTestBehaviourOnWarningError.EXECUTENEXT:
							rOnWarningExecuteNext.Checked = true;
							break;

						case BatchTestBehaviourOnWarningError.STOPCURRENT:
							rOnWarningStopCurrent.Checked = true;
							break;

						case BatchTestBehaviourOnWarningError.STOPALL:
							rOnWarningStopAll.Checked = true;
							break;

						case BatchTestBehaviourOnWarningError.USERDEFINED:
							rOnWarningUserDefined.Checked = true;
							break;

						default:
							rOnWarningContinue.Checked = true;
							break;
					}
				}
			}

			/// <summary>
			/// 
			/// </summary>
			private BatchTestBehaviourOnWarningError ErrorBehavior
			{
				get
				{
					if (rOnErrorContinue.Checked)
						return BatchTestBehaviourOnWarningError.CONTINUE;

					if (rOnErrorExecuteNext.Checked)
						return BatchTestBehaviourOnWarningError.EXECUTENEXT;

					if (rOnErrorStopCurrent.Checked)
						return BatchTestBehaviourOnWarningError.STOPCURRENT;

					if (rOnErrorStopAll.Checked)
						return BatchTestBehaviourOnWarningError.STOPALL;

					if (rOnErrorUserDefined.Checked)
						return BatchTestBehaviourOnWarningError.USERDEFINED;

					return BatchTestBehaviourOnWarningError.STOPALL;
				}

				set
				{
					switch (value)
					{
						case BatchTestBehaviourOnWarningError.CONTINUE:
							rOnErrorContinue.Checked = true;
							break;

						case BatchTestBehaviourOnWarningError.EXECUTENEXT:
							rOnErrorExecuteNext.Checked = true;
							break;

						case BatchTestBehaviourOnWarningError.STOPCURRENT:
							rOnErrorStopCurrent.Checked = true;
							break;

						case BatchTestBehaviourOnWarningError.STOPALL:
							rOnErrorStopAll.Checked = true;
							break;

						case BatchTestBehaviourOnWarningError.USERDEFINED:
							rOnErrorUserDefined.Checked = true;
							break;

						default:
							rOnErrorStopAll.Checked = true;
							break;
					}
				}
			}

		#endregion


		#region EVENTS

			/// <summary>
			/// 
			/// </summary>
			private void OnNameChanged(object sender, EventArgs e)
			{
				FireConfigurationChanged();
			}

		#endregion


		#region METHODS

			/// <summary>
			/// Method used to trigger OnConfigurationChanged event
			/// </summary>
			private void FireConfigurationChanged()
			{
				// Exclude changes that occur at construction time
				if (constructionChange)
					return;

				// Mark document as changed since last save
				wasChanged = true;

				// Trigger OnConfigurationChanged event
				if (OnConfigurationChanged != null)
					OnConfigurationChanged();
			}
		
		#endregion




		#region BACKGROUND EXECUTION

			private void StartExecution(object sender, DoWorkEventArgs e)
			{
				engine = Engine.EngineFactory.Instance.CreateEngine();

				SubscribeToEngineEvents(engine);

			}

			private void StopExecution(object sender, RunWorkerCompletedEventArgs e)
			{
				UnsubscribeToEngineEvents(engine);
			}


			private void ExecutionProgressReport(object sender, ProgressChangedEventArgs e)
			{
				ListViewItem item = this.executionResults.Items.Add(new ListViewItem(e.UserState.ToString()));
				item.SubItems.Add(e.UserState.ToString());
				item.EnsureVisible();

				Application.DoEvents();
			}

			#region ENGINE EVENTS

				private void SubscribeToEngineEvents(IMS.WebApp.Engine.IEngine engine)
				{
					engine.OnInformationUpdate += new IMS.WebApp.Engine.EngineDelegates.Information(EngineBatchInformationUpdate);
				}

				private void UnsubscribeToEngineEvents(IMS.WebApp.Engine.IEngine engine)
				{
					engine.OnInformationUpdate -= new IMS.WebApp.Engine.EngineDelegates.Information(EngineBatchInformationUpdate);
				}

				void EngineBatchInformationUpdate(int percentage, IMS.WebApp.Engine.EngineExecutionProgressReport progressReport)
				{
					BackgroundExecution.ReportProgress(percentage, progressReport);
				}

			#endregion

				private void txtServerAddress_TextChanged(object sender, EventArgs e)
				{

				}

		#endregion


	}
}

using System;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using IMS.WebApp.Data;
using IMS.WebApp.Data.Documents.Interfaces;
using IMS.WebApp.Data.Units;
using IMS.WebApp.Engine;
using IMS.WebApp.UI.Forms.Tools;


namespace IMS.WebApp.UI.Forms.Documents
{
	public partial class Test : Form, /*Crownwood.DotNetMagic.Forms.DotNetMagicForm,*/ IMS.WebApp.UI.Interfaces.IDocument
	{
		#region FIELDS

			private string fileName = "";
			private TestConfiguration configuration;

			private bool wasSaved = false;
			private bool wasChanged = false;
			private bool constructionChange = false;
			private bool busyResizing = false;

			private Engine.IEngine engine;

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Default constructor for Test control document
			/// </summary>
			public Test()
			{
				// Initialize the components - mandatory line for UI
				InitializeComponent();

				// Create test units groups
				TestUnitsList.Groups.Add("TestUnits", "Test Units");

				// Set default tab for main area
				MainArea.SelectedTab = GeneralPage;
				// Set default tab for configuration area
				ConfigurationArea.SelectedTab = ServerOptionsPage;
				// Set default tab for execution area
				switch (IMS.WebApp.Tools.Settings.Settings.DefaultExecutionTab)
				{
					case IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_LOG:
						ExecutionArea.SelectedTab = ExecutionLogsPage;
						break;

					case IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_STATISTICS:
						ExecutionArea.SelectedTab = ExecutionStatisticsPage;
						break;
				}

				// Update the visual style for Test document
                //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

				// Start construction changes
				constructionChange = true;

				// Default Test document configuration
				Configuration = new TestConfiguration();

				// Stop construction changes
				constructionChange = false;
			}


			/// <summary>
			/// Constructor for Test control document
			/// Used to create a Test document from a TestConfiguration provided
			/// </summary>
			/// <param name="configuration">Provided TestConfiguration</param>
			public Test(TestConfiguration configuration, string filename)
			{
				// Initialize the components - mandatory line for UI
				InitializeComponent();

				// Set filename
				fileName = filename;

				// Create test units groups
				TestUnitsList.Groups.Add("TestUnits", "Test Units");

				// Set default tab for main area
				MainArea.SelectedTab = GeneralPage;
				// Set default tab for configuration area
				ConfigurationArea.SelectedTab = ServerOptionsPage;
				// Set default tab for execution area
				switch (IMS.WebApp.Tools.Settings.Settings.DefaultExecutionTab)
				{
					case IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_LOG:
						ExecutionArea.SelectedTab = ExecutionLogsPage;
						break;

					case IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_STATISTICS:
						ExecutionArea.SelectedTab = ExecutionStatisticsPage;
						break;
				}

				// Update the visual style for Test document
                //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

				// Start construction changes
				constructionChange = true;

				// Update Test document configuration
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
					configuration.Name = txtTestName.Text;
					configuration.Description = txtTestDescription.Text;

					// Configuration -> Server Options Tab
					configuration.Url		= txtServerAddress.Text;
					configuration.Username	= txtUsername.Text;
					configuration.Password	= txtPassword.Text;

					// Configuration -> Runtime Settings Tab
					configuration.NumberOfExecutions	= (int)nNumberOfExecutions.Value;
					configuration.NumberOfThreads		= (int)nNumberOfThreads.Value;
					configuration.ExecutionCounterStart	= (int)nCounterStart.Value;
					configuration.ExecutionDelay		= (int)nExecutionDelay.Value;
					configuration.StepDelay				= (int)nStepDelay.Value;
					configuration.WarningBehavior		= WarningBehaviour;
					configuration.ErrorBehavior			= ErrorBehaviour;
					configuration.ClearExecutionLog		= chkClearExecutionLog.Checked;

					// Configuration -> Data Source Settings Tab
					configuration.UseDataFile	= chkUseDataFiles.Checked;
					configuration.DataFileName	= txtDataSourceFilePath.Text;
					configuration.FileType		= DataSourceFileType;

					// Configuration -> Logging Settings Tab
					configuration.EnableLogging				= chkEnableLogging.Checked;
					configuration.LogOutputPath				= txtLogOutputPath.Text;
					configuration.CreateSeparateLogFiles	= chkCreateSepateLogs.Checked;

					// Configuration -> E-Mail Settings Tab
					configuration.EmailAddress				= txtEMailAddress.Text;
					configuration.SendMailOnFailureOnly		= chkSendOnFailureOnly.Checked;
					configuration.SendMailFromConsoleOnly	= chkSendFromConsoleOnly.Checked;

					// Test Units Tab
					configuration.TestUnits = GetTestUnits();

					return configuration;
				}

				set
				{
					configuration = value as TestConfiguration;

					// General Settings Tab
					txtTestName.Text		= configuration.Name;
					txtTestDescription.Text = configuration.Description;

					// Configuration -> Server Address Settings Tab
					txtServerAddress.Text	= configuration.Url;
					txtUsername.Text		= configuration.Username;
					txtPassword.Text		= configuration.Password;

					// Configuration -> Runtime Settings Tab
					nNumberOfExecutions.Value	= configuration.NumberOfExecutions;
					nNumberOfThreads.Value		= configuration.NumberOfThreads;
					nCounterStart.Value			= configuration.ExecutionCounterStart;
					nExecutionDelay.Value		= configuration.ExecutionDelay;
					nStepDelay.Value			= configuration.StepDelay;
					WarningBehaviour			= configuration.WarningBehavior;
					ErrorBehaviour				= configuration.ErrorBehavior;

					chkClearExecutionLog.Checked = configuration.ClearExecutionLog;

					// Configuration -> Data Source Settings Tab
					chkUseDataFiles.Checked		= configuration.UseDataFile;
					txtDataSourceFilePath.Text	= configuration.DataFileName;
					DataSourceFileType			= configuration.FileType;

					// Configuration -> Logging Settings Tab
					chkEnableLogging.Checked	= configuration.EnableLogging;
					txtLogOutputPath.Text		= configuration.LogOutputPath;
					chkCreateSepateLogs.Checked	= configuration.CreateSeparateLogFiles;

					// Configuration -> E-Mail Settings Tab
					txtEMailAddress.Text			= configuration.EmailAddress;
					chkSendOnFailureOnly.Checked	= configuration.SendMailOnFailureOnly;
					chkSendFromConsoleOnly.Checked	= configuration.SendMailFromConsoleOnly;

					// Test Units Tab
					SetTestUnits(configuration.TestUnits);
				}
			}


			/// <summary>
			/// Returns true if document can be executed, false otherwise
			/// </summary>
			public bool CanRun
			{
				get
				{
					TestConfiguration configuration = Configuration as TestConfiguration;

					return (!BackgroundExecution.IsBusy && configuration.TestUnits != null && configuration.TestUnits.Length > 0);
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
			/// Method used to update the visual style for a test document (Implementation from IDocument interface)
			/// </summary>
			/// <param name="style">The visual style which test document will adopt.</param>
            //public void UpdateVisualStyle(Crownwood.DotNetMagic.Common.VisualStyle style)
            //{
            //    Style					= style;
            //    MainArea.Style			= style;
            //    ConfigurationArea.Style	= style;
            //    ExecutionArea.Style		= style;


            //    #region Set toolbar items display style

            //        // Get the toolbar buttons display style
            //        ToolStripItemDisplayStyle displayStyle = IMS.WebApp.Tools.Settings.Settings.ToolbarAppearance;

            //        // Apply visual style to each button from Test Unit
            //        foreach (ToolStripItem item in TestUnitsToolbar.Items)
            //        {
            //            item.DisplayStyle = IMS.WebApp.Tools.Settings.Settings.ApplyToDocumentsToolbar ? displayStyle : ToolStripItemDisplayStyle.Image;
            //        }

            //    #endregion
            //}


			/// <summary>
			/// Method used to update the state of controls, menu option, toolbar buttons
			/// </summary>
			public void UpdateControlsState()
			{
				#region Configuration -> Runtime Tab

					// Read 'Use Multiple Threads' setting from registry
					bool useThreads = IMS.WebApp.Tools.Settings.Settings.UseMultipleThreads;

					// Update multiple threaded execution controls
					labelNumberOfThreads.Enabled	= useThreads;
					nNumberOfThreads.Enabled		= useThreads;
					labelThreads.Enabled			= useThreads;

				#endregion


				#region Configuration -> Data Source Tab

					// Update data source controls
					labelDataFileName.Enabled		= chkUseDataFiles.Checked;
					txtDataSourceFilePath.Enabled	= chkUseDataFiles.Checked;
					bBrowse.Enabled					= chkUseDataFiles.Checked;
					labelDataFileType.Enabled		= chkUseDataFiles.Checked;
					rExcelFile.Enabled				= chkUseDataFiles.Checked;
					rXMLFile.Enabled				= chkUseDataFiles.Checked;

				#endregion


				#region Configuration -> Logging Tab

					// Update log controls
					labelLogOutputPath.Enabled		= chkEnableLogging.Checked;
					txtLogOutputPath.Enabled		= chkEnableLogging.Checked;
					bSelectLogOutputFolder.Enabled	= chkEnableLogging.Checked;
					chkCreateSepateLogs.Enabled		= chkEnableLogging.Checked;

				#endregion


				#region Test Units List - Toolbar buttons & Context menu options

					// Update test list tool buttons state
					TestUnitsToolInsertFromText.Enabled		= TestUnitsList.SelectedItems.Count > 0;
					TestUnitsToolEditTestUnit.Enabled		= TestUnitsList.SelectedItems.Count == 1;
					TestUnitsToolInsertTestUnit.Enabled		= TestUnitsList.SelectedItems.Count > 0;
					TestUnitsToolRemoveTestUnits.Enabled	= TestUnitsList.SelectedItems.Count > 0;
					TestUnitsToolRemoveAll.Enabled			= TestUnitsList.Items.Count > 0;

					// Update context menu options state
					TestUnitContextMenuInsertFromText.Visible	= TestUnitsList.SelectedItems.Count > 0;
					TestUnitContextMenuEditTestUnit.Visible		= TestUnitsList.SelectedItems.Count == 1;
					TestUnitContextMenuInsertTestUnit.Visible	= TestUnitsList.SelectedItems.Count > 0;
					TestUnitContextMenuRemoveTestUnit.Visible	= TestUnitsList.SelectedItems.Count > 0;
					TestUnitContextMenuRemoveAll.Visible		= TestUnitsList.Items.Count > 0;

				#endregion
			}


			/// <summary>
			/// Method used for starting document execution
			/// </summary>
			public void StartExecution()
			{
				// Clear previous execution logs and statistics
				ClearPreviousExecution();

				// Start background execution
				BackgroundExecution.RunWorkerAsync(Configuration);

				// Trigger document execution state changed
				FireExecutionStateChanged();

				// Change to Execution tab
				MainArea.SelectedTab = ExecutionPage;
				ExecutionArea.SelectedTab = IMS.WebApp.Tools.Settings.Settings.DefaultExecutionTab == IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_LOG ? ExecutionLogsPage : ExecutionStatisticsPage;
			}

			/// <summary>
			/// Method used for stopping document execution on user request
			/// </summary>
			public void StopExecution()
			{
				if (engine != null)	engine.Stop();
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
					String title = txtTestName.Text.Trim().Length == 0 ? "<Untitled>" : txtTestName.Text;

					// Append '*' if document was modified since last save
					if (wasChanged)	title += " *";

					// Return title string
					return title;
				}
			}

			/// <summary>
			/// Gets document file name.
			/// Returns null if the document is not saved.
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
					TestConfiguration.SaveToFile(FileName, Configuration as TestConfiguration);

					// Mark document as saved
					wasSaved = true;

					// Mark document as not changed since last save
					wasChanged = false;

					// Fire configuration changed
					FireConfigurationChanged();
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
					TestConfiguration.SaveToFile(filename, Configuration as TestConfiguration);

					// Update file name where document configuration is saved
					this.fileName = filename;

					// Mark document as saved
					wasSaved = true;

					// Mark document as not changed since last save
					wasChanged = false;

					// Fire configuration changed
					FireConfigurationChanged();
				}
				catch (Exception exception)
				{
					// Treat any exceptions that may occur at save
					MessageBox.Show(exception.Message, "File save error");
				}
			}

			/// <summary>
			/// Method used to load document configuration from file
			/// </summary>
			/// <param name="filename">File name from where to load document configuration</param>
			public void LoadFromFile(string filename)
			{
				try
				{
					// Load configuration from file
					Configuration = TestConfiguration.LoadFromFile(filename);

					// Mark document as saved
					wasSaved = true;

					// Mark document as not changed (since last save)
					wasChanged = false;
					

					// Update file name where document configuration is saved
					this.fileName = filename;
				}
				catch (Exception exception)
				{
					// Treat any exceptions that may occur at load
					MessageBox.Show(exception.Message, "File loading error");
				}
			}

		#endregion


		#region GETTER \ SETTER

			/// <summary>
			/// 
			/// </summary>
			private TestBehaviourOnWarningError WarningBehaviour
			{
				get
				{
					if (rOnWarningContinue.Checked)
						return TestBehaviourOnWarningError.CONTINUE;

					if (rOnWarningStopCurrent.Checked)
						return TestBehaviourOnWarningError.STOPCURRENT;

					if (rOnWarningStopAll.Checked)
						return TestBehaviourOnWarningError.STOPALL;

					return TestBehaviourOnWarningError.STOPALL;
				}

				set
				{
					switch (value)
					{
						case TestBehaviourOnWarningError.CONTINUE:
							rOnWarningContinue.Checked = true;
							break;

						case TestBehaviourOnWarningError.STOPCURRENT:
							rOnWarningStopCurrent.Checked = true;
							break;

						case TestBehaviourOnWarningError.STOPALL:
							rOnWarningStopAll.Checked = true;
							break;
					}
				}
			}

			/// <summary>
			/// 
			/// </summary>
			private TestBehaviourOnWarningError ErrorBehaviour
			{
				get
				{
					if (rOnErrorContinue.Checked)
						return TestBehaviourOnWarningError.CONTINUE;

					if (rOnErrorStopCurrent.Checked)
						return TestBehaviourOnWarningError.STOPCURRENT;

					if (rOnErrorsStopAll.Checked)
						return TestBehaviourOnWarningError.STOPALL;

					return TestBehaviourOnWarningError.STOPALL;
				}

				set
				{
					switch (value)
					{
						case TestBehaviourOnWarningError.CONTINUE:
							rOnErrorContinue.Checked = true;
							break;

						case TestBehaviourOnWarningError.STOPCURRENT:
							rOnErrorStopCurrent.Checked = true;
							break;

						case TestBehaviourOnWarningError.STOPALL:
							rOnErrorsStopAll.Checked = true;
							break;
					}
				}
			}

			/// <summary>
			/// 
			/// </summary>
			private DataFileType DataSourceFileType
			{
				get
				{
					if (rExcelFile.Checked)
						return DataFileType.EXCEL;

					if (rXMLFile.Checked)
						return DataFileType.XML;

					return DataFileType.XML;
				}

				set
				{
					switch (value)
					{
						case DataFileType.EXCEL:
							rExcelFile.Checked = true;
							break;

						case DataFileType.XML:
							rXMLFile.Checked = true;
							break;
					}
				}
			}

		#endregion


		#region EVENTS

			/// <summary>
			/// Event handler for controls value changes
			/// Will notify about document changes
			/// </summary>
			private void OnTestConfigurationChanged(object sender, EventArgs e)
			{
				// Exclude changes that occur at construction time
				if (constructionChange)
					return;

				// Mark document as changed since last save
				wasChanged = true;

				// Trigger OnConfigurationChangeEvent in application
				FireConfigurationChanged();
			}


			/// <summary>
			/// Event handler for selecting a data source file
			/// </summary>
			private void DataSourceFileBrowse(object sender, EventArgs e)
			{
				// Set default extension
				switch (DataSourceFileType)
				{
					case DataFileType.XML:
						SelectFileDataSource.FilterIndex = 2;
						break;

					case DataFileType.EXCEL:
						SelectFileDataSource.FilterIndex = 3;
						break;

					default:
						SelectFileDataSource.FilterIndex = 1;	// by default select "All files" filter
						break;
				}

				// If the user chooses a file - display the file name (with path)
				if (SelectFileDataSource.ShowDialog() == DialogResult.OK)
				{
					txtDataSourceFilePath.Text = SelectFileDataSource.FileName;

					// Trigger configuration chagend event
					FireConfigurationChanged();
				}
			}


			/// <summary>
			/// Event handler for selecting log file output path
			/// </summary>
			private void LogFileOutputPathChoose(object sender, EventArgs e)
			{
				// If the user choses a directory - display the path
				if (SelectFileLogOuputPath.ShowDialog() == DialogResult.OK)
				{
					txtLogOutputPath.Text = SelectFileLogOuputPath.SelectedPath;

					// Trigger configuration changed event
					FireConfigurationChanged();
				}
			}


			private void TestUnitsListResize(object sender, EventArgs e)
			{
				ResizeTestUnitsLastColumn();
			}

			private void TestUnitsListColumnResize(object sender, ColumnWidthChangedEventArgs e)
			{
				ResizeTestUnitsLastColumn();
			}

			private void TestUnitListSelectionChanged(object sender, EventArgs e)
			{
				UpdateControlsState();
			}

			private void TestUnitsListDoubleClick(object sender, EventArgs e)
			{
				EditSelectedItem();
			}

			private void TestUnitsLoad(object sender, EventArgs e)
			{
				if (LoadTestUnitsFile.ShowDialog() == DialogResult.OK)
				{
					try
					{
						SetTestUnits(IMS.WebApp.Data.Units.Tools.TestUnitLoader.LoadFromFile(LoadTestUnitsFile.FileName));
						wasChanged = true;
						FireConfigurationChanged();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}

			private void TestUnitsLoadFromText(object sender, EventArgs e)
			{
				AddTestUnitsFromText(false);
			}

			private void TestUnitsInsertFromText(object sender, EventArgs e)
			{
				AddTestUnitsFromText(true);
			}

			private void TestUnitsExportToText(object sender, EventArgs e)
			{
				ExportTestUnitsToText(TestUnitsList.SelectedItems.Count != 0);
				 
			}

			private void TestUnitsAddTestUnit(object sender, EventArgs e)
			{
				AddNewItem();
			}

			private void TestUnitsEditTestUnit(object sender, EventArgs e)
			{
				EditSelectedItem();
			}

			private void TestUnitsInsertTestUnit(object sender, EventArgs e)
			{
				InsertNewItem();
			}

			private void TestUnitsRemoveTestUnits(object sender, EventArgs e)
			{
				RemoveSelectedItems();
			}

			private void TestUnitsRemoveAll(object sender, EventArgs e)
			{
				RemoveAllItems();
			}

		#endregion


		#region METHODS

			/// <summary>
			/// Method used to trigger OnConfigurationChanged event
			/// </summary>
			private void FireConfigurationChanged()
			{
				// Trigger OnConfigurationChanged event
				if (OnConfigurationChanged != null)
					OnConfigurationChanged();
			}


			/// <summary>
			/// Method used to trigger OnExecutionStateChange event
			/// </summary>
			private void FireExecutionStateChanged()
			{
				// Trigger OnExecutionStateChanged event
				if (OnExecutionStateChanged != null)
					OnExecutionStateChanged();
			}


			/// <summary>
			/// Methos used for adding / inserting test units from a string
			/// </summary>
			/// <param name="insert">Boolean paramter used to switch between adding or inserting mode</param>
			private void AddTestUnitsFromText(bool insert)
			{
				TextEditor editor = new TextEditor();

				if (editor.ShowDialog() == DialogResult.OK)
				{
					AddTestUnits(IMS.WebApp.Data.Units.Tools.TestUnitLoader.LoadFromText(editor.String), insert);

					wasChanged = true;

					FireConfigurationChanged();
				}
			}


			/// <summary>
			/// Method used for exporting document test units string value
			/// </summary>
			/// <param name="selecteItems">Boolean paramter to determine if only selected units are to be exported</param>
			private void ExportTestUnitsToText(bool selecteItems)
			{
				new TextEditor(GetTestUnitsString(selecteItems)).ShowDialog();
			}


			/// <summary>
			/// Method used to transform document test units into one string
			/// </summary>
			/// <returns>String value of document test units</returns>
			private string GetTestUnitsString(bool selectedOnly)
			{
				// Get document test units
				TestUnit[] units = selectedOnly ? GetSelectedTestUnits() : GetTestUnits();

				// Create a string builder to use for building string vaue
				StringBuilder value = new StringBuilder();

				// Iterate through document test unit collection
				foreach (TestUnit unit in units)
				{
					// Append request and response from each unit and separate them with dashes
					value.AppendLine(unit.Request);
					value.AppendLine("-----------------------------------------------------------------------------------------------");
					value.AppendLine(unit.Response);
					value.AppendLine("-----------------------------------------------------------------------------------------------");
				}

				// Return document test units string
				return value.ToString();
			}

		
			/// <summary>
			/// Method used to retrieve test units
			/// </summary>
			/// <returns>TestUnit array</returns>
			private TestUnit[] GetTestUnits()
			{
				// Create TestUnit array
				TestUnit[] TestUnitsCollection = new TestUnit[TestUnitsList.Items.Count];

				// Set index to 0
				int index = 0;

				// Iterate all items in Test Units List
				foreach (ListViewItem item in TestUnitsList.Items)
				{
					// Assign each item tag (of TestUnit type) to a test unit collection
					// Also increment the index
					TestUnitsCollection[index++] = item.Tag as TestUnit;
				}

				// Return test unit collection
				return TestUnitsCollection;
			}


			/// <summary>
			/// Method used to retrieve selected test units
			/// </summary>
			/// <returns>TestUnit array</returns>
			private TestUnit[] GetSelectedTestUnits()
			{
				// Create TestUnit array
				TestUnit[] TestUnitsCollection = new TestUnit[TestUnitsList.SelectedItems.Count];

				// Set index to 0
				int index = 0;

				// Iterate all selected items in TestUnits List
				foreach (ListViewItem item in TestUnitsList.SelectedItems)
				{
					// Assign each item tag (of TestUnit type) to a test unit collection
					// Also increment the index afterwards
					TestUnitsCollection[index++] = item.Tag as TestUnit;
				}

				// Return test unit collection
				return TestUnitsCollection;
			}


			/// <summary>
			/// Method used to populate test units to document control
			/// </summary>
			/// <param name="testUnits">Array containing test units</param>
			private void SetTestUnits(TestUnit[] testUnits)
			{
				// Clear test units
				TestUnitsList.Items.Clear();

				// Exit the function if test units array is null
				if (testUnits == null)
					return;


				// Iterate test units array
				foreach (TestUnit unit in testUnits)
				{
					// Add each test unit to TestUnitsList grid
					AddTestUnit(unit);
				}

				// Call function to update step and current form
				UpdateTestUnitItemSteps();
			}


			/// <summary>
			/// Method used to insert test units into document control
			/// </summary>
			/// <param name="units">Array containing test units</param>
			private void AddTestUnits(TestUnit[] units, bool insert)
			{
				// In case we are only adding items instead of inserting use this execution
				if (!insert)
				{
					// Add each test unit at the end
					foreach (TestUnit testUnit in units)
					{
						AddTestUnit(testUnit);
					}

					// Call function to update step and current form
					UpdateTestUnitItemSteps();

					// Terminate method execution here
					// Rest of the code is executed when inserting test units
					return;
				}

				// Test for selected items
				if (TestUnitsList.SelectedItems.Count == 0)
					return;

				// Get the last selected item index
				int index = TestUnitsList.SelectedItems[0].Index;

				foreach (ListViewItem item in TestUnitsList.SelectedItems)
				{
					index = index < item.Index ? item.Index : index;
				}


				// Add each test unit after the selected item
				foreach (TestUnit testUnit in units)
				{
					InsertTestUnit(testUnit, ++index);
				}

				// Call function to update step and current form
				UpdateTestUnitItemSteps();
			}

			/// <summary>
			/// Function used to add test unit to document test unit list
			/// </summary>
			/// <param name="unit">Test Unit to be added to test unit list</param>
			private void AddTestUnit(TestUnit unit)
			{
				// Exit the function if test unit parameter is null
				if (unit == null)
					return;

				// Create ListViewItem with display data from test unit in TestUnits list
				ListViewItem item = TestUnitsList.Items.Add("", unit.ExpectedResponseType.GetHashCode());

				// Create test unit subitems (display columns)
				CreateTestUnitSubItems(unit, item);
			}


			/// <summary>
			/// Method used to insert test unit to document test unit list at specified index
			/// </summary>
			/// <param name="unit"></param>
			/// <param name="index"></param>
			private void InsertTestUnit(TestUnit unit, int index)
			{
				// Exit the function if test unit parameter is null
				if (unit == null)
					return;

				// Create or insert ListViewItem with display data from test unit in TestUnits list
				ListViewItem item = TestUnitsList.Items.Insert(index, "", unit.ExpectedResponseType.GetHashCode());

				// Create test unit subitems (display columns)
				CreateTestUnitSubItems(unit, item);
			}


			/// <summary>
			/// 
			/// </summary>
			/// <param name="unit"></param>
			/// <param name="item"></param>
			private void CreateTestUnitSubItems(TestUnit unit, ListViewItem item)
			{
				// Add sub items (display values for the rest of the columns) and assign keys to subitems
				ListViewItem.ListViewSubItem subItem = item.SubItems.Add(unit.ExpectedProcessingTime.ToString() + " ms");
				subItem.Name = "ExpectedProcessingTime";

				subItem = item.SubItems.Add(unit.CurrentForm);
				subItem.Name = "CurrentForm";

				subItem = item.SubItems.Add(unit.RequestDescription);
				subItem.Name = "RequestDescription";

				// Set item group
				item.Group = TestUnitsList.Groups["TestUnits"];

				// Set item value to test unit
				item.Tag = unit;
			}

		
			/// <summary>
			/// 
			/// </summary>
			private void AddNewItem()
			{
				// Create Test Unit Editor & show it modally
				TestUnitEditor unitEditor = new TestUnitEditor();

				if (unitEditor.ShowDialog() == DialogResult.OK)
				{
					TestUnit unit = unitEditor.TestUnit;

					// Create ListViewItem with display data from test unit in TestUnits list
					ListViewItem item = TestUnitsList.Items.Add("", unit.ExpectedResponseType.GetHashCode());

					// Create test unit subitems (display columns)
					CreateTestUnitSubItems(unit, item);

					// Call function to update step and current form
					UpdateTestUnitItemSteps();

					// Mark configuration as changed
					wasChanged = true;

					// Trigger delegate event for configuration changed
					FireConfigurationChanged();
				}
			}


			/// <summary>
			/// 
			/// </summary>
			private void InsertNewItem()
			{
				// Get last selected index
				int index = TestUnitsList.SelectedIndices[TestUnitsList.SelectedIndices.Count - 1] + 1;

				// Create Test Unit Editor & show it modally
				TestUnitEditor unitEditor = new TestUnitEditor();

				if (unitEditor.ShowDialog() == DialogResult.OK)
				{
					TestUnit unit = unitEditor.TestUnit;

					// Create ListViewItem with display data from test unit in TestUnits list
					ListViewItem item = TestUnitsList.Items.Insert(index, "", unit.ExpectedResponseType.GetHashCode());
						
					// Create test unit subitems (display columns)
					CreateTestUnitSubItems(unit, item);
					
					// Call function to update step and current form
					UpdateTestUnitItemSteps();

					// Mark configuration as changed
					wasChanged = true;

					// Trigger delegate event for configuration changed
					FireConfigurationChanged();
				}
			}


			/// <summary>
			/// Function used to edit a test unit from list
			/// </summary>
			private void EditSelectedItem()
			{
				// Exit function if more than one item is selected (or none)
				if (TestUnitsList.SelectedItems.Count != 1)
					return;

				// Get selected item tag as a test unit
				ListViewItem selectedItem = TestUnitsList.SelectedItems[0];
				TestUnit unit = selectedItem.Tag as TestUnit;

				// Create Test Unit Editor tool & show it modally
				TestUnitEditor unitEditor = new TestUnitEditor(unit);

				if (unitEditor.ShowDialog() == DialogResult.OK)
				{
					// In case the user accepts changes
					// Update the unit
					unit = unitEditor.TestUnit;							

					// Update item value
					selectedItem.Tag = unit;

					// Update sub items
					selectedItem.SubItems["ExpectedProcessingTime"].Text = unit.ExpectedProcessingTime.ToString() + " ms";
					selectedItem.SubItems["RequestDescription"].Text = unit.RequestDescription;

					// Call function to update step and current form
					UpdateTestUnitItemSteps();

					// Mark configuration as changed
					wasChanged = true;

					// Trigger delegate event for configuration changed
					FireConfigurationChanged();
				}
			}


			/// <summary>
			/// 
			/// </summary>
			private void RemoveSelectedItems()
			{
				// Iterate through selected items collection
				foreach (ListViewItem item in TestUnitsList.SelectedItems)
				{
					// Remove each item from Test Units List
					TestUnitsList.Items.Remove(item);
				}

				// Call function to update step and current form
				UpdateTestUnitItemSteps();

				// Mark configuration as changed
				wasChanged = true;

				// Trigger delegate event for configuration changed
				FireConfigurationChanged();
			}


			/// <summary>
			/// 
			/// </summary>
			private void RemoveAllItems()
			{
				if (MessageBox.Show("Do you want to clear all tests?", "Clear All", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					// Remove all test units
					TestUnitsList.Items.Clear();

					// Call function to update step and current form (called mostly for updating tab page title and status bar)
					UpdateTestUnitItemSteps();

					// Mark configuration as changed
					wasChanged = true;

					// Trigger delegate event for configuration changed
					FireConfigurationChanged();
				}
			}


			/// <summary>
			/// Function used to populate step number and current form value
			/// </summary>
			private void UpdateTestUnitItemSteps()
			{
				// Set initial index and current form value to temporary variables
				int index = 0;
				string currentForm = "N/A";


				// Iterate items in collection and update step and current form value
				foreach (ListViewItem item in TestUnitsList.Items)
				{
					// Update the step value and current form
					// When updating a sub item get - retrieve it by using a string key
					// to avoid bugs if modifications to TestUnitsList occur
					item.Text							= (++index).ToString();
					item.SubItems["CurrentForm"].Text	= currentForm;

					// Alternate backcolor for items in TestUnits list
					item.BackColor = index % 2 == 0 ? Color.AntiqueWhite : TestUnitsList.BackColor;
					
					// Update current form varibale if necessary
					TestUnit unit = item.Tag as TestUnit;
					currentForm = unit.CurrentForm != null && unit.CurrentForm.Trim().Length > 0 ? unit.CurrentForm : currentForm;
				}

				// Set Test Units page title (append number of test units)
				TestUnitsPage.Text = "Test Units (" + TestUnitsList.Items.Count.ToString() + ")";
				// Update TestUnits count to label
				TestUnitsCount.Text = TestUnitsList.Items.Count.ToString();
			}

		
			/// <summary>
			/// 
			/// </summary>
			private void ClearPreviousExecution()
			{
				// Clear execution logs
				ExecutionLogs.TabPages.Clear();

				// TODO Clear execution statistics
			}


			/// <summary>
			/// Function used to adapt the size of last column
			/// </summary>
			private void ResizeTestUnitsLastColumn()
			{
				// Check if busy with resizing
				if (busyResizing)
					return;

				// Prevent other calls to this function
				busyResizing = true;

				// Calculate fixed columns width
				int columnsWidth = 0;

				foreach (ColumnHeader column in TestUnitsList.Columns)
				{
					columnsWidth += column.Width;
				}

				columnsWidth -= TestUnitsList.Columns[TestUnitsList.Columns.Count - 1].Width;


				// Calculate white space width (margins and vertical scroll bar width)
				int whiteSpaceWidth = TestUnitsList.Margin.Left + TestUnitsList.Margin.Right + 20;

				// Resize the last column
				TestUnitsList.Columns[TestUnitsList.Columns.Count - 1].Width = TestUnitsList.Width - columnsWidth - whiteSpaceWidth;

				// Allow other calls to this function				
				busyResizing = false;
			}

		#endregion

		
		#region BACKGROUND EXECUTION

			/// <summary>
			/// 
			/// </summary>
			private void StartExecution(object sender, DoWorkEventArgs e)
			{
				// Get the configuration from parameters
				IDocumentConfiguration configuration = e.Argument as IDocumentConfiguration;

				// Create new engine - default engine will be JSCN, but other engines can be added
				engine = Engine.EngineFactory.Instance.CreateEngine();

                // Subscribe to engine's events - needed for reporting on progress
				SubscribeToEngineEvents(engine);

                // Run engine
                engine.Run(configuration);
			}

			/// <summary>
			/// 
			/// </summary>
			private void StopExecution(object sender, RunWorkerCompletedEventArgs e)
			{
				// Trigger execution 
				FireExecutionStateChanged();

				UnsubscribeToEngineEvents(engine);
			}

			/// <summary>
			/// 
			/// </summary>
			private void ExecutionProgressReport(object sender, ProgressChangedEventArgs e)
			{
				EngineExecutionProgressReport progressReport = e.UserState as EngineExecutionProgressReport;

				switch (progressReport.ReportType)
				{
					case ExecutionProgressReportType.EXECUTION_START:
					{
						// Create a new execution log control
						ExecutionLog executionLog = new ExecutionLog(progressReport.Thread, progressReport.Execution);

						// Add execution log to Execution Log Area
                        System.Windows.Forms.TabPage executionLogPage = new System.Windows.Forms.TabPage("Execution " + progressReport.Execution.ToString() + " - Thread " + progressReport.Thread.ToString());
                        executionLogPage.Controls.Add(executionLog);
						ExecutionLogs.TabPages.Add(executionLogPage);


						break;
					}

					case ExecutionProgressReportType.EXECUTION_ENDS:
						break;

					case ExecutionProgressReportType.EXECUTION_STEP_PREEXECUTION:
					{
						// Indentify the correct execution log tab page
						foreach (System.Windows.Forms.TabPage page in ExecutionLogs.TabPages)
						{
							ExecutionLog executionLog = page.Controls[0] as ExecutionLog;

							// Add information to the execution log matching the execution
							if (executionLog.Execution == progressReport.Execution)
							{
								executionLog.AddPreExecutionReport(progressReport);
							}
						}

						break;
					}

					default:
					{
						// Identify the correct execution log tab page
						foreach (System.Windows.Forms.TabPage page in ExecutionLogs.TabPages)
						{
							ExecutionLog executionLog = page.Controls[0] as ExecutionLog;

							// Add information to the execution log matching the execution
							if (executionLog.Execution == progressReport.Execution)
							{
								executionLog.AddExecutionReport(progressReport);
							}
						}

						break;
					}

				}
			}


			#region ENGINE EVENTS

				/// <summary>
				/// 
				/// </summary>
				/// <param name="engine"></param>
				private void SubscribeToEngineEvents(IMS.WebApp.Engine.IEngine engine)
				{
					engine.OnInformationUpdate += new IMS.WebApp.Engine.EngineDelegates.Information(EngineInformationUpdate);
				}


				/// <summary>
				/// 
				/// </summary>
				/// <param name="engine"></param>
				private void UnsubscribeToEngineEvents(IMS.WebApp.Engine.IEngine engine)
				{
					engine.OnInformationUpdate -= new IMS.WebApp.Engine.EngineDelegates.Information(EngineInformationUpdate);
				}


				/// <summary>
				/// 
				/// </summary>
				/// <param name="percentage"></param>
				/// <param name="progressReport"></param>
				void EngineInformationUpdate(int percentage, EngineExecutionProgressReport progressReport)
				{
					BackgroundExecution.ReportProgress(percentage, progressReport);
				}

			#endregion

		#endregion
	}
}

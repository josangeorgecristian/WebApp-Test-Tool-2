using System;
using System.Windows.Forms;

//using Crownwood.DotNetMagic.Common;

using IMS.WebApp.UI.Forms.Documents;
using IMS.WebApp.UI.Forms.Help;
using IMS.WebApp.UI.Forms.Settings;

using IMS.WebApp.UI.Interfaces;

namespace IMS.WebApp.UI.Forms
{
	public partial class WebAppMain : Form // Crownwood.DotNetMagic.Forms.DotNetMagicForm
	{
		#region FIELDS
		#endregion


		#region GETTER \ SETTER
		#endregion


		#region CONTRUCTORS

			/// <summary>
			/// Default constructor
			/// It will initialize the components and then update the application
			/// visual style to the one saved in settings (or default one)
			/// </summary>
			public WebAppMain()
			{
				InitializeComponent();

				// Update the visual styles of the application accordingly to saved settings
                //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

				// Update the controls state
				UpdateControlsState();
			}


			/// <summary>
			/// Constructor for application main form used to open the application
			/// when a file (registred as application document) is double cliked
			/// In additon of the actions performed by the standard constructor it will
			/// attemp to open the file that is double clicked
			/// </summary>
			/// <param name="filename">File name double cliked</param>
			public WebAppMain(string filename)
			{
				InitializeComponent();

				// Attempt to open document - filename provided
				OpenDocument(filename);

				// Update the visual style of the application accordingly to saved settings
                //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

				// Update the controls state
				UpdateControlsState();
			}

		#endregion


		#region STATIC FUNCTIONS
		#endregion


		#region EVENTS

			#region MAIN MENU EVENTS

				/// <summary>
				/// Event handler for New Test menu option (File->New->New Test)
				/// </summary>
				private void MenuFileNewTestClick(object sender, EventArgs e)
				{
					AddNewTest();
				}

				/// <summary>
				/// Event handler for New Batch menu option (File->New->New Batch Test)
				/// </summary>
				private void MenuFileNewBatchTestClick(object sender, EventArgs e)
				{
					AddNewBatchTest();
				}

				/// <summary>
				/// Event handler for Open menu option (File->Open)
				/// </summary>
				private void MenuFileOpenClick(object sender, EventArgs e)
				{
					OpenDocument();
				}

				/// <summary>
				/// Event handler for Save menu option (File->Save)
				/// </summary>
				private void MenuFileSaveClick(object sender, EventArgs e)
				{
					SaveDocument(false);
				}

				/// <summary>
				/// Event handler for Save As menu option (File->Save As)
				/// </summary>
				private void MenuFileSaveAsClick(object sender, EventArgs e)
				{
					SaveDocument(true);
				}

				/// <summary>
				/// Event handler for Save All menu option (File->Save All)
				/// </summary>
				private void MenuFileSaveAllClick(object sender, EventArgs e)
				{
					SaveDocuments();
				}

				/// <summary>
				/// Event handler for Close menu option (File->Close)
				/// </summary>
				private void MenuFileCloseClick(object sender, EventArgs e)
				{
					CloseDocument();
				}

				/// <summary>
				/// Event handler for Close All menu option (File->Close All)
				/// </summary>
				private void MenuFileCloseAllClick(object sender, EventArgs e)
				{
					CloseDocuments();
				}

				/// <summary>
				/// Event handler for Exit menu option (File->Exit)
				/// </summary>
				private void MenuFileExitClick(object sender, EventArgs e)
				{
					this.Close();
				}

				/// <summary>
				/// Event handler for View Status Bar menu option (View -> Status Bar)
				/// </summary>
				private void MenuViewClick(object sender, EventArgs e)
				{
					// Toggle checked state for the menu
					MenuViewStatusBar.Checked = !MenuViewStatusBar.Checked;
					// Update application settings
					IMS.WebApp.Tools.Settings.Settings.StatusBarVisible = MenuViewStatusBar.Checked;
					// Update controls state
					UpdateControlsState();
				}

				/// <summary>
				/// Event handler for Run menu option (Test->Run)
				/// </summary>
				private void MenuTestRunClick(object sender, EventArgs e)
				{
					ExecuteDocument();
				}

				/// <summary>
				/// 
				/// </summary>
				private void MenuTestPause_Click(object sender, EventArgs e)
				{
					throw new NotImplementedException();
				}

				/// <summary>
				/// Event handler for Stop menu option (Test->Stop)
				/// </summary>
				private void MenuTestStopClick(object sender, EventArgs e)
				{
					StopDocumentExecution();
				}

				/// <summary>
				/// Event handler for Stop All menu option (Test->Stop All)
				/// </summary>
				private void MenuTestStopAllClick(object sender, EventArgs e)
				{
					StopAllDocumentExecutions();
				}

				/// <summary>
				/// Event handler for Settings menu option (Tools->Settings)
				/// </summary>
				private void MenuToolSettingsClick(object sender, EventArgs e)
				{
					// Create a settings dialog
					SettingsDlg settingsDialog = new SettingsDlg();

					// Show settings dialog
					if (settingsDialog.ShowDialog() == DialogResult.OK)
					{
						// Update visual style
                        //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

						// Update controls state
						UpdateControlsState();
					}
				}

				/// <summary>
				/// 
				/// </summary>
				private void MenuHelpWebAppTestToolHelpClick(object sender, EventArgs e)
				{
					// Create a WebApp Help dialog
					WebAppHelp webAppHelpDialog = new WebAppHelp();

					// Display the WebApp Help dialog
					webAppHelpDialog.Show();
				}

				/// <summary>
				/// 
				/// </summary>
				private void MenuHelpHowDoIClick(object sender, EventArgs e)
				{

				}

				/// <summary>
				/// 
				/// </summary>
				private void MenuHelpKeywordsClick(object sender, EventArgs e)
				{

				}

				/// <summary>
				/// 
				/// </summary>
				private void MenuHelpUpdateClick(object sender, EventArgs e)
				{

				}

				/// <summary>
				/// 
				/// </summary>
				private void MenuHelpAboutClick(object sender, EventArgs e)
				{
					// Create an about dialog
					About aboutDialog = new About();

					// Display about dialog
					aboutDialog.ShowDialog();
				}

			#endregion


			#region TOOLBAR EVENTS

				/// <summary>
				/// Event handler for New Test toolbar button
				/// </summary>
				private void ToolNewTestClick(object sender, EventArgs e)
				{
					AddNewTest();
				}

				/// <summary>
				/// Event handler for New Batch Test toolbar button
				/// </summary>
				private void ToolNewBatchTestClick(object sender, EventArgs e)
				{
					AddNewBatchTest();
				}

				/// <summary>
				/// Event handler for Open Document toolbar button
				/// </summary>
				private void ToolOpenDocumentClick(object sender, EventArgs e)
				{
					OpenDocument();
				}

				/// <summary>
				/// Event handler for Save Document toolbar button
				/// </summary>
				private void ToolSaveDocumentClick(object sender, EventArgs e)
				{
					SaveDocument(false);
				}

				/// <summary>
				/// Event handler for Save All Documents toolbar button
				/// </summary>
				private void ToolSaveAllDocumentsClick(object sender, EventArgs e)
				{
					SaveDocuments();
				}

				/// <summary>
				/// Event handler for Run toolbar button
				/// </summary>
				private void ToolRunClick(object sender, EventArgs e)
				{
					ExecuteDocument();
				}

				/// <summary>
				/// Event handler for Stop toolbar button
				/// </summary>
				private void ToolStopClick(object sender, EventArgs e)
				{
					StopDocumentExecution();
				}

			#endregion


			#region DOCUMENT AREA EVENTS

				/// <summary>
				/// Event handler for document area mouse click (treat the event when the middle button of the mouse is pressed - to close clicked document)
				/// </summary>
				private void DocumentAreaMouseClick(object sender, MouseEventArgs e)
				{
					// Check if middle mouse button is pressed
					if (e.Button.Equals(MouseButtons.Middle))
					{
						CloseDocument();
					}
				}

				/// <summary>
				/// Event handler for document area close button pressed
				/// </summary>
				private void DocumentAreaClosePressed(object sender, EventArgs e)
				{
					CloseDocument();
				}

				/// <summary>
				/// Event handler for document area when selected document is changed
				/// </summary>
				private void DocumentAreaSelectionChanged(System.Windows.Forms.TabControl sender, System.Windows.Forms.TabPage oldPage, System.Windows.Forms.TabPage newPage)
				{
					UpdateControlsState();
				}


                private void DocumentArea_Selecting(object sender, TabControlCancelEventArgs e)
                {
                    UpdateControlsState();
                }

			#endregion


			/// <summary>
			/// Event handler for form closing event
			/// Attempt to close all documents opened. Cancel closing if any of the documents can not be closed
			/// </summary>
			private void WebAppMainFormClosing(object sender, FormClosingEventArgs e)
			{
				// Cancel closing if any of the documents can not be closed
				e.Cancel = !CloseDocuments();
			}

			/// <summary>
			/// Event handler for form closed event
			/// Make sure that all executions are ended and the settings are saved
			/// </summary>
			private void WebAppMainFormClosed(object sender, FormClosedEventArgs e)
			{
				// Wait for all to terminate execution
			}

		#endregion


		#region METHODS

			#region Form controls state methods

				/// <summary>
				/// Method used to update the visual style for the application and opened documents
				/// </summary>
				/// <param name="style">The new style which the application and opened documents must adopt</param>
                //private void UpdateVisualStyle(VisualStyle style)
                //{
                //    // Set style to window
                //    this.Style = style;

                //    #region Set toolbar items display style

                //        // Get the toolbar buttons display style
                //        ToolStripItemDisplayStyle displayStyle = IMS.WebApp.Tools.Settings.Settings.ToolbarAppearance;

                //        if (IMS.WebApp.Tools.Settings.Settings.ApplyToApplicationToolbar)
                //        {
                //            foreach (ToolStripItem item in Toolbar.Items)
                //            {
                //                item.DisplayStyle = displayStyle;
                //            }
                //        }
                //        else
                //        {
                //            foreach (ToolStripItem item in Toolbar.Items)
                //            {
                //                item.DisplayStyle = ToolStripItemDisplayStyle.Image;
                //            }
                //        }

                //    #endregion

                //    // Set the document area style
                //    DocumentArea.Style = style;

                //    // Update all opened documents
                //    for (int i = 0; i < DocumentArea.TabPages.Count; i++)
                //    {
                //        if (DocumentArea.TabPages[i].Controls[0] is IDocument)
                //        {
                //            ((IDocument)DocumentArea.TabPages[i].Controls[0]).UpdateVisualStyle(style);
                //        }
                //    }
                //}

				/// <summary>
				/// Method used to update the state of controls, menu option, toolbar buttons
				/// </summary>
				private void UpdateControlsState()
				{
					// Update document area
					DocumentArea.Visible = DocumentArea.TabPages.Count > 0;
					
					// Update status bar & menu option controling visibility of the status bar
					MenuViewStatusBar.Checked = IMS.WebApp.Tools.Settings.Settings.StatusBarVisible;
					StatusBar.Visible = MenuViewStatusBar.Checked;


					#region Document name

						// Check for an opened document
                        if (DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null)
                        {
                            // Update document title
                            DocumentArea.SelectedTab.Text = (DocumentArea.SelectedTab.Controls[0] as IDocument).Title;
                        }

					#endregion


					#region Save controls

						// Enable or disable the menu options controling document saving options
						MenuFileSave.Enabled = DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null;
						MenuFileSaveAs.Enabled = DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null;
						MenuFileSaveAll.Enabled = DocumentArea.TabPages.Count > 0;

						// Enable or disable the toolbar buttons controlling document saving options
						tbSaveDocument.Enabled = DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null;
						tbSaveDocumentAs.Enabled = DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null;
						tbSaveAllDocuments.Enabled = DocumentArea.TabPages.Count > 0;

					#endregion


					#region Execution controls

						// Show or hide the menu options controling document execution
                        MenuTest.Visible = (DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null);
                        MenuTestRun.Visible = (DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null);
						MenuTestStop.Visible = (DocumentArea.TabCount > 0 &&DocumentArea.SelectedTab != null);

						// Enable or disable the menu options controling document execution
                        MenuTestRun.Enabled = ((DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null) && ((IDocument)DocumentArea.SelectedTab.Controls[0]).CanRun && !((IDocument)DocumentArea.SelectedTab.Controls[0]).IsRunning);
                        MenuTestStop.Enabled = ((DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null) && ((IDocument)DocumentArea.SelectedTab.Controls[0]).IsRunning);

						// Show or hide the toolbar buttons controling document execution
                        tbRun.Visible = DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null;
                        tbStop.Visible = DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null;

						// Enable or disable the toolbar buttons controling document execution
                        tbRun.Enabled = ((DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null) && ((IDocument)DocumentArea.SelectedTab.Controls[0]).CanRun && !((IDocument)DocumentArea.SelectedTab.Controls[0]).IsRunning);
                        tbStop.Enabled = ((DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null) && ((IDocument)DocumentArea.SelectedTab.Controls[0]).IsRunning);

					#endregion


					#region Close controls

						// Enable or disable the menu options controling document closing options
                        MenuFileClose.Enabled = DocumentArea.TabCount > 0 && DocumentArea.SelectedTab != null;
						MenuFileCloseAll.Enabled = DocumentArea.TabPages.Count > 0;

					#endregion

					#region Update controls state in documents

						// Iterate opened documents
						foreach (System.Windows.Forms.TabPage page in DocumentArea.TabPages)
						{
							// Get document interface
							IDocument document = page.Controls[0] as IDocument;

							// Call document UpdateControlsState method
							document.UpdateControlsState();
						}

					#endregion
				}

			#endregion


			#region Subscribe to document events methods

				/// <summary>
				/// Method used to subscribe to document events
				/// </summary>
				/// <param name="document">Provided document</param>
				private void SubscribeToDocumentEvents(IDocument document)
				{
					document.OnConfigurationChanged		+= new FileDelegates.FileChanged(UpdateControlsState);
					document.OnExecutionStateChanged	+= new DocumentDelegates.ExecutionStateChanged(UpdateControlsState);
				}

				/// <summary>
				/// Method used to unsubscribe to document events
				/// </summary>
				/// <param name="document">Provided document</param>
				private void UnsubscribeToDocumentEvents(IDocument document)
				{
					document.OnConfigurationChanged -= new FileDelegates.FileChanged(UpdateControlsState);
					document.OnExecutionStateChanged -= new DocumentDelegates.ExecutionStateChanged(UpdateControlsState);
				}

			#endregion


			#region Document usage methods

				/// <summary>
				/// Method used to create a new document from provided control
				/// </summary>
				/// <param name="control">Provided control - if the control doesn't implement the IDocument interface the open will fail</param>
				private void AddDocument(Control control)
				{
					// Check if the control provided implements the IDocument interface
					if (!(control is IDocument))
					{
						MessageBox.Show("Invalid document type!", "Error creating document", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					// Determine the name to display for the document tab
					string documentName = ((IDocument)control).Title;

					// Create document based on the control provided
					System.Windows.Forms.TabPage document = new System.Windows.Forms.TabPage(((IDocument)control).Title);
                    document.Controls.Add(control);
					control.Dock = DockStyle.Fill;
					
					// Subscribe to document events
					SubscribeToDocumentEvents((IDocument)control);
					
					// Add document to document area
					DocumentArea.TabPages.Add(document);

					// Select documents
					DocumentArea.SelectedTab = document;

                    // Update controls state
                    UpdateControlsState();
				}

				/// <summary>
				/// Method used to create a new test document
				/// </summary>
				private void AddNewTest()
				{
					// Call the AddDocument method with a new Test control
					AddDocument(new TestUC());
				}

				/// <summary>
				/// Method used to create a new batch test document
				/// </summary>
				private void AddNewBatchTest()
				{
					// Call the AddDocument method with a new BatchTest control
					AddDocument(new BatchTestUC());
				}

				/// <summary>
				/// Method used to open a document based on the document configuration saved in a file
				/// </summary>
				private void OpenDocument()
				{
					// Show Open file dialog for choosing a file
					if (OpenFile.ShowDialog() == DialogResult.OK)
					{
						// Call function to open a document from file
						OpenDocument(OpenFile.FileName);
					}
				}

				/// <summary>
				/// Method used to open a document based on the document configuration saved in a file
				/// </summary>
				/// <param name="filename">File name with document configuration provided</param>
				private void OpenDocument(string filename)
				{
					try
					{
						// Attempt to create a TEST document from the file
						Test test = new Test(IMS.WebApp.Data.TestConfiguration.LoadFromFile(filename), filename);

						// Add created TEST document
						AddDocument(test);
					}
					catch (Exception exception)
					{
						MessageBox.Show(exception.Message);
						return;
					}
				}

				/// <summary>
				/// Function used to save or save as a document
				/// </summary>
				/// <param name="saveAs">Parameter indicating to perform a save as instead of a simple save</param>
				/// <returns>Returns true if selected document succeeds to save, otherwise returns false</returns>
				private bool SaveDocument(bool saveAs)
				{
					// Check if there is a opened document
					if (DocumentArea.SelectedTab == null)
						return true;

					try
					{
						// Check if a save as will be perfomed
						if (saveAs || !((IDocument)DocumentArea.SelectedTab.Controls[0]).WasSaved)
						{
							// Show Save file dialog for choosing a file name
							if (SaveFile.ShowDialog() == DialogResult.OK)
							{
								// Perform a save as for currently selected document
								((IDocument)DocumentArea.SelectedTab.Controls[0]).SaveAs(SaveFile.FileName);

								// End function in success (prevent the additional save)
								return true;
							}
							else
								return false;
						}

						// Perform a save for currently selected document
						(DocumentArea.SelectedTab.Controls[0] as IDocument).Save();

						// End the function in success
						return true;
					}
					catch (Exception exception)
					{
						MessageBox.Show(exception.Message);
						return false;
					}
				}

				/// <summary>
				/// Method used to save all opened documents
				/// </summary>
				private void SaveDocuments()
				{
					// Iterate opened documents
					for (int i = 0; i < DocumentArea.TabPages.Count; i++)
					{
						// Select each document
						DocumentArea.SelectedIndex = i;

						// Save selected document
						SaveDocument(false);
					}
				}

				/// <summary>
				/// Method used to close selected opened document
				/// </summary>
				/// <returns>Returns true if selected document succesfully closes, false otherwise</returns>
				private bool CloseDocument()
				{
					// Check if there is a document opened
					if (DocumentArea.SelectedTab == null)
						return true;

					// Treat selected tab as a document (control used on tab page must implement IDocument interface)
					IDocument document = DocumentArea.SelectedTab.Controls[0] as IDocument;

					// Check if document is running
					if (document.IsRunning)
					{
						// Stop document execution
						document.StopExecution();
					}

					// Check if document has beed changed
					if (document.WasChanged)
					{
						// Ask confimation from user to save and close
						switch (MessageBox.Show("The document '" + document.Title + "' has changed, do you want to save the changes?", "Close Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
						{
							// Save the document
							case DialogResult.Yes:
							{
								// Check if document save succeeded
								if (!SaveDocument(false))
									// If selected documents failed to save end the function as failed - return false
									return false;

								break;
							}

							// Cancel document closing
							case DialogResult.Cancel:
								// End function as failed - return false
								return false;
						}
					}

					// Unsubscribe from document events
					UnsubscribeToDocumentEvents(document);

					// Remove document from document area
					DocumentArea.TabPages.Remove(DocumentArea.SelectedTab);

					// End function as success - return true
					return true;
				}

				/// <summary>
				/// Method used to close all opended documents
				/// </summary>
				/// <returns>Returns true if all documents were successfully closed, false otherwise</returns>
				private bool CloseDocuments()
				{
					// Iterate opened documents (backwards)
					for (int index = DocumentArea.TabPages.Count; index > 0; index--)
					{
						// Select each opened document
						DocumentArea.SelectedIndex = index - 1;

						// Call close on selected document
						// If it will succeed then the document will
						// be removed from document area
						if (!CloseDocument())
							// If selected document failed to close end the function as failed - return false
							return false;
					}

					// In the end function succeeded in closing all documents - return true
					return true;
				}

				/// <summary>
				/// Method used to start execution of a document
				/// </summary>
				private void ExecuteDocument()
				{
					// Check for an opened document
					if (DocumentArea.SelectedTab == null)
						return;

					// Treat selected tab as a document (control used on tab page must implement IDocument interface)
					IDocument document = DocumentArea.SelectedTab.Controls[0] as IDocument;

					// Check if document is running
					if (!document.IsRunning)
					{
						// Start document execution
						document.StartExecution();
					}
				}

				/// <summary>
				/// Method used to stop execution of a document
				/// </summary>
				private void StopDocumentExecution()
				{
					// Check for an opened document
					if (DocumentArea.SelectedTab == null)
						return;

					// Treat selected tab as a document (control used on tab page must implement IDocument interface)
					IDocument document = DocumentArea.SelectedTab.Controls[0] as IDocument;

					// Check if document is running
					if (document.IsRunning)
					{
						// Stop document execution
						document.StopExecution();
					}
				}

				/// <summary>
				/// Method used to stop execution of all running documents
				/// </summary>
				private void StopAllDocumentExecutions()
				{
					// Iterate opened documents
					for (int i = 0; i < DocumentArea.TabPages.Count; i++)
					{
						// Treat each opened tab as document (control used on tab pages must implement IDocument interface)
						IDocument document = DocumentArea.TabPages[i].Controls[0] as IDocument;

						// Check if document is running
						if (document.IsRunning)
						{
							// Stop document execution
							document.StopExecution();
						}
					}
				}

			#endregion


		#endregion
	}
}

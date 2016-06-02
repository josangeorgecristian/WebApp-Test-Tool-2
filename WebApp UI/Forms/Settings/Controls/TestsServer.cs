using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

using IMS.CustomControls;
using IMS.WebApp.UI.Interfaces;

namespace IMS.WebApp.UI.Forms.Settings
{
	public partial class TestsServer : UserControl, ISettingsControl
	{
		/// <summary>
		/// Structure used to keep a project server along project name
		/// </summary>
		public struct Project
		{
			public string Name;
			public string Server;
		}

		/// <summary>
		/// Class used to keep the servers configuration, serialize and deserialize the configuration into/from a file
		/// </summary>
		public class ServersConfiguration
		{
			#region FIELDS

				private Project[] projects;

			#endregion

			
			#region STATIC FUNCTIONS

				/// <summary>
				/// Function used to serialize a ServersConfiguration object to a file
				/// </summary>
				/// <param name="filename">File name where the object will be serialized</param>
				/// <param name="configuration">ServersConfiguration object to be serialized</param>
				public static void SaveServers(string filename, ServersConfiguration configuration)
				{
					try
					{
						// Create a file stream creating or overwrite the existing file
						FileStream file = File.Create(filename);

						try
						{
							// Create a XML serializer of ServersConfiguration type
							XmlSerializer serializer = new XmlSerializer(typeof (ServersConfiguration));

							// Attempt to serializethe ServersConfiguration object to file stream
							serializer.Serialize(file, configuration);

							// Close the file stream
							file.Close();
						}
						catch (Exception exception)
						{
							// Make sure the file stream is closed
							if (file != null)
								file.Close();

							throw exception;
						}
					}
					catch (IOException exception)
					{
						throw exception;
					}
				}

				/// <summary>
				/// Function used to deserialize a ServersConfiguration object from a file
				/// </summary>
				/// <param name="filename">File name from where the object will be deserialized</param>
				/// <returns>The deserialized ServersConfiguration object</returns>
				public static ServersConfiguration LoadServers(string filename)
				{
					try
					{
						// Create a file stream opening for reading the file provided
						FileStream file = File.OpenRead(filename);

						try
						{
							// Create a XML serializer of ServersConfiguration type
							XmlSerializer serializer = new XmlSerializer(typeof(ServersConfiguration));

							// Attempt to deserialize the configuration from file name
							ServersConfiguration configuration = (ServersConfiguration)serializer.Deserialize(file);

							// Close the file stream
							file.Close();

							// Return the configuration object
							return configuration;

						}
						catch (Exception exception)
						{
							// Make sure the file stream is closed
							if (file != null)
								file.Close();

							throw exception;
						}
					}
					catch (IOException exception)
					{
						throw exception;
					}
				}

			#endregion


			#region GETTER \ SETTER

				/// <summary>
				/// 
				/// </summary>
				public Project[] Projects
				{
					get { return projects; }
					set { projects = value; }
				}

			#endregion
		}


		#region FIELDS

			private bool projectsSaved;

		#endregion


		#region CONSTRUCTORS

		public TestsServer()
			{
				InitializeComponent();
			}

		#endregion


		#region ISettingsControl Members

			/// <summary>
			/// Funtion used to load the test server settings
			/// If reading a setting from registry fails the default value will be used
			/// </summary>
			public void LoadSettings()
			{
				// Load default server URL setting
				txtDefaultServerURL.Text = IMS.WebApp.Tools.Settings.Settings.DefaultServerURL;
				// Load override server URL setting
				chkOverrideServerURL.Checked = IMS.WebApp.Tools.Settings.Settings.OverrideServerURL;
				// Load file projects server setting
				txtFile.Text = IMS.WebApp.Tools.Settings.Settings.FileProjectsServer;

				// Load projects server list
				LoadProjects(txtFile.Text);

				// Update controls state
				updateControlState();
			}

			/// <summary>
			/// Function used to save the test server settings
			/// </summary>
			public void SaveSettings()
			{
				// Save default server URL setting
				IMS.WebApp.Tools.Settings.Settings.DefaultServerURL = txtDefaultServerURL.Text;
				// Save override server URL setting
				IMS.WebApp.Tools.Settings.Settings.OverrideServerURL = chkOverrideServerURL.Checked;
				// Save file projects server setting
				IMS.WebApp.Tools.Settings.Settings.FileProjectsServer = txtFile.Text;

				// Save projects server list
				SaveProjects(txtFile.Text);
			}

		#endregion


		#region EVENTS

			/// <summary>
			/// 
			/// </summary>
			private void OnBrowseClick(object sender, EventArgs e)
			{
				// Check if projects have been saved
				if (!projectsSaved)
				{
					DialogResult result = MessageBox.Show("Current projects were not saved. Do you want to save them now?", "Message", MessageBoxButtons.YesNoCancel);

					switch (result)
					{
						case DialogResult.Cancel:
							return;

						case DialogResult.Yes:
							SaveProjects(txtFile.Text);
							break;
					}
				}

				if (FileServerSelect.ShowDialog() == DialogResult.OK)
				{
					txtFile.Text = FileServerSelect.FileName;

					LoadProjects(txtFile.Text);
				}
			}

			/// <summary>
			/// 
			/// </summary>
			private void OnSaveClick(object sender, EventArgs e)
			{
				SaveProjects(txtFile.Text);
			}

			/// <summary>
			/// 
			/// </summary>
			private void OnProjectsListClick(object sender, EventArgs e)
			{
				updateControlState();
			}

			/// <summary>
			/// 
			/// </summary>
			private void OnProjectsListSelectionChanged(object sender, EventArgs e)
			{
				SelectProject();

				updateControlState();
			}

			/// <summary>
			/// 
			/// </summary>
			private void OnFileSelect(object sender, CancelEventArgs e)
			{
				// TODO Validate the file before selecting it
			}

			#region Projects Context Menu Options

				/// <summary>
				/// 
				/// </summary>
				private void OnMenuNewProjectClick(object sender, EventArgs e)
				{
					AddProjectControl();
				}

				/// <summary>
				/// 
				/// </summary>
				private void OnMenuEditProjectClick(object sender, EventArgs e)
				{
					AddProjectControlEdit();
				}


				/// <summary>
				/// 
				/// </summary>
				private void OnMenuDeleteProjectClick(object sender, EventArgs e)
				{
					RemoveProject();

					// Mark projects as not having been saved
					projectsSaved = false;
				}

			#endregion

			/// <summary>
			/// 
			/// </summary>
			private void AddProject(Object sender, EventArgs e)
			{
				foreach (Control control in this.Controls)
				{
					if (!(control is AddNamedLink))
						continue;

					Project project = new Project();
					project.Name = ((AddNamedLink)control).UrlName.Text;
					project.Server = ((AddNamedLink)control).UrlLink.Text;

					AddProject(project);

					control.Dispose();

					// Mark projects as not having been saved
					projectsSaved = false;
				}
			}

			/// <summary>
			/// 
			/// </summary>
			private void EditProject(Object sender, EventArgs e)
			{
				foreach (Control control in this.Controls)
				{
					if (!(control is AddNamedLink))
						continue;

					Project project = (Project) ((AddNamedLink)control).Tag;
					project.Name = ((AddNamedLink)control).UrlName.Text;
					project.Server = ((AddNamedLink)control).UrlLink.Text;

					UpdateProject(project);

					((AddNamedLink)control).Dispose();

					// Mark projects as not having been saved
					projectsSaved = false;
				}
			}

			/// <summary>
			/// 
			/// </summary>
			private void UpdateProject(Project project)
			{
				// Update displayed text for list view item
				listProjects.SelectedItems[0].Text = project.Name;
				listProjects.SelectedItems[0].SubItems[1].Text = project.Server;

				// Update selected items
				listProjects.SelectedItems[0].Tag = project;
			}

		#endregion


		#region METHODS

			/// <summary>
			/// 
			/// </summary>
			private void AddProjectControl()
			{
				AddNamedLink addProjectControl = new AddNamedLink(new EventHandler(AddProject), true);
				addProjectControl.Location = new System.Drawing.Point(50, 145);

				this.Controls.Add(addProjectControl);
				addProjectControl.BringToFront();
				addProjectControl.Focus();
				addProjectControl.Show();
			}

			private void AddProjectControlEdit()
			{
				AddNamedLink addProjectControl = new AddNamedLink(new EventHandler(EditProject), true);
				addProjectControl.Location = new System.Drawing.Point(50, 145);
				
				addProjectControl.UrlName.Text = listProjects.SelectedItems[0].Text;
				addProjectControl.UrlLink.Text = listProjects.SelectedItems[0].SubItems[1].Text;
				addProjectControl.Tag = listProjects.SelectedItems[0].Tag;

				this.Controls.Add(addProjectControl);

				addProjectControl.BringToFront();
				addProjectControl.Focus();
				addProjectControl.Show();
			}

			/// <summary>
			/// Function used to load the projects servers from file
			/// </summary>
			/// <param name="filename">File name from which the projects will be read</param>
			private void LoadProjects(string filename)
			{
				try
				{
					// Mark projects as having been saved
					projectsSaved = true;

					// Clear the project list
					listProjects.Items.Clear();

					// Check if the file exists
					if (!File.Exists(filename))
					{
						txtFile.Text = "";
						return;
					}

					// Attempt to load the configuration for projects from file
					ServersConfiguration configuration = ServersConfiguration.LoadServers(filename);

					// Add projects from configuration to list
					for (int i = 0; i < configuration.Projects.Length; i++)
					{
						AddProject(configuration.Projects[i]);
					}

				}
				catch (Exception exception)
				{
					// Treat any exception that may occur
					MessageBox.Show(exception.Message, "WebApp Test Tool - Error loading server collection", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

			/// <summary>
			/// Function used to save the projects servers to file
			/// </summary>
			/// <param name="filename">File name where the projects will be saved</param>
			private void SaveProjects(string filename)
			{
				try
				{
					// Create an instance of configuration object
					ServersConfiguration configuration = new ServersConfiguration();
					// Get the projects servers configuration from list
					configuration.Projects = GetProjects();

					// If there are no projects to save end function execution
					if (configuration.Projects.Length == 0)
						return;

					// Check if the file exists
					if (!File.Exists(filename))
					{
						// Ask user to provide a file to save
						DialogResult result = FileServerSave.ShowDialog();

						switch (result)
						{
							// If the user provided a file name
							case DialogResult.OK:

								// Set the file name
								txtFile.Text = FileServerSave.FileName;
								// Update file name
								filename = FileServerSave.FileName;

								break;

							// If the user refused to provide a file - end function execution
							case DialogResult.Cancel:
								return;
						}
					}

					// Attempt to save the projects servers configuration
					ServersConfiguration.SaveServers(filename, configuration);

					// Mark projects as having been saved
					projectsSaved = true;
				}
				catch (Exception exception)
				{
					// Treat any exception that may occur
					MessageBox.Show(exception.Message, "WebApp Test Tool - Error saving server collection", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

			/// <summary>
			/// Function used to retrieve the Projects array from list
			/// </summary>
			/// <returns>Array of projects present in the list</returns>
			private Project[] GetProjects()
			{
				// Create an array to fit and keep all the projects in the list
				Project[] projects = new Project[listProjects.Items.Count];

				// Retrieve the projects from list
				int index = 0;
				foreach (ListViewItem item in listProjects.Items)
				{
					projects[index++] = (Project)item.Tag;
				}

				// Return the array with projects
				return projects;
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="project"></param>
			private void AddProject(Project project)
			{
				ListViewItem item = new ListViewItem();
				item.Text = project.Name;
				item.SubItems.Add(project.Server);

				item.Tag = project;

				listProjects.Items.Add(item);
			}

			/// <summary>
			/// 
			/// </summary>
			private void RemoveProject()
			{
				if (listProjects.SelectedItems.Count == 0)
					return;

				listProjects.Items.Remove(listProjects.SelectedItems[0]);

				updateControlState();
			}

			/// <summary>
			/// Function used to update the default server based on selection made
			/// </summary>
			private void SelectProject()
			{
				// Test if there are entries to be selected
				if (listProjects.SelectedItems.Count == 0)
					return;

				txtDefaultServerURL.Text = listProjects.SelectedItems[0].SubItems[1].Text;
			}

			/// <summary>
			/// Function used to update the controls state
			/// </summary>
			private void updateControlState()
			{
				// Context menu options 'Edit Project Server' and 'Delete Project Server' should be visible only when a project is selected
				MenuEditProject.Visible = listProjects.SelectedItems.Count != 0;
				MenuDeleteProject.Visible = listProjects.SelectedItems.Count != 0;
			}

		#endregion





	}
}

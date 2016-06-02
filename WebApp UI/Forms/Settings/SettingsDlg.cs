using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using IMS.WebApp.UI.Interfaces;

namespace IMS.WebApp.UI.Forms.Settings
{
	public partial class SettingsDlg : Form // Crownwood.DotNetMagic.Forms.DotNetMagicForm
	{
		#region FIELDS

			private static int INDEX_ENVIROMENT_GENERAL = 0;
			private static int INDEX_TESTS_EXECUTION = 1;
			private static int INDEX_TESTS_SERVER = 2;
			private static int INDEX_EMAIL_SERVER_SETTINGS = 3;
			private static int INDEX_UPLOAD_SETTINGS = 4;

		#endregion


		#region GETTER \ SETTER
		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Default constructor
			/// It will use the currently selected visual style for the application
			/// </summary>
			public SettingsDlg()
			{
				InitializeComponent();

				// Set visual style
                //Style = IMS.WebApp.Tools.Settings.Settings.Style;

				// Add settings custom controls
				OptionsControlsArea.Controls.Add(new EnviromentGeneral());
				OptionsControlsArea.Controls.Add(new TestsExecution());
				OptionsControlsArea.Controls.Add(new TestsServer());
				OptionsControlsArea.Controls.Add(new EMailServerSettings());
				OptionsControlsArea.Controls.Add(new UploadSettings());

				// Load settings
				LoadSettings();
			}

		#endregion


		#region STATIC FUNCTIONS
		#endregion


		#region EVENTS

			/// <summary>
			/// 
			/// </summary>
			private void OnTreeNode_Selected(object sender, TreeViewEventArgs e)
			{
				switch (e.Node.Name)
				{
					case "NodeEnviroment":
					case "NodeEnviromentGeneral":
						ShowSettingsDetails(INDEX_ENVIROMENT_GENERAL);
						break;

					case "NodeTests":
					case "NodeTestsExecution":
						ShowSettingsDetails(INDEX_TESTS_EXECUTION);
						break;

					case "NodeTestsServer":
						ShowSettingsDetails(INDEX_TESTS_SERVER);
						break;

					case "NodeEMail":
					case "NodeEMailServerSettings":
						ShowSettingsDetails(INDEX_EMAIL_SERVER_SETTINGS);
						break;

					case "NodeUpdate":
						ShowSettingsDetails(INDEX_UPLOAD_SETTINGS);
						break;

					default:
						ShowSettingsDetails(INDEX_ENVIROMENT_GENERAL);
						break;
				}
			}

			/// <summary>
			/// 
			/// </summary>
			private void OnOK_Click(object sender, EventArgs e)
			{
				SaveSettings();
			}

			/// <summary>
			/// 
			/// </summary>
			private void OnCancel_Click(object sender, EventArgs e)
			{
			}

			/// <summary>
			/// 
			/// </summary>
			private void OnDefaultSettings_Click(object sender, EventArgs e)
			{
				RestoreDefaultSettings();
			}

		#endregion


		#region METHODS

			private void ShowSettingsDetails(int index)
			{
				for (int i = 0; i < OptionsControlsArea.Controls.Count; i++)
				{
					OptionsControlsArea.Controls[i].Visible = (i == index);
				}
			}

			private void LoadSettings()
			{
				for (int i = 0; i < OptionsControlsArea.Controls.Count; i++)
				{
					if (OptionsControlsArea.Controls[i] is ISettingsControl)
					{
						((ISettingsControl)OptionsControlsArea.Controls[i]).LoadSettings();
					}
				}
			}

			private void SaveSettings()
			{
				for (int i = 0; i < OptionsControlsArea.Controls.Count; i++)
				{
					if (OptionsControlsArea.Controls[i] is ISettingsControl)
					{
						((ISettingsControl)OptionsControlsArea.Controls[i]).SaveSettings();
					}
				}
			}

			private void RestoreDefaultSettings()
			{
				IMS.WebApp.Tools.Settings.Settings.RestoreDefaultSettings();

				LoadSettings();
			}

		#endregion
	}
}

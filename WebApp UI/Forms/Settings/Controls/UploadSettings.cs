using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using IMS.WebApp.UI.Interfaces;

namespace IMS.WebApp.UI.Forms.Settings
{
	public partial class UploadSettings : UserControl, ISettingsControl
	{
		public UploadSettings()
		{
			InitializeComponent();
		}

		#region ISettingsControl Members

			/// <summary>
			/// Function used to load the upload settings
			/// If reading a setting from registry fails the default setting will be used
			/// </summary>
			public void LoadSettings()
			{
				txtUpdateLocation.Text = IMS.WebApp.Tools.Settings.Settings.UploadLocation;
			}

			/// <summary>
			/// Function used to save the upload settings
			/// </summary>
			public void SaveSettings()
			{
				IMS.WebApp.Tools.Settings.Settings.UploadLocation = txtUpdateLocation.Text;
			}

		#endregion


		#region EVENTS

			/// <summary>
			/// Event handler for when pressing the select location
			/// The selected location will be used to download the updates and pathces
			/// </summary>
			private void SelectLocationClick(object sender, EventArgs e)
			{
				if (UploadLocation.ShowDialog() == DialogResult.OK)
				{
					txtUpdateLocation.Text = UploadLocation.SelectedPath;
				}
			}

		#endregion
	}
}

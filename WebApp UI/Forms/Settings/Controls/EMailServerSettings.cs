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
	public partial class EMailServerSettings : UserControl, ISettingsControl
	{
		public EMailServerSettings()
		{
			InitializeComponent();
		}

		#region ISettingsControl Members

			/// <summary>
			/// Function used to load the email settings
			/// If an registry read of a setting fails then the default value will be used
			/// </summary>
			public void LoadSettings()
			{
				#region E-Mail Server Settings

					txtEMailServer.Text = IMS.WebApp.Tools.Settings.Settings.EMailServer;
					txtEMailUsername.Text = IMS.WebApp.Tools.Settings.Settings.EMailUsername;
					txtEMailPassword.Text = IMS.WebApp.Tools.Settings.Settings.EMailPassword;

				#endregion

				#region E-Mail Advanced Server Settings

					nSMTPPort.Value = IMS.WebApp.Tools.Settings.Settings.PortSMTP;
					chkServerSSLEncryption.Checked = IMS.WebApp.Tools.Settings.Settings.EncryptSSL;

				#endregion

				#region E-Mail Recipient Settings

					txtEMailName.Text = IMS.WebApp.Tools.Settings.Settings.RecipientName;
					txtEMailAddress.Text = IMS.WebApp.Tools.Settings.Settings.RecipientAddress;

				#endregion
			}

			/// <summary>
			/// Function used to save the email settings
			/// </summary>
			public void SaveSettings()
			{
				#region E-Mail Server Settings

					IMS.WebApp.Tools.Settings.Settings.EMailServer = txtEMailServer.Text;
					IMS.WebApp.Tools.Settings.Settings.EMailUsername = txtEMailUsername.Text;
					IMS.WebApp.Tools.Settings.Settings.EMailPassword = txtEMailPassword.Text;

				#endregion

				#region E-Mail Advanced Server Settings

					IMS.WebApp.Tools.Settings.Settings.PortSMTP = (int) nSMTPPort.Value;
					IMS.WebApp.Tools.Settings.Settings.EncryptSSL = chkServerSSLEncryption.Checked;

				#endregion

				#region E-Mail Recipient Settings

					IMS.WebApp.Tools.Settings.Settings.RecipientName = txtEMailName.Text;
					IMS.WebApp.Tools.Settings.Settings.RecipientAddress = txtEMailAddress.Text;

				#endregion
			}

		#endregion
	}
}

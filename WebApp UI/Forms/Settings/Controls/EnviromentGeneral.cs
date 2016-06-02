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
	public partial class EnviromentGeneral : UserControl, ISettingsControl
	{
		public EnviromentGeneral()
		{
			InitializeComponent();
		}

		#region ISettingsControl Members

			/// <summary>
			/// Function used to load the enviroment general settings
			/// If reading a setting from registry fails the default setting will be used
			/// </summary>
			public void LoadSettings()
			{
				#region Load Visual Style

                    //switch (IMS.WebApp.Tools.Settings.Settings.Style)
                    //{
                    //    case Crownwood.DotNetMagic.Common.VisualStyle.Plain:
                    //        rdoStylePlain.Checked = true;
                    //        break;

                    //    case Crownwood.DotNetMagic.Common.VisualStyle.IDE2005:
                    //        rdoStyleIDE2005.Checked = true;
                    //        break;

                    //    case Crownwood.DotNetMagic.Common.VisualStyle.Office2003:
                    //        rdoStyleOffice2003.Checked = true;
                    //        break;

                    //    case Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerOrange:
                    //        rdoStyleMPlayerOrange.Checked = true;
                    //        break;

                    //    case Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue:
                    //        rdoStyleMPlayerBlue.Checked = true;
                    //        break;

                    //    case Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerPurple:
                    //        rdoStyleMPlayerPurple.Checked = true;
                    //        break;

                    //    case Crownwood.DotNetMagic.Common.VisualStyle.Office2007Black:
                    //        rdoStyleOffice2007Black.Checked = true;
                    //        break;

                    //    case Crownwood.DotNetMagic.Common.VisualStyle.Office2007Blue:
                    //        rdoStyleOffice2007Blue.Checked = true;
                    //        break;

                    //    case Crownwood.DotNetMagic.Common.VisualStyle.Office2007Silver:
                    //        rdoStyleOffice2007Silver.Checked = true;
                    //        break;
                    //}

				#endregion

				#region Load Toolbar Appearence Settings

					switch (IMS.WebApp.Tools.Settings.Settings.ToolbarAppearance)
					{
						case ToolStripItemDisplayStyle.Image:
							rdoImageOnly.Checked = true;
							break;

						case ToolStripItemDisplayStyle.Text:
							rdoTextOnly.Checked = true;
							break;

						case ToolStripItemDisplayStyle.ImageAndText:
							rdoImageAndText.Checked = true;
							break;

						default:
							rdoImageOnly.Checked = true;
							break;
					}

					chkApplicationToolbars.Checked = IMS.WebApp.Tools.Settings.Settings.ApplyToApplicationToolbar;
					chkDocumentToolbar.Checked = IMS.WebApp.Tools.Settings.Settings.ApplyToDocumentsToolbar;

				#endregion

				#region Load Recent Files Settings

					nRecentTests.Value = IMS.WebApp.Tools.Settings.Settings.NumberOfRecentlyTestsShown;
					nRecentBatchTests.Value = IMS.WebApp.Tools.Settings.Settings.NumberOfRecentlyBatchesShown;

				#endregion
			}

			/// <summary>
			/// Function used to save the enviroment general settings
			/// </summary>
			public void SaveSettings()
			{
				#region Save Visual Style

                    //if (rdoStylePlain.Checked)
                    //{
                    //    IMS.WebApp.Tools.Settings.Settings.Style = Crownwood.DotNetMagic.Common.VisualStyle.Plain;
                    //}
                    //else if (rdoStyleIDE2005.Checked)
                    //{
                    //    IMS.WebApp.Tools.Settings.Settings.Style = Crownwood.DotNetMagic.Common.VisualStyle.IDE2005;
                    //}
                    //else if (rdoStyleOffice2003.Checked)
                    //{
                    //    IMS.WebApp.Tools.Settings.Settings.Style = Crownwood.DotNetMagic.Common.VisualStyle.Office2003;
                    //}
                    //else if (rdoStyleOffice2007Black.Checked)
                    //{
                    //    IMS.WebApp.Tools.Settings.Settings.Style = Crownwood.DotNetMagic.Common.VisualStyle.Office2007Black;
                    //}
                    //else if (rdoStyleOffice2007Blue.Checked)
                    //{
                    //    IMS.WebApp.Tools.Settings.Settings.Style = Crownwood.DotNetMagic.Common.VisualStyle.Office2007Blue;
                    //}
                    //else if (rdoStyleOffice2007Silver.Checked)
                    //{
                    //    IMS.WebApp.Tools.Settings.Settings.Style = Crownwood.DotNetMagic.Common.VisualStyle.Office2007Silver;
                    //}
                    //else if (rdoStyleMPlayerBlue.Checked)
                    //{
                    //    IMS.WebApp.Tools.Settings.Settings.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
                    //}
                    //else if (rdoStyleMPlayerOrange.Checked)
                    //{
                    //    IMS.WebApp.Tools.Settings.Settings.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerOrange;
                    //}
                    //else if (rdoStyleMPlayerPurple.Checked)
                    //{
                    //    IMS.WebApp.Tools.Settings.Settings.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerPurple;
                    //}

				#endregion

				#region Save Toolbar Appearence

					if (rdoImageOnly.Checked)
					{
						IMS.WebApp.Tools.Settings.Settings.ToolbarAppearance = ToolStripItemDisplayStyle.Image;
					}
					else if (rdoImageAndText.Checked)
					{
						IMS.WebApp.Tools.Settings.Settings.ToolbarAppearance = ToolStripItemDisplayStyle.ImageAndText;
					}
					else if (rdoTextOnly.Checked)
					{
						IMS.WebApp.Tools.Settings.Settings.ToolbarAppearance = ToolStripItemDisplayStyle.Text;
					}

					IMS.WebApp.Tools.Settings.Settings.ApplyToApplicationToolbar = chkApplicationToolbars.Checked;
					IMS.WebApp.Tools.Settings.Settings.ApplyToDocumentsToolbar = chkDocumentToolbar.Checked;

				#endregion

				#region Save Recent Files Settings

					IMS.WebApp.Tools.Settings.Settings.NumberOfRecentlyTestsShown = (int)nRecentTests.Value;
					IMS.WebApp.Tools.Settings.Settings.NumberOfRecentlyBatchesShown = (int)nRecentBatchTests.Value;

				#endregion
			}

		#endregion
	}
}

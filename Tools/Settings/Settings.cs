using System;
using System.Collections.Generic;
using System.Text;
//using Crownwood.DotNetMagic.Common;
using System.Windows.Forms;

using IMS.WebApp.Tools;

namespace IMS.WebApp.Tools.Settings
{
	public enum ExecutionTab
	{
		EXECUTION_LOG, EXECUTION_STATISTICS
	}


	public class Settings
	{
		/// <summary>
		/// Registry path where the the settings will be kept
		/// </summary>
		private static readonly string RegistryRootKey = Application.CompanyName + "\\" + Application.ProductName;


		#region DEFAULT SETTINGS VALUES

			// Default value for application status bar visible
			private static readonly bool DEFAULT_STATUS_BAR_VISIBLE = false;

			// Default value for application visual style
            //private static readonly VisualStyle DEFAULT_VISUAL_STYLE = VisualStyle.MediaPlayerPurple;

			// Default value for toolbar button appearence
			private static readonly ToolStripItemDisplayStyle DEFAULT_TOOLBAR_APPEARENCE = ToolStripItemDisplayStyle.Image;

			// Default value for toolbar appearence style change
			private static readonly bool DEFAULT_TOOLBAR_APPLICATION_STYLE_CHANGE = false;
			private static readonly bool DEFAULT_TOOLBAR_DOCUMENT_STYLE_CHANGE = false;

			// Default values for recently test and batches shown in recent files
			private static readonly int DEFAULT_RECENT_TESTS_SHOWN = 5;
			private static readonly int DEFAULT_RECENT_BATCHES_SHOWN = 5;

			// Default values for multiple threaded execution
			private static readonly bool DEFAULT_USE_MULTIPLE_THREADS = false;
			private static readonly bool DEFAULT_LIMIT_EXECUTION_THREADS = true;
			private static readonly int DEFAULT_MAXIMUM_THREADS_PER_EXECUTION = 5;

			// Default value for default execution tab
			private static readonly ExecutionTab DEFAULT_EXECUTION_TAB = ExecutionTab.EXECUTION_STATISTICS;

			// Default values for execution log path
			private static readonly string DEFAULT_EXECUTION_LOG_OUTPUT_PATH = "";
			private static readonly bool DEFAULT_OVERRIDE_LOG_OUTPUT_PATH = false;

			// Default values for test default server
			private static readonly string DEFAULT_SERVER_URL = "";
			private static readonly bool DEFAULT_OVERRIDE_SERVER_URL = false;
			private static readonly string DEFAULT_FILE_PROJECTS_SERVER = System.IO.Path.Combine(Application.StartupPath, "ProjectsServer.xml");

			// Default values for email server settings
			private static readonly string DEFAULT_EMAIL_SERVER = "";
			private static readonly string DEFAULT_EMAIL_USERNAME = "";
			private static readonly string DEFAULT_EMAIL_PASSWORD = "";

			// Default values for advanced email server settings
			private static readonly int DEFAULT_EMAIL_SMTP_PORT = 25;
			private static readonly bool DEFAULT_EMAIL_SSL_ENCRYPTION = false;
			
			// Default values for default email recipient
			private static readonly string DEFAULT_EMAIL_RECIPIENT_NAME = "";
			private static readonly string DEFAULT_EMAIL_RECIPIENT_ADDRESS = "";

			// Default value for upload location
			private static readonly string DEFAULT_UPLOAD_LOCATION = "";

		#endregion


		#region GETTER / SETTER FOR SETTINGS

			/// <summary>
			/// 
			/// </summary>
			public static Boolean StatusBarVisible
			{
				get
				{
					try
					{
						return Boolean.Parse(Registry.RegistryRead(RegistryRootKey + "\\Settings", "StatusBarVisible").ToString());
					}
					catch
					{
						return DEFAULT_STATUS_BAR_VISIBLE;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "StatusBarVisible", value);
				}
			}

			/// <summary>
			/// The visual style that should be uniform in the application
			/// </summary>
            //public static VisualStyle Style
            //{
            //    get
            //    {
            //        try
            //        {
            //            string visualStyleName = (String)Registry.RegistryRead(RegistryRootKey + "\\Settings", "Style");

            //            #region Determine Visual Style

            //                switch (visualStyleName)
            //                {
            //                    // Can not use VisualStyle.Plain.ToString() - because compiler doesn't recognize it as a constant
            //                    case "Plain":
            //                        return VisualStyle.Plain;

            //                    case "IDE2005":
            //                        return VisualStyle.IDE2005;

            //                    case "Office2003":
            //                        return VisualStyle.Office2003;

            //                    case "Office2007Black":
            //                        return VisualStyle.Office2007Black;

            //                    case "Office2007Blue":
            //                        return VisualStyle.Office2007Blue;

            //                    case "Office2007Silver":
            //                        return VisualStyle.Office2007Silver;

            //                    case "MediaPlayerBlue":
            //                        return VisualStyle.MediaPlayerBlue;

            //                    case "MediaPlayerOrange":
            //                        return VisualStyle.MediaPlayerOrange;

            //                    case "MediaPlayerPurple":
            //                        return VisualStyle.MediaPlayerPurple;

            //                    default:
            //                        return DEFAULT_VISUAL_STYLE;
            //                }

            //            #endregion
            //        }
            //        catch
            //        {
            //            return DEFAULT_VISUAL_STYLE;
            //        }
            //    }

            //    set
            //    {
            //        Registry.RegistryWrite(RegistryRootKey + "\\Settings", "Style", value);
            //    }
            //}

			/// <summary>
			/// The toolbar buttons appearence
			/// </summary>
			public static ToolStripItemDisplayStyle ToolbarAppearance
			{
				get
				{
					try
					{
						string styleToolbarButton = (String)Registry.RegistryRead(RegistryRootKey + "\\Settings", "Toolbar Button Style");

						#region Determine Toolbar Buttons Appearance Style

							switch (styleToolbarButton)
							{
								case "Image":
									return ToolStripItemDisplayStyle.Image;

								case "Text":
									return ToolStripItemDisplayStyle.Text;

								case "ImageAndText":
									return ToolStripItemDisplayStyle.ImageAndText;

								default:
									return ToolStripItemDisplayStyle.Image;
							}

						#endregion
					}
					catch
					{
						return DEFAULT_TOOLBAR_APPEARENCE;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "Toolbar Button Style", value);
				}
			}

			/// <summary>
			/// By default do not allow application toolbar to be modified
			/// </summary>
			public static Boolean ApplyToApplicationToolbar
			{
				get
				{
					try
					{
						return Boolean.Parse(Registry.RegistryRead(RegistryRootKey + "\\Settings", "ApplyToApplicationToolbar").ToString());
					}
					catch
					{
						return DEFAULT_TOOLBAR_APPLICATION_STYLE_CHANGE;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "ApplyToApplicationToolbar", value);
				}
			}

			/// <summary>
			/// By default do not allow document toolbars to be modified
			/// </summary>
			public static Boolean ApplyToDocumentsToolbar
			{
				get
				{
					try
					{
						return Boolean.Parse(Registry.RegistryRead(RegistryRootKey + "\\Settings", "ApplyToDocumentToolbar").ToString());
					}
					catch
					{
						return DEFAULT_TOOLBAR_DOCUMENT_STYLE_CHANGE;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "ApplyToDocumentToolbar", value);
				}
			}

			/// <summary>
			/// The number of recently opened tests to be shown
			/// </summary>
			public static int NumberOfRecentlyTestsShown
			{
				get
				{
					try
					{
						return (int)Registry.RegistryRead(RegistryRootKey + "\\Settings", "Recent Tests");
					}
					catch
					{
						return DEFAULT_RECENT_TESTS_SHOWN;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "Recent Tests", value);
				}
			}

			/// <summary>
			/// The number of recently opened batches to be shown
			/// </summary>
			public static int NumberOfRecentlyBatchesShown
			{
				get
				{
					try
					{
						return (int)Registry.RegistryRead(RegistryRootKey + "\\Settings", "Recent Batches");
					}
					catch
					{
						return DEFAULT_RECENT_BATCHES_SHOWN;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "Recent Batches", value);
				}
			}

			/// <summary>
			/// Enable / disable multithreaded execution
			/// </summary>
			public static Boolean UseMultipleThreads
			{
				get
				{
					try
					{
						return Boolean.Parse(Registry.RegistryRead(RegistryRootKey + "\\Settings", "UseMultipleThreads").ToString());
					}
					catch
					{
						return DEFAULT_USE_MULTIPLE_THREADS;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "UseMultipleThreads", value);
				}
			}

			/// <summary>
			/// Enable / disable execution threads limit
			/// </summary>
			public static Boolean LimitExecutionThreads
			{
				get
				{
					try
					{
						return Boolean.Parse(Registry.RegistryRead(RegistryRootKey + "\\Settings", "LimitExecutionThreads").ToString());
					}
					catch
					{
						return DEFAULT_LIMIT_EXECUTION_THREADS;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "LimitExecutionThreads", value);
				}
			}

			/// <summary>
			/// Maximum execution threads limit
			/// </summary>
			public static int MaximumThreadsPerExecution
			{
				get
				{
					try
					{
						return (int)Registry.RegistryRead(RegistryRootKey + "\\Settings", "MaximumThreadsPerExecution");
					}
					catch
					{
						return DEFAULT_MAXIMUM_THREADS_PER_EXECUTION;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "MaximumThreadsPerExecution", value);
				}
			}

			/// <summary>
			/// Default execution tab
			/// </summary>
			public static ExecutionTab DefaultExecutionTab
			{
				get
				{
					try
					{
						string executionTabName = Registry.RegistryRead(RegistryRootKey + "\\Settings", "DefaultExecutionTab").ToString();

						switch (executionTabName)
						{
							case "EXECUTION_LOG":
								return ExecutionTab.EXECUTION_LOG;

							case "EXECUTION_STATISTICS":
								return ExecutionTab.EXECUTION_STATISTICS;

							default:
								return DEFAULT_EXECUTION_TAB;
						}
					}
					catch
					{
						return DEFAULT_EXECUTION_TAB;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "DefaultExecutionTab", value);
				}
			}

			/// <summary>
			/// Default log output path
			/// </summary>
			public static string DefaultLogOutputPath
			{
				get
				{
					try
					{
						return Registry.RegistryRead(RegistryRootKey + "\\Settings", "DefaultLogOutputPath").ToString();
					}
					catch
					{
						return DEFAULT_EXECUTION_LOG_OUTPUT_PATH;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "DefaultLogOutputPath", value);
				}
			}

			/// <summary>
			/// Override tests log output path
			/// </summary>
			public static Boolean OverrideLogOutputPath
			{
				get
				{
					try
					{
						return Boolean.Parse(Registry.RegistryRead(RegistryRootKey + "\\Settings", "OverrideLogOutputPath").ToString());
					}
					catch
					{
						return DEFAULT_OVERRIDE_LOG_OUTPUT_PATH;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "OverrideLogOutputPath", value);
				}
			}

			/// <summary>
			/// Default server URL settings
			/// </summary>
			public static string DefaultServerURL
			{
				get
				{
					try
					{
						return Registry.RegistryRead(RegistryRootKey + "\\Settings", "DefaultServerURL").ToString();
					}
					catch
					{
						return DEFAULT_SERVER_URL;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "DefaultServerURL", value);
				}
			}

			/// <summary>
			/// Override server url
			/// </summary>
			public static Boolean OverrideServerURL
			{
				get
				{
					try
					{
						return Boolean.Parse(Registry.RegistryRead(RegistryRootKey + "\\Settings", "OverrideServerURL").ToString());
					}
					catch
					{
						return DEFAULT_OVERRIDE_SERVER_URL;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "OverrideServerURL", value);
				}
			}

			/// <summary>
			/// File where projects server are stored
			/// </summary>
			public static string FileProjectsServer
			{
				get
				{
					try
					{
						return Registry.RegistryRead(RegistryRootKey + "\\Settings", "File Projects Server").ToString();
					}
					catch
					{
						return DEFAULT_FILE_PROJECTS_SERVER;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "File Projects Server", value);
				}
			}

			/// <summary>
			/// EMail server used
			/// </summary>
			public static string EMailServer
			{
				get
				{
					try
					{
						return Registry.RegistryRead(RegistryRootKey + "\\Settings", "E-Mail Server").ToString();
					}
					catch
					{
						return DEFAULT_EMAIL_SERVER;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "E-Mail Server", value);
				}
			}

			/// <summary>
			/// EMail Username
			/// </summary>
			public static string EMailUsername
			{
				get
				{
					try
					{
						return Registry.RegistryRead(RegistryRootKey + "\\Settings", "E-Mail Username").ToString();
					}
					catch
					{
						return DEFAULT_EMAIL_USERNAME;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "E-Mail Username", value);
				}
			}

			/// <summary>
			/// EMail Password
			/// </summary>
			public static string EMailPassword
			{
				get
				{
					try
					{
						return Registry.RegistryRead(RegistryRootKey + "\\Settings", "E-Mail Password").ToString();
					}
					catch
					{
						return DEFAULT_EMAIL_PASSWORD;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "E-Mail Password", value);
				}
			}

			/// <summary>
			/// SMTP Port used
			/// </summary>
			public static int PortSMTP
			{
				get
				{
					try
					{
						return (int)Registry.RegistryRead(RegistryRootKey + "\\Settings", "SMTP Port");
					}
					catch
					{
						return DEFAULT_EMAIL_SMTP_PORT;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "SMTP Port", value);
				}
			}

			/// <summary>
			/// SSL Encryption used
			/// </summary>
			public static bool EncryptSSL
			{
				get
				{
					try
					{
						return Boolean.Parse(Registry.RegistryRead(RegistryRootKey + "\\Settings", "Encrypt SSL").ToString());
					}
					catch
					{
						return DEFAULT_EMAIL_SSL_ENCRYPTION;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "Encrypt SSL", value);
				}
			}

			/// <summary>
			/// Email Recipient Name
			/// </summary>
			public static string RecipientName
			{
				get
				{
					try
					{
						return Registry.RegistryRead(RegistryRootKey + "\\Settings", "Recipient Name").ToString();
					}
					catch
					{
						return DEFAULT_EMAIL_RECIPIENT_NAME;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "Recipient Name", value);
				}
			}

			/// <summary>
			/// EMail Recipient Address
			/// </summary>
			public static string RecipientAddress
			{
				get
				{
					try
					{
						return Registry.RegistryRead(RegistryRootKey + "\\Settings", "Recipient Address").ToString();
					}
					catch
					{
						return DEFAULT_EMAIL_RECIPIENT_ADDRESS;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "Recipient Address", value);
				}
			}

			/// <summary>
			/// Upload location
			/// </summary>
			public static string UploadLocation
			{
				get
				{
					try
					{
						return Registry.RegistryRead(RegistryRootKey + "\\Settings", "Upload Location").ToString();
					}
					catch
					{
						return DEFAULT_UPLOAD_LOCATION;
					}
				}

				set
				{
					Registry.RegistryWrite(RegistryRootKey + "\\Settings", "Upload Location", value);
				}
			}

		#endregion


		#region STATIC FUNCTIONS

			/// <summary>
			/// Function used to restore default settings for application
			/// Active settings will be overwritten with default values
			/// </summary>
			public static void RestoreDefaultSettings()
			{
				// Restore default visual style
                //Style = DEFAULT_VISUAL_STYLE;

				// Restore default recent files shown
				NumberOfRecentlyTestsShown = DEFAULT_RECENT_TESTS_SHOWN;
				NumberOfRecentlyBatchesShown = DEFAULT_RECENT_BATCHES_SHOWN;

				// Restore default multithreaded execution settings
				UseMultipleThreads = DEFAULT_USE_MULTIPLE_THREADS;
				LimitExecutionThreads = DEFAULT_LIMIT_EXECUTION_THREADS;
				MaximumThreadsPerExecution = DEFAULT_MAXIMUM_THREADS_PER_EXECUTION;

				// Restore default execution tab setting
				DefaultExecutionTab = DEFAULT_EXECUTION_TAB;

				// Restore default execution log output path settings
				DefaultLogOutputPath = DEFAULT_EXECUTION_LOG_OUTPUT_PATH;
				OverrideLogOutputPath = DEFAULT_OVERRIDE_LOG_OUTPUT_PATH;

				// Restore default test server setting
				DefaultServerURL = DEFAULT_SERVER_URL;

				// Restore default e-mail server settings
				EMailServer = DEFAULT_EMAIL_SERVER;
				EMailUsername = DEFAULT_EMAIL_USERNAME;
				EMailPassword = DEFAULT_EMAIL_PASSWORD;

				// Restore default e-mail server advanced settings
				PortSMTP = DEFAULT_EMAIL_SMTP_PORT;
				EncryptSSL = DEFAULT_EMAIL_SSL_ENCRYPTION;

				// Restore default e-mail recipient settings
				RecipientName = DEFAULT_EMAIL_RECIPIENT_NAME;
				RecipientAddress = DEFAULT_EMAIL_RECIPIENT_ADDRESS;

				// Restore default upload settings
				UploadLocation = DEFAULT_UPLOAD_LOCATION;
			}
		
		#endregion


		#region EXECUTION ENGINE

			public static int ExecutionEngine
			{
				get
				{
					return 1;
				}
			}

		#endregion


		#region CONNECTION TYPE

			public static int ConnectionType
			{
				get
				{
					return 1;
				}
			}

		#endregion
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

//using Crownwood.DotNetMagic.Common;

namespace IMS.WebApp.UI.Forms.Help
{
	partial class About : Form //Crownwood.DotNetMagic.Forms.DotNetMagicForm
	{
		/// <summary>
		/// Default constructor
		/// It will initialize the components and then update the About box
		/// visual style to the one saved in the settings (or default one)
		/// </summary>
		public About()
		{
			InitializeComponent();

			// Update the visual style of the About box accordingly to saved settings
            //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);
			
            //this.Text = String.Format("About {0}", AssemblyTitle);
			this.labelProductName.Text = AssemblyProduct;
			this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
			this.labelCopyright.Text = AssemblyCopyright;
			this.labelCompanyName.Text = AssemblyCompany;
			this.textBoxDescription.Text = AssemblyDescription;
		}
		

		#region Assembly Attribute Accessors

			/// <summary>
			/// Automatically generated getter for Assembly Title
			/// </summary>
			public string AssemblyTitle
			{
				get
				{
					object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);

					if (attributes.Length > 0)
					{
						AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
						if (titleAttribute.Title != "")
						{
							return titleAttribute.Title;
						}
					}
		
					return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
				}
			}

			/// <summary>
			/// Automatically generated getter for Assembly Version
			/// </summary>
			public string AssemblyVersion
			{
				get
				{
					return Assembly.GetExecutingAssembly().GetName().Version.ToString();
				}
			}

			/// <summary>
			/// Automatically generated getter for Assembly Description
			/// </summary>
			public string AssemblyDescription
			{
				get
				{
					object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);

					if (attributes.Length == 0)
					{
						return "";
					}
		
					return ((AssemblyDescriptionAttribute)attributes[0]).Description;
				}
			}

			/// <summary>
			/// Automatically generated getter for Assembly Product
			/// </summary>
			public string AssemblyProduct
			{
				get
				{
					object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				
					if (attributes.Length == 0)
					{
						return "";
					}
					
					return ((AssemblyProductAttribute)attributes[0]).Product;
				}
			}

			/// <summary>
			/// Automatically generated getter for Assembly Copyright
			/// </summary>
			public string AssemblyCopyright
			{
				get
				{
					object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
					
					if (attributes.Length == 0)
					{
						return "";
					}
					
					return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
				}
			}

			/// <summary>
			/// Automatically generated getter for Assembly Company
			/// </summary>
			public string AssemblyCompany
			{
				get
				{
					object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
					
					if (attributes.Length == 0)
					{
						return "";
					}
					
					return ((AssemblyCompanyAttribute)attributes[0]).Company;
				}
			}

		#endregion


		#region METHODS

			/// <summary>
			/// Method used to update the visual style for the About box
			/// </summary>
			/// <param name="visualStyle">The new style which the About box must adopt</param>
            //private void UpdateVisualStyle(VisualStyle style)
            //{
            //    // Set style to About box
            //    this.Style = style;
            //}
		
		#endregion
	}
}

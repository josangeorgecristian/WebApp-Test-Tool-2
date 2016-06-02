using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

//using Crownwood.DotNetMagic.Common;

namespace IMS.WebApp.UI.Forms.Help
{
	public partial class WebAppHelp : Form //Crownwood.DotNetMagic.Forms.DotNetMagicForm
	{
		#region FIELDS
		#endregion


		#region GETTER / SETTER
		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Default constructor
			/// It will initialize the components and then update the window
			/// visual style to the one saved in settings (or default one)
			/// </summary>
			public WebAppHelp()
			{
				InitializeComponent();

				// Update the visual style of the application acordingly to saved settings
                //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

				// Set the default value
				StreamReader stream = new StreamReader("..\\Help Files\\index.html");
				htmlHelpDisplay.DocumentStream = stream.BaseStream;
			}

		#endregion


		#region STATIC FUNCTIONS
		#endregion


		#region EVENTS
		#endregion


		#region METHODS

			/// <summary>
			/// Method used to update the visual style for the current window and opened documents
			/// </summary>
			/// <param name="style">The new style which the current window must adopt</param>
            //private void UpdateVisualStyle(VisualStyle style)
            //{
            //    // Set style to the window
            //    this.Style = style;
            //}

		#endregion
	}
}

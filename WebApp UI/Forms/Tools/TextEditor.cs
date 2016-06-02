using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Crownwood.DotNetMagic.Common;

namespace IMS.WebApp.UI.Forms.Tools
{
	public partial class TextEditor : Form // Crownwood.DotNetMagic.Forms.DotNetMagicForm
	{
		public TextEditor()
		{
			InitializeComponent();

            //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);
		}

		public TextEditor(string text)
		{
			InitializeComponent();

            //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

			TextControl.Text = text;
		}

        //private void UpdateVisualStyle(VisualStyle visualStyle)
        //{
        //    Style = visualStyle;
        //}

		public string String
		{
			get { return TextControl.Text; }
		}
	}
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using IMS.WebApp.UI.Forms;

namespace IMS.WebApp.UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(String[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (args.Length == 0)
			{
				Application.Run(new WebAppMain());
			}
			else
			{
				Application.Run(new WebAppMain(args[0]));
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IMS.WebApp.UI.Interfaces
{
	public interface ISettingsControl
	{
		void LoadSettings();
		void SaveSettings();
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IMS.WebApp.UI.Interfaces
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class FileDelegates
	{
		public delegate void FileChanged();
	}

	/// <summary>
	/// 
	/// </summary>
	public interface IFile
	{
		event FileDelegates.FileChanged OnConfigurationChanged;

		bool WasChanged { get; }
		bool WasSaved { get; }

		string Title { get; }
		string FileName { get; }

		void Save();
		void SaveAs(string filename);
		void LoadFromFile(string filename);
	}
}

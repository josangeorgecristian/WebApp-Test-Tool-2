using System;
using System.Collections.Generic;
using System.Text;

//using Crownwood.DotNetMagic.Common;

using IMS.WebApp.Data;
using IMS.WebApp.Data.Documents.Interfaces;

namespace IMS.WebApp.UI.Interfaces
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class DocumentDelegates
	{
		public delegate void ExecutionStateChanged();
	}

	/// <summary>
	/// 
	/// </summary>
	public interface IDocument : IFile
	{
		event DocumentDelegates.ExecutionStateChanged OnExecutionStateChanged;

		IDocumentConfiguration Configuration { get; }

		bool CanRun { get; }
		bool IsRunning { get; }

		void StartExecution();
		void StopExecution();

        //void UpdateVisualStyle(VisualStyle style);
		void UpdateControlsState();
	}
}

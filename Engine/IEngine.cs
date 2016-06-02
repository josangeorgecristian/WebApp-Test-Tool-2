using System;
using System.Collections.Generic;
using System.Text;

using IMS.WebApp.Data.Units;

namespace IMS.WebApp.Engine
{
	/// <summary>
	/// Enumeration used to determine execution progress report type
	/// </summary>
	public enum ExecutionProgressReportType : int
	{
		EXECUTION_START				= 0,
		EXECUTION_CONNECTION_ERROR	= 1,
		EXECUTION_FATAL_ERROR		= 2,
		EXECUTION_STEP_PREEXECUTION = 3,
		EXECUTION_STEP_SUCCESS		= 4,
		EXECUTION_STEP_WARNING		= 5,
		EXECUTION_STEP_ERROR		= 6,
		EXECUTION_STEP_FATALERROR	= 7,
		EXECUTION_ENDS				= 8
	}


	/// <summary>
	/// 
	/// </summary>
	public sealed class EngineExecutionProgressReport
	{
		#region FIELDS

			private int threadID;
			private int execution;
			private ExecutionProgressReportType progressReportType;
			private TestUnit unit;
			private TestUnitExecuted executedUnit;
			private string information;

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// 
			/// </summary>
			/// <param name="thread"></param>
			/// <param name="execution"></param>
			/// <param name="reportType"></param>
			/// <param name="information"></param>
			public EngineExecutionProgressReport(int thread, int execution, ExecutionProgressReportType reportType, string information)
			{
				this.threadID			= thread;
				this.execution			= execution;
				this.progressReportType = reportType;
				this.information		= information;
			}


			public EngineExecutionProgressReport(int thread, int execution, ExecutionProgressReportType reportType, string information, TestUnit unit)
				: this (thread, execution, reportType, information)
			{
				this.unit				= unit;
			}


			/// <summary>
			/// 
			/// </summary>
			/// <param name="thread"></param>
			/// <param name="execution"></param>
			/// <param name="reportType"></param>
			/// <param name="information"></param>
			/// <param name="executedUnit"></param>
			public EngineExecutionProgressReport(int thread, int execution, ExecutionProgressReportType reportType, string information, TestUnitExecuted executedUnit)
				: this (thread, execution, reportType, information)
			{
				this.executedUnit		= executedUnit;
			}

		#endregion


		#region GETTER / SETTER

			public int Thread
			{
				get { return threadID; }
			}

			public int Execution
			{
				get { return execution; }
			}

			public string Information
			{
				get { return information; }
			}

			public ExecutionProgressReportType ReportType
			{
				get { return progressReportType; }
			}

			public TestUnit Unit
			{
				get { return unit; }
			}

			public TestUnitExecuted ExecutedUnit
			{
				get { return executedUnit; }
			}

		#endregion
	}
	


	/// <summary>
	/// Class containing engine delegates
	/// </summary>
	public sealed class EngineDelegates
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="percentage"></param>
		/// <param name="progressReport"></param>
		public delegate void Information(int percentage, EngineExecutionProgressReport progressReport);
	}



	/// <summary>
	/// 
	/// </summary>
	public sealed class DocumentNotRecognizedException : Exception
	{
		public DocumentNotRecognizedException() : this("Unknown Error")
		{		}


		public DocumentNotRecognizedException(string message) : base(message)
		{		}
	}


	/// <summary>
	/// Interface for engines
	/// </summary>
	public interface IEngine
	{
		#region EVENTS

			/// <summary>
			/// Event used to pass information on execution progress back to document
			/// </summary>
			event EngineDelegates.Information OnInformationUpdate;

		#endregion
		

		#region METHODS

			/// <summary>
			/// Function used to execute DocumentConfiguration
			/// </summary>
			/// <param name="configuration">Document configuration to be executed</param>
			/// <param name="cancel">Boolean value used for cancelling Document configuration execution</param>
			 void Run(IMS.WebApp.Data.Documents.Interfaces.IDocumentConfiguration configuration);

			/// <summary>
			/// Function used to pause DocumentConfiguration execution
			/// </summary>
			void Pause();

			/// <summary>
			/// Function used to stop DocumentConfiguration execution
			/// </summary>
			void Stop();

		#endregion
	}
}

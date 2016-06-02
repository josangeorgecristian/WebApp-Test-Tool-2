using System;
using System.Collections.Generic;
using System.Text;

using IMS.WebApp.Tools.Settings;

namespace IMS.WebApp.Engine
{
	/// <summary>
	/// Class that holds the execution paramters
	/// The getters will return the value based on application settings (server url, threads)
	/// </summary>
	public sealed class ExecutionParameters
	{
		#region FIELDS

			private string url;
			private string logOutputPath;
			private string emailRecipient;
			
			private int threads;

		#endregion
		

		#region CONSTRUCTORS

			/// <summary>
			/// 
			/// </summary>
			/// <param name="url"></param>
			/// <param name="logOutputPath"></param>
			/// <param name="emailRecipient"></param>
			/// <param name="threads"></param>
			public ExecutionParameters(string url, string logOutputPath, string emailRecipient, int threads)
			{
				this.url = url;
				this.logOutputPath = logOutputPath;
				this.emailRecipient = emailRecipient;

				this.threads = threads;
			}

		#endregion

		
		#region GETTER / SETTER

			public string URL
			{
				get
				{
					if (Settings.OverrideServerURL)
						return Settings.DefaultServerURL;

					return url;
				}
			}

			public string LogOutputPath
			{
				get
				{
					if (Settings.OverrideLogOutputPath)
						return Settings.DefaultLogOutputPath;

					return logOutputPath;
				}
			}

			public int NumberOfThreads
			{
				get
				{
					if (!Settings.UseMultipleThreads)
						return 1;

					if (Settings.LimitExecutionThreads && threads > Settings.MaximumThreadsPerExecution)
						return Settings.MaximumThreadsPerExecution;
					else
						return threads;
				}
			}

		#endregion
	}


	/// <summary>
	/// EngineFactory
	/// Singleton pattern class
	/// Used to create execution engines based on the engine type in settings
	/// </summary>
	public sealed class EngineFactory
	{
		#region FIELDS

            /// <summary>
            /// Use a simple Singleton pattern - eager initialization of a static member
            /// Static member initialization is thread safe; use this method to avoid the overkill
            /// of thread syncronization
            /// </summary>
            private static readonly EngineFactory _instance = new EngineFactory();

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Private empty constructor - class instance will be created using singleton pattern
			/// </summary>
			private EngineFactory()
			{			}

		#endregion


        #region GETTER / SETTER

			/// <summary>
			/// Gets the singleton instance of the EngineFactory
			/// </summary>
            public static EngineFactory Instance
            {
                get { return _instance; }
            }

        #endregion


        #region METHODS

			/// <summary>
			/// Function used for creating an execution engine
			/// </summary>
			/// <returns>A newly created execution engine</returns>
            public IEngine CreateEngine()
			{
				// Read the ExecutionEngine type from settings and determine which type should it be created
				switch (IMS.WebApp.Tools.Settings.Settings.ExecutionEngine)
				{
					// Create other engines here (depending on settings)

					// Default engine is the JSCN Engine
					default:
						return new JSCN.JSCNEngine();
				}
			}

		#endregion
	}
}

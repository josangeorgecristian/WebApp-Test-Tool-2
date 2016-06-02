using System;
using System.IO;
using System.Xml.Serialization;

using IMS.WebApp.Data.Documents.Interfaces;
using IMS.WebApp.Data.Units;

namespace IMS.WebApp.Data
{
	public enum BatchTestBehaviourOnWarningError
	{
		CONTINUE = 0, EXECUTENEXT = 1, STOPCURRENT = 2, STOPALL = 3, USERDEFINED = 4
	}

	public class BatchTestConfiguration : IDocumentConfiguration
	{
		#region FIELDS

			/// <summary>
			/// Self generated id for batch test
			/// </summary>
			private string id;

			// General Tab
			private string name;
			private string description;

			// Configuration -> Server Options Tab
			private string url;
			private string username;
			private string password;

			// Configuration -> Runtime Tab
			private int numberOfExecutions = 1;
			private int numberOfThreads = 1;

			private int delayExecution;
			private int delayTest;
			private int delayTestExecution;
			private int delayTestUnits;

			private bool overrideDelayTestExecution;
			private bool overrideDelayTestStep;

			private BatchTestBehaviourOnWarningError warningBehavior;
			private BatchTestBehaviourOnWarningError errorBehavior;

			private bool clearExecutionLog;

			// Configuration -> Logging Tab
			private string logOutputPath;

			private bool enableLogging;
			private bool createSeparateLogFiles;

			// Configuration -> EMail Tab
			private string emailAddress;

			private bool sendMailOnFailureOnly;
			private bool sendMailFormConsoleOnly;

			// Execution units
			private BatchTestUnit[] batchTestUnits;

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Default constructor
			/// It will create a BatchTestConfiguration object with default values
			/// </summary>
			public BatchTestConfiguration()
			{
				this.url = IMS.WebApp.Tools.Settings.Settings.DefaultServerURL;

				this.logOutputPath = IMS.WebApp.Tools.Settings.Settings.DefaultLogOutputPath;

				this.emailAddress = IMS.WebApp.Tools.Settings.Settings.RecipientAddress;
			}

		#endregion


		#region STATIC FUNCTIONS

			/// <summary>
			/// Function used to deserialize a BatchTestConfiguration object from a file
			/// </summary>
			/// <param name="fileName">File name from where the object will be deserialized</param>
			/// <returns>The deserialized BatchTestConfiguration object</returns>
			public static BatchTestConfiguration LoadFromFile(string fileName)
			{
				try
				{
					// Create a file stream opening for reading	the file provided
					FileStream file = File.OpenRead(fileName);

					try
					{
						// Create a XML serializer of BatchTestConfiguration type
						XmlSerializer serializer = new XmlSerializer(typeof(BatchTestConfiguration));

						// Attempt to deserialize the configuration from file stream
						BatchTestConfiguration configuration = serializer.Deserialize(file) as BatchTestConfiguration;

						// Close the file stream
						file.Close();

						// Return the configuration object
						return configuration;
					}
					catch (Exception exception)
					{
						// Make sure the file strem is closed
						if (file != null)
							file.Close();

						throw exception;
					}
				}
				catch (IOException exception)
				{
					throw exception;
				}
			}

			/// <summary>
			/// Function used to serialize a BatchTestConfiguration object to a file
			/// </summary>
			/// <param name="fileName">File name where the object will be serialized</param>
			/// <param name="configuration">BatchTestConfiguration object to be serialized</param>
			public static void SaveToFile(string fileName, BatchTestConfiguration configuration)
			{
				try
				{
					// Create a file stream creating or overwriting the file provided
					FileStream file = File.Create(fileName);

					try
					{
						// Create a XML serializer of BatchTestConfiguration type
						XmlSerializer serializer = new XmlSerializer(typeof(BatchTestConfiguration));

						// Attempt to serialize the BatchTestConfiguration object to file stream
						serializer.Serialize(file, configuration);

						// Close the file stream
						file.Close();
					}
					catch (Exception exception)
					{
						// Make sure the file stream is closed
						if (file != null)
							file.Close();

						throw exception;
					}
				}
				catch (IOException exception)
				{
					throw exception;
				}
			}

		#endregion


		#region IDocumentConfiguration Members

			/// <summary>
			/// 
			/// </summary>
			public string ID
			{
				get { return id; }
			}

			/// <summary>
			/// 
			/// </summary>
			public string Name
			{
				get { return name; }
				set { name = value; }
			}
		
			/// <summary>
			/// 
			/// </summary>
			public string Description
			{
				get { return description; }
				set { description = value; }
			}

		#endregion


		#region GETTER \ SETTER

			#region Configuration -> Server Options Tab

				public string Url
				{
					get { return url; }
					set { url = value; }
				}

				public string Username
				{
					get { return username; }
					set { username = value; }
				}

				public string Password
				{
					get { return password; }
					set { password = value; }
				}

			#endregion

			#region Configuration -> Runtime Tab

				public int NumberOfExecutions
				{
					get { return numberOfExecutions; }
					set { numberOfExecutions = value; }
				}

				public int NumberOfThreads
				{
					get { return numberOfThreads; }
					set { numberOfThreads = value; }
				}

				public int ExecutionDelay
				{
					get { return delayExecution; }
					set { delayExecution = value; }
				}

				public int TestDelay
				{
					get { return delayTest; }
					set { delayTest = value; }
				}

				public int TestExecutionDelay
				{
					get { return delayTestExecution; }
					set { delayTestExecution = value; }
				}

				public int TestStepDelay
				{
					get { return delayTestUnits; }
					set { delayTestUnits = value; }
				}

				public bool OverrideTestExecutionDelay
				{
					get { return overrideDelayTestExecution; }
					set { overrideDelayTestExecution = value; }
				}

				public bool OverrideTestStepDelay
				{
					get { return overrideDelayTestStep; }
					set { overrideDelayTestStep = value; }
				}

				public BatchTestBehaviourOnWarningError WarningBehavior
				{
					get { return warningBehavior; }
					set { warningBehavior = value; }
				}

				public BatchTestBehaviourOnWarningError ErrorBehavior
				{
					get { return errorBehavior; }
					set { errorBehavior = value; }
				}

				public bool ClearExecutionLog
				{
					get { return clearExecutionLog; }
					set { clearExecutionLog = value; }
				}
			
			#endregion

			#region Configuration -> Logging Tab

				public string LogOutputPath
				{
					get { return logOutputPath; }
					set { logOutputPath = value; }
				}

				public bool EnableLogging
				{
					get { return enableLogging; }
					set { enableLogging = value; }
				}

				public bool CreateSeparateLogFiles
				{
					get { return createSeparateLogFiles; }
					set { createSeparateLogFiles = value; }
				}

			#endregion

			#region Configuration -> EMail Tab

				public string EmailAddress
				{
					get { return emailAddress; }
					set { emailAddress = value; }
				}

				public bool SendMailOnFailureOnly
				{
					get { return sendMailOnFailureOnly; }
					set { sendMailOnFailureOnly = value; }
				}

				public bool SendMailFromConsoleOnly
				{
					get { return sendMailFormConsoleOnly; }
					set { sendMailFormConsoleOnly = value; }
				}

			#endregion


			public BatchTestUnit[] BatchTestUnits
			{
				get { return batchTestUnits; }
				set { batchTestUnits = value; }
			}

		#endregion


		#region EVENTS
		#endregion


		#region METHODS
		#endregion
	}
}

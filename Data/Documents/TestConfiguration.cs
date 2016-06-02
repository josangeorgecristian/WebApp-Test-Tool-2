using System;
using System.IO;
using System.Xml.Serialization;

using IMS.WebApp.Data.Documents.Interfaces;
using IMS.WebApp.Data.Units;

namespace IMS.WebApp.Data
{
	public enum TestBehaviourOnWarningError
	{
		CONTINUE = 0, STOPCURRENT = 1, STOPALL = 2
	}

	public enum DataFileType
	{
		XML = 0, EXCEL = 1
	}

	public class TestConfiguration : IDocumentConfiguration
	{
		#region FIELDS
			
			/// <summary>
			/// Self generated id for the test
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
			private int executionCounterStart;

			private int delayExecution;
			private int delayStep;

			private TestBehaviourOnWarningError warningBehavior;
			private TestBehaviourOnWarningError errorBehavior;

			private bool clearExecutionLog;

			// Configuration -> Data Source Tab
			private bool useDataFile;
			private string dataFileName;
			private DataFileType dataFileType;

			// Configuration -> Logging Tab
			private string logOutputPath;

			private bool enableLogging;
			private bool createSeparateLogFiles;

			// Configuration -> EMail Tab
			private string emailAddress;

			private bool sendMailOnFailureOnly;
			private bool sendMailFromConsoleOnly;

			// Execution units
			private TestUnit[] testUnits;

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Default constructor
			/// It will create a TestConfiguration object with default values
			/// </summary>
			public TestConfiguration()
			{
				// Generate new ID for TestConfiguration object
				this.id = System.Guid.NewGuid().ToString();

				// Set default url
				this.url = IMS.WebApp.Tools.Settings.Settings.DefaultServerURL;
				// Set default log output path
				this.logOutputPath = IMS.WebApp.Tools.Settings.Settings.DefaultLogOutputPath;
				// Set default email adddress
				this.emailAddress = IMS.WebApp.Tools.Settings.Settings.RecipientAddress;
			}

		#endregion


		#region STATIC FUNCTIONS

			/// <summary>
			/// Function used to deserialize a TestConfiguration object from a file
			/// </summary>
			/// <param name="filename">File name from where the object will be deserialized</param>
			/// <returns>The deserialized TestConfiguration object</returns>
			public static TestConfiguration LoadFromFile(string filename)
			{
				try
				{
					// Create a file stream opening for reading the file provided
					FileStream file = File.OpenRead(filename);

					try
					{
						// Create a XML serializer of TestConfiguration type
						XmlSerializer serializer = new XmlSerializer(typeof(TestConfiguration));

						// Attempt to deserialize the configuration from file stream
						TestConfiguration configuration = serializer.Deserialize(file) as TestConfiguration;

						// Close the file stream
						file.Close();

						// Return the configuration object
						return configuration;
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

			/// <summary>
			/// Function used to serialize a TestConfiguration object to a file
			/// </summary>
			/// <param name="fileName">File name where the object will be serialized</param>
			/// <param name="configuration">TestConfiguration object to be serialized</param>
			public static void SaveToFile(string fileName, TestConfiguration configuration)
			{
				try
				{
					// Create a file stream creating or overwriting the file provided
					FileStream file = File.Create(fileName);

					try
					{
						// Generate a new ID for the configuration
						configuration.id = System.Guid.NewGuid().ToString();

						// Create a XML serializer of TestConfiguration type
						XmlSerializer serializer = new XmlSerializer(typeof (TestConfiguration));

						// Attempt to serialize the TestConfiguration object to file stream
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
	
		
		#region GETTER / SETTER

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
				public int ExecutionCounterStart
				{
					get { return executionCounterStart; }
					set { executionCounterStart = value; }
				}

				public int ExecutionDelay
				{
					get { return delayExecution; }
					set { delayExecution = value; }
				}
				public int StepDelay
				{
					get { return delayStep; }
					set { delayStep = value; }
				}

				public TestBehaviourOnWarningError WarningBehavior
				{
					get { return warningBehavior; }
					set { warningBehavior = value; }
				}
				public TestBehaviourOnWarningError ErrorBehavior
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

			#region Configuration -> Data Source Tab

				public bool UseDataFile
				{
					get { return useDataFile; }
					set { useDataFile = value; }
				}

				public string DataFileName
				{
					get { return dataFileName; }
					set { dataFileName = value; }
				}

				public DataFileType FileType
				{
					get { return dataFileType; }
					set { dataFileType = value; }
				}

			#endregion

			#region Configuration -> Logging Tab

				public bool EnableLogging
				{
					get { return enableLogging; }
					set { enableLogging = value; }
				}

				public string LogOutputPath
				{
					get { return logOutputPath; }
					set { logOutputPath = value; }
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
					get { return sendMailFromConsoleOnly; }
					set { sendMailFromConsoleOnly = value; }
				}

			#endregion

			
			public TestUnit[] TestUnits
			{
				get { return testUnits; }
				set { testUnits = value; }
			}

            public bool HasTestsExecutedOnce
            {
                get
                {
                    if (testUnits == null)
                        return false;

                    foreach (TestUnit unit in testUnits)
                    {
                        if (unit.ExecuteOnce)
                            return true;
                    }

                    return false;
                }
            }

		#endregion


		#region EVENTS
		#endregion


		#region METHODS
		#endregion
	}
}

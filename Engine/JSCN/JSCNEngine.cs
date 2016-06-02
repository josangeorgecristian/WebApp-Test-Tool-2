using System;
using System.Net;
using System.Threading;
using IMS.WebApp.Communication;
using IMS.WebApp.Data;
using IMS.WebApp.Data.Documents.Interfaces;
using IMS.WebApp.Data.Execution;
using IMS.WebApp.Data.Units;

namespace IMS.WebApp.Engine.JSCN
{
	internal class JSCNEngine : IEngine
    {
        #region SINGLE-THREADED EXECUTION CLASSES

			/// <summary>
			/// Class used as an argument for single threaded execution of a IDocumentConfiguration
			/// Needed to keep code consistency with multi threaded execution where only an object can be passed
			/// </summary>
			private class SingleThreadedExecutionParameter
			{
				#region FIELDS

					private IDocumentConfiguration configuration;
					private int numberOfExecutions;

				#endregion


				#region CONSTRUCTOR

					/// <summary>
					/// 
					/// </summary>
					/// <param name="documentConfiguration"></param>
					/// <param name="numberOfExecution"></param>
					public SingleThreadedExecutionParameter(IDocumentConfiguration documentConfiguration, int numberOfExecution)
					{
						configuration = documentConfiguration;
						this.numberOfExecutions = numberOfExecution;
					}

				#endregion


				#region GETTER

					/// <summary>
					/// 
					/// </summary>
					public IDocumentConfiguration Configuration
					{
						get { return configuration; }
					}

					/// <summary>
					/// 
					/// </summary>
					public int NumberOfExecutions
					{
						get { return numberOfExecutions; }
					}

				#endregion
			}


            /// <summary>
            /// Class used for single threaded execution of a TestConfiguration
            /// </summary>
            private class TestConfigurationSinglethreadedExecutionClass
            {
                #region FIELDS

                    // Event used to pass back execution information
                    private EngineDelegates.Information executionUpdate;

                    // Events used for controling execution (Pause, Stop or Completing)
                    private ManualResetEvent ExecutionPauseEvent;
                    private ManualResetEvent ExecutionStopEvent;
                    private ManualResetEvent ExecutionCompletedEvent;

                #endregion


                #region CONSTRUCTOR

                    /// <summary>
                    /// Constructor for Singlethreaded Execution class for TestConfiguration
                    /// </summary>
                    /// <param name="PauseEvent">Event for pausing execution on user control</param>
                    /// <param name="StopEvent">Event for stoping execution on user control</param>
                    /// <param name="CompletedEvent">Event for execution completion</param>
                    public TestConfigurationSinglethreadedExecutionClass(ManualResetEvent PauseEvent, ManualResetEvent StopEvent, ManualResetEvent CompletedEvent)
                    {
						// Link events for Pause, Stop and Completed events
                        ExecutionPauseEvent = PauseEvent;
                        ExecutionStopEvent = StopEvent;
                        ExecutionCompletedEvent = CompletedEvent;
                    }

                #endregion


                public event EngineDelegates.Information ExecutionUpdate
                {
                    add { executionUpdate += value; }
                    remove { executionUpdate -= value; }
                }


				/// <summary>
				/// 
				/// </summary>
				/// <param name="data"></param>
                public void ExecutionMethod(Object data)
                {
                    // Get data passed as a parameter SingleThreadedExecutionParameter
					SingleThreadedExecutionParameter parameter = data as SingleThreadedExecutionParameter;
					// Get the data from parameter
					TestConfiguration configuration = parameter.Configuration as TestConfiguration;


					// TODO Read Data from data source file

					// TODO Open log file

					int NumberOfExecution = configuration.NumberOfExecutions;


					// Create connection to server
					IConnection connection = ConnectionFactory.Instance.CreateConnection();


					// Start the executions - stop if the ExecutionStopEvent is triggered
					for (int i = 0;	i < parameter.NumberOfExecutions && ExecutionStopEvent.WaitOne(0); i++)
					{
						// Establish connection to server if connection is not active already
						if (!connection.Connected)
							connection.Connect(configuration.Url);

						// Build execution started update parameter
						EngineExecutionProgressReport startExecutionReport = new EngineExecutionProgressReport(0, i, ExecutionProgressReportType.EXECUTION_START, "Execution Started");

						// Call execution update with "Execution Started" message
						executionUpdate(calculatePercentage(), startExecutionReport);


                        // Execute test units
                        foreach (TestUnit unit in configuration.TestUnits)
                        {
							try
							{
								if (!ExecutionStopEvent.WaitOne(0))
								{
									// Build execution stop event - stopped by user
									EngineExecutionProgressReport userStopedExecution = new EngineExecutionProgressReport(0, i, ExecutionProgressReportType.EXECUTION_ENDS, "Execution stopped by user");
									// Notify user stoped execution
									executionUpdate(calculatePercentage(), userStopedExecution);

									return;
								}


								// Replace system tokens
								// Replace data tokens

								// Show pre-execution test unit
								EngineExecutionProgressReport stepPreExecutionReport = new EngineExecutionProgressReport(0, i, ExecutionProgressReportType.EXECUTION_STEP_PREEXECUTION, "Preexecution Step", unit);

								executionUpdate(calculatePercentage(), stepPreExecutionReport);


								// Execute test unit
								TestUnitExecuted unitExecuted = new TestUnitExecuted(unit, connection.Request(unit.Request));


								// Build execution step update parameter
								EngineExecutionProgressReport stepExecutionReport = new EngineExecutionProgressReport(0, i, GetExecutionProgressReportType(unitExecuted), "Execution Step", unitExecuted);

								executionUpdate(calculatePercentage(), stepExecutionReport);


								// Take decision upon execution result
								if (ResponseType.FATALERROR.Equals(unitExecuted.ReceivedResponseType) || ResponseType.ERROR.Equals(unitExecuted.ReceivedResponseType))
								{
									if (TestBehaviourOnWarningError.STOPCURRENT.Equals(configuration.ErrorBehavior))
									{
										connection.Disconnect();
										break;
									}

									if (TestBehaviourOnWarningError.STOPALL.Equals(configuration.ErrorBehavior))
										return;
								}


								if (ResponseType.FATALERROR.Equals(unitExecuted.ReceivedResponseType) || ResponseType.ERROR.Equals(unitExecuted.ReceivedResponseType))
								{
									if (TestBehaviourOnWarningError.STOPCURRENT.Equals(configuration.ErrorBehavior))
									{
										connection.Disconnect();
										break;
									}

									if (TestBehaviourOnWarningError.STOPALL.Equals(configuration.WarningBehavior))
										return;
								}


								if (!ExecutionStopEvent.WaitOne(0))
								{
									// Build execution stop event - stopped by user
									EngineExecutionProgressReport userStoppedExecution = new EngineExecutionProgressReport(0, i, ExecutionProgressReportType.EXECUTION_ENDS, "Execution stopped by user");
									// Notify user stoped execution
									executionUpdate(calculatePercentage(), userStoppedExecution);
									return;
								}
							}
							catch (WebException webEx)
							{
								// Build execution step exception update parameter
								EngineExecutionProgressReport exceptionExecutionReport = new EngineExecutionProgressReport(0, i, ExecutionProgressReportType.EXECUTION_CONNECTION_ERROR, "Connection Error: " + webEx.Message);
								// Notify on the execution exception
								executionUpdate(calculatePercentage(), exceptionExecutionReport);

								// TODO - Treat and notify on errors
								return;
							}
							catch
							{
								// Build execution step exception update parameter
								EngineExecutionProgressReport exceptionExecutionReport = new EngineExecutionProgressReport(0, i, ExecutionProgressReportType.EXECUTION_FATAL_ERROR, "Application Error");
								// Notify on the execution exception
								executionUpdate(calculatePercentage(), exceptionExecutionReport);

								// TODO - Treat and notify on errors
								return;
							}
                        }

						// Build execution ended update parameter
						EngineExecutionProgressReport endExecutionReport = new EngineExecutionProgressReport(0, i, ExecutionProgressReportType.EXECUTION_ENDS, "Execution Ended");

						// Call execution update with "Execution Ended" message
						executionUpdate(calculatePercentage(), endExecutionReport);

						// Disconnect if test doesn't have execute once units and is still connected
						if (!configuration.HasTestsExecutedOnce && connection.Connected)
							connection.Disconnect();
					}

                    ExecutionCompletedEvent.Set();
                }


				#region PRIVATE FUNCTIONS

					/// <summary>
					/// 
					/// </summary>
					/// <param name="executedUnit"></param>
					/// <returns></returns>
					private ExecutionProgressReportType GetExecutionProgressReportType(TestUnitExecuted executedUnit)
					{
						if (ResponseType.FATALERROR.Equals(executedUnit.ReceivedResponseType))
							return ExecutionProgressReportType.EXECUTION_STEP_FATALERROR;

						if (ResponseType.ERROR.Equals(executedUnit.ReceivedResponseType))
							return ExecutionProgressReportType.EXECUTION_STEP_ERROR;

						if (ResponseType.WARNING.Equals(executedUnit.ReceivedResponseType))
							return ExecutionProgressReportType.EXECUTION_STEP_WARNING;

						if (ResponseType.INFORMATION.Equals(executedUnit.ReceivedResponseType))
							return ExecutionProgressReportType.EXECUTION_STEP_WARNING;

						return ExecutionProgressReportType.EXECUTION_STEP_SUCCESS;
					}

					private int calculatePercentage()
					{
						//throw new NotImplementedException();

						return 0;
					}

				#endregion
			}

        #endregion


        #region MULTI-THREADED EXECUTION CLASSES

            private class TestConfigurationMultithreadedExecutionClass
			{
				#region FIELDS (DELGATES & EVENTS for controling the execution)

					// Thread ID
					private int threadID;

					// Event used to pass back execution information
					private EngineDelegates.Information executionUpdate;

					// Events used for controling execution (Pause, Stop or Completing)
					private ManualResetEvent ExecutionPauseEvent;
					private ManualResetEvent ExecutionStopEvent;
					private ManualResetEvent ExecutionCompletedEvent;

				#endregion


				#region CONSTRUCTOR

					/// <summary>
					/// Constructor for Multithreaded Execution class for TestConfiguration
					/// </summary>
					/// <param name="PauseEvent">Event for pausing execution on user comand</param>
					/// <param name="StopEvent">Event for stoping execution on user comand</param>
					/// <param name="CompletedEvent">Event for execution completion</param>
					public TestConfigurationMultithreadedExecutionClass(int threadIndex, ManualResetEvent PauseEvent, ManualResetEvent StopEvent, ManualResetEvent CompletedEvent)
					{
						threadID = threadIndex;

						ExecutionPauseEvent = PauseEvent;
						ExecutionStopEvent = StopEvent;
						ExecutionCompletedEvent = CompletedEvent;
					}
				
				#endregion


				public event EngineDelegates.Information ExecutionUpdate
				{
					add { executionUpdate += value; }
					remove { executionUpdate -= value; }
				}


				/// <summary>
				/// Function used to execute TestConfiguration documents
				/// </summary>
				/// <param name="data">Execution parameter - contains TestConfiguration</param>
				public void ExecutionMethod(Object data)
				{
					// Get data passed as a TestConfiguration
					IMS.WebApp.Data.TestConfiguration configuration = data as IMS.WebApp.Data.TestConfiguration;

					//executionUpdate(threadID, ExecutionProgressReportType.EXECUTION_START, ExecutionResult.SUCCESS, null, "Execution started");

					int i = 0;

					while (ExecutionStopEvent.WaitOne(0) && i < 10)
					{
						// Trigger an event of sorts
						if (executionUpdate != null)
						{
							//executionUpdate(threadID, ExecutionProgressReportType.EXECUTION_STEP, ExecutionResult.SUCCESS, null, i.ToString());
						}

						// Simulate long server response
						i++;
						Thread.Sleep(3000);

						ExecutionPauseEvent.WaitOne();
					}

					//executionUpdate(threadID, ExecutionProgressReportType.EXECUTION_ENDS, ExecutionResult.SUCCESS, null, "Completed!");

					ExecutionCompletedEvent.Set();
				}
			}

		#endregion

		
		#region FIELDS (ENGINE & DELEGATES)

			IConnection connection;

			private EngineDelegates.Information onInformationUpdate;

			private ManualResetEvent pauseEvent = new ManualResetEvent(true);
			private ManualResetEvent stopEvent = new ManualResetEvent(true);

		#endregion


		#region CONSTRUCTOR
		#endregion


		#region IEngine Members

			/// <summary>
			/// Execution engine delegate used for updating progress
			/// </summary>
			public event EngineDelegates.Information OnInformationUpdate
			{
				add { onInformationUpdate += value; }
				remove { onInformationUpdate -= value; }
			}


			/// <summary>
			/// Method used for executing a document.
			/// <p>Supports the following types of documents TestConfiguration, BatchTestConfiguration</p>
			/// </summary>
			/// <param name="configuration">Document configuration to be executed</param>
			/// <param name="cancel">A reference bool parameter used for canceling engine execution</param>
			/// <thows>Can throw DocumentNotRecognizedException if the </thows>
			/// <returns>Returns the execution result of the document.</returns>
			public void Run(IMS.WebApp.Data.Documents.Interfaces.IDocumentConfiguration configuration)
			{
				// Determine the execution type (Test, BatchTest or other type)
				if (configuration is IMS.WebApp.Data.TestConfiguration)
				{
					StartTestConfigurationExecution(configuration as IMS.WebApp.Data.TestConfiguration);

                    return;
				}
				else if (configuration is IMS.WebApp.Data.BatchTestConfiguration)
				{
					StartBatchTestConfigurationExecution(configuration as IMS.WebApp.Data.BatchTestConfiguration);

                    return;
				}

				// If the document is not recognized throw DocumentNotRecognized exception
				throw new DocumentNotRecognizedException("Document format not recognized");
			}


			/// <summary>
			/// Method used for pausing the execution of a document
			/// </summary>
			public void Pause()
			{
				pauseEvent.Reset();
			}


			/// <summary>
			/// Method used for stoping the execution of a document
			/// </summary>
			public void Stop()
			{
				stopEvent.Reset();
			}

		#endregion


		#region TestConfiguration Execution

			/// <summary>
			/// Funtion used to start TestConfiguration execution
			/// </summary>
			/// <param name="configuration">TestConfiguration to be executed</param>
			private void StartTestConfigurationExecution(IMS.WebApp.Data.TestConfiguration configuration)
			{
                // Extract data from Data File
                if (configuration.UseDataFile)
                {
                    throw new NotImplementedException();
                }

                // Determine the number of executions
                    // TODO - Take into account the data from datafiles
				int NumberOfExecutions = configuration.NumberOfExecutions;

                // Determine if this is a single threaded execution or a multithreaded execution
                if (IMS.WebApp.Tools.Settings.Settings.UseMultipleThreads && NumberOfExecutions > 1)
                {
					// TODO - Create parameter for multi threaded execution of a document (Batch Test Configuration)

                    // Start test configuration multithreaded execution
                    ExecuteTestConfigurationMultithreaded(configuration, NumberOfExecutions);

                    return;
                }


				// Create paramter for single threaded execution of a document (Test Configuration)
				SingleThreadedExecutionParameter parameter = new SingleThreadedExecutionParameter(configuration, NumberOfExecutions);

                // Start test configuration singlethreaded execution
                ExecuteTestConfigurationSinglethreaded(parameter);


					// Diferences between single and multithreaded execution
					//	- execute once test units on single connection
					//	- one connection per execution in multithread; a sigle connection for all execution
					//	- data from excel files determine the execution - are the same
					//	- log files are separate for executions; or the same file for execution
					//	- one report must be generated at all times (generating one for each execution will generate too many)

				// Prepare data for execution
				// Get data from excel files
				// Determine if only one log file will be used or multiple logs
				// Can not use one log file for multithreaded execution
			}


		    /// <summary>
            /// 
            /// </summary>
            /// <param name="executionParameter"></param>
            private void ExecuteTestConfigurationSinglethreaded(SingleThreadedExecutionParameter executionParameter)
            {
                ManualResetEvent completedEvent = new ManualResetEvent(false);

                TestConfigurationSinglethreadedExecutionClass executionObject = new TestConfigurationSinglethreadedExecutionClass(pauseEvent, stopEvent, completedEvent);

                // Subscribe to events
                executionObject.ExecutionUpdate += new EngineDelegates.Information(executionUpdate);

                // Start execution
                executionObject.ExecutionMethod(executionParameter);

                // Unsubscribe from events
                executionObject.ExecutionUpdate -= new EngineDelegates.Information(executionUpdate);
            }



            /// <summary>
            /// 
            /// </summary>
            /// <param name="configuration"></param>
            /// <param name="NumberOfExecutions"></param>
            private void ExecuteTestConfigurationMultithreaded(IMS.WebApp.Data.TestConfiguration configuration, int NumberOfExecutions)
            {
                // Get the maximum number of threads
                int NumberOfThreads = NumberOfExecutions < configuration.NumberOfThreads ? NumberOfExecutions : configuration.NumberOfThreads;

                // Create thread pool with the maximum number of execution threads and I/O threads
                // The parameters passed to the function can not be less than the number of processors in the machine
                int Processors = System.Environment.ProcessorCount;
                ThreadPool.SetMaxThreads(NumberOfThreads < Processors ? Processors : NumberOfThreads, NumberOfThreads < Processors ? Processors : NumberOfThreads);


                // Create TestConfiguration execution objects
                TestConfigurationMultithreadedExecutionClass[] executionThreads = new TestConfigurationMultithreadedExecutionClass[NumberOfExecutions];
                // Create TestConfiguration completing execution events
				// These will be used to determine when all executions will complete
                ManualResetEvent[] completedEvents = new ManualResetEvent[NumberOfExecutions];


                for (int i = 0; i < NumberOfExecutions; i++)
                {
                    // Create the events for completing executions
                    completedEvents[i] = new ManualResetEvent(false);

                    // Create the objects for executing classes
                    executionThreads[i] = new TestConfigurationMultithreadedExecutionClass(i, pauseEvent, stopEvent, completedEvents[i]);

                    // Subscribe to events for each execution object created
                    SubscribeToExecutionEvents(executionThreads[i]);

                    // Create execution data object to be passed to execution method


                    // Start queueing the execution objects for processing
                    ThreadPool.QueueUserWorkItem(executionThreads[i].ExecutionMethod, configuration);
                }


                // Wait for all events for completing execution events to be reset
                // This means that all executions have finished processing
                WaitHandle.WaitAll(completedEvents);


                // Unsubscribe from events for each execution object
                for (int i = 0; i < NumberOfExecutions; i++)
                {
                    UnsubscribeFromExecutionEvents(executionThreads[i]);
                }
            }


			/// <summary>
			/// Function used to subscribe to an execution object for TestConfiguration
			/// </summary>
			/// <param name="testExecution">TestConfiguration execution class</param>
			private void SubscribeToExecutionEvents(TestConfigurationMultithreadedExecutionClass testExecution)
			{
				testExecution.ExecutionUpdate += new EngineDelegates.Information(executionUpdate);
			}


			/// <summary>
			/// Function used to unsubscribe from an execution object for TestConfiguration
			/// </summary>
			/// <param name="testExecution">TestConfiguration execution class</param>
			private void UnsubscribeFromExecutionEvents(TestConfigurationMultithreadedExecutionClass testExecution)
			{
				testExecution.ExecutionUpdate -= new EngineDelegates.Information(executionUpdate);
			}

		#endregion


		#region BatchTestConfiguration Execution

			private void StartBatchTestConfigurationExecution(IMS.WebApp.Data.BatchTestConfiguration batchTestConfiguration)
			{
				throw new NotImplementedException();
			}

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="percentage"></param>
        /// <param name="information"></param>
		void executionUpdate(int percentage, EngineExecutionProgressReport progressReport)
		{
			if (onInformationUpdate != null)
				onInformationUpdate(percentage, progressReport);
		}

	}
}

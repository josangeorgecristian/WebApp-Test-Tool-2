using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using IMS.WebApp.Data.Execution;

namespace IMS.WebApp.Data.Units
{
	internal sealed class TestUnitDetails
	{
		#region FIELDS

			private bool editMode = false;
			private string currentForm = "";

			private string requestDescription = "";

			private string expectedResponseDescription;
			private string recievedResponseDescription;
			
			private string differencesDescription = "";

			private ResponseType expectedResponseType = ResponseType.EXPECTED;
			private ResponseType receivedResponseType = ResponseType.EXPECTED;

			private string processingTime;

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// Constructor for creating TestUnitDetails object for a TestUnit object
			/// </summary>
			public TestUnitDetails(TestUnit testUnit)
			{
				AnalyzeRequest(testUnit.Request);

				AnalyzeResponse(testUnit.Response, out currentForm, out editMode, out expectedResponseDescription, out expectedResponseType);
			}

			/// <summary>
			/// Constructor for creating TestUnitDetails object for a TestUnitExecuted object
			/// </summary>
			public TestUnitDetails(TestUnitExecuted testUnitExecuted)
			{
				AnalyzeRequest(testUnitExecuted.Request);

				AnalyzeResponse(testUnitExecuted.Response, out currentForm, out editMode, out expectedResponseDescription, out expectedResponseType);

				AnalyzeResponse(testUnitExecuted.ResponseReceived, out currentForm, out editMode, out recievedResponseDescription, out receivedResponseType);

				if (!testUnitExecuted.IgnoreResponse)
				{
					AnalyzeDifferences(testUnitExecuted.ResponseReceived, testUnitExecuted.Response, out differencesDescription, out receivedResponseType);
				}
			}

		#endregion


		#region GETTER \ SETTER

			public bool EditMode
			{
				get { return editMode; }
			}

			public string CurrentForm
			{
				get { return currentForm; }
			}

			public string RequestDescription
			{
				get { return requestDescription; }
			}

			public string ExpectedResponseDescription
			{
				get { return expectedResponseDescription; }
			}

			public string ReceivedResponseDescription
			{
				get { return recievedResponseDescription; }
			}

			public string DifferencesDescription
			{
				get { return differencesDescription; }
			}

			public bool hasDifferencesInRespose
			{
				get { return differencesDescription.Trim().Length > 0; }
			}

			public ResponseType ExpectedResponseType
			{
				get { return expectedResponseType; }
			}

			public ResponseType ReceivedResponseType
			{
				get { return receivedResponseType; }
			}

			public string ProcessingTime
			{
				get { return processingTime; }
			}

		#endregion


		#region METHODS

			/// <summary>
			/// Method used to analyze TestUnit request
			/// </summary>
			/// <param name="request"></param>
			private void AnalyzeRequest(string request)
			{
				try
				{
					XmlDocument xmlRequest = new XmlDocument();
					xmlRequest.LoadXml(request);

					foreach (XmlNode node in xmlRequest.DocumentElement.ChildNodes)
					{
						switch (node.Name)
						{
							#region Theme & Appeareance events

								case "updateTheme":
								{
									string theme = "Unknown";

									if (node.Attributes["theme"] != null && node.Attributes["theme"].Value != null)
										theme = node.Attributes["theme"].Value;

									requestDescription = theme.Substring(0, 1).ToUpper() + theme.Substring(1) + " Theme";

									return;
								}

							#endregion


							#region Log In & Log Out events

								case "loginEvent":
								{
									string username = "";
									string password = "";

									if (node.Attributes["name"] != null && node.Attributes["name"].Value != null)
										username = node.Attributes["name"].Value;

									if (node.Attributes["pass"] != null && node.Attributes["pass"].Value != null)
										password = node.Attributes["pass"].Value;

									requestDescription = "Login (Username: " + username + " Password: " + password + ")";

									return;
								}

								case "logout":
								{
									requestDescription = "Logout";
									return;
								}

								case "selectRoleEvent":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Role selected";

									break;
								}

							#endregion


							#region Navigation & Dialogs events

								case "navigation":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Navigation clicked";

									break;
								}

								case "openform":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Form opened (" + (node.Attributes["form"] == null ? "?" : node.Attributes["form"].Value) + ")";

									break;
								}

								case "link":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Link clicked";

									break;
								}

								case "dialogWasClosed":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Dialog closed";

									break;
								}

								case "messagebox":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Message box closed";

									break;
								}

								case "containertabselected":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Tab selected";

									break;
								}

								case "alert":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Alert icon clicked";

									break;
								}

								case "riealert":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "RIE Alert icon clicked";

									break;
								}

								case "imsjourney":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Journey entry selected";

									break;
								}

								case "topbutton":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Top button clicked";

									break;
								}

							#endregion


							#region Controls

								#region ComboBox

									case "combobox":
									{
										if (node.Attributes["selection"] != null)
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Combo box selection changed";
										}

										if (node.Attributes["search"] != null)
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Query combo box search performed";
										}

										break;
									}

								#endregion

								#region Grid & Dynamic Grid events

									#region Grid

										case "gridselection":
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Grid selection";

											break;
										}

										case "gridButton":
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Grid button clicked";

											break;
										}

										case "gridmutablecombobox":
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Grid combo box changed";

											break;
										}

									#endregion

									#region Dynamic Grid

										case "dynamicgrid2selection":
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Dynamic grid selection";

											break;
										}

										case "dynamicgrid2checkbox":
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Dynamic grid check box changed";

											break;
										}

										case "dynamicgrid2checkedlistbox":
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Dynamic grid multi check box changed";

											break;
										}

									#endregion

								#endregion

								#region Tree

									case "treeview":
									{
										if (node.Attributes["selection"] != null)
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Tree node selected";
										}

										if (node.Attributes["expanded"] != null)
										{
											if (requestDescription.Length > 0)
												requestDescription += ", ";

											requestDescription += "Tree node expanded";
										}

										break;
									}

									case "treenodeedited":
									{
										if (requestDescription.Length > 0)
											requestDescription += ", ";

										requestDescription += "Tree node edited";

										break;
									}

								#endregion

								case "menuclick":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Context menu item clicked";

									break;
								}

								case "button":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Button clicked";

									break;
								}

								case "imagebutton":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Image button clicked";

									break;
								}

								case "textbox":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Textbox changed";

									break;
								}

								case "checkbox":
								{
									if (node.Attributes["checked"] != null)
									{
										if (requestDescription.Length > 0)
											requestDescription += ", ";

										requestDescription += "Check box changed";
									}

									break;
								}

								case "radiobox":
								{
									if (requestDescription.Length > 0)
										requestDescription += ", ";

									requestDescription += "Radio button changed";

									break;
								}

								case "datebox":
								{
									if (node.Attributes["value"] != null)
									{
										if (requestDescription.Length > 0)
											requestDescription += ", ";

										requestDescription += "Date changed";
									}

									break;
								}
							
							#endregion


							default:
								break;
						}
					}
				}
				catch
				{
					requestDescription = "Invalid request";
				}

				if (requestDescription.Trim().Length == 0)
					requestDescription = request;
			}

			/// <summary>
			/// Method used to analyze TestUnit response
			/// </summary>
			/// <param name="response"></param>
			private void AnalyzeResponse(string response, out string currentForm, out bool editMode, out string responseDescription, out ResponseType responseType)
			{
				editMode = false;
				currentForm = "";
				responseDescription = "";
				responseType = ResponseType.EXPECTED;

				if (response.Trim().Length == 0)
				{
					responseDescription = "No response available";
				}

				try
				{
					XmlDocument xmlResponse = new XmlDocument();
					xmlResponse.LoadXml(response);

					if (xmlResponse.DocumentElement.Attributes["pt"] != null && xmlResponse.DocumentElement.Attributes["pt"].Value != null)
						processingTime = xmlResponse.DocumentElement.Attributes["pt"].Value + " ms";

					foreach (XmlNode node in xmlResponse.DocumentElement.ChildNodes)
					{
						switch (node.Name)
						{
							case "form":
							{
								if (node.Attributes["caption"] != null && node.Attributes["caption"].Value != null)
								{
									currentForm = node.Attributes["caption"].Value;
									responseDescription = "'" + currentForm + "' form loaded";
								}
								else if (node.Attributes["id"] != null && node.Attributes["id"].Value == "selectRoleForm")
								{
									currentForm = "Role selection";
									responseDescription = "Role selection";
								}

								return;
							}

							case "data":
							{
								if (node.Attributes["canLeaveForm"] != null && node.Attributes["canLeaveForm"].Value != null)
								{
									editMode = node.Attributes["canLeaveForm"].Value == "false";
									return;
								}

								break;
							}

							case "passwordDialog":
							{
								responseDescription = "System password dialog displayed";
								return;
							}

							case "html":
							{
								currentForm = "Login screen";
								responseDescription = "Login screen";
								return;
							}

							case "formError":
							{
								string title = "";
								if (node.Attributes["title"] != null && node.Attributes["title"].Value != null)
									title = node.Attributes["title"].Value;

								string caption = "";
								if (node.Attributes["caption"] != null && node.Attributes["caption"].Value != null)
									caption = node.Attributes["caption"].Value;

								responseDescription = caption + ": " + title;

								if (node.Attributes["suspend"] != null && node.Attributes["suspend"].Value != null)
								{
									responseType = ResponseType.FATALERROR;
								}
								else
								{
									responseType = ResponseType.ERROR;
								}

								return;
							}

							default:
								break;
						}
					}

				}
				catch (Exception exception)
				{
					expectedResponseType = ResponseType.FATALERROR;
					responseDescription = exception.Message;
				}
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="receivedResponse"></param>
			/// <param name="expectedResponse"></param>
			/// <param name="receivedResponseType"></param>
			private void AnalyzeDifferences(string receivedResponse, string expectedResponse, out string differences, out ResponseType receivedResponseType)
			{
				receivedResponseType = ResponseType.SUCCESS;
				differences = "";

				try
				{
					XmlDocument xmlReceivedResponse = new XmlDocument();
					XmlDocument xmlExpectedResponse = new XmlDocument();

					xmlReceivedResponse.LoadXml(receivedResponse);
					xmlExpectedResponse.LoadXml(expectedResponse);


					#region ANALYZE FORM

						bool hasForm = HasParentNode(xmlReceivedResponse, "form");
						bool expectsForm = HasParentNode(xmlExpectedResponse, "form");

						if (hasForm != expectsForm)
						{
							if (differences.Length > 0)
								differences += ", ";

							if (hasForm)
								differences += "Unexpected form in response";
							else
								differences += "Form expected in response was not found";
						}

					#endregion


					#region ANALYZE DATA

						bool hasData = HasParentNode(xmlReceivedResponse, "data");
						bool expectsData = HasParentNode(xmlExpectedResponse, "data");

						if (hasData != expectsData)
						{
							if (differences.Length > 0)
								differences += ", ";

							if (hasData)
								differences += "Unexpected data in response";
							else
								differences += "Data expected in response was not found";
						}

					#endregion


					#region ANALYZE ERRORS

						bool hasErrors = HasParentNode(xmlReceivedResponse, "error");
						bool expectsErrors = HasParentNode(xmlExpectedResponse, "error");

						if (hasErrors != expectsErrors)
						{
							if (differences.Length > 0)
								differences += ", ";

							if (hasErrors)
								differences += "Unexpected errors in response";
							else
								differences += "Errors expected in response were not found";
						}

					#endregion


					#region ANALYZE MESSAGES

						bool hasMessages = HasParentNode(xmlReceivedResponse, "error");
						bool expectsMessages = HasParentNode(xmlExpectedResponse, "error");

						if (hasMessages != expectsMessages)
						{
							if (differences.Length > 0)
								differences += ", ";

							if (hasMessages)
								differences += "Unexpected messages in response";
							else
								differences += "Messages expected in response were not found";
						}

					#endregion
				}
				catch
				{
				}
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="xmlResponse"></param>
			/// <param name="nodeName"></param>
			/// <returns></returns>
			private bool HasParentNode(XmlDocument xmlResponse, string nodeName)
			{
				foreach (XmlNode node in xmlResponse.DocumentElement.ChildNodes)
				{
					if (node.Name == nodeName)
						return true;
				}

				return false;
			}

		#endregion
	}
}

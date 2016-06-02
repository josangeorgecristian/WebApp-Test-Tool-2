using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

//using Crownwood.DotNetMagic.Forms;
//using Crownwood.DotNetMagic.Common;

using IMS.WebApp.Data.Units;

namespace IMS.WebApp.UI.Forms.Tools
{
	public partial class TestUnitEditor : Form //DotNetMagicForm
	{
		private const int BottomSpace = 32;


		#region FIELDS

			private int searchIndexRequest = 0;
            private int searchIndexResponse = 0;

			private TestUnit unit;

        #endregion


        #region GETTER / SETTER

			/// <summary>
			/// 
			/// </summary>
			public TestUnit TestUnit
			{
				get
				{
					// Check if the unit is null
					if (unit == null)
					{
						// Create a new unit
						unit = new TestUnit();

						// Initialize default values
						unit.IgnoreResponse = false;
						unit.ExecuteOnce = false;
					}

					unit.Request = txtRequest.Text;
					unit.Response = txtResponse.Text;

					return unit;
				}

				set
				{
					unit = value;

					txtRequest.Text = IndentXMLString(unit.Request);
					txtResponse.Text = unit is TestUnitExecuted ? IndentXMLString((unit as TestUnitExecuted).ResponseReceived) : IndentXMLString(unit.Response);
				}
			}

        #endregion


        #region CONSTRUCTORS


			/// <summary>
			/// Default constructor for TestUnit Editor
			/// Used for creating a new TestUnit
			/// </summary>
            public TestUnitEditor()
            {
                InitializeComponent();

                // Update the visual style of the dialog accordingly to saved settings
                //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

                // Update the controls state
                UpdateControlsState(false);
            }


			/// <summary>
			/// Parameterized costructor for Test Unit Editor dialog
			/// Used for displaying and editing of a Test Unit
			/// </summary>
			/// <param name="unit">Test Unit to be edited</param>
            public TestUnitEditor(TestUnit unit)
		    {
			    InitializeComponent();

				// Assign test unit (if not null)
				if (unit != null) TestUnit = unit;

                // Update the visual style of the dialog accordingly to saved settings
                //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

                // Update the controls state
                UpdateControlsState(false);
		    }


			/// <summary>
			/// Parameterized constructor for Test Unit Editor dialog
			/// Used for displaying a Test Unit Executed. The Dialog will be set in Read-Only mode
			/// </summary>
			/// <param name="unit">Test Unit Executed to be displayed</param>
            public TestUnitEditor(TestUnitExecuted unit)
            {
                InitializeComponent();

				// Assign executed test unit
				TestUnit = unit;

				// Update the visual style of the dialog accordingly to saved settings
                //UpdateVisualStyle(IMS.WebApp.Tools.Settings.Settings.Style);

				// Update the controls state
                UpdateControlsState(true);
            }


		#endregion


		#region STATIC FUNCTIONS

			/// <summary>
			/// Function used to format with identing a XML string
			/// </summary>
			/// <param name="xmlContent">XML content to be formated</param>
			/// <returns>Returns a string containign the XML formated with identation</returns>
			private static string IndentXMLString(string xmlContent)
			{
				// Attempt to format the XML string passed
				try
				{
					// Create an XML Document
					XmlDocument xmlDoc = new XmlDocument();
					// Load the unformated xml content to XML Document
					xmlDoc.LoadXml(xmlContent);

					// Create a memory stream and a XMLTextWriter that will send
					// the output to the memory stream
					MemoryStream memory = new MemoryStream();
					XmlTextWriter xmlWriter = new XmlTextWriter(memory, Encoding.Unicode);

					// Set the formatting property of the XML Text Writer to indented
					xmlWriter.Formatting = Formatting.Indented;

					// Write XML Document to XML Text Writer
					xmlDoc.WriteContentTo(xmlWriter);
					// Flush the contents of the text writer to memory stream
					xmlWriter.Flush();

					// Set the seeker to the start of the memory stream
					memory.Seek(0, SeekOrigin.Begin);
					// Create a reader to read the contents of the memory stream
					StreamReader streamRead = new StreamReader(memory);

					// Return the formated string					
					return streamRead.ReadToEnd();
				}
				catch
				{
					// In case the formating fails for any reason
					// return the original string
					return xmlContent;
				}
			}
		
		#endregion


		#region EVENTS


			#region FIND / REPLACE EVENTS

				/// <summary>
				/// 
				/// </summary>
				private void OnFindTextChanged(object sender, EventArgs e)
				{
					searchIndexRequest = 0;
					searchIndexResponse = 0;
				}

        
				/// <summary>
				/// 
				/// </summary>
				private void OnFindClick(object sender, EventArgs e)
				{
					// TODO Rework the code here
					if (!(searchIndexRequest < 0))
					{
						searchIndexRequest = txtRequest.Text.IndexOf(txtFind.Text, searchIndexRequest);

						if (searchIndexRequest >= 0)
						{
							txtRequest.Select(searchIndexRequest, txtFind.Text.Length);
							txtRequest.Focus();

							searchIndexRequest += txtFind.Text.Length;
							return;
						}
					}

					if (!(searchIndexResponse < 0))
					{
						searchIndexResponse = txtResponse.Text.IndexOf(txtFind.Text, searchIndexResponse);

						if (searchIndexResponse >= 0)
						{
							txtResponse.Select(searchIndexResponse, txtFind.Text.Length);
							txtResponse.Focus();

							searchIndexResponse += txtFind.Text.Length;
							return;
						}
					}

					searchIndexRequest = 0;
					searchIndexResponse = 0;
				}


				/// <summary>
				/// 
				/// </summary>
				private void OnReplaceClick(object sender, EventArgs e)
				{
					throw new NotImplementedException();
				}


				/// <summary>
				/// 
				/// </summary>
				private void OnReplaceAllClick(object sender, EventArgs e)
				{
					txtRequest.Text = txtRequest.Text.Replace(txtFind.Text, txtReplace.Text);
					txtResponse.Text = txtResponse.Text.Replace(txtFind.Text, txtReplace.Text);
				}


				/// <summary>
				/// 
				/// </summary>
                //private void OpenChanged(object sender, EventArgs e)
                //{
                //    // Check if the Find/Replace or Test Unit Settings controls are open
                //    if (FindReplace.Open || Settings.Open)
                //    {
                //        // Set the height of the Response/Request container to the height of Content container
                //            // minus the height of Find/Replace or Settings expanded controls
                //            // minus the space needed at the bottom for the Save and Cancel buttons
                //        RequestResponseContainer.Height = Content.Height - 126 - BottomSpace;

                //        // Set the location of the Response/Request container below
                //            // Find/Replace or Settings expanded controls
                //        RequestResponseContainer.Location = new System.Drawing.Point(0, 126);
                //    }
                //    else
                //    {
                //        // Set the height of the Response/Request container to the height of Content container
                //            // minus the height of Find/Replace or Settings collapsed controls
                //            // minus the space needed at the bottom for Save and Cancel buttons
                //        RequestResponseContainer.Height = Content.Height - 32 - BottomSpace;

                //        // Set the location of the Response/Request container below
                //            // Find/Replace or Settings collapsed controls
                //        RequestResponseContainer.Location = new System.Drawing.Point(0, 32);
                //    }
                //}


			#endregion

		
			private void SaveClick(object sender, EventArgs e)
			{
			}

			private void CancelClick(object sender, EventArgs e)
			{
			}

			private void OnKeyDown(object sender, KeyEventArgs e)
			{
				if (e.Control && e.KeyCode == Keys.Tab)
				{
					this.Opacity = 0.5;
				}
			}

			private void OnKeyUp(object sender, KeyEventArgs e)
			{
				if (!e.Control || e.KeyCode == Keys.Tab)
				{
					this.Opacity = 1;
				}
			}


		#endregion


        #region METHODS

            #region Form controls state methods

                /// <summary>
                /// Method used to update the visual style for dialog
                /// </summary>
                /// <param name="visualStyle">The new style which </param>
                //private void UpdateVisualStyle(VisualStyle visualStyle)
                //{
                //    this.Style = visualStyle;

                //    // Set controls Find/Replace and Settings style
                //    FindReplace.Style = visualStyle;
                //    Settings.Style = visualStyle;
                //}


                /// <summary>
                /// Method used to update the state of controls
                /// </summary>
                /// <param name="readOnly">Determine if the dialog is in read-only mode or not</param>
                private void UpdateControlsState(bool readOnly)
                {
                    // Disable Find/Replace editing options for read-only
                    Replace.Enabled = !readOnly;
                    ReplaceAll.Enabled = !readOnly;

					// Disable input fields for read-only
					txtRequest.ReadOnly = readOnly;
					txtResponse.ReadOnly = readOnly;

					// Disable Save button for read-only
					Save.Enabled = !readOnly;
					// Change text for Cancel button to Close for read-only
					Cancel.Text = readOnly ? "&Close" : "&Cancel";
                }

            #endregion

        #endregion
	}
}

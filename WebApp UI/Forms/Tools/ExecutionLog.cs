using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IMS.WebApp.Data.Units;
using IMS.WebApp.Engine;

namespace IMS.WebApp.UI.Forms.Tools
{
	public partial class ExecutionLog : Form // Crownwood.DotNetMagic.Forms.DotNetMagicForm
	{

		#region FIELDS

			private int thread;
			private int execution;

		#endregion


		#region CONSTRUCTORS

			/// <summary>
			/// 
			/// </summary>
			/// <param name="thread"></param>
			/// <param name="execution"></param>
			public ExecutionLog(int thread, int execution)
			{
				// Initialize the components - mandatory line for UI
				InitializeComponent();

				this.thread		= thread;
				this.execution	= execution;
			}

		#endregion


		#region STATIC FUNCTIONS
		#endregion


		#region GETTER / SETTER

			/// <summary>
			///  Get thread assosciated with execution log
			/// </summary>
			public int Thread
			{
				get { return thread; }
			}

			
			/// <summary>
			/// Get execution associated with execution log
			/// </summary>
			public int Execution
			{
				get { return execution; }
			}

		#endregion


		#region EVENTS

			/// <summary>
			/// 
			/// </summary>
			private void OnExecutionLogResize(object sender, EventArgs e)
			{
				int fixedColumnsWidth = 0;

				for (int i = 0; i < 4; i++)
				{
					fixedColumnsWidth += ExecutionResultList.Columns[i].Width;
				}

				ExecutionResultList.Columns[4].Width = ExecutionResultList.Width - fixedColumnsWidth - ExecutionResultList.Margin.Left - ExecutionResultList.Margin.Right - 20;
			}


			/// <summary>
			/// 
			/// </summary>
			private void ExecutionResultListDoubleClick(object sender, EventArgs e)
			{
				if (ExecutionResultList.SelectedItems.Count == 1)
				{
					if (ExecutionResultList.SelectedItems[0].Tag == null)
						return;

					new TestUnitEditor(ExecutionResultList.SelectedItems[0].Tag as TestUnitExecuted).ShowDialog();
				}

			}

		#endregion


		#region METHODS

			/// <summary>
			/// 
			/// </summary>
			/// <param name="progressReport"></param>
			public void AddPreExecutionReport(EngineExecutionProgressReport progressReport)
			{
				// Create a new pre-execution report
				ListViewItem item = ExecutionResultList.Items.Add("");

				item.ImageIndex = 1;

				ListViewItem.ListViewSubItem subItem = item.SubItems.Add(progressReport.Thread.ToString());
				subItem.Name = "Thread";

				subItem = item.SubItems.Add("-");
				subItem.Name = "ExecutionTime";

				subItem = item.SubItems.Add(progressReport.Unit.CurrentForm);
				subItem.Name = "CurrentForm";

				subItem = item.SubItems.Add(progressReport.Unit.ExpectedResponseDescription);
				subItem.Name = "Response";

				item.Tag = progressReport.Unit;
			}
		

			/// <summary>
			/// 
			/// </summary>
			/// <param name="progressReport"></param>
			public void AddExecutionReport(EngineExecutionProgressReport progressReport)
			{
				// Remove pre-execution report
				ExecutionResultList.Items.RemoveAt(ExecutionResultList.Items.Count - 1);

				// Create a new execution report
				ListViewItem item = ExecutionResultList.Items.Add("");

				switch (progressReport.ReportType)
				{
					case ExecutionProgressReportType.EXECUTION_STEP_SUCCESS:
					case ExecutionProgressReportType.EXECUTION_STEP_WARNING:
					case ExecutionProgressReportType.EXECUTION_STEP_ERROR:
					case ExecutionProgressReportType.EXECUTION_STEP_FATALERROR:
					{
						item.ImageIndex = progressReport.ExecutedUnit.ReceivedResponseType.GetHashCode();

						ListViewItem.ListViewSubItem subItem = item.SubItems.Add(progressReport.Thread.ToString());
						subItem.Name = "Thread";

						subItem = item.SubItems.Add(progressReport.ExecutedUnit.ProcessingTime);
						subItem.Name = "ExecutionTime";

						subItem = item.SubItems.Add(progressReport.ExecutedUnit.CurrentForm);
						subItem.Name = "CurrentForm";

						subItem = item.SubItems.Add(progressReport.ExecutedUnit.ReceivedResponseDescription);
						subItem.Name = "Response";

						item.Tag = progressReport.ExecutedUnit;

						UpdateExecutedTestUnitItemSteps();

						break;
					}


					case ExecutionProgressReportType.EXECUTION_CONNECTION_ERROR:
					{
						item.ImageIndex = 2;

						ListViewItem.ListViewSubItem subItem = item.SubItems.Add(progressReport.Thread.ToString());
						subItem.Name = "Thread";

						subItem = item.SubItems.Add("-");
						subItem.Name = "ExecutionTime";

						subItem = item.SubItems.Add("-");
						subItem.Name = "CurrentForm";

						subItem = item.SubItems.Add(progressReport.Information);
						subItem.Name = "Response";

						UpdateExecutedTestUnitItemSteps();

						break;
					}


					case ExecutionProgressReportType.EXECUTION_FATAL_ERROR:
					{
						item.ImageIndex = 2;

						ListViewItem.ListViewSubItem subItem = item.SubItems.Add(progressReport.Thread.ToString());
						subItem.Name = "Thread";

						subItem = item.SubItems.Add("-");
						subItem.Name = "ExecutionTime";

						subItem = item.SubItems.Add("-");
						subItem.Name = "CurrentForm";

						subItem = item.SubItems.Add(progressReport.Information);
						subItem.Name = "Response";

						UpdateExecutedTestUnitItemSteps();

						break;
					}
				}
			}


			/// <summary>
			/// 
			/// </summary>
			private void UpdateExecutedTestUnitItemSteps()
			{
				// Set initial index and current form value to temporary variables
				int index = 0;
				string currentForm = "N/A";

				// Iterate items in collection and update step and current form values
				foreach (ListViewItem item in ExecutionResultList.Items)
				{
					// Update the step value and current form
					// When updating a sub item - retrieve it by using the strin key
					// to avoid bugs if modication to ExecutionResultList occur
					item.Text = (++index).ToString();
					item.SubItems["CurrentForm"].Text = currentForm;

					// Alternate back color for items in ExecutionResult list
					item.BackColor = index % 2 == 0 ? Color.AntiqueWhite : ExecutionResultList.BackColor;

					// Update current form variable if necessary
					TestUnitExecuted executedUnit = item.Tag as TestUnitExecuted;
					currentForm = executedUnit != null && executedUnit.CurrentForm != null && executedUnit.CurrentForm.Trim().Length > 0 ? executedUnit.CurrentForm : currentForm;

				}
			}

		#endregion
	}
}

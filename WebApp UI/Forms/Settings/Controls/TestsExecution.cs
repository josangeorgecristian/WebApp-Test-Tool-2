using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using IMS.WebApp.UI.Interfaces;

namespace IMS.WebApp.UI.Forms.Settings
{
	public partial class TestsExecution : UserControl, ISettingsControl
	{
		public TestsExecution()
		{
			InitializeComponent();
		}

		#region ISettingsControl Members

			/// <summary>
			/// Function used to load the test execution settings
			/// If reading a setting from registry fails the default setting will be used
			/// </summary>
			public void LoadSettings()
			{
				#region Load Settings For Multithreaded Execution

					chkUseMultipleThreads.Checked = IMS.WebApp.Tools.Settings.Settings.UseMultipleThreads;
					chkLimitExecutionThreads.Checked = IMS.WebApp.Tools.Settings.Settings.LimitExecutionThreads;
					nMaxThreadsPerExecution.Value = IMS.WebApp.Tools.Settings.Settings.MaximumThreadsPerExecution;

				#endregion

				#region Load Settings For Default Execution Tab

					switch (IMS.WebApp.Tools.Settings.Settings.DefaultExecutionTab)
					{
						case IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_LOG:
							rdoExecutionLog.Checked = true;
							break;

						case IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_STATISTICS:
							rdoExecutionStatistics.Checked = true;
							break;
					}

				#endregion

				#region Load Settings For Execution Log

					txtOutputLogPath.Text = IMS.WebApp.Tools.Settings.Settings.DefaultLogOutputPath;
					chkOverrideLogOutputPath.Checked = IMS.WebApp.Tools.Settings.Settings.OverrideLogOutputPath;
					
				#endregion

				// Update controls state
				UpdateControlsState();
			}

			/// <summary>
			/// Function used to save the test execution settings
			/// </summary>
			public void SaveSettings()
			{
				#region Save Settings For Multithreaded Execution
				
					IMS.WebApp.Tools.Settings.Settings.UseMultipleThreads = chkUseMultipleThreads.Checked;
					IMS.WebApp.Tools.Settings.Settings.LimitExecutionThreads = chkLimitExecutionThreads.Checked;
					IMS.WebApp.Tools.Settings.Settings.MaximumThreadsPerExecution = (int)nMaxThreadsPerExecution.Value;

				#endregion

				#region Save Settings For Default Execution Tab

					if (rdoExecutionLog.Checked)
					{
						IMS.WebApp.Tools.Settings.Settings.DefaultExecutionTab = IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_LOG;
					}
					else if (rdoExecutionStatistics.Checked)
					{
						IMS.WebApp.Tools.Settings.Settings.DefaultExecutionTab = IMS.WebApp.Tools.Settings.ExecutionTab.EXECUTION_STATISTICS;
					}

				#endregion

				#region Save Settings For Execution Log

					IMS.WebApp.Tools.Settings.Settings.DefaultLogOutputPath = txtOutputLogPath.Text;
					IMS.WebApp.Tools.Settings.Settings.OverrideLogOutputPath = chkOverrideLogOutputPath.Checked;

				#endregion
			}

		#endregion

		#region EVENTS

			/// <summary>
			/// 
			/// </summary>
			private void OnUseMultipleThreadsClick(object sender, EventArgs e)
			{
				UpdateControlsState();
			}

			/// <summary>
			/// 
			/// </summary>
			private void OnBrowseClick(object sender, EventArgs e)
			{
				if (SelectDefaultLogPath.ShowDialog() == DialogResult.OK)
				{
					txtOutputLogPath.Text = SelectDefaultLogPath.SelectedPath;
				}
			}

		#endregion

		#region METHODS

			/// <summary>
			/// Function used to update the controls state
			/// </summary>
			private void UpdateControlsState()
			{
				// Multiple threaded execution controls
				chkLimitExecutionThreads.Enabled = chkUseMultipleThreads.Checked;
				nMaxThreadsPerExecution.Enabled = chkUseMultipleThreads.Checked;
				label1.Enabled = chkUseMultipleThreads.Checked;
			}

		#endregion
	}
}

namespace IMS.WebApp.UI.Forms.Settings
{
	partial class TestsExecution
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestsExecution));
			this.grpDefaultExecutionTab = new System.Windows.Forms.GroupBox();
			this.rdoExecutionStatistics = new System.Windows.Forms.RadioButton();
			this.rdoExecutionLog = new System.Windows.Forms.RadioButton();
			this.grpExecutionThreads = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.nMaxThreadsPerExecution = new System.Windows.Forms.NumericUpDown();
			this.chkLimitExecutionThreads = new System.Windows.Forms.CheckBox();
			this.chkUseMultipleThreads = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bBrowse = new System.Windows.Forms.Button();
			this.TestExecutionSettingsImages = new System.Windows.Forms.ImageList(this.components);
			this.txtOutputLogPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkOverrideLogOutputPath = new System.Windows.Forms.CheckBox();
			this.SelectDefaultLogPath = new System.Windows.Forms.FolderBrowserDialog();
			this.grpDefaultExecutionTab.SuspendLayout();
			this.grpExecutionThreads.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nMaxThreadsPerExecution)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpDefaultExecutionTab
			// 
			this.grpDefaultExecutionTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpDefaultExecutionTab.Controls.Add(this.rdoExecutionStatistics);
			this.grpDefaultExecutionTab.Controls.Add(this.rdoExecutionLog);
			this.grpDefaultExecutionTab.Location = new System.Drawing.Point(3, 82);
			this.grpDefaultExecutionTab.Name = "grpDefaultExecutionTab";
			this.grpDefaultExecutionTab.Size = new System.Drawing.Size(394, 70);
			this.grpDefaultExecutionTab.TabIndex = 0;
			this.grpDefaultExecutionTab.TabStop = false;
			this.grpDefaultExecutionTab.Text = "Default Execution Tab";
			// 
			// rdoExecutionStatistics
			// 
			this.rdoExecutionStatistics.AutoSize = true;
			this.rdoExecutionStatistics.Location = new System.Drawing.Point(20, 42);
			this.rdoExecutionStatistics.Name = "rdoExecutionStatistics";
			this.rdoExecutionStatistics.Size = new System.Drawing.Size(117, 17);
			this.rdoExecutionStatistics.TabIndex = 1;
			this.rdoExecutionStatistics.Text = "Execution Statistics";
			this.rdoExecutionStatistics.UseVisualStyleBackColor = true;
			// 
			// rdoExecutionLog
			// 
			this.rdoExecutionLog.AutoSize = true;
			this.rdoExecutionLog.Checked = true;
			this.rdoExecutionLog.Location = new System.Drawing.Point(20, 19);
			this.rdoExecutionLog.Name = "rdoExecutionLog";
			this.rdoExecutionLog.Size = new System.Drawing.Size(93, 17);
			this.rdoExecutionLog.TabIndex = 0;
			this.rdoExecutionLog.TabStop = true;
			this.rdoExecutionLog.Text = "Execution Log";
			this.rdoExecutionLog.UseVisualStyleBackColor = true;
			// 
			// grpExecutionThreads
			// 
			this.grpExecutionThreads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpExecutionThreads.Controls.Add(this.label1);
			this.grpExecutionThreads.Controls.Add(this.nMaxThreadsPerExecution);
			this.grpExecutionThreads.Controls.Add(this.chkLimitExecutionThreads);
			this.grpExecutionThreads.Controls.Add(this.chkUseMultipleThreads);
			this.grpExecutionThreads.Location = new System.Drawing.Point(3, 3);
			this.grpExecutionThreads.Name = "grpExecutionThreads";
			this.grpExecutionThreads.Size = new System.Drawing.Size(394, 73);
			this.grpExecutionThreads.TabIndex = 1;
			this.grpExecutionThreads.TabStop = false;
			this.grpExecutionThreads.Text = "Execution Threads";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Enabled = false;
			this.label1.Location = new System.Drawing.Point(230, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "per execution";
			// 
			// nMaxThreadsPerExecution
			// 
			this.nMaxThreadsPerExecution.Enabled = false;
			this.nMaxThreadsPerExecution.Location = new System.Drawing.Point(178, 43);
			this.nMaxThreadsPerExecution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nMaxThreadsPerExecution.Name = "nMaxThreadsPerExecution";
			this.nMaxThreadsPerExecution.Size = new System.Drawing.Size(46, 20);
			this.nMaxThreadsPerExecution.TabIndex = 2;
			this.nMaxThreadsPerExecution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// chkLimitExecutionThreads
			// 
			this.chkLimitExecutionThreads.AutoSize = true;
			this.chkLimitExecutionThreads.Enabled = false;
			this.chkLimitExecutionThreads.Location = new System.Drawing.Point(20, 44);
			this.chkLimitExecutionThreads.Name = "chkLimitExecutionThreads";
			this.chkLimitExecutionThreads.Size = new System.Drawing.Size(152, 17);
			this.chkLimitExecutionThreads.TabIndex = 1;
			this.chkLimitExecutionThreads.Text = "Limit Execution Threads At";
			this.chkLimitExecutionThreads.UseVisualStyleBackColor = true;
			// 
			// chkUseMultipleThreads
			// 
			this.chkUseMultipleThreads.AutoSize = true;
			this.chkUseMultipleThreads.Location = new System.Drawing.Point(20, 20);
			this.chkUseMultipleThreads.Name = "chkUseMultipleThreads";
			this.chkUseMultipleThreads.Size = new System.Drawing.Size(176, 17);
			this.chkUseMultipleThreads.TabIndex = 0;
			this.chkUseMultipleThreads.Text = "Use Multiple Execution Threads";
			this.chkUseMultipleThreads.UseVisualStyleBackColor = true;
			this.chkUseMultipleThreads.Click += new System.EventHandler(this.OnUseMultipleThreadsClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.bBrowse);
			this.groupBox1.Controls.Add(this.txtOutputLogPath);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.chkOverrideLogOutputPath);
			this.groupBox1.Location = new System.Drawing.Point(3, 158);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 70);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Execution Log";
			// 
			// bBrowse
			// 
			this.bBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bBrowse.ImageIndex = 0;
			this.bBrowse.ImageList = this.TestExecutionSettingsImages;
			this.bBrowse.Location = new System.Drawing.Point(363, 17);
			this.bBrowse.Name = "bBrowse";
			this.bBrowse.Size = new System.Drawing.Size(25, 23);
			this.bBrowse.TabIndex = 3;
			this.bBrowse.UseVisualStyleBackColor = true;
			this.bBrowse.Click += new System.EventHandler(this.OnBrowseClick);
			// 
			// TestExecutionSettingsImages
			// 
			this.TestExecutionSettingsImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TestExecutionSettingsImages.ImageStream")));
			this.TestExecutionSettingsImages.TransparentColor = System.Drawing.Color.Magenta;
			this.TestExecutionSettingsImages.Images.SetKeyName(0, "Open.bmp");
			// 
			// txtOutputLogPath
			// 
			this.txtOutputLogPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutputLogPath.Location = new System.Drawing.Point(113, 19);
			this.txtOutputLogPath.Name = "txtOutputLogPath";
			this.txtOutputLogPath.Size = new System.Drawing.Size(244, 20);
			this.txtOutputLogPath.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Default Log Path:";
			// 
			// chkOverrideLogOutputPath
			// 
			this.chkOverrideLogOutputPath.AutoSize = true;
			this.chkOverrideLogOutputPath.Location = new System.Drawing.Point(20, 45);
			this.chkOverrideLogOutputPath.Name = "chkOverrideLogOutputPath";
			this.chkOverrideLogOutputPath.Size = new System.Drawing.Size(147, 17);
			this.chkOverrideLogOutputPath.TabIndex = 0;
			this.chkOverrideLogOutputPath.Text = "Override Log Output Path";
			this.chkOverrideLogOutputPath.UseVisualStyleBackColor = true;
			// 
			// TestsExecution
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpExecutionThreads);
			this.Controls.Add(this.grpDefaultExecutionTab);
			this.MaximumSize = new System.Drawing.Size(400, 300);
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "TestsExecution";
			this.Size = new System.Drawing.Size(400, 300);
			this.grpDefaultExecutionTab.ResumeLayout(false);
			this.grpDefaultExecutionTab.PerformLayout();
			this.grpExecutionThreads.ResumeLayout(false);
			this.grpExecutionThreads.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nMaxThreadsPerExecution)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpDefaultExecutionTab;
		private System.Windows.Forms.RadioButton rdoExecutionLog;
		private System.Windows.Forms.GroupBox grpExecutionThreads;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nMaxThreadsPerExecution;
		private System.Windows.Forms.CheckBox chkLimitExecutionThreads;
		private System.Windows.Forms.CheckBox chkUseMultipleThreads;
		private System.Windows.Forms.RadioButton rdoExecutionStatistics;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bBrowse;
		private System.Windows.Forms.TextBox txtOutputLogPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkOverrideLogOutputPath;
		private System.Windows.Forms.ImageList TestExecutionSettingsImages;
		private System.Windows.Forms.FolderBrowserDialog SelectDefaultLogPath;
	}
}

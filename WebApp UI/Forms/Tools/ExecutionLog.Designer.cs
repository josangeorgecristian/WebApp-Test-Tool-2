namespace IMS.WebApp.UI.Forms.Tools
{
	partial class ExecutionLog
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecutionLog));
			this.ExecutionResultList = new System.Windows.Forms.ListView();
			this.colStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colThread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colExecutionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colForm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ExecutionLogImages = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// ExecutionResultList
			// 
			this.ExecutionResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStep,
            this.colThread,
            this.colExecutionTime,
            this.colForm,
            this.colResponse});
			this.ExecutionResultList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ExecutionResultList.FullRowSelect = true;
			this.ExecutionResultList.Location = new System.Drawing.Point(0, 0);
			this.ExecutionResultList.MultiSelect = false;
			this.ExecutionResultList.Name = "ExecutionResultList";
			this.ExecutionResultList.Size = new System.Drawing.Size(758, 370);
			this.ExecutionResultList.SmallImageList = this.ExecutionLogImages;
			this.ExecutionResultList.TabIndex = 0;
			this.ExecutionResultList.UseCompatibleStateImageBehavior = false;
			this.ExecutionResultList.View = System.Windows.Forms.View.Details;
			this.ExecutionResultList.DoubleClick += new System.EventHandler(this.ExecutionResultListDoubleClick);
			// 
			// colStep
			// 
			this.colStep.Text = "Step";
			this.colStep.Width = 51;
			// 
			// colThread
			// 
			this.colThread.Text = "Thread";
			this.colThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.colThread.Width = 58;
			// 
			// colExecutionTime
			// 
			this.colExecutionTime.Text = "Execution Time";
			this.colExecutionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.colExecutionTime.Width = 89;
			// 
			// colForm
			// 
			this.colForm.Text = "Current Form";
			this.colForm.Width = 167;
			// 
			// colResponse
			// 
			this.colResponse.Text = "Response";
			this.colResponse.Width = 388;
			// 
			// ExecutionLogImages
			// 
			this.ExecutionLogImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ExecutionLogImages.ImageStream")));
			this.ExecutionLogImages.TransparentColor = System.Drawing.Color.Transparent;
			this.ExecutionLogImages.Images.SetKeyName(0, "02 - OK.png");
			this.ExecutionLogImages.Images.SetKeyName(1, "01 - Test Unit.png");
			this.ExecutionLogImages.Images.SetKeyName(2, "03 - Error.png");
			// 
			// ExecutionLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 370);
			this.Controls.Add(this.ExecutionResultList);
			this.Name = "ExecutionLog";
            //this.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerBlue;
			this.Text = "ExecutionLog";
			this.Resize += new System.EventHandler(this.OnExecutionLogResize);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColumnHeader colStep;
		private System.Windows.Forms.ColumnHeader colThread;
		private System.Windows.Forms.ColumnHeader colForm;
		private System.Windows.Forms.ColumnHeader colExecutionTime;
		private System.Windows.Forms.ColumnHeader colResponse;
		public System.Windows.Forms.ListView ExecutionResultList;
		private System.Windows.Forms.ImageList ExecutionLogImages;
	}
}
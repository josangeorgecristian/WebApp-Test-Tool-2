namespace IMS.WebApp.UI.Forms.Help
{
	partial class WebAppHelp
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
			this.htmlHelpDisplay = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// htmlHelpDisplay
			// 
			this.htmlHelpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmlHelpDisplay.Location = new System.Drawing.Point(0, 0);
			this.htmlHelpDisplay.MinimumSize = new System.Drawing.Size(20, 20);
			this.htmlHelpDisplay.Name = "htmlHelpDisplay";
			this.htmlHelpDisplay.Size = new System.Drawing.Size(609, 472);
			this.htmlHelpDisplay.TabIndex = 0;
			// 
			// WebAppHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 472);
			this.Controls.Add(this.htmlHelpDisplay);
			this.Name = "WebAppHelp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            //this.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerOrange;
			this.Text = "WebAppHelp";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser htmlHelpDisplay;
	}
}
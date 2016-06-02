namespace IMS.WebApp.UI.Forms.Settings
{
	partial class UploadSettings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadSettings));
			this.grpUpdateSettings = new System.Windows.Forms.GroupBox();
			this.bSelectLocation = new System.Windows.Forms.Button();
			this.UploadSettingsImage = new System.Windows.Forms.ImageList(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.txtUpdateLocation = new System.Windows.Forms.TextBox();
			this.UploadLocation = new System.Windows.Forms.FolderBrowserDialog();
			this.grpUpdateSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpUpdateSettings
			// 
			this.grpUpdateSettings.Controls.Add(this.bSelectLocation);
			this.grpUpdateSettings.Controls.Add(this.label1);
			this.grpUpdateSettings.Controls.Add(this.txtUpdateLocation);
			this.grpUpdateSettings.Location = new System.Drawing.Point(3, 3);
			this.grpUpdateSettings.Name = "grpUpdateSettings";
			this.grpUpdateSettings.Size = new System.Drawing.Size(394, 52);
			this.grpUpdateSettings.TabIndex = 0;
			this.grpUpdateSettings.TabStop = false;
			this.grpUpdateSettings.Text = "Update Settings";
			// 
			// bSelectLocation
			// 
			this.bSelectLocation.ImageIndex = 0;
			this.bSelectLocation.ImageList = this.UploadSettingsImage;
			this.bSelectLocation.Location = new System.Drawing.Point(365, 17);
			this.bSelectLocation.Name = "bSelectLocation";
			this.bSelectLocation.Size = new System.Drawing.Size(23, 23);
			this.bSelectLocation.TabIndex = 2;
			this.bSelectLocation.UseVisualStyleBackColor = true;
			this.bSelectLocation.Click += new System.EventHandler(this.SelectLocationClick);
			// 
			// UploadSettingsImage
			// 
			this.UploadSettingsImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("UploadSettingsImage.ImageStream")));
			this.UploadSettingsImage.TransparentColor = System.Drawing.Color.Magenta;
			this.UploadSettingsImage.Images.SetKeyName(0, "Open.bmp");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Update Location:";
			// 
			// txtUpdateLocation
			// 
			this.txtUpdateLocation.Location = new System.Drawing.Point(115, 19);
			this.txtUpdateLocation.Name = "txtUpdateLocation";
			this.txtUpdateLocation.Size = new System.Drawing.Size(244, 20);
			this.txtUpdateLocation.TabIndex = 0;
			// 
			// UploadLocation
			// 
			this.UploadLocation.ShowNewFolderButton = false;
			// 
			// UploadSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpUpdateSettings);
			this.MaximumSize = new System.Drawing.Size(400, 300);
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "UploadSettings";
			this.Size = new System.Drawing.Size(400, 300);
			this.grpUpdateSettings.ResumeLayout(false);
			this.grpUpdateSettings.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpUpdateSettings;
		private System.Windows.Forms.Button bSelectLocation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUpdateLocation;
		private System.Windows.Forms.ImageList UploadSettingsImage;
		private System.Windows.Forms.FolderBrowserDialog UploadLocation;
	}
}

namespace IMS.WebApp.UI.Forms.Settings
{
	partial class EMailServerSettings
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
			this.grpServerSettings = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEMailPassword = new System.Windows.Forms.TextBox();
			this.txtEMailUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEMailServer = new System.Windows.Forms.TextBox();
			this.nSMTPPort = new System.Windows.Forms.NumericUpDown();
			this.chkServerSSLEncryption = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grpAdvancedSettings = new System.Windows.Forms.GroupBox();
			this.grpDefaultRecipient = new System.Windows.Forms.GroupBox();
			this.txtEMailAddress = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEMailName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.grpServerSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nSMTPPort)).BeginInit();
			this.grpAdvancedSettings.SuspendLayout();
			this.grpDefaultRecipient.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpServerSettings
			// 
			this.grpServerSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpServerSettings.Controls.Add(this.label4);
			this.grpServerSettings.Controls.Add(this.label3);
			this.grpServerSettings.Controls.Add(this.txtEMailPassword);
			this.grpServerSettings.Controls.Add(this.txtEMailUsername);
			this.grpServerSettings.Controls.Add(this.label1);
			this.grpServerSettings.Controls.Add(this.txtEMailServer);
			this.grpServerSettings.Location = new System.Drawing.Point(3, 3);
			this.grpServerSettings.Name = "grpServerSettings";
			this.grpServerSettings.Size = new System.Drawing.Size(394, 104);
			this.grpServerSettings.TabIndex = 0;
			this.grpServerSettings.TabStop = false;
			this.grpServerSettings.Text = "Server Settings";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "&Username:";
			// 
			// txtEMailPassword
			// 
			this.txtEMailPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEMailPassword.Location = new System.Drawing.Point(84, 71);
			this.txtEMailPassword.Name = "txtEMailPassword";
			this.txtEMailPassword.Size = new System.Drawing.Size(291, 20);
			this.txtEMailPassword.TabIndex = 5;
			this.txtEMailPassword.UseSystemPasswordChar = true;
			// 
			// txtEMailUsername
			// 
			this.txtEMailUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEMailUsername.Location = new System.Drawing.Point(84, 45);
			this.txtEMailUsername.Name = "txtEMailUsername";
			this.txtEMailUsername.Size = new System.Drawing.Size(291, 20);
			this.txtEMailUsername.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Server:";
			// 
			// txtEMailServer
			// 
			this.txtEMailServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEMailServer.Location = new System.Drawing.Point(84, 19);
			this.txtEMailServer.Name = "txtEMailServer";
			this.txtEMailServer.Size = new System.Drawing.Size(291, 20);
			this.txtEMailServer.TabIndex = 1;
			// 
			// nSMTPPort
			// 
			this.nSMTPPort.Location = new System.Drawing.Point(84, 19);
			this.nSMTPPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nSMTPPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nSMTPPort.Name = "nSMTPPort";
			this.nSMTPPort.Size = new System.Drawing.Size(51, 20);
			this.nSMTPPort.TabIndex = 1;
			this.nSMTPPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// chkServerSSLEncryption
			// 
			this.chkServerSSLEncryption.AutoSize = true;
			this.chkServerSSLEncryption.Location = new System.Drawing.Point(23, 45);
			this.chkServerSSLEncryption.Name = "chkServerSSLEncryption";
			this.chkServerSSLEncryption.Size = new System.Drawing.Size(277, 17);
			this.chkServerSSLEncryption.TabIndex = 2;
			this.chkServerSSLEncryption.Text = "The Server Requires An &Encrypted Connection (SSL)";
			this.chkServerSSLEncryption.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "S&MTP";
			// 
			// grpAdvancedSettings
			// 
			this.grpAdvancedSettings.Controls.Add(this.label2);
			this.grpAdvancedSettings.Controls.Add(this.chkServerSSLEncryption);
			this.grpAdvancedSettings.Controls.Add(this.nSMTPPort);
			this.grpAdvancedSettings.Location = new System.Drawing.Point(3, 113);
			this.grpAdvancedSettings.Name = "grpAdvancedSettings";
			this.grpAdvancedSettings.Size = new System.Drawing.Size(394, 71);
			this.grpAdvancedSettings.TabIndex = 1;
			this.grpAdvancedSettings.TabStop = false;
			this.grpAdvancedSettings.Text = "Advanced Settings";
			// 
			// grpDefaultRecipient
			// 
			this.grpDefaultRecipient.Controls.Add(this.txtEMailAddress);
			this.grpDefaultRecipient.Controls.Add(this.label6);
			this.grpDefaultRecipient.Controls.Add(this.txtEMailName);
			this.grpDefaultRecipient.Controls.Add(this.label5);
			this.grpDefaultRecipient.Location = new System.Drawing.Point(3, 190);
			this.grpDefaultRecipient.Name = "grpDefaultRecipient";
			this.grpDefaultRecipient.Size = new System.Drawing.Size(394, 75);
			this.grpDefaultRecipient.TabIndex = 2;
			this.grpDefaultRecipient.TabStop = false;
			this.grpDefaultRecipient.Text = "Default Recipient";
			// 
			// txtEMailAddress
			// 
			this.txtEMailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEMailAddress.Location = new System.Drawing.Point(84, 45);
			this.txtEMailAddress.Name = "txtEMailAddress";
			this.txtEMailAddress.Size = new System.Drawing.Size(291, 20);
			this.txtEMailAddress.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Address:";
			// 
			// txtEMailName
			// 
			this.txtEMailName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEMailName.Location = new System.Drawing.Point(84, 19);
			this.txtEMailName.Name = "txtEMailName";
			this.txtEMailName.Size = new System.Drawing.Size(291, 20);
			this.txtEMailName.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Name:";
			// 
			// EMailServerSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpDefaultRecipient);
			this.Controls.Add(this.grpAdvancedSettings);
			this.Controls.Add(this.grpServerSettings);
			this.MaximumSize = new System.Drawing.Size(400, 300);
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "EMailServerSettings";
			this.Size = new System.Drawing.Size(400, 300);
			this.grpServerSettings.ResumeLayout(false);
			this.grpServerSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nSMTPPort)).EndInit();
			this.grpAdvancedSettings.ResumeLayout(false);
			this.grpAdvancedSettings.PerformLayout();
			this.grpDefaultRecipient.ResumeLayout(false);
			this.grpDefaultRecipient.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpServerSettings;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEMailPassword;
		private System.Windows.Forms.TextBox txtEMailUsername;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEMailServer;
		private System.Windows.Forms.NumericUpDown nSMTPPort;
		private System.Windows.Forms.CheckBox chkServerSSLEncryption;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grpAdvancedSettings;
		private System.Windows.Forms.GroupBox grpDefaultRecipient;
		private System.Windows.Forms.TextBox txtEMailName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEMailAddress;
		private System.Windows.Forms.Label label6;
	}
}

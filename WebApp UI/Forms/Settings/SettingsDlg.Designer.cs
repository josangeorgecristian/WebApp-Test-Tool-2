namespace IMS.WebApp.UI.Forms.Settings
{
	partial class SettingsDlg
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
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("General");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Enviroment", new System.Windows.Forms.TreeNode[] {
            treeNode9});
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Execution");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Server");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Tests", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Server Settings");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("E-Mail", new System.Windows.Forms.TreeNode[] {
            treeNode14});
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Update");
			this.treeCategories = new System.Windows.Forms.TreeView();
			this.bOK = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.OptionsControlsArea = new System.Windows.Forms.Panel();
			this.bDefaultSettings = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeCategories
			// 
			this.treeCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.treeCategories.Location = new System.Drawing.Point(12, 12);
			this.treeCategories.Name = "treeCategories";
			treeNode9.Name = "NodeEnviromentGeneral";
			treeNode9.Text = "General";
			treeNode10.Name = "NodeEnviroment";
			treeNode10.Text = "Enviroment";
			treeNode11.Name = "NodeTestsExecution";
			treeNode11.Text = "Execution";
			treeNode12.Name = "NodeTestsServer";
			treeNode12.Text = "Server";
			treeNode13.Name = "NodeTests";
			treeNode13.Text = "Tests";
			treeNode14.Name = "NodeEMailServerSettings";
			treeNode14.Text = "Server Settings";
			treeNode15.Name = "NodeEMail";
			treeNode15.Text = "E-Mail";
			treeNode16.Name = "NodeUpdate";
			treeNode16.Text = "Update";
			this.treeCategories.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode13,
            treeNode15,
            treeNode16});
			this.treeCategories.Size = new System.Drawing.Size(164, 300);
			this.treeCategories.TabIndex = 0;
			this.treeCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnTreeNode_Selected);
			// 
			// bOK
			// 
			this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bOK.Location = new System.Drawing.Point(426, 318);
			this.bOK.Name = "bOK";
			this.bOK.Size = new System.Drawing.Size(75, 23);
			this.bOK.TabIndex = 3;
			this.bOK.Text = "&OK";
			this.bOK.UseVisualStyleBackColor = true;
			this.bOK.Click += new System.EventHandler(this.OnOK_Click);
			// 
			// bCancel
			// 
			this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point(507, 318);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(75, 23);
			this.bCancel.TabIndex = 4;
			this.bCancel.Text = "&Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.OnCancel_Click);
			// 
			// OptionsControlsArea
			// 
			this.OptionsControlsArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.OptionsControlsArea.Location = new System.Drawing.Point(182, 12);
			this.OptionsControlsArea.MaximumSize = new System.Drawing.Size(400, 300);
			this.OptionsControlsArea.MinimumSize = new System.Drawing.Size(400, 300);
			this.OptionsControlsArea.Name = "OptionsControlsArea";
			this.OptionsControlsArea.Size = new System.Drawing.Size(400, 300);
			this.OptionsControlsArea.TabIndex = 1;
			// 
			// bDefaultSettings
			// 
			this.bDefaultSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bDefaultSettings.Location = new System.Drawing.Point(12, 318);
			this.bDefaultSettings.Name = "bDefaultSettings";
			this.bDefaultSettings.Size = new System.Drawing.Size(164, 23);
			this.bDefaultSettings.TabIndex = 2;
			this.bDefaultSettings.Text = "Restore Default Settings";
			this.bDefaultSettings.UseVisualStyleBackColor = true;
			this.bDefaultSettings.Click += new System.EventHandler(this.OnDefaultSettings_Click);
			// 
			// SettingsDlg
			// 
			this.AcceptButton = this.bOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.bCancel;
			this.ClientSize = new System.Drawing.Size(594, 353);
			this.Controls.Add(this.bDefaultSettings);
			this.Controls.Add(this.OptionsControlsArea);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bOK);
			this.Controls.Add(this.treeCategories);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            //this.Style = Crownwood.DotNetMagic.Common.VisualStyle.MediaPlayerOrange;
			this.Text = "Settings";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeCategories;
		private System.Windows.Forms.Button bOK;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Panel OptionsControlsArea;
		private System.Windows.Forms.Button bDefaultSettings;

	}
}
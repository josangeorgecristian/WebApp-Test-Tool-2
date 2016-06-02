namespace IMS.WebApp.UI.Forms.Settings
{
	partial class TestsServer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestsServer));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkOverrideServerURL = new System.Windows.Forms.CheckBox();
			this.txtDefaultServerURL = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grpProjectServers = new System.Windows.Forms.GroupBox();
			this.listProjects = new System.Windows.Forms.ListView();
			this.colProject = new System.Windows.Forms.ColumnHeader();
			this.colServerAddress = new System.Windows.Forms.ColumnHeader();
			this.ProjectsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MenuNewProject = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuEditProject = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuDeleteProject = new System.Windows.Forms.ToolStripMenuItem();
			this.bSave = new System.Windows.Forms.Button();
			this.ButtonImages = new System.Windows.Forms.ImageList(this.components);
			this.bBrowse = new System.Windows.Forms.Button();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.FileServerSelect = new System.Windows.Forms.OpenFileDialog();
			this.FileServerSave = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			this.grpProjectServers.SuspendLayout();
			this.ProjectsContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.chkOverrideServerURL);
			this.groupBox1.Controls.Add(this.txtDefaultServerURL);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 73);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Default Server Settings";
			// 
			// chkOverrideServerURL
			// 
			this.chkOverrideServerURL.AutoSize = true;
			this.chkOverrideServerURL.Location = new System.Drawing.Point(14, 45);
			this.chkOverrideServerURL.Name = "chkOverrideServerURL";
			this.chkOverrideServerURL.Size = new System.Drawing.Size(125, 17);
			this.chkOverrideServerURL.TabIndex = 2;
			this.chkOverrideServerURL.Text = "Override Server URL";
			this.chkOverrideServerURL.UseVisualStyleBackColor = true;
			// 
			// txtDefaultServerURL
			// 
			this.txtDefaultServerURL.Location = new System.Drawing.Point(120, 19);
			this.txtDefaultServerURL.Name = "txtDefaultServerURL";
			this.txtDefaultServerURL.Size = new System.Drawing.Size(259, 20);
			this.txtDefaultServerURL.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Default Server URL:";
			// 
			// grpProjectServers
			// 
			this.grpProjectServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpProjectServers.Controls.Add(this.listProjects);
			this.grpProjectServers.Controls.Add(this.bSave);
			this.grpProjectServers.Controls.Add(this.bBrowse);
			this.grpProjectServers.Controls.Add(this.txtFile);
			this.grpProjectServers.Controls.Add(this.label2);
			this.grpProjectServers.Location = new System.Drawing.Point(3, 82);
			this.grpProjectServers.Name = "grpProjectServers";
			this.grpProjectServers.Size = new System.Drawing.Size(394, 215);
			this.grpProjectServers.TabIndex = 1;
			this.grpProjectServers.TabStop = false;
			this.grpProjectServers.Text = "Projects Servers";
			// 
			// listProjects
			// 
			this.listProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProject,
            this.colServerAddress});
			this.listProjects.ContextMenuStrip = this.ProjectsContextMenu;
			this.listProjects.FullRowSelect = true;
			this.listProjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listProjects.Location = new System.Drawing.Point(14, 45);
			this.listProjects.MultiSelect = false;
			this.listProjects.Name = "listProjects";
			this.listProjects.ShowItemToolTips = true;
			this.listProjects.Size = new System.Drawing.Size(365, 152);
			this.listProjects.TabIndex = 3;
			this.listProjects.UseCompatibleStateImageBehavior = false;
			this.listProjects.View = System.Windows.Forms.View.Details;
			this.listProjects.SelectedIndexChanged += new System.EventHandler(this.OnProjectsListSelectionChanged);
			this.listProjects.Click += new System.EventHandler(this.OnProjectsListClick);
			// 
			// colProject
			// 
			this.colProject.Text = "Project";
			this.colProject.Width = 120;
			// 
			// colServerAddress
			// 
			this.colServerAddress.Text = "Server Address";
			this.colServerAddress.Width = 230;
			// 
			// ProjectsContextMenu
			// 
			this.ProjectsContextMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.ProjectsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewProject,
            this.MenuEditProject,
            this.MenuDeleteProject});
			this.ProjectsContextMenu.Name = "ProjectsContextMenu";
			this.ProjectsContextMenu.Size = new System.Drawing.Size(187, 70);
			// 
			// MenuNewProject
			// 
			this.MenuNewProject.Image = ((System.Drawing.Image)(resources.GetObject("MenuNewProject.Image")));
			this.MenuNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MenuNewProject.Name = "MenuNewProject";
			this.MenuNewProject.Size = new System.Drawing.Size(186, 22);
			this.MenuNewProject.Text = "&New Project Server";
			this.MenuNewProject.Click += new System.EventHandler(this.OnMenuNewProjectClick);
			// 
			// MenuEditProject
			// 
			this.MenuEditProject.Image = ((System.Drawing.Image)(resources.GetObject("MenuEditProject.Image")));
			this.MenuEditProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MenuEditProject.Name = "MenuEditProject";
			this.MenuEditProject.Size = new System.Drawing.Size(186, 22);
			this.MenuEditProject.Text = "&Edit Project Server";
			this.MenuEditProject.Click += new System.EventHandler(this.OnMenuEditProjectClick);
			// 
			// MenuDeleteProject
			// 
			this.MenuDeleteProject.Image = ((System.Drawing.Image)(resources.GetObject("MenuDeleteProject.Image")));
			this.MenuDeleteProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MenuDeleteProject.Name = "MenuDeleteProject";
			this.MenuDeleteProject.Size = new System.Drawing.Size(186, 22);
			this.MenuDeleteProject.Text = "&Delete Project Server";
			this.MenuDeleteProject.Click += new System.EventHandler(this.OnMenuDeleteProjectClick);
			// 
			// bSave
			// 
			this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bSave.ImageKey = "Save.bmp";
			this.bSave.ImageList = this.ButtonImages;
			this.bSave.Location = new System.Drawing.Point(327, 17);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(23, 23);
			this.bSave.TabIndex = 2;
			this.bSave.UseVisualStyleBackColor = true;
			this.bSave.Click += new System.EventHandler(this.OnSaveClick);
			// 
			// ButtonImages
			// 
			this.ButtonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ButtonImages.ImageStream")));
			this.ButtonImages.TransparentColor = System.Drawing.Color.Magenta;
			this.ButtonImages.Images.SetKeyName(0, "Open.bmp");
			this.ButtonImages.Images.SetKeyName(1, "Save.bmp");
			this.ButtonImages.Images.SetKeyName(2, "ProjectAdd.bmp");
			this.ButtonImages.Images.SetKeyName(3, "ProjectEdit.bmp");
			this.ButtonImages.Images.SetKeyName(4, "ProjectRemove.bmp");
			// 
			// bBrowse
			// 
			this.bBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bBrowse.ImageKey = "Open.bmp";
			this.bBrowse.ImageList = this.ButtonImages;
			this.bBrowse.Location = new System.Drawing.Point(356, 17);
			this.bBrowse.Name = "bBrowse";
			this.bBrowse.Size = new System.Drawing.Size(23, 23);
			this.bBrowse.TabIndex = 2;
			this.bBrowse.UseVisualStyleBackColor = true;
			this.bBrowse.Click += new System.EventHandler(this.OnBrowseClick);
			// 
			// txtFile
			// 
			this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtFile.Location = new System.Drawing.Point(43, 19);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(278, 20);
			this.txtFile.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "File:";
			// 
			// FileServerSelect
			// 
			this.FileServerSelect.DefaultExt = "xml";
			this.FileServerSelect.Filter = "All files (*.*)|*.*|Xml files (*.xml)|*.xml";
			this.FileServerSelect.FilterIndex = 2;
			this.FileServerSelect.InitialDirectory = ".";
			this.FileServerSelect.Title = "Select Servers Collection File";
			this.FileServerSelect.FileOk += new System.ComponentModel.CancelEventHandler(this.OnFileSelect);
			// 
			// FileServerSave
			// 
			this.FileServerSave.DefaultExt = "xml";
			this.FileServerSave.Filter = "All files (*.*)|*.*|Xml files (*.xml)|*.xml";
			this.FileServerSave.FilterIndex = 2;
			this.FileServerSave.Title = "Select Servers Collection File";
			// 
			// TestsServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpProjectServers);
			this.Controls.Add(this.groupBox1);
			this.MaximumSize = new System.Drawing.Size(400, 300);
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "TestsServer";
			this.Size = new System.Drawing.Size(400, 300);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grpProjectServers.ResumeLayout(false);
			this.grpProjectServers.PerformLayout();
			this.ProjectsContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkOverrideServerURL;
		private System.Windows.Forms.TextBox txtDefaultServerURL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpProjectServers;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bBrowse;
		private System.Windows.Forms.ImageList ButtonImages;
		private System.Windows.Forms.ListView listProjects;
		private System.Windows.Forms.ColumnHeader colProject;
		private System.Windows.Forms.ColumnHeader colServerAddress;
		private System.Windows.Forms.OpenFileDialog FileServerSelect;
		private System.Windows.Forms.ContextMenuStrip ProjectsContextMenu;
		private System.Windows.Forms.ToolStripMenuItem MenuNewProject;
		private System.Windows.Forms.ToolStripMenuItem MenuEditProject;
		private System.Windows.Forms.ToolStripMenuItem MenuDeleteProject;
		private System.Windows.Forms.SaveFileDialog FileServerSave;
		private System.Windows.Forms.Button bSave;
	}
}

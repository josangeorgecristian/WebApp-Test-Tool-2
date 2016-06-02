namespace IMS.WebApp.UI.Forms.Tools
{
	partial class TestUnitEditor
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

		private void CreateFindReplaceContent()
		{
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.txtReplace = new System.Windows.Forms.TextBox();
			this.ReplaceAll = new System.Windows.Forms.Button();
			this.Replace = new System.Windows.Forms.Button();
			this.Find = new System.Windows.Forms.Button();
			this.Content = new System.Windows.Forms.Panel();
			this.Cancel = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.RequestResponseContainer = new System.Windows.Forms.SplitContainer();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRequest = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtResponse = new System.Windows.Forms.TextBox();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Content.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RequestResponseContainer)).BeginInit();
			this.RequestResponseContainer.Panel1.SuspendLayout();
			this.RequestResponseContainer.Panel2.SuspendLayout();
			this.RequestResponseContainer.SuspendLayout();
			this.MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(10, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "F&ind:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "R&eplace:";
			// 
			// txtFind
			// 
			this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFind.Location = new System.Drawing.Point(66, 8);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(274, 20);
			this.txtFind.TabIndex = 1;
			this.txtFind.TextChanged += new System.EventHandler(this.OnFindTextChanged);
			// 
			// txtReplace
			// 
			this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtReplace.Location = new System.Drawing.Point(66, 34);
			this.txtReplace.Name = "txtReplace";
			this.txtReplace.Size = new System.Drawing.Size(274, 20);
			this.txtReplace.TabIndex = 3;
			// 
			// ReplaceAll
			// 
			this.ReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ReplaceAll.Location = new System.Drawing.Point(265, 61);
			this.ReplaceAll.Name = "ReplaceAll";
			this.ReplaceAll.Size = new System.Drawing.Size(75, 23);
			this.ReplaceAll.TabIndex = 6;
			this.ReplaceAll.Text = "Replace &All";
			this.ReplaceAll.UseVisualStyleBackColor = true;
			this.ReplaceAll.Click += new System.EventHandler(this.OnReplaceAllClick);
			// 
			// Replace
			// 
			this.Replace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Replace.Location = new System.Drawing.Point(185, 61);
			this.Replace.Name = "Replace";
			this.Replace.Size = new System.Drawing.Size(75, 23);
			this.Replace.TabIndex = 5;
			this.Replace.Text = "&Replace";
			this.Replace.UseVisualStyleBackColor = true;
			this.Replace.Click += new System.EventHandler(this.OnReplaceClick);
			// 
			// Find
			// 
			this.Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Find.Location = new System.Drawing.Point(106, 61);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(75, 23);
			this.Find.TabIndex = 4;
			this.Find.Text = "&Find";
			this.Find.UseVisualStyleBackColor = true;
			this.Find.Click += new System.EventHandler(this.OnFindClick);
			// 
			// Content
			// 
			this.Content.Controls.Add(this.Cancel);
			this.Content.Controls.Add(this.Save);
			this.Content.Controls.Add(this.RequestResponseContainer);
			this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Content.Location = new System.Drawing.Point(0, 24);
			this.Content.Name = "Content";
			this.Content.Size = new System.Drawing.Size(592, 442);
			this.Content.TabIndex = 2;
			// 
			// Cancel
			// 
			this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(505, 413);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 4;
			this.Cancel.Text = "&Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// Save
			// 
			this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Save.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Save.Location = new System.Drawing.Point(424, 413);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 3;
			this.Save.Text = "&Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.SaveClick);
			// 
			// RequestResponseContainer
			// 
			this.RequestResponseContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RequestResponseContainer.Location = new System.Drawing.Point(0, 32);
			this.RequestResponseContainer.Name = "RequestResponseContainer";
			this.RequestResponseContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// RequestResponseContainer.Panel1
			// 
			this.RequestResponseContainer.Panel1.Controls.Add(this.label3);
			this.RequestResponseContainer.Panel1.Controls.Add(this.txtRequest);
			// 
			// RequestResponseContainer.Panel2
			// 
			this.RequestResponseContainer.Panel2.Controls.Add(this.label4);
			this.RequestResponseContainer.Panel2.Controls.Add(this.txtResponse);
			this.RequestResponseContainer.Size = new System.Drawing.Size(592, 378);
			this.RequestResponseContainer.SplitterDistance = 160;
			this.RequestResponseContainer.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Re&quest:";
			// 
			// txtRequest
			// 
			this.txtRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRequest.Location = new System.Drawing.Point(88, 0);
			this.txtRequest.MaxLength = 0;
			this.txtRequest.Multiline = true;
			this.txtRequest.Name = "txtRequest";
			this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRequest.Size = new System.Drawing.Size(492, 160);
			this.txtRequest.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Res&ponse:";
			// 
			// txtResponse
			// 
			this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtResponse.Location = new System.Drawing.Point(88, 2);
			this.txtResponse.MaxLength = 0;
			this.txtResponse.Multiline = true;
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResponse.Size = new System.Drawing.Size(492, 209);
			this.txtResponse.TabIndex = 1;
			// 
			// MainMenu
			// 
			this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(592, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// TestUnitEditor
			// 
			this.AcceptButton = this.Save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(592, 466);
			this.Controls.Add(this.Content);
			this.Controls.Add(this.MainMenu);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(600, 500);
			this.Name = "TestUnitEditor";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Test Unit Editor";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
			this.Content.ResumeLayout(false);
			this.RequestResponseContainer.Panel1.ResumeLayout(false);
			this.RequestResponseContainer.Panel1.PerformLayout();
			this.RequestResponseContainer.Panel2.ResumeLayout(false);
			this.RequestResponseContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RequestResponseContainer)).EndInit();
			this.RequestResponseContainer.ResumeLayout(false);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        //private System.Windows.Forms.SlidingTitleBar FindReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button ReplaceAll;
        private System.Windows.Forms.Button Replace;
        //private System.Windows.Forms.SlidingTitleBar Settings;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.SplitContainer RequestResponseContainer;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
	}
}
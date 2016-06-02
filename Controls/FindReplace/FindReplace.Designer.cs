namespace IMS.CustomControls
{
	partial class FindReplace
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
			this.txtBoxFindWhat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBoxReplaceWith = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bFind = new System.Windows.Forms.Button();
			this.bReplace = new System.Windows.Forms.Button();
			this.bReplaceAll = new System.Windows.Forms.Button();
			this.panelDesignArea = new System.Windows.Forms.Panel();
			this.panelDesignArea.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtBoxFindWhat
			// 
			this.txtBoxFindWhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxFindWhat.Location = new System.Drawing.Point(85, 6);
			this.txtBoxFindWhat.Name = "txtBoxFindWhat";
			this.txtBoxFindWhat.Size = new System.Drawing.Size(440, 20);
			this.txtBoxFindWhat.TabIndex = 1;
			this.txtBoxFindWhat.TextChanged += new System.EventHandler(this.OnFindTextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fi&nd what:";
			// 
			// txtBoxReplaceWith
			// 
			this.txtBoxReplaceWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxReplaceWith.Location = new System.Drawing.Point(85, 32);
			this.txtBoxReplaceWith.Name = "txtBoxReplaceWith";
			this.txtBoxReplaceWith.Size = new System.Drawing.Size(440, 20);
			this.txtBoxReplaceWith.TabIndex = 3;
			this.txtBoxReplaceWith.TextChanged += new System.EventHandler(this.OnReplaceTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Replace &with:";
			// 
			// bFind
			// 
			this.bFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bFind.Enabled = false;
			this.bFind.Location = new System.Drawing.Point(243, 60);
			this.bFind.Name = "bFind";
			this.bFind.Size = new System.Drawing.Size(90, 23);
			this.bFind.TabIndex = 4;
			this.bFind.Text = "&Find";
			this.bFind.UseVisualStyleBackColor = true;
			this.bFind.Click += new System.EventHandler(this.OnFindClick);
			// 
			// bReplace
			// 
			this.bReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bReplace.Enabled = false;
			this.bReplace.Location = new System.Drawing.Point(339, 60);
			this.bReplace.Name = "bReplace";
			this.bReplace.Size = new System.Drawing.Size(90, 23);
			this.bReplace.TabIndex = 5;
			this.bReplace.Text = "&Replace";
			this.bReplace.UseVisualStyleBackColor = true;
			this.bReplace.Click += new System.EventHandler(this.OnReplaceClick);
			// 
			// bReplaceAll
			// 
			this.bReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bReplaceAll.Enabled = false;
			this.bReplaceAll.Location = new System.Drawing.Point(435, 60);
			this.bReplaceAll.Name = "bReplaceAll";
			this.bReplaceAll.Size = new System.Drawing.Size(90, 23);
			this.bReplaceAll.TabIndex = 6;
			this.bReplaceAll.Text = "Replace &All";
			this.bReplaceAll.UseVisualStyleBackColor = true;
			this.bReplaceAll.Click += new System.EventHandler(this.OnReplaceAllClick);
			// 
			// panelDesignArea
			// 
			this.panelDesignArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panelDesignArea.Controls.Add(this.bReplaceAll);
			this.panelDesignArea.Controls.Add(this.bReplace);
			this.panelDesignArea.Controls.Add(this.bFind);
			this.panelDesignArea.Controls.Add(this.label2);
			this.panelDesignArea.Controls.Add(this.txtBoxReplaceWith);
			this.panelDesignArea.Controls.Add(this.label1);
			this.panelDesignArea.Controls.Add(this.txtBoxFindWhat);
			this.panelDesignArea.Location = new System.Drawing.Point(0, 24);
			this.panelDesignArea.Name = "panelDesignArea";
			this.panelDesignArea.Size = new System.Drawing.Size(535, 92);
			this.panelDesignArea.TabIndex = 1;
			// 
			// FindReplace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.panelDesignArea);
			this.MinimumSize = new System.Drawing.Size(370, 24);
			this.Name = "FindReplace";
			this.Size = new System.Drawing.Size(535, 115);
			this.panelDesignArea.ResumeLayout(false);
			this.panelDesignArea.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtBoxFindWhat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBoxReplaceWith;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bFind;
		private System.Windows.Forms.Button bReplace;
		private System.Windows.Forms.Button bReplaceAll;
		private System.Windows.Forms.Panel panelDesignArea;
	}
}

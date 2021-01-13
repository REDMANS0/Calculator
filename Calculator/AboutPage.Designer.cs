
namespace Calculator
{
	partial class AboutPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPage));
			this.Background = new System.Windows.Forms.Panel();
			this.AboutText = new System.Windows.Forms.LinkLabel();
			this.Icon2Info = new System.Windows.Forms.Label();
			this.Icon2PictureBox = new System.Windows.Forms.PictureBox();
			this.IconModification = new System.Windows.Forms.Label();
			this.IconLink = new System.Windows.Forms.LinkLabel();
			this.IconLicense = new System.Windows.Forms.LinkLabel();
			this.IconTitle = new System.Windows.Forms.Label();
			this.IconAuthor = new System.Windows.Forms.LinkLabel();
			this.IconPictureBox = new System.Windows.Forms.PictureBox();
			this.Background.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Icon2PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// Background
			// 
			this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
			this.Background.Controls.Add(this.AboutText);
			this.Background.Controls.Add(this.Icon2Info);
			this.Background.Controls.Add(this.Icon2PictureBox);
			this.Background.Controls.Add(this.IconModification);
			this.Background.Controls.Add(this.IconLink);
			this.Background.Controls.Add(this.IconLicense);
			this.Background.Controls.Add(this.IconTitle);
			this.Background.Controls.Add(this.IconAuthor);
			this.Background.Controls.Add(this.IconPictureBox);
			this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Background.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Background.Location = new System.Drawing.Point(0, 0);
			this.Background.Name = "Background";
			this.Background.Size = new System.Drawing.Size(319, 541);
			this.Background.TabIndex = 0;
			// 
			// AboutText
			// 
			this.AboutText.ActiveLinkColor = System.Drawing.Color.Blue;
			this.AboutText.Dock = System.Windows.Forms.DockStyle.Top;
			this.AboutText.LinkArea = new System.Windows.Forms.LinkArea(8, 8);
			this.AboutText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.AboutText.Location = new System.Drawing.Point(0, 0);
			this.AboutText.Name = "AboutText";
			this.AboutText.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.AboutText.Size = new System.Drawing.Size(319, 60);
			this.AboutText.TabIndex = 0;
			this.AboutText.TabStop = true;
			this.AboutText.Text = "Made by REDMANS0\r\nDone as a learning project for learning C#\r\nVersion 1.0.1.2";
			this.AboutText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.AboutText.UseCompatibleTextRendering = true;
			this.AboutText.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.AboutText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutText_LinkClicked);
			// 
			// Icon2Info
			// 
			this.Icon2Info.Location = new System.Drawing.Point(0, 225);
			this.Icon2Info.Name = "Icon2Info";
			this.Icon2Info.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.Icon2Info.Size = new System.Drawing.Size(319, 30);
			this.Icon2Info.TabIndex = 0;
			this.Icon2Info.Text = "Icon is made by my friend";
			this.Icon2Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Icon2PictureBox
			// 
			this.Icon2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Icon2PictureBox.Image")));
			this.Icon2PictureBox.Location = new System.Drawing.Point(0, 195);
			this.Icon2PictureBox.Name = "Icon2PictureBox";
			this.Icon2PictureBox.Size = new System.Drawing.Size(319, 30);
			this.Icon2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Icon2PictureBox.TabIndex = 2;
			this.Icon2PictureBox.TabStop = false;
			// 
			// IconModification
			// 
			this.IconModification.Location = new System.Drawing.Point(0, 180);
			this.IconModification.Name = "IconModification";
			this.IconModification.Size = new System.Drawing.Size(319, 15);
			this.IconModification.TabIndex = 0;
			this.IconModification.Text = "Icon hasn\'t been modified\r\n";
			this.IconModification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// IconLink
			// 
			this.IconLink.ActiveLinkColor = System.Drawing.Color.Blue;
			this.IconLink.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IconLink.LinkArea = new System.Windows.Forms.LinkArea(19, 9);
			this.IconLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.IconLink.Location = new System.Drawing.Point(0, 130);
			this.IconLink.Name = "IconLink";
			this.IconLink.Size = new System.Drawing.Size(319, 15);
			this.IconLink.TabIndex = 0;
			this.IconLink.TabStop = true;
			this.IconLink.Text = "Icon is taken from this page";
			this.IconLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.IconLink.UseCompatibleTextRendering = true;
			this.IconLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.IconLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IconLink_LinkClicked);
			// 
			// IconLicense
			// 
			this.IconLicense.ActiveLinkColor = System.Drawing.Color.Blue;
			this.IconLicense.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IconLicense.LinkArea = new System.Windows.Forms.LinkArea(23, 43);
			this.IconLicense.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.IconLicense.Location = new System.Drawing.Point(0, 145);
			this.IconLicense.Name = "IconLicense";
			this.IconLicense.Size = new System.Drawing.Size(319, 35);
			this.IconLicense.TabIndex = 0;
			this.IconLicense.TabStop = true;
			this.IconLicense.Text = "Icon is licensed under Creative Commons (Attribution 3.0 Unported)";
			this.IconLicense.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.IconLicense.UseCompatibleTextRendering = true;
			this.IconLicense.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.IconLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IconLicense_LinkClicked);
			// 
			// IconTitle
			// 
			this.IconTitle.Location = new System.Drawing.Point(0, 115);
			this.IconTitle.Name = "IconTitle";
			this.IconTitle.Size = new System.Drawing.Size(319, 15);
			this.IconTitle.TabIndex = 0;
			this.IconTitle.Text = "Icon title is \"Calculator, math, school, tool icon\"";
			this.IconTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// IconAuthor
			// 
			this.IconAuthor.ActiveLinkColor = System.Drawing.Color.Blue;
			this.IconAuthor.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IconAuthor.LinkArea = new System.Windows.Forms.LinkArea(15, 7);
			this.IconAuthor.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.IconAuthor.Location = new System.Drawing.Point(0, 90);
			this.IconAuthor.Name = "IconAuthor";
			this.IconAuthor.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.IconAuthor.Size = new System.Drawing.Size(319, 25);
			this.IconAuthor.TabIndex = 0;
			this.IconAuthor.TabStop = true;
			this.IconAuthor.Text = "Icon author is bamicon";
			this.IconAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.IconAuthor.UseCompatibleTextRendering = true;
			this.IconAuthor.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.IconAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IconAuthor_LinkClicked);
			// 
			// IconPictureBox
			// 
			this.IconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IconPictureBox.Image")));
			this.IconPictureBox.Location = new System.Drawing.Point(0, 60);
			this.IconPictureBox.Name = "IconPictureBox";
			this.IconPictureBox.Size = new System.Drawing.Size(319, 30);
			this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.IconPictureBox.TabIndex = 1;
			this.IconPictureBox.TabStop = false;
			// 
			// AboutPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 541);
			this.Controls.Add(this.Background);
			this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "AboutPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About the calculator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutPage_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutPage_KeyDown);
			this.Background.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Icon2PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel Background;
		private System.Windows.Forms.PictureBox IconPictureBox;
		private System.Windows.Forms.LinkLabel IconAuthor;
		private System.Windows.Forms.Label IconTitle;
		private System.Windows.Forms.LinkLabel IconLicense;
		private System.Windows.Forms.LinkLabel IconLink;
		private System.Windows.Forms.Label IconModification;
		private System.Windows.Forms.Label Icon2Info;
		private System.Windows.Forms.PictureBox Icon2PictureBox;
		private System.Windows.Forms.LinkLabel AboutText;
	}
}
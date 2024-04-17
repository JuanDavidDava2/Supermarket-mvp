namespace Supermarket_mvp.Views
{
	partial class MainView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			panel1 = new Panel();
			BtnPayMode = new Button();
			pictureBox1 = new PictureBox();
			BtnExit = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(BtnExit);
			panel1.Controls.Add(BtnPayMode);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(377, 696);
			panel1.TabIndex = 0;
			// 
			// BtnPayMode
			// 
			BtnPayMode.BackgroundImage = (Image)resources.GetObject("BtnPayMode.BackgroundImage");
			BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
			BtnPayMode.Location = new Point(3, 113);
			BtnPayMode.Name = "BtnPayMode";
			BtnPayMode.Size = new Size(371, 207);
			BtnPayMode.TabIndex = 1;
			BtnPayMode.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Top;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(377, 119);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// BtnExit
			// 
			BtnExit.BackgroundImage = (Image)resources.GetObject("BtnExit.BackgroundImage");
			BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
			BtnExit.Dock = DockStyle.Bottom;
			BtnExit.Location = new Point(0, 533);
			BtnExit.Name = "BtnExit";
			BtnExit.Size = new Size(377, 163);
			BtnExit.TabIndex = 2;
			BtnExit.UseVisualStyleBackColor = true;
			// 
			// MainView
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1004, 696);
			Controls.Add(panel1);
			IsMdiContainer = true;
			Name = "MainView";
			Text = "Supermarket";
			WindowState = FormWindowState.Maximized;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button BtnPayMode;
		private PictureBox pictureBox1;
		private Button BtnExit;
	}
}
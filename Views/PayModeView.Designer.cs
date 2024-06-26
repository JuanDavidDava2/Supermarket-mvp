﻿namespace Supermarket_mvp.Views
{
	partial class PayModeView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			tabControl1 = new TabControl();
			tabPagePayModeList = new TabPage();
			BtnClose = new Button();
			BtnDelete = new Button();
			BtnEdit = new Button();
			BtnNew = new Button();
			DgPayMode = new DataGridView();
			BtnSearch = new Button();
			TxtSearch = new TextBox();
			label2 = new Label();
			tabPagePayModeDetail = new TabPage();
			TxtPayModeObservation = new TextBox();
			BtnCancel = new Button();
			BtnSave = new Button();
			TxtPayModeName = new TextBox();
			TxtPayModel = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tabControl1.SuspendLayout();
			tabPagePayModeList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
			tabPagePayModeDetail.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1166, 158);
			panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(33, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(137, 121);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(212, 65);
			label1.Name = "label1";
			label1.Size = new Size(120, 32);
			label1.TabIndex = 0;
			label1.Text = "Pay Mode";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPagePayModeList);
			tabControl1.Controls.Add(tabPagePayModeDetail);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 158);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1166, 641);
			tabControl1.TabIndex = 1;
			// 
			// tabPagePayModeList
			// 
			tabPagePayModeList.Controls.Add(BtnClose);
			tabPagePayModeList.Controls.Add(BtnDelete);
			tabPagePayModeList.Controls.Add(BtnEdit);
			tabPagePayModeList.Controls.Add(BtnNew);
			tabPagePayModeList.Controls.Add(DgPayMode);
			tabPagePayModeList.Controls.Add(BtnSearch);
			tabPagePayModeList.Controls.Add(TxtSearch);
			tabPagePayModeList.Controls.Add(label2);
			tabPagePayModeList.Location = new Point(8, 46);
			tabPagePayModeList.Name = "tabPagePayModeList";
			tabPagePayModeList.Padding = new Padding(3);
			tabPagePayModeList.Size = new Size(1150, 587);
			tabPagePayModeList.TabIndex = 0;
			tabPagePayModeList.Text = "Pay Mode List ";
			tabPagePayModeList.UseVisualStyleBackColor = true;
			// 
			// BtnClose
			// 
			BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
			BtnClose.Location = new Point(832, 458);
			BtnClose.Name = "BtnClose";
			BtnClose.Size = new Size(291, 72);
			BtnClose.TabIndex = 7;
			BtnClose.UseVisualStyleBackColor = true;
			// 
			// BtnDelete
			// 
			BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
			BtnDelete.Location = new Point(832, 354);
			BtnDelete.Name = "BtnDelete";
			BtnDelete.Size = new Size(291, 72);
			BtnDelete.TabIndex = 6;
			BtnDelete.UseVisualStyleBackColor = true;
			// 
			// BtnEdit
			// 
			BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
			BtnEdit.Location = new Point(832, 252);
			BtnEdit.Name = "BtnEdit";
			BtnEdit.Size = new Size(291, 72);
			BtnEdit.TabIndex = 5;
			BtnEdit.UseVisualStyleBackColor = true;
			// 
			// BtnNew
			// 
			BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
			BtnNew.Location = new Point(832, 150);
			BtnNew.Name = "BtnNew";
			BtnNew.Size = new Size(291, 72);
			BtnNew.TabIndex = 4;
			BtnNew.UseVisualStyleBackColor = true;
			// 
			// DgPayMode
			// 
			DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DgPayMode.Location = new Point(25, 129);
			DgPayMode.Name = "DgPayMode";
			DgPayMode.RowHeadersWidth = 82;
			DgPayMode.RowTemplate.Height = 41;
			DgPayMode.Size = new Size(774, 452);
			DgPayMode.TabIndex = 3;
			// 
			// BtnSearch
			// 
			BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
			BtnSearch.Location = new Point(737, 53);
			BtnSearch.Name = "BtnSearch";
			BtnSearch.Size = new Size(62, 55);
			BtnSearch.TabIndex = 2;
			BtnSearch.UseVisualStyleBackColor = true;
			// 
			// TxtSearch
			// 
			TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			TxtSearch.Location = new Point(25, 69);
			TxtSearch.Name = "TxtSearch";
			TxtSearch.PlaceholderText = "Data to search";
			TxtSearch.Size = new Size(689, 39);
			TxtSearch.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(25, 22);
			label2.Name = "label2";
			label2.Size = new Size(198, 32);
			label2.TabIndex = 0;
			label2.Text = "Search Pay Mode";
			// 
			// tabPagePayModeDetail
			// 
			tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
			tabPagePayModeDetail.Controls.Add(BtnCancel);
			tabPagePayModeDetail.Controls.Add(BtnSave);
			tabPagePayModeDetail.Controls.Add(TxtPayModeName);
			tabPagePayModeDetail.Controls.Add(TxtPayModel);
			tabPagePayModeDetail.Controls.Add(label5);
			tabPagePayModeDetail.Controls.Add(label4);
			tabPagePayModeDetail.Controls.Add(label3);
			tabPagePayModeDetail.Location = new Point(8, 46);
			tabPagePayModeDetail.Name = "tabPagePayModeDetail";
			tabPagePayModeDetail.Padding = new Padding(3);
			tabPagePayModeDetail.Size = new Size(1150, 587);
			tabPagePayModeDetail.TabIndex = 1;
			tabPagePayModeDetail.Text = "Pay Mode Detail";
			tabPagePayModeDetail.UseVisualStyleBackColor = true;
			// 
			// TxtPayModeObservation
			// 
			TxtPayModeObservation.Location = new Point(25, 330);
			TxtPayModeObservation.Multiline = true;
			TxtPayModeObservation.Name = "TxtPayModeObservation";
			TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
			TxtPayModeObservation.Size = new Size(535, 88);
			TxtPayModeObservation.TabIndex = 8;
			// 
			// BtnCancel
			// 
			BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
			BtnCancel.Location = new Point(291, 452);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(168, 93);
			BtnCancel.TabIndex = 7;
			BtnCancel.UseVisualStyleBackColor = true;
			BtnCancel.Click += BtnCancel_Click;
			// 
			// BtnSave
			// 
			BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
			BtnSave.Location = new Point(25, 452);
			BtnSave.Name = "BtnSave";
			BtnSave.Size = new Size(168, 93);
			BtnSave.TabIndex = 6;
			BtnSave.UseVisualStyleBackColor = true;
			// 
			// TxtPayModeName
			// 
			TxtPayModeName.Location = new Point(25, 213);
			TxtPayModeName.Name = "TxtPayModeName";
			TxtPayModeName.PlaceholderText = "Pay Mode Name";
			TxtPayModeName.Size = new Size(535, 39);
			TxtPayModeName.TabIndex = 4;
			// 
			// TxtPayModel
			// 
			TxtPayModel.Location = new Point(25, 84);
			TxtPayModel.Name = "TxtPayModel";
			TxtPayModel.Size = new Size(255, 39);
			TxtPayModel.TabIndex = 3;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(25, 280);
			label5.Name = "label5";
			label5.Size = new Size(256, 32);
			label5.TabIndex = 2;
			label5.Text = "Pay Mode Observation";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(25, 167);
			label4.Name = "label4";
			label4.Size = new Size(191, 32);
			label4.TabIndex = 1;
			label4.Text = "Pay Mode Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(25, 40);
			label3.Name = "label3";
			label3.Size = new Size(147, 32);
			label3.TabIndex = 0;
			label3.Text = "Pay Mode Id";
			// 
			// PayModeView
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1166, 799);
			Controls.Add(tabControl1);
			Controls.Add(panel1);
			Name = "PayModeView";
			Text = "Pay Mode Management";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tabControl1.ResumeLayout(false);
			tabPagePayModeList.ResumeLayout(false);
			tabPagePayModeList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
			tabPagePayModeDetail.ResumeLayout(false);
			tabPagePayModeDetail.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label1;
		private TabControl tabControl1;
		private TabPage tabPagePayModeList;
		private TabPage tabPagePayModeDetail;
		private TextBox TxtSearch;
		private Label label2;
		private Button BtnSearch;
		private DataGridView DgPayMode;
		private Button BtnClose;
		private Button BtnDelete;
		private Button BtnEdit;
		private Button BtnNew;
		private TextBox TxtPayModeName;
		private TextBox TxtPayModel;
		private Label label5;
		private Label label4;
		private Label label3;
		private Button BtnCancel;
		private Button BtnSave;
		private TextBox TxtPayModeObservation;
	}
}
﻿namespace Supermarket_mvp.Views
{
	public partial class PayModeView : Form, IPayModeView
	{
		private bool isEdit;
		private bool isSuccessful;
		private string message;

		public PayModeView()
		{
			InitializeComponent();
			AssociateAndRaiseViewEvents();

			tabControl1.TabPages.Remove(tabPagePayModeDetail);
		}

		private void AssociateAndRaiseViewEvents()
		{
			BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

			TxtSearch.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					SearchEvent?.Invoke(this, EventArgs.Empty);
				}
			};
		}

		public string PayModeId
		{
			get { return TxtPayModel.Text; }
			set { TxtPayModel.Text = value; }

		}
		public string PayModeName
		{

			get { return TxtPayModeName.Text; }
			set { TxtPayModeName.Text = value; }
		}
		public string PayModeObservation 
		{
			get { return TxtPayModeObservation.Text; }
			set { TxtPayModeObservation.Text = value; }
		}
		public string SearchValue 
		{
			get { return TxtSearch.Text;  }
			set { TxtSearch.Text = value; } 
		}
		public bool IsEdit 
		{
			get { return isEdit; }

			set { isEdit = value; } 
		}
		public bool IsSuccessful 
		{
			get { return isSuccessful; }
			set { isSuccessful = value; }
		} 
		public string Message {
			get { return message; }
			set { message = value; } 
		}

		public event EventHandler SearchEvent;
		public event EventHandler AddNewEvent;
		public event EventHandler EditEvent;
		public event EventHandler DeleteEvent;
		public event EventHandler SaveEvent;
		public event EventHandler CancelEvent;

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{

		}

		public void SetPayModeListBildingSource(BindingSource payModeList)
		{
			DgPayMode.DataSource = payModeList;
		}

		//Patron singleton para controlar solo una instancia del formulario
		private static PayModeView instance;

		public static PayModeView GetInstance()
		{
			if (instance == null || instance.IsDisposed)
			{
				instance = new PayModeView();
			}
			else 
			{
				if (instance.WindowState == FormWindowState.Minimized)
				{
					instance.WindowState = FormWindowState.Normal;
				}
				instance.BringToFront();
			}
			return instance;
		}
	}
}

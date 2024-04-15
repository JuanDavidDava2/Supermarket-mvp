namespace Supermarket_mvp.Views
{
	public partial class PayModeView : Form, IPayModeView
	{
		private string message;
		private bool isSuccessful;
		private bool isEdit;

		public PayModeView()
		{
			InitializeComponent();
		}

		public string PayModeId
		{
			get { return TxtPayModel.Text; }
			set { TxtPayModel.Text = value; }

		}
		public string PayModeName
		{

			get { return TxtPayModeName.Text; }
			set { TxtPayModeName.text = value; }
		}
		public string PayModeObservation 
		{
			get { return TxtPayModeObservation.Text; }
			set { TxtPayModeObservation.Text = value; }
		}
		public string SearchValue 
		{
			get { return TxtSearch.Text;  }
			set { TxtSearch = value; } 
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
	}
}

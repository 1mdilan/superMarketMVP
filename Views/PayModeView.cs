using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superMarketMVP.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePayModeDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string PayModeID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PayModeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PayModeObservation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string payModeID
        {
            get { return txtPayModeID.Text; }
            set { txtPayModeID.Text = value; }
        }
        public string payModeName
        {
            get { return txtPayModeName.Text; }
            set { txtPayModeName.Text = value; }
        }
        public string payModeObservation
        {
            get { return txtPayModeObservation.Text; }
            set { txtPayModeObservation.Text = value; }
        }

        public string searchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool isEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool isSuccesful
        {
            get { return isSuccesful; }
            set { isSuccesful = value; }
        }
        public string message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPayModelListBildingSource(BindingSource payModeList)
        {
            dgPayMode.DataSource = payModeList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

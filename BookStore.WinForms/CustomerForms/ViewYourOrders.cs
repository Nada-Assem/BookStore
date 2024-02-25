using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.WinForms.CustomerForms
{
    public partial class ViewYourOrders : Form
    {
        private readonly int _customerId;

        public ViewYourOrders(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        private void ViewYourOrders_Load(object sender, EventArgs e)
        {
            IOrderService OrderService = new OrderService(new StoreContext());
            var orders = OrderService.GetAllCustomerOrders(_customerId);
            dataGridView1.DataSource = orders;
        }
    }
}

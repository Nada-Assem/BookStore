using BookStore.Core.Entities;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Repository.Enums;
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
    public partial class Cart : Form
    {
        IOrderService orderService;
        private readonly StoreContext _dbContext;
        private readonly int _customerId;

        public Cart(StoreContext dbContext, int customerId)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _customerId = customerId;
            orderService = new OrderService(_dbContext);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Create an order
        private void button2_Click(object sender, EventArgs e)
        {
            OrderStatusEnum status = orderService.CreateOrder(_customerId);
            if (status == OrderStatusEnum.Created)
                MessageBox.Show("Order Created :)");
            else if(status == OrderStatusEnum.NotCreated)
                MessageBox.Show("Order doesn't Created :(");
            else if (status == OrderStatusEnum.NoItems)
                MessageBox.Show("Your Cart is Empty !!");
        }
    }
}

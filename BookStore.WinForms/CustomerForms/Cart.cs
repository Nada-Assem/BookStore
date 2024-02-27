using BookStore.Core.Entities;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;
using BookStore.WinForms.AdminForms;
using Microsoft.EntityFrameworkCore;
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
        private readonly int _BookId;
        private readonly StoreContext _dbContext;
        private readonly int _customerId;
        //  Customer customer = new Customer();
        ICustomerService customerService;
        Book _book;
        Customer c;
        public Cart(StoreContext dbContext, int customerId, Book _book)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _customerId = customerId;
            orderService = new OrderService(_dbContext);
            _BookId = _book.Id;
            this._book = _book;
            customerService = new CustomerService(_dbContext);
        }
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


            //to make the cart empty
            c.CustomerBooks.Clear();
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            BookCustomer bookCustomer = new BookCustomer();
            bookCustomer.CustomerId = _customerId;
            bookCustomer.BookId = _BookId;
            bookCustomer.Quantity = int.Parse(label4.Text);

            c.CustomerBooks.Add(bookCustomer);
            _dbContext.SaveChanges();
            dataGridView1.DataSource = c.CustomerBooks;

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            if (_book != null)
            {
                label7.Text = _book.Title;
                label6.Text = _book.Price.ToString();
            }
            else
            {
                label7.Text = "";
                label6.Text ="";

            }
            c = customerService.GetCustomerById(_customerId);
            pictureBox1.Image = System.Drawing.Image.FromFile(_book.Image);
            dataGridView1.DataSource= c.CustomerBooks;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(label4.Text);
            x++;
            label4.Text = x.ToString();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(label4.Text);
            x--;
            label4.Text = x.ToString();
            
        }
    }
}

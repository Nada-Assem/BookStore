using BookStore.Core.Entities;
using BookStore.Repository.Data;
using BookStore.WinForms.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.WinForms
{
    public partial class HomeAdmin : Form
    {
        private readonly StoreContext _dbContext;

        public HomeAdmin(StoreContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void btOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders(_dbContext);
            orders.Show();
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void btCategories_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories(_dbContext);
            categories.Show();
        }

        private void btBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
        }

        private void PBLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}

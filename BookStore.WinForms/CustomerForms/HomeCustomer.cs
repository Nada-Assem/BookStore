using BookStore.Core.Entities;
using BookStore.Repository.Data;
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
    public partial class HomeCustomer : Form
    {
        private readonly int _customerId;
        private readonly StoreContext _dbContext;

        public HomeCustomer(int customerId, StoreContext dbContext)
        {
            InitializeComponent();
            _customerId = customerId;
            _dbContext = dbContext;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Account account = new Account(_customerId, _dbContext);
            account.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void HomeCustomer_Load(object sender, EventArgs e)
        {

        }

        private void PBCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(_dbContext, _customerId);
            cart.ShowDialog();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void PBLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}

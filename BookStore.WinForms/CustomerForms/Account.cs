using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;
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

namespace BookStore.WinForms.CustomerForms
{
    public partial class Account : Form
    {
        private readonly int _customerId;
        private readonly StoreContext _dbContext;
        ICustomerService customerService;
        public Account(int customerId, StoreContext dbConetxt)
        {
            InitializeComponent();
            _customerId = customerId;
            _dbContext = dbConetxt;
            customerService = new CustomerService(_dbContext);
        }
        private void Account_Load(object sender, EventArgs e)
        {
            var customer = customerService.GetCustomerById(_customerId);
            textBox1.Text = customer.Name;
            textBox3.Text = customer.Phone;
            textBox4.Text = customer.Address;
            textBox5.Text = customer.UserName;
            textBox6.Text = customer.Password;
        }
        private void BTViewOrders_Click(object sender, EventArgs e)
        {
            ViewYourOrders viewYourOrders = new ViewYourOrders(_customerId);
            viewYourOrders.ShowDialog();
        }
        // Update Customer Account
        private void button1_Click(object sender, EventArgs e)
        {

            CustomerToUpdateDTO inputs = new CustomerToUpdateDTO();
            inputs.Name = textBox1.Text;
            inputs.Phone = textBox3.Text;
            inputs.Address = textBox4.Text;
            inputs.UserName = textBox5.Text;
            inputs.Password = textBox6.Text;
            CustomerLoginMsgsDTO? msgs = customerService.UpdateCustomer(inputs, _customerId);
            if (msgs != null)
            {
                lbNameMgs.Text = msgs.NameMsg;
                lbUserNameMgs.Text = msgs.UserNameMsg;
                lbPhoneMgs.Text = msgs.PhoneMsg;
                lbPasswordMgs.Text = msgs.PasswordMsg;
                lbAddressMgs.Text = msgs.AddressMsg;

                if (string.IsNullOrEmpty(msgs.NameMsg) &&
                    string.IsNullOrEmpty(msgs.UserNameMsg) &&
                    string.IsNullOrEmpty(msgs.PhoneMsg) &&
                    string.IsNullOrEmpty(msgs.PasswordMsg) &&
                    string.IsNullOrEmpty(msgs.AddressMsg))
                {
                    var customer = customerService.GetCustomerById(_customerId);
                    customer.Name = textBox1.Text;
                    customer.Phone = textBox3.Text;
                    customer.Address = textBox4.Text;
                    customer.UserName = textBox5.Text;
                    customer.Password = textBox6.Text;
                    _dbContext.SaveChanges();

                    MessageBox.Show("Saved :)");

                    textBox1.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    textBox5.Text = string.Empty;
                    textBox6.Text = string.Empty;
                }
                else
                    MessageBox.Show("Not Saved :(");
            }
        }
    }
}

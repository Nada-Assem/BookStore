using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BookStore.WinForms.AdminForms
{
    public partial class viewAndDelBooks : Form
    {
        static StoreContext dbContext = new StoreContext();
        IBookService bookService = new BooksService(dbContext);
        public viewAndDelBooks()
        {
            InitializeComponent();
            dataGridView1.DataError += DataGridView1_DataError;
            intis();
            InitializeDataGridView();


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void intis()
        {

            // Define columns
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("CategoryId", "Category ID");
            // Call function to get book data

            //  Create and add DataGridViewComboBoxColumn for each list
            DataGridViewComboBoxColumn AuthorscomboBoxColumn = new DataGridViewComboBoxColumn();
            AuthorscomboBoxColumn.HeaderText = "Authors";
            AuthorscomboBoxColumn.Name = "Authors";
            dataGridView1.Columns.Add(AuthorscomboBoxColumn);
            ///////
            DataGridViewComboBoxColumn PublisherscomboBoxColumn = new DataGridViewComboBoxColumn();
            PublisherscomboBoxColumn.HeaderText = "Publishers";
            PublisherscomboBoxColumn.Name = "Publishers";
            dataGridView1.Columns.Add(PublisherscomboBoxColumn);
            ////
            DataGridViewComboBoxColumn CustomerscomboBoxColumn = new DataGridViewComboBoxColumn();
            CustomerscomboBoxColumn.HeaderText = "Customers";
            CustomerscomboBoxColumn.Name = "Customers";
            dataGridView1.Columns.Add(CustomerscomboBoxColumn);
            ///
            DataGridViewComboBoxColumn OrderscomboBoxColumn = new DataGridViewComboBoxColumn();
            OrderscomboBoxColumn.HeaderText = "Orders";
            OrderscomboBoxColumn.Name = "Orders";
            dataGridView1.Columns.Add(OrderscomboBoxColumn);
        }
        private void InitializeDataGridView()
        {
            var bookData = bookService.GetAllBooks().ToList();
            dataGridView1.Rows.Clear();
            foreach (var book in bookData)
            {
                var rowIndex = dataGridView1.Rows.Add(
                    book.Id,
                  book.Title,
                  book.Price,
                  book.Status,
                  book.CategoryId

              );

                var BookAuthors = book.BookAuthors.ToList();
                List<int> tempAuthors = new List<int>();
                foreach (var item in BookAuthors)
                {
                    tempAuthors.Add(item.AuthorId);
                }
                /////////
                var BookCustomers = book.BookCustomers.ToList();
                List<int> tempCustomers = new List<int>();
                foreach (var item in BookCustomers)
                {
                    tempCustomers.Add(item.CustomerId);
                }

                ///////////////////////
                var bookOrders = book.BookOrders.ToList();
                List<int> tempOrders = new List<int>();
                foreach (var item in bookOrders)
                {
                    tempOrders.Add(item.OrderId);
                }

                //////////////////////////
                var BookPublishers = book.BookPublishers.ToList();
                List<int> tempPublishers = new List<int>();
                foreach (var item in BookPublishers)
                {
                    tempPublishers.Add(item.PublisherId);
                }

                // Populate ComboBoxColumn with authors
                var comboBoxCell = (DataGridViewComboBoxCell)dataGridView1.Rows[rowIndex].Cells["Authors"];
                comboBoxCell.DataSource = tempAuthors;
                comboBoxCell = (DataGridViewComboBoxCell)dataGridView1.Rows[rowIndex].Cells["Publishers"];
                comboBoxCell.DataSource = tempPublishers;
                comboBoxCell = (DataGridViewComboBoxCell)dataGridView1.Rows[rowIndex].Cells["Customers"];
                comboBoxCell.DataSource = tempCustomers;
                comboBoxCell = (DataGridViewComboBoxCell)dataGridView1.Rows[rowIndex].Cells["Orders"];
                comboBoxCell.DataSource = tempOrders;
            }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is ArgumentException)
            {
                // Handle the exception here
                MessageBox.Show("Invalid value entered in DataGridViewComboBoxCell.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void BTDelBook_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0 && textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int bookid;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                bookid = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            }
            else
            {
                if (!int.TryParse(textBox1.Text, out bookid))
                {
                    MessageBox.Show("Please enter a valid id.");
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bookService.DeleteBook(bookid);
                InitializeDataGridView();
            }
        }

        private void BTAddBook_Click(object sender, EventArgs e)
        {

        }

        private void viewAndDelBooks_Load(object sender, EventArgs e)
        {

        }
    }
}

using Azure.Core.GeoJson;
using BookStore.Core.Entities;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;
using BookStore.WinForms.AdminForms;
using Microsoft.EntityFrameworkCore;
using BookStore.Core.Entities;
using BookStore.Repository.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStore.WinForms.CustomerForms
{
    public partial class HomeCustomer : Form
    {


        private List<Book> allBooks;
        private readonly int _customerId;
        private readonly StoreContext _dbContext;
        IBookService bookService;

        FlowLayoutPanel flowLayoutPanelBooks;

        public HomeCustomer(int customerId, StoreContext dbContext)
        {
            InitializeComponent();
            _customerId = customerId;
            _dbContext = dbContext;
            bookService = new BooksService(_dbContext);
            InitializePanel();
            LoadBooks();
        }

        private void InitializePanel()
        {

            flowLayoutPanelBooks = new FlowLayoutPanel();
            flowLayoutPanelBooks.AutoScroll = true;
            flowLayoutPanelBooks.Size = new Size(965, 561);

            // flowLayoutPanelBooks.Dock = DockStyle.Fill;
            flowLayoutPanelBooks.FlowDirection = FlowDirection.TopDown;

            flowLayoutPanelBooks.WrapContents = false;
            //    flowLayoutPanelBooks.AutoScrollPosition = new Point(0, 200);
            this.Controls.Add(flowLayoutPanelBooks);

            comboBox1.DataSource = _dbContext.Categories.ToList();
            comboBox1.DisplayMember = "Name";
            allBooks = bookService.GetAllBooks().ToList();

        }

        private void flowLayoutPanelBooks_Scroll(object sender, ScrollEventArgs e)
        {

            pictureBox1.Location = new Point(pictureBox1.Location.X - flowLayoutPanelBooks.HorizontalScroll.Value, pictureBox1.Location.Y - flowLayoutPanelBooks.VerticalScroll.Value);
        }
        private void LoadBooks()
        {
            flowLayoutPanelBooks.Controls.Clear();
            int columnWidth = (flowLayoutPanelBooks.ClientSize.Width - flowLayoutPanelBooks.Padding.Horizontal) / 2;
            List<Book> booksForPage = allBooks;

            for (int i = 0; i < booksForPage.Count; i++)
            {

                Book book = booksForPage[i];
                // Book book2 = booksForPage[i+1];
                PictureBox pictureBox = new PictureBox
                {
                    Image = System.Drawing.Image.FromFile(book.Image),
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Width = 960,
                    Height = 500

                };
                pictureBox.Click += (sender, e) =>
                {
                    pictureBox1.Image = pictureBox.Image; // Show the clicked image in pictureBox1
                };

                Label titleLabel = new Label
                {

                    Text = ("\n\n\n\n" + new string(' ', 20) + book.Title),
                    AutoSize = true
                };
                titleLabel.ForeColor = Color.Wheat;
                titleLabel.Font = new System.Drawing.Font(titleLabel.Font.FontFamily, 12f, FontStyle.Regular);
                StringBuilder sb = new StringBuilder();
                foreach (var auth in book.BookAuthors)
                {
                    Author author = _dbContext.Authors.FirstOrDefault(a => a.Id == auth.AuthorId);
                    sb.AppendLine($" {author.Name} ");
                }
                string result = sb.ToString();

                Label AutherLabel = new Label
                {

                    Text = new string(' ', 20) + result,
                    AutoSize = true
                };
                AutherLabel.ForeColor = Color.Wheat;
                AutherLabel.Font = new System.Drawing.Font(titleLabel.Font.FontFamily, 12f, FontStyle.Regular);
                Label priceLabel = new Label
                {
                    Text = new string(' ', 20) + book.Price.ToString("C"),
                    AutoSize = true
                };
                priceLabel.ForeColor = Color.Wheat;
                priceLabel.Font = new System.Drawing.Font(priceLabel.Font.FontFamily, 12f, FontStyle.Regular);
                Button addToCartButton = new Button
                {
                    Text = "Add to Cart",
                    Tag = book,
                    AutoSize = true,
                    BackColor = Color.FromArgb(69, 51, 39),
                    ForeColor = Color.Wheat


                };
                addToCartButton.Margin = new Padding(90, 0, 0, 0);
                FlowLayoutPanel bookPanel = new FlowLayoutPanel();
                bookPanel.Size = new Size(950, 200);
                bookPanel.FlowDirection = FlowDirection.TopDown;

                bookPanel.Controls.Add(pictureBox);

                bookPanel.Controls.Add(titleLabel);
                bookPanel.Controls.Add(AutherLabel);
                bookPanel.Controls.Add(priceLabel);
                bookPanel.Controls.Add(addToCartButton);

                flowLayoutPanelBooks.Controls.Add(bookPanel);
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Account account = new Account(_customerId, _dbContext);
            account.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = comboBox1.SelectedItem as Category;
            allBooks = bookService.GetBooksByCategoryId(category.Id);
            LoadBooks();
        }
    }
}

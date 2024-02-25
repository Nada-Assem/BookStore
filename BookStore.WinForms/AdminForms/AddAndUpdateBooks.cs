using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.WinForms.AdminForms
{
    public partial class AddAndUpdateBooks : Form
    {
        static StoreContext dbContext = new StoreContext();
        IBookService bookService = new BooksService(dbContext);
        public AddAndUpdateBooks()
        {
            InitializeComponent();
            handelCompoBoxData();
        }
        void handelCompoBoxData()
        {
            comboBox1.DataSource = dbContext.Categories.ToList();
            comboBox1.DisplayMember = "Id";
            listBox2.DataSource = dbContext.Authors.ToList();
            listBox2.DisplayMember = "Id";
            listBox3.DataSource = dbContext.Publishers.ToList();
            listBox3.DisplayMember = "Id";

        }


        private void AddAndUpdateBooks_Load(object sender, EventArgs e)
        {

        }


        private void BTUploadImg_Click(object sender, EventArgs e)
        {
           

        }

        private void BTAddBook_Click(object sender, EventArgs e)
        {
            bool ok = true;
            Book book = new Book();
            book.Status = BookStatusEnum.Available;
            if (textBox4.Text.Length > 0 || bookService.GetBookByName(textBox4.Text) != null)
            {
                book.Title = textBox4.Text;
                label10.Text = "";
                ok = true;
            }
            else
            {
                label10.Text = "Please Enter the title not found before";
                ok = false;
            }
            if (textBox3.Text.Length > 0)
            {
                book.Price = decimal.Parse(textBox3.Text);
                label11.Text = "";
                ok = true;
            }
            else
            {
                label11.Text = "Please Enter the Price";
                ok = false;
            }
            if (comboBox1.SelectedItem != null)
            {
                Category c = comboBox1.SelectedItem as Category;
                book.CategoryId = c.Id;
                label3.Text = "Please Enter the Category";
            }
            else
            {
                label3.Text = "";
                ok = false;
            }
            if(ok)
            bookService.AddBook(book);
            if (listBox3.SelectedItems.Count > 0)
            {
                List<BookPublisher> selectedPublisher = new List<BookPublisher>();
                foreach (var selectedItem in listBox3.SelectedItems)
                {
                    Publisher publisher = selectedItem as Publisher;
                    BookPublisher selectedBook = new BookPublisher();
                    selectedBook.BookId = book.Id;
                    selectedBook.PublisherId = publisher.Id;
                    selectedPublisher.Add(selectedBook);
                }
                book.BookPublishers = selectedPublisher;
                label1.Text = "";
                ok = true;
            }
            else
            {
                label1.Text = "Please select Publisher";
                ok = false;
            }
            if (listBox2.SelectedItems.Count > 0)
            {
                List<BookAuthor> selectedAuthor = new List<BookAuthor>();
                foreach (var selectedItem in listBox2.SelectedItems)
                {
                    Author author = selectedItem as Author;
                    BookAuthor selectedBook = new BookAuthor();
                    selectedBook.BookId = book.Id;
                    selectedBook.AuthorId = author.Id;
                    selectedAuthor.Add(selectedBook);
                }
                ok = true;
                label5.Text = "";
            }
            else
            {
                label5.Text = "Please select Author";
                ok = false;
            }

            if (Img.Image != null)
            {
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    Img.Image.Save(ms, ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }

                book.Image =  Convert.ToBase64String(imageBytes);

            }
            else
            {
                MessageBox.Show("Please upload an image first.");
            }
            if (ok)
            {
                bookService.UpdateBook(book);
                MessageBox.Show("new Book Add");
            }
           

        }

        private void Img_Click(object sender, EventArgs e)
        {

        }
    }
}

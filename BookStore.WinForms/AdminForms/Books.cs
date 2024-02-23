using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.WinForms.AdminForms
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void BtviewandDelBooks_Click(object sender, EventArgs e)
        {
            viewAndDelBooks viewAndDelBooks = new viewAndDelBooks();
            viewAndDelBooks.ShowDialog();   
        }

        private void BTAddandUpdateBooks_Click(object sender, EventArgs e)
        {
            AddAndUpdateBooks books = new AddAndUpdateBooks();
            books.ShowDialog();
        }
    }
}

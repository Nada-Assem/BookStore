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
    public partial class AddAndUpdateBooks : Form
    {
        public AddAndUpdateBooks()
        {
            InitializeComponent();
        }

        private void AddAndUpdateBooks_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BTUploadImg_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                try
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFile = openFileDialog1.FileName;
                        // Load the selected image file into the PictureBox
                        this.Invoke(new Action(() => Img.Image = Image.FromFile(selectedFile)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void Img_Click(object sender, EventArgs e)
        {

        }
    }
}

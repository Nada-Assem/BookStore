namespace BookStore.WinForms.AdminForms
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BTAddandUpdateBooks = new Button();
            BtviewandDelBooks = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imag4;
            pictureBox1.Location = new Point(360, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(107, 61);
            label1.Name = "label1";
            label1.Size = new Size(135, 54);
            label1.TabIndex = 1;
            label1.Text = "Books";
            // 
            // BTAddandUpdateBooks
            // 
            BTAddandUpdateBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTAddandUpdateBooks.ForeColor = Color.FromArgb(69, 51, 39);
            BTAddandUpdateBooks.Location = new Point(44, 218);
            BTAddandUpdateBooks.Name = "BTAddandUpdateBooks";
            BTAddandUpdateBooks.Size = new Size(273, 40);
            BTAddandUpdateBooks.TabIndex = 2;
            BTAddandUpdateBooks.Text = "Add And Update Books";
            BTAddandUpdateBooks.UseVisualStyleBackColor = true;
            BTAddandUpdateBooks.Click += BTAddandUpdateBooks_Click;
            // 
            // BtviewandDelBooks
            // 
            BtviewandDelBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BtviewandDelBooks.ForeColor = Color.FromArgb(69, 51, 39);
            BtviewandDelBooks.Location = new Point(44, 303);
            BtviewandDelBooks.Name = "BtviewandDelBooks";
            BtviewandDelBooks.Size = new Size(273, 40);
            BtviewandDelBooks.TabIndex = 3;
            BtviewandDelBooks.Text = "View And Delete Books";
            BtviewandDelBooks.UseVisualStyleBackColor = true;
            BtviewandDelBooks.Click += BtviewandDelBooks_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(BtviewandDelBooks);
            Controls.Add(BTAddandUpdateBooks);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button BTAddandUpdateBooks;
        private Button BtviewandDelBooks;
    }
}
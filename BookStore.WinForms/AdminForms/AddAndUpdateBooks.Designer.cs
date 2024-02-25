namespace BookStore.WinForms.AdminForms
{
    partial class AddAndUpdateBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndUpdateBooks));
            BTAddBook = new Button();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            BTUploadImg = new Button();
            Img = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Img).BeginInit();
            SuspendLayout();
            // 
            // BTAddBook
            // 
            BTAddBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTAddBook.ForeColor = Color.FromArgb(69, 51, 39);
            BTAddBook.Location = new Point(583, 280);
            BTAddBook.Margin = new Padding(3, 2, 3, 2);
            BTAddBook.Name = "BTAddBook";
            BTAddBook.Size = new Size(100, 28);
            BTAddBook.TabIndex = 0;
            BTAddBook.Text = "Add";
            BTAddBook.UseVisualStyleBackColor = true;
            BTAddBook.Click += BTAddBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(39, 58);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(36, 111);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(431, 73);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 7;
            label6.Text = "Category ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(431, 163);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 8;
            label7.Text = "Author ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(12, 178);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 9;
            label8.Text = "Publisher ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 111);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 56);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 23);
            textBox4.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(271, 9);
            label9.Name = "label9";
            label9.Size = new Size(179, 45);
            label9.TabIndex = 17;
            label9.Text = "Add Books";
            // 
            // BTUploadImg
            // 
            BTUploadImg.Location = new Point(12, 286);
            BTUploadImg.Margin = new Padding(3, 2, 3, 2);
            BTUploadImg.Name = "BTUploadImg";
            BTUploadImg.Size = new Size(116, 22);
            BTUploadImg.TabIndex = 18;
            BTUploadImg.Text = "Upload Image";
            BTUploadImg.UseVisualStyleBackColor = true;
            BTUploadImg.Click += BTUploadImg_Click;
            // 
            // Img
            // 
            Img.Image = (Image)resources.GetObject("Img.Image");
            Img.Location = new Point(159, 248);
            Img.Margin = new Padding(3, 2, 3, 2);
            Img.Name = "Img";
            Img.Size = new Size(176, 280);
            Img.SizeMode = PictureBoxSizeMode.StretchImage;
            Img.TabIndex = 19;
            Img.TabStop = false;
            Img.Click += Img_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(179, 81);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(179, 136);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 21;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(574, 155);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 29;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(126, 154);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(180, 79);
            listBox3.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(312, 196);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(742, 73);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(742, 184);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 33;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(574, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 34;
            // 
            // AddAndUpdateBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(817, 338);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Img);
            Controls.Add(BTUploadImg);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(BTAddBook);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAndUpdateBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAndUpdateBooks";
            Load += AddAndUpdateBooks_Load;
            ((System.ComponentModel.ISupportInitialize)Img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTAddBook;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label9;
        private Button BTUploadImg;
        private PictureBox Img;
        private Label label10;
        private Label label11;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label1;
        private Label label3;
        private Label label5;
        private ComboBox comboBox1;
    }
}
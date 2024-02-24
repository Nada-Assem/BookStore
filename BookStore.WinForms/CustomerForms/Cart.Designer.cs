namespace BookStore.WinForms.CustomerForms
{
    partial class Cart
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
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            TotalCart = new Label();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(35, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 204);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(246, 36);
            label7.Name = "label7";
            label7.Size = new Size(181, 41);
            label7.TabIndex = 7;
            label7.Text = "Book Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(348, 92);
            label6.Name = "label6";
            label6.Size = new Size(111, 41);
            label6.TabIndex = 6;
            label6.Text = "230.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(256, 92);
            label5.Name = "label5";
            label5.Size = new Size(74, 41);
            label5.TabIndex = 5;
            label5.Text = "EGP";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(69, 51, 39);
            button1.Location = new Point(451, 160);
            button1.Name = "button1";
            button1.Size = new Size(153, 37);
            button1.TabIndex = 0;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(315, 154);
            label4.Name = "label4";
            label4.Size = new Size(33, 38);
            label4.TabIndex = 4;
            label4.Text = "2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.books;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.add;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            button4.Location = new Point(366, 160);
            button4.Name = "button4";
            button4.Size = new Size(33, 29);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.minus_sign;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            button3.Location = new Point(262, 160);
            button3.Name = "button3";
            button3.Size = new Size(33, 29);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(TotalCart);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(663, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 125);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // TotalCart
            // 
            TotalCart.AutoSize = true;
            TotalCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TotalCart.ForeColor = SystemColors.Control;
            TotalCart.Location = new Point(221, 36);
            TotalCart.Name = "TotalCart";
            TotalCart.Size = new Size(62, 28);
            TotalCart.TabIndex = 4;
            TotalCart.Text = "Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(165, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 3;
            label1.Text = "EGP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(15, 29);
            label2.Name = "label2";
            label2.Size = new Size(130, 38);
            label2.TabIndex = 2;
            label2.Text = "Subtotal";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(69, 51, 39);
            button2.Location = new Point(60, 83);
            button2.Name = "button2";
            button2.Size = new Size(192, 39);
            button2.TabIndex = 1;
            button2.Text = "Create Order";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(45, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 54);
            label3.TabIndex = 2;
            label3.Text = "Cart";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(990, 495);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label1;
        private Button button4;
        private Button button3;
        private Label TotalCart;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
    }
}
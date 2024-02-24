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
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            TotalCart = new Label();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(35, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 194);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(TotalCart);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(647, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 125);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(69, 51, 39);
            button1.Location = new Point(49, 140);
            button1.Name = "button1";
            button1.Size = new Size(174, 37);
            button1.TabIndex = 0;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
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
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.minus_sign;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            button3.Location = new Point(293, 148);
            button3.Name = "button3";
            button3.Size = new Size(33, 29);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.add;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            button4.Location = new Point(397, 148);
            button4.Name = "button4";
            button4.Size = new Size(33, 29);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 113);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(346, 142);
            label4.Name = "label4";
            label4.Size = new Size(33, 38);
            label4.TabIndex = 4;
            label4.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(270, 51);
            label5.Name = "label5";
            label5.Size = new Size(74, 41);
            label5.TabIndex = 5;
            label5.Text = "EGP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(350, 51);
            label6.Name = "label6";
            label6.Size = new Size(111, 41);
            label6.TabIndex = 6;
            label6.Text = "230.00";
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
            Name = "Cart";
            Text = "Cart";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
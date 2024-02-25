namespace BookStore.WinForms.CustomerForms
{
    partial class HomeCustomer
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
            pictureBox3 = new PictureBox();
            PBCart = new PictureBox();
            PBAccount = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            PBLogout = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ScrollBar;
            pictureBox3.Location = new Point(-1, -2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(975, 40);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // PBCart
            // 
            PBCart.BackColor = SystemColors.ScrollBar;
            PBCart.Image = Properties.Resources.shopping_cart__1_;
            PBCart.Location = new Point(828, 4);
            PBCart.Margin = new Padding(3, 2, 3, 2);
            PBCart.Name = "PBCart";
            PBCart.Size = new Size(47, 32);
            PBCart.SizeMode = PictureBoxSizeMode.StretchImage;
            PBCart.TabIndex = 4;
            PBCart.TabStop = false;
            PBCart.Click += PBCart_Click;
            // 
            // PBAccount
            // 
            PBAccount.BackColor = SystemColors.ScrollBar;
            PBAccount.Image = Properties.Resources.user__2_;
            PBAccount.Location = new Point(758, 4);
            PBAccount.Margin = new Padding(3, 2, 3, 2);
            PBAccount.Name = "PBAccount";
            PBAccount.Size = new Size(47, 32);
            PBAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            PBAccount.TabIndex = 3;
            PBAccount.TabStop = false;
            PBAccount.Click += pictureBox1_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ScrollBar;
            pictureBox4.Image = Properties.Resources.books;
            pictureBox4.Location = new Point(74, 4);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(69, 51, 39);
            label1.Location = new Point(145, 1);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 6;
            label1.Text = "Book Store";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(499, 9);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 23);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ScrollBar;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(69, 51, 39);
            label4.Location = new Point(399, 8);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 20;
            label4.Text = "categories";
            // 
            // PBLogout
            // 
            PBLogout.BackColor = SystemColors.ScrollBar;
            PBLogout.Image = Properties.Resources.logout;
            PBLogout.Location = new Point(903, 4);
            PBLogout.Margin = new Padding(3, 2, 3, 2);
            PBLogout.Name = "PBLogout";
            PBLogout.Size = new Size(36, 31);
            PBLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            PBLogout.TabIndex = 26;
            PBLogout.TabStop = false;
            PBLogout.Click += PBLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(628, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // HomeCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(975, 514);
            Controls.Add(pictureBox1);
            Controls.Add(PBLogout);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(PBCart);
            Controls.Add(PBAccount);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomeCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeCustomer";
            Load += HomeCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox PBCart;
        private PictureBox PBAccount;
        private PictureBox pictureBox4;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private PictureBox PBLogout;
        private PictureBox pictureBox1;
    }
}
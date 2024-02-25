namespace BookStore.WinForms.CustomerForms
{
    partial class Account
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            BTViewOrders = new Button();
            lbNameMgs = new Label();
            lbPhoneMgs = new Label();
            lbAddressMgs = new Label();
            lbUserNameMgs = new Label();
            lbPasswordMgs = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(322, 61);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 0;
            label1.Text = "Account details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(56, 122);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(56, 220);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(56, 308);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(574, 122);
            label6.Name = "label6";
            label6.Size = new Size(117, 28);
            label6.TabIndex = 5;
            label6.Text = "User_Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(574, 220);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(301, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 341);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(297, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(574, 162);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(297, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(574, 255);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(297, 27);
            textBox6.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(69, 51, 39);
            button1.Location = new Point(359, 403);
            button1.Name = "button1";
            button1.Size = new Size(192, 35);
            button1.TabIndex = 13;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BTViewOrders
            // 
            BTViewOrders.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BTViewOrders.ForeColor = Color.FromArgb(69, 51, 39);
            BTViewOrders.Location = new Point(723, 12);
            BTViewOrders.Name = "BTViewOrders";
            BTViewOrders.Size = new Size(188, 35);
            BTViewOrders.TabIndex = 14;
            BTViewOrders.Text = "View Your Orders";
            BTViewOrders.UseVisualStyleBackColor = true;
            BTViewOrders.Click += BTViewOrders_Click;
            // 
            // lbNameMgs
            // 
            lbNameMgs.AutoSize = true;
            lbNameMgs.ForeColor = Color.Red;
            lbNameMgs.Location = new Point(56, 192);
            lbNameMgs.Name = "lbNameMgs";
            lbNameMgs.Size = new Size(0, 20);
            lbNameMgs.TabIndex = 15;
            // 
            // lbPhoneMgs
            // 
            lbPhoneMgs.AutoSize = true;
            lbPhoneMgs.ForeColor = Color.Red;
            lbPhoneMgs.Location = new Point(56, 285);
            lbPhoneMgs.Name = "lbPhoneMgs";
            lbPhoneMgs.Size = new Size(0, 20);
            lbPhoneMgs.TabIndex = 16;
            // 
            // lbAddressMgs
            // 
            lbAddressMgs.AutoSize = true;
            lbAddressMgs.ForeColor = Color.Red;
            lbAddressMgs.Location = new Point(56, 371);
            lbAddressMgs.Name = "lbAddressMgs";
            lbAddressMgs.Size = new Size(0, 20);
            lbAddressMgs.TabIndex = 17;
            // 
            // lbUserNameMgs
            // 
            lbUserNameMgs.AutoSize = true;
            lbUserNameMgs.ForeColor = Color.Red;
            lbUserNameMgs.Location = new Point(574, 192);
            lbUserNameMgs.Name = "lbUserNameMgs";
            lbUserNameMgs.Size = new Size(0, 20);
            lbUserNameMgs.TabIndex = 18;
            // 
            // lbPasswordMgs
            // 
            lbPasswordMgs.AutoSize = true;
            lbPasswordMgs.ForeColor = Color.Red;
            lbPasswordMgs.Location = new Point(574, 285);
            lbPasswordMgs.Name = "lbPasswordMgs";
            lbPasswordMgs.Size = new Size(0, 20);
            lbPasswordMgs.TabIndex = 19;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(lbPasswordMgs);
            Controls.Add(lbUserNameMgs);
            Controls.Add(lbAddressMgs);
            Controls.Add(lbPhoneMgs);
            Controls.Add(lbNameMgs);
            Controls.Add(BTViewOrders);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button BTViewOrders;
        private Label lbNameMgs;
        private Label lbPhoneMgs;
        private Label lbAddressMgs;
        private Label lbUserNameMgs;
        private Label lbPasswordMgs;
    }
}
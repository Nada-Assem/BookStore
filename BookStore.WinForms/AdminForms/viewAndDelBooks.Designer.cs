namespace BookStore.WinForms.AdminForms
{
    partial class viewAndDelBooks
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
            BTDelBook = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BTDelBook
            // 
            BTDelBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BTDelBook.ForeColor = Color.FromArgb(69, 51, 39);
            BTDelBook.Location = new Point(581, 389);
            BTDelBook.Name = "BTDelBook";
            BTDelBook.Size = new Size(136, 43);
            BTDelBook.TabIndex = 11;
            BTDelBook.Text = "Delete";
            BTDelBook.UseVisualStyleBackColor = true;
            BTDelBook.Click += BTDelBook_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 399);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 27);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(161, 395);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 7;
            label2.Text = "Book ID";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(69, 51, 39);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 301);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(369, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 54);
            label1.TabIndex = 13;
            label1.Text = "Books";
            label1.Click += label1_Click;
            // 
            // viewAndDelBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 451);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(BTDelBook);
            Controls.Add(textBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "viewAndDelBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            Load += viewAndDelBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTDelBook;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
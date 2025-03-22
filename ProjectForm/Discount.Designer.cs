namespace ProjectForm
{
    partial class Discount
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTotalprice = new TextBox();
            txtDiscount = new TextBox();
            txtDiscountAmount = new TextBox();
            btnConfirm = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 50);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(255, 128, 128);
            pictureBox1.Image = Properties.Resources.close1;
            pictureBox1.Location = new Point(775, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(86, 22);
            label1.TabIndex = 1;
            label1.Text = "Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 8;
            label2.Text = "Total Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 164);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 9;
            label3.Text = "Discount % :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(174, 21);
            label4.TabIndex = 10;
            label4.Text = "Discount Amount :";
            // 
            // txtTotalprice
            // 
            txtTotalprice.Enabled = false;
            txtTotalprice.Location = new Point(192, 101);
            txtTotalprice.Name = "txtTotalprice";
            txtTotalprice.ReadOnly = true;
            txtTotalprice.Size = new Size(595, 30);
            txtTotalprice.TabIndex = 11;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(192, 164);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(595, 30);
            txtDiscount.TabIndex = 12;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Enabled = false;
            txtDiscountAmount.Location = new Point(192, 221);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new Size(595, 30);
            txtDiscountAmount.TabIndex = 13;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.BackColor = Color.Peru;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Location = new Point(680, 283);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(107, 46);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // Discount
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 341);
            Controls.Add(btnConfirm);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscount);
            Controls.Add(txtTotalprice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Discount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discount";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnConfirm;
        public TextBox txtTotalprice;
        public TextBox txtDiscount;
        public TextBox txtDiscountAmount;
    }
}
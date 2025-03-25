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
            picClose = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtTotalPrice = new TextBox();
            txtDiscount = new TextBox();
            txtDicountAmount = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 50);
            panel1.TabIndex = 7;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.BackColor = Color.FromArgb(255, 128, 128);
            picClose.Image = Properties.Resources.close1;
            picClose.Location = new Point(657, 9);
            picClose.Name = "picClose";
            picClose.Size = new Size(39, 33);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 13;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
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
            label2.Location = new Point(36, 162);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 8;
            label2.Text = "Discount % :";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Location = new Point(216, 109);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(462, 30);
            txtTotalPrice.TabIndex = 9;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(216, 156);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(462, 30);
            txtDiscount.TabIndex = 10;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // txtDicountAmount
            // 
            txtDicountAmount.Enabled = false;
            txtDicountAmount.Location = new Point(216, 203);
            txtDicountAmount.Name = "txtDicountAmount";
            txtDicountAmount.Size = new Size(462, 30);
            txtDicountAmount.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 112);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 12;
            label3.Text = "Total Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 212);
            label4.Name = "label4";
            label4.Size = new Size(174, 21);
            label4.TabIndex = 13;
            label4.Text = "Discount Amount :";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.Peru;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(571, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 46);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // Discount
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(706, 320);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDicountAmount);
            Controls.Add(txtDiscount);
            Controls.Add(txtTotalPrice);
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
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox picClose;
        private Button btnSave;
        public TextBox txtTotalPrice;
        public TextBox txtDiscount;
        public TextBox txtDicountAmount;
    }
}
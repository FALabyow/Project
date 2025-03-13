namespace ProjectForm
{
    partial class Cashier
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pnlSlide = new Panel();
            btnLogout = new Button();
            btnDailySales = new Button();
            btnClearCart = new Button();
            btnPayment = new Button();
            btnDiscount = new Button();
            btnSearchProduct = new Button();
            btnTransaction = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            picClose = new PictureBox();
            panel5 = new Panel();
            lblTimer = new Label();
            lblSalesTotal = new Label();
            label8 = new Label();
            txtBarcode = new TextBox();
            label7 = new Label();
            lblDate = new Label();
            label6 = new Label();
            lblTranNo = new Label();
            label3 = new Label();
            lblDisplaytotal = new Label();
            dgvCashier = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            colAdd = new DataGridViewImageColumn();
            colReduce = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel7 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCashier).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(141, 110, 98);
            panel1.Controls.Add(pnlSlide);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnDailySales);
            panel1.Controls.Add(btnClearCart);
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(btnSearchProduct);
            panel1.Controls.Add(btnTransaction);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 700);
            panel1.TabIndex = 0;
            // 
            // pnlSlide
            // 
            pnlSlide.BackColor = Color.SaddleBrown;
            pnlSlide.Location = new Point(192, 180);
            pnlSlide.Name = "pnlSlide";
            pnlSlide.Size = new Size(8, 50);
            pnlSlide.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(193, 135, 107);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnLogout.ForeColor = Color.Cornsilk;
            btnLogout.Image = Properties.Resources.logout1;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 650);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 50);
            btnLogout.TabIndex = 11;
            btnLogout.Text = " Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDailySales
            // 
            btnDailySales.BackColor = Color.FromArgb(193, 135, 107);
            btnDailySales.Dock = DockStyle.Top;
            btnDailySales.FlatAppearance.BorderSize = 0;
            btnDailySales.FlatStyle = FlatStyle.Flat;
            btnDailySales.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnDailySales.ForeColor = Color.FromArgb(255, 245, 230);
            btnDailySales.Image = Properties.Resources.charts;
            btnDailySales.ImageAlign = ContentAlignment.MiddleLeft;
            btnDailySales.Location = new Point(0, 430);
            btnDailySales.Name = "btnDailySales";
            btnDailySales.Size = new Size(200, 50);
            btnDailySales.TabIndex = 10;
            btnDailySales.Text = "Daily Sales";
            btnDailySales.UseVisualStyleBackColor = false;
            btnDailySales.Click += btnDailySales_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(193, 135, 107);
            btnClearCart.Dock = DockStyle.Top;
            btnClearCart.FlatAppearance.BorderSize = 0;
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnClearCart.ForeColor = Color.FromArgb(255, 245, 230);
            btnClearCart.Image = Properties.Resources.clear;
            btnClearCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearCart.Location = new Point(0, 380);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(200, 50);
            btnClearCart.TabIndex = 9;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(193, 135, 107);
            btnPayment.Dock = DockStyle.Top;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnPayment.ForeColor = Color.FromArgb(255, 245, 230);
            btnPayment.Image = Properties.Resources.payment_method;
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(0, 330);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(200, 50);
            btnPayment.TabIndex = 8;
            btnPayment.Text = "Settle Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleRight;
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = Color.FromArgb(193, 135, 107);
            btnDiscount.Dock = DockStyle.Top;
            btnDiscount.FlatAppearance.BorderSize = 0;
            btnDiscount.FlatStyle = FlatStyle.Flat;
            btnDiscount.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnDiscount.ForeColor = Color.FromArgb(255, 245, 230);
            btnDiscount.Image = Properties.Resources.discount;
            btnDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiscount.Location = new Point(0, 280);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(200, 50);
            btnDiscount.TabIndex = 7;
            btnDiscount.Text = "   Add Discount";
            btnDiscount.TextAlign = ContentAlignment.MiddleRight;
            btnDiscount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDiscount.UseVisualStyleBackColor = false;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.FromArgb(193, 135, 107);
            btnSearchProduct.Dock = DockStyle.Top;
            btnSearchProduct.FlatAppearance.BorderSize = 0;
            btnSearchProduct.FlatStyle = FlatStyle.Flat;
            btnSearchProduct.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnSearchProduct.ForeColor = Color.FromArgb(255, 245, 230);
            btnSearchProduct.Image = Properties.Resources.search_interface_symbol32;
            btnSearchProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchProduct.Location = new Point(0, 230);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(200, 50);
            btnSearchProduct.TabIndex = 6;
            btnSearchProduct.Text = "Search Product";
            btnSearchProduct.TextAlign = ContentAlignment.MiddleRight;
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.FromArgb(193, 135, 107);
            btnTransaction.Dock = DockStyle.Top;
            btnTransaction.FlatAppearance.BorderSize = 0;
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnTransaction.ForeColor = Color.FromArgb(255, 245, 230);
            btnTransaction.Image = Properties.Resources.transaction1;
            btnTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaction.Location = new Point(0, 180);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(200, 50);
            btnTransaction.TabIndex = 5;
            btnTransaction.Text = "New Transaction";
            btnTransaction.TextAlign = ContentAlignment.MiddleRight;
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 180);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 139);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Cashier";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.orangeuser1;
            pictureBox1.Location = new Point(33, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(141, 110, 98);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 700);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(141, 110, 98);
            panel4.Controls.Add(picClose);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(208, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(992, 50);
            panel4.TabIndex = 2;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.BackColor = Color.FromArgb(255, 128, 128);
            picClose.Image = Properties.Resources.close1;
            picClose.Location = new Point(947, 8);
            picClose.Name = "picClose";
            picClose.Size = new Size(39, 33);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 13;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(225, 215, 190);
            panel5.Controls.Add(lblTimer);
            panel5.Controls.Add(lblSalesTotal);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtBarcode);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(lblDate);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(lblTranNo);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblDisplaytotal);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(980, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 650);
            panel5.TabIndex = 3;
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.Moccasin;
            lblTimer.Dock = DockStyle.Bottom;
            lblTimer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(0, 600);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(220, 50);
            lblTimer.TabIndex = 9;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblTimer.Click += lblTimer_Click;
            // 
            // lblSalesTotal
            // 
            lblSalesTotal.Location = new Point(124, 380);
            lblSalesTotal.Name = "lblSalesTotal";
            lblSalesTotal.Size = new Size(84, 21);
            lblSalesTotal.TabIndex = 8;
            lblSalesTotal.Text = "0.00";
            lblSalesTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 380);
            label8.Name = "label8";
            label8.Size = new Size(90, 18);
            label8.TabIndex = 7;
            label8.Text = "Sales Total :";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(8, 279);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.ReadOnly = true;
            txtBarcode.Size = new Size(145, 24);
            txtBarcode.TabIndex = 6;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 247);
            label7.Name = "label7";
            label7.Size = new Size(64, 18);
            label7.TabIndex = 5;
            label7.Text = "Barcode";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(8, 204);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(72, 18);
            lblDate.TabIndex = 4;
            lblDate.Text = "00000000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 167);
            label6.Name = "label6";
            label6.Size = new Size(39, 18);
            label6.TabIndex = 3;
            label6.Text = "Date";
            // 
            // lblTranNo
            // 
            lblTranNo.AutoSize = true;
            lblTranNo.Location = new Point(6, 125);
            lblTranNo.Name = "lblTranNo";
            lblTranNo.Size = new Size(112, 18);
            lblTranNo.TabIndex = 2;
            lblTranNo.Text = "0000000000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(114, 18);
            label3.TabIndex = 1;
            label3.Text = "Transaction No.";
            // 
            // lblDisplaytotal
            // 
            lblDisplaytotal.BackColor = Color.FromArgb(141, 110, 98);
            lblDisplaytotal.Dock = DockStyle.Top;
            lblDisplaytotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplaytotal.Location = new Point(0, 0);
            lblDisplaytotal.Name = "lblDisplaytotal";
            lblDisplaytotal.Size = new Size(220, 31);
            lblDisplaytotal.TabIndex = 0;
            lblDisplaytotal.Text = "0.00";
            lblDisplaytotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvCashier
            // 
            dgvCashier.AllowUserToAddRows = false;
            dgvCashier.BackgroundColor = Color.White;
            dgvCashier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 236, 179);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCashier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCashier.ColumnHeadersHeight = 30;
            dgvCashier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCashier.Columns.AddRange(new DataGridViewColumn[] { Column1, Column8, Column2, Column4, Column6, Column3, Column5, Column7, colAdd, colReduce, Delete });
            dgvCashier.Dock = DockStyle.Fill;
            dgvCashier.EnableHeadersVisualStyles = false;
            dgvCashier.GridColor = Color.White;
            dgvCashier.Location = new Point(208, 50);
            dgvCashier.Name = "dgvCashier";
            dgvCashier.RowHeadersVisible = false;
            dgvCashier.RowHeadersWidth = 51;
            dgvCashier.Size = new Size(772, 650);
            dgvCashier.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 55;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "ID";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 45;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Pcode";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 74;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Description";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column6.DefaultCellStyle = dataGridViewCellStyle2;
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 65;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Qty";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 54;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column5.DefaultCellStyle = dataGridViewCellStyle4;
            Column5.HeaderText = "Discount";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 90;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle5;
            Column7.HeaderText = "Total";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 64;
            // 
            // colAdd
            // 
            colAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colAdd.HeaderText = "";
            colAdd.Image = Properties.Resources.plus;
            colAdd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colAdd.MinimumWidth = 6;
            colAdd.Name = "colAdd";
            colAdd.Width = 6;
            // 
            // colReduce
            // 
            colReduce.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colReduce.HeaderText = "";
            colReduce.Image = Properties.Resources.minus_sign;
            colReduce.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colReduce.MinimumWidth = 6;
            colReduce.Name = "colReduce";
            colReduce.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.bin;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1200, 700);
            panel7.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 215, 190);
            ClientSize = new Size(1200, 700);
            Controls.Add(dgvCashier);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Cashier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCashier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button btnTransaction;
        private Button btnClearCart;
        private Button btnPayment;
        private Button btnDiscount;
        private Button btnSearchProduct;
        private Button btnDailySales;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private PictureBox picClose;
        private Panel pnlSlide;
        private DataGridView dgvCashier;
        private Panel panel7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn colAdd;
        private DataGridViewImageColumn colReduce;
        private DataGridViewImageColumn Delete;
        private Label lblDisplaytotal;
        private Label label3;
        private Label label8;
        private TextBox txtBarcode;
        private Label label7;
        private Label lblDate;
        private Label label6;
        private Label lblTranNo;
        private Label lblSalesTotal;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}
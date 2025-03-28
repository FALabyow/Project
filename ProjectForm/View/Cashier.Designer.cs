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
            panel1 = new Panel();
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
            pnlSlide = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            picClose = new PictureBox();
            panel5 = new Panel();
            barcodetxt = new TextBox();
            lblTimer = new Label();
            lblSalesTotal = new Label();
            label8 = new Label();
            label7 = new Label();
            lblDate = new Label();
            label6 = new Label();
            lblTranNo = new Label();
            label3 = new Label();
            lblDisplaytotal = new Label();
            dgvCashier = new DataGridView();
            panel7 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            BarcodeData = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductQuantity = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            BuyerQuantity = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCashier).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(141, 110, 98);
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
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // pnlSlide
            // 
            pnlSlide.BackColor = Color.SaddleBrown;
            pnlSlide.Location = new Point(0, 180);
            pnlSlide.Name = "pnlSlide";
            pnlSlide.Size = new Size(8, 50);
            pnlSlide.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(141, 110, 98);
            panel3.Controls.Add(pnlSlide);
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
            panel5.Controls.Add(barcodetxt);
            panel5.Controls.Add(lblTimer);
            panel5.Controls.Add(lblSalesTotal);
            panel5.Controls.Add(label8);
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
            // barcodetxt
            // 
            barcodetxt.Location = new Point(18, 280);
            barcodetxt.Name = "barcodetxt";
            barcodetxt.Size = new Size(190, 24);
            barcodetxt.TabIndex = 10;
            barcodetxt.TextChanged += barcodetxt_TextChanged;
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
            lblTranNo.Size = new Size(80, 18);
            lblTranNo.TabIndex = 2;
            lblTranNo.Text = "000000000";
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
            dgvCashier.ColumnHeadersHeight = 40;
            dgvCashier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCashier.Columns.AddRange(new DataGridViewColumn[] { BarcodeData, ProductName, ProductPrice, ProductQuantity, CategoryName, BuyerQuantity });
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
            // BarcodeData
            // 
            BarcodeData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BarcodeData.DataPropertyName = "BarcodeData";
            BarcodeData.HeaderText = "Barcode";
            BarcodeData.Name = "BarcodeData";
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Description";
            ProductName.Name = "ProductName";
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductPrice.DataPropertyName = "ProductPrice";
            ProductPrice.HeaderText = "Price";
            ProductPrice.Name = "ProductPrice";
            // 
            // ProductQuantity
            // 
            ProductQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductQuantity.DataPropertyName = "ProductQuantity";
            ProductQuantity.HeaderText = "Stock";
            ProductQuantity.Name = "ProductQuantity";
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Category";
            CategoryName.Name = "CategoryName";
            // 
            // BuyerQuantity
            // 
            BuyerQuantity.DataPropertyName = "BuyerQuantity";
            BuyerQuantity.HeaderText = "Quantity";
            BuyerQuantity.Name = "BuyerQuantity";
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
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
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
        private Label label3;
        private Label label8;
        private Label label7;
        private Label lblDate;
        private Label label6;
        private Label lblTranNo;
        private Label lblSalesTotal;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        public Label lblDisplaytotal;
        private TextBox barcodetxt;
        private DataGridViewTextBoxColumn BarcodeData;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn BuyerQuantity;
    }
}
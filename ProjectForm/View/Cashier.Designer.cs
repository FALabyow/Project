﻿namespace ProjectForm
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
            adminBtn = new Button();
            btnLogout = new Button();
            btnDailySales = new Button();
            btnPayment = new Button();
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
            checkOutBtn = new Button();
            lblChange = new Label();
            label5 = new Label();
            lblCash = new Label();
            label2 = new Label();
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
            BarcodeData = new DataGridViewTextBoxColumn();
            StockId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            BuyerQuantity = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ProductQuantity = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewImageColumn();
            panel7 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
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
            panel1.Controls.Add(adminBtn);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnDailySales);
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(btnSearchProduct);
            panel1.Controls.Add(btnTransaction);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 700);
            panel1.TabIndex = 0;
            // 
            // adminBtn
            // 
            adminBtn.BackColor = Color.FromArgb(193, 135, 107);
            adminBtn.Dock = DockStyle.Top;
            adminBtn.FlatAppearance.BorderSize = 0;
            adminBtn.FlatStyle = FlatStyle.Flat;
            adminBtn.Font = new Font("Microsoft Sans Serif", 10.8F);
            adminBtn.ForeColor = Color.FromArgb(255, 245, 230);
            adminBtn.Image = Properties.Resources.server_person_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            adminBtn.ImageAlign = ContentAlignment.MiddleLeft;
            adminBtn.Location = new Point(0, 380);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(200, 50);
            adminBtn.TabIndex = 12;
            adminBtn.Text = "Admin";
            adminBtn.UseVisualStyleBackColor = false;
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
            btnDailySales.Location = new Point(0, 330);
            btnDailySales.Name = "btnDailySales";
            btnDailySales.Size = new Size(200, 50);
            btnDailySales.TabIndex = 10;
            btnDailySales.Text = "Daily Sales";
            btnDailySales.UseVisualStyleBackColor = false;
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
            btnPayment.Location = new Point(0, 280);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(200, 50);
            btnPayment.TabIndex = 8;
            btnPayment.Text = "Settle Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleRight;
            btnPayment.UseVisualStyleBackColor = false;
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
            label1.Size = new Size(80, 25);
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
            panel4.Size = new Size(983, 50);
            panel4.TabIndex = 2;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.BackColor = Color.FromArgb(255, 128, 128);
            picClose.Image = Properties.Resources.close1;
            picClose.Location = new Point(938, 8);
            picClose.Name = "picClose";
            picClose.Size = new Size(39, 33);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 13;
            picClose.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(225, 215, 190);
            panel5.Controls.Add(checkOutBtn);
            panel5.Controls.Add(lblChange);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lblCash);
            panel5.Controls.Add(label2);
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
            panel5.Location = new Point(971, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 650);
            panel5.TabIndex = 3;
            // 
            // checkOutBtn
            // 
            checkOutBtn.BackColor = Color.Red;
            checkOutBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOutBtn.ForeColor = SystemColors.ButtonHighlight;
            checkOutBtn.Location = new Point(0, 551);
            checkOutBtn.Name = "checkOutBtn";
            checkOutBtn.Size = new Size(220, 46);
            checkOutBtn.TabIndex = 15;
            checkOutBtn.Text = "Checkout";
            checkOutBtn.UseVisualStyleBackColor = false;
            // 
            // lblChange
            // 
            lblChange.Location = new Point(124, 455);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(84, 21);
            lblChange.TabIndex = 14;
            lblChange.Text = "0.00";
            lblChange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 454);
            label5.Name = "label5";
            label5.Size = new Size(78, 22);
            label5.TabIndex = 13;
            label5.Text = "Change ";
            // 
            // lblCash
            // 
            lblCash.Location = new Point(124, 420);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(84, 21);
            lblCash.TabIndex = 12;
            lblCash.Text = "0.00";
            lblCash.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 419);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 11;
            label2.Text = "Cash";
            // 
            // barcodetxt
            // 
            barcodetxt.Location = new Point(8, 280);
            barcodetxt.Name = "barcodetxt";
            barcodetxt.Size = new Size(190, 28);
            barcodetxt.TabIndex = 10;
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
            label8.Size = new Size(56, 22);
            label8.TabIndex = 7;
            label8.Text = "Total ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 247);
            label7.Name = "label7";
            label7.Size = new Size(77, 22);
            label7.TabIndex = 5;
            label7.Text = "Barcode";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(8, 204);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(90, 22);
            lblDate.TabIndex = 4;
            lblDate.Text = "00000000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 167);
            label6.Name = "label6";
            label6.Size = new Size(48, 22);
            label6.TabIndex = 3;
            label6.Text = "Date";
            // 
            // lblTranNo
            // 
            lblTranNo.AutoSize = true;
            lblTranNo.Location = new Point(6, 125);
            lblTranNo.Name = "lblTranNo";
            lblTranNo.Size = new Size(100, 22);
            lblTranNo.TabIndex = 2;
            lblTranNo.Text = "000000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(138, 22);
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
            dgvCashier.Columns.AddRange(new DataGridViewColumn[] { BarcodeData, StockId, ProductName, ProductPrice, BuyerQuantity, Column1, ProductQuantity, ProductCode, Remove });
            dgvCashier.Dock = DockStyle.Fill;
            dgvCashier.EnableHeadersVisualStyles = false;
            dgvCashier.GridColor = Color.White;
            dgvCashier.Location = new Point(208, 50);
            dgvCashier.Name = "dgvCashier";
            dgvCashier.RowHeadersVisible = false;
            dgvCashier.RowHeadersWidth = 51;
            dgvCashier.Size = new Size(763, 650);
            dgvCashier.TabIndex = 5;
            // 
            // BarcodeData
            // 
            BarcodeData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BarcodeData.DataPropertyName = "BarcodeData";
            BarcodeData.HeaderText = "Barcode";
            BarcodeData.MinimumWidth = 6;
            BarcodeData.Name = "BarcodeData";
            // 
            // StockId
            // 
            StockId.DataPropertyName = "StockId";
            StockId.HeaderText = "StockId";
            StockId.MinimumWidth = 6;
            StockId.Name = "StockId";
            StockId.Visible = false;
            StockId.Width = 125;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Description";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductPrice.DataPropertyName = "ProductPrice";
            ProductPrice.HeaderText = "Price";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            // 
            // BuyerQuantity
            // 
            BuyerQuantity.DataPropertyName = "BuyerQuantity";
            BuyerQuantity.HeaderText = "Qty";
            BuyerQuantity.MinimumWidth = 6;
            BuyerQuantity.Name = "BuyerQuantity";
            BuyerQuantity.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SubTotal";
            Column1.HeaderText = "Sub Total";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // ProductQuantity
            // 
            ProductQuantity.DataPropertyName = "ProductQuantity";
            ProductQuantity.HeaderText = "Stocks";
            ProductQuantity.MinimumWidth = 6;
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Visible = false;
            ProductQuantity.Width = 125;
            // 
            // ProductCode
            // 
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "ProductCode";
            ProductCode.MinimumWidth = 6;
            ProductCode.Name = "ProductCode";
            ProductCode.Width = 125;
            // 
            // Remove
            // 
            Remove.HeaderText = "";
            Remove.Image = Properties.Resources.remove_28dp_EA3323_FILL0_wght400_GRAD0_opsz24;
            Remove.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Remove.MinimumWidth = 6;
            Remove.Name = "Remove";
            Remove.Width = 50;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1191, 700);
            panel7.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 215, 190);
            ClientSize = new Size(1191, 700);
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
            Load += Cashier_Load;
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
        private Button btnPayment;
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
        private Label lblCash;
        private Label label2;
        private Button checkOutBtn;
        private Label lblChange;
        private Label label5;
        private Button adminBtn;
        private DataGridViewTextBoxColumn BarcodeData;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn BuyerQuantity;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewImageColumn Remove;
    }
}
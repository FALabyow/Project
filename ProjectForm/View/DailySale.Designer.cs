namespace ProjectForm
{
    partial class DailySale
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            picboxClose = new PictureBox();
            lblTitle = new Label();
            dgvCashier = new DataGridView();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            panel2 = new Panel();
            loadSalesBtn = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            SalesHistoryId = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductQuantity = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCashier).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(picboxClose);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 50);
            panel1.TabIndex = 7;
            // 
            // picboxClose
            // 
            picboxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picboxClose.BackColor = Color.FromArgb(255, 128, 128);
            picboxClose.Image = Properties.Resources.close1;
            picboxClose.Location = new Point(1035, 9);
            picboxClose.Name = "picboxClose";
            picboxClose.Size = new Size(39, 33);
            picboxClose.SizeMode = PictureBoxSizeMode.Zoom;
            picboxClose.TabIndex = 13;
            picboxClose.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(99, 22);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Sold Items";
            lblTitle.Visible = false;
            // 
            // dgvCashier
            // 
            dgvCashier.AllowUserToAddRows = false;
            dgvCashier.BackgroundColor = Color.White;
            dgvCashier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 236, 179);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCashier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCashier.ColumnHeadersHeight = 40;
            dgvCashier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCashier.Columns.AddRange(new DataGridViewColumn[] { Column1, SalesHistoryId, ProductCode, ProductName, ProductPrice, ProductQuantity, TotalAmount });
            dgvCashier.Dock = DockStyle.Fill;
            dgvCashier.EnableHeadersVisualStyles = false;
            dgvCashier.GridColor = Color.White;
            dgvCashier.Location = new Point(0, 50);
            dgvCashier.Name = "dgvCashier";
            dgvCashier.RowHeadersVisible = false;
            dgvCashier.RowHeadersWidth = 51;
            dgvCashier.Size = new Size(1084, 763);
            dgvCashier.TabIndex = 8;
            // 
            // dtFrom
            // 
            dtFrom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(202, 852);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(150, 30);
            dtFrom.TabIndex = 9;
            // 
            // dtTo
            // 
            dtTo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(394, 853);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(150, 30);
            dtTo.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(141, 110, 98);
            label2.ForeColor = Color.FromArgb(255, 245, 230);
            label2.Location = new Point(12, 857);
            label2.Name = "label2";
            label2.Size = new Size(184, 21);
            label2.TabIndex = 11;
            label2.Text = "FIlter By Date : From";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(141, 110, 98);
            label3.ForeColor = Color.FromArgb(255, 245, 230);
            label3.Location = new Point(358, 857);
            label3.Name = "label3";
            label3.Size = new Size(30, 21);
            label3.TabIndex = 12;
            label3.Text = "To";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.BackColor = Color.FromArgb(141, 110, 98);
            lblTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(255, 245, 230);
            lblTotal.Location = new Point(936, 859);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(136, 21);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 110, 98);
            panel2.Controls.Add(loadSalesBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 813);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 105);
            panel2.TabIndex = 14;
            // 
            // loadSalesBtn
            // 
            loadSalesBtn.Location = new Point(578, 39);
            loadSalesBtn.Name = "loadSalesBtn";
            loadSalesBtn.Size = new Size(153, 34);
            loadSalesBtn.TabIndex = 3;
            loadSalesBtn.Text = "Load Sales";
            loadSalesBtn.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 67;
            // 
            // SalesHistoryId
            // 
            SalesHistoryId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SalesHistoryId.DataPropertyName = "SalesHistoryId";
            SalesHistoryId.HeaderText = "Invoice#";
            SalesHistoryId.MinimumWidth = 6;
            SalesHistoryId.Name = "SalesHistoryId";
            SalesHistoryId.Width = 116;
            // 
            // ProductCode
            // 
            ProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "Pcode";
            ProductCode.MinimumWidth = 6;
            ProductCode.Name = "ProductCode";
            ProductCode.Width = 96;
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
            ProductPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductPrice.DataPropertyName = "ProductPrice";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            ProductPrice.DefaultCellStyle = dataGridViewCellStyle2;
            ProductPrice.HeaderText = "Price";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Width = 80;
            // 
            // ProductQuantity
            // 
            ProductQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductQuantity.DataPropertyName = "ProductQuantity";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            ProductQuantity.HeaderText = "Qty";
            ProductQuantity.MinimumWidth = 6;
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Width = 71;
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            TotalAmount.DefaultCellStyle = dataGridViewCellStyle4;
            TotalAmount.HeaderText = "Total";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Width = 79;
            // 
            // DailySale
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 918);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtTo);
            Controls.Add(dtFrom);
            Controls.Add(dgvCashier);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DailySale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale History";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCashier).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvCashier;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private PictureBox picboxClose;
        public Label lblTitle;
        private Panel panel2;
        private Button loadSalesBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn SalesHistoryId;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewTextBoxColumn TotalAmount;
    }
}
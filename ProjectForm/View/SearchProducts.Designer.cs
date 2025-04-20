namespace ProjectForm
{
    partial class SearchProducts
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvProduct = new DataGridView();
            panel1 = new Panel();
            refreshBtn = new Button();
            btnClose = new Button();
            txtSearch = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            StockId = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            BarcodeData = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductQuantity = new DataGridViewTextBoxColumn();
            Select = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 236, 179);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeight = 40;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, StockId, ProductCode, BarcodeData, ProductName, Column3, ProductPrice, ProductQuantity, Select });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.GridColor = Color.White;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(986, 566);
            dgvProduct.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(refreshBtn);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 566);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 78);
            panel1.TabIndex = 7;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.Lime;
            refreshBtn.Location = new Point(12, 20);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(94, 46);
            refreshBtn.TabIndex = 12;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.SandyBrown;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(867, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 46);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(283, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(415, 30);
            txtSearch.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 67;
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
            // ProductCode
            // 
            ProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "Pcode";
            ProductCode.MinimumWidth = 6;
            ProductCode.Name = "ProductCode";
            ProductCode.Width = 96;
            // 
            // BarcodeData
            // 
            BarcodeData.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BarcodeData.DataPropertyName = "BarcodeData";
            BarcodeData.HeaderText = "Barcode";
            BarcodeData.MinimumWidth = 6;
            BarcodeData.Name = "BarcodeData";
            BarcodeData.Width = 112;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Description";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.DataPropertyName = "ProductCategory";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column3.DefaultCellStyle = dataGridViewCellStyle2;
            Column3.HeaderText = "Category";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 123;
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductPrice.DataPropertyName = "ProductPrice";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            ProductPrice.DefaultCellStyle = dataGridViewCellStyle3;
            ProductPrice.HeaderText = "Price";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Width = 80;
            // 
            // ProductQuantity
            // 
            ProductQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductQuantity.DataPropertyName = "ProductQuantity";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            ProductQuantity.HeaderText = "Qty";
            ProductQuantity.MinimumWidth = 6;
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Width = 71;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Select.HeaderText = "";
            Select.Image = Properties.Resources.shopping_cart_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.Width = 6;
            // 
            // SearchProducts
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 644);
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SearchProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Products";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProduct;
        private Panel panel1;
        private TextBox txtSearch;
        private Button btnClose;
        private Button refreshBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn BarcodeData;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewImageColumn Select;
    }
}
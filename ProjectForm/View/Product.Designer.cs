namespace ProjectForm
{
    partial class Product
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
            panel1 = new Panel();
            txtSearch = new TextBox();
            btnAdd = new Button();
            lblManageProduct = new Label();
            dgvProduct = new DataGridView();
            rowNumber = new DataGridViewTextBoxColumn();
            productId = new DataGridViewTextBoxColumn();
            productCode = new DataGridViewTextBoxColumn();
            productBarcode = new DataGridViewTextBoxColumn();
            productDescription = new DataGridViewTextBoxColumn();
            productCategory = new DataGridViewTextBoxColumn();
            productCategoryId = new DataGridViewTextBoxColumn();
            productPrice = new DataGridViewTextBoxColumn();
            productQty = new DataGridViewTextBoxColumn();
            productReorder = new DataGridViewTextBoxColumn();
            scannedAt = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblManageProduct);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 475);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 78);
            panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(283, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(415, 27);
            txtSearch.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(891, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 56);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblManageProduct
            // 
            lblManageProduct.AutoSize = true;
            lblManageProduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblManageProduct.Location = new Point(12, 23);
            lblManageProduct.Name = "lblManageProduct";
            lblManageProduct.Size = new Size(172, 23);
            lblManageProduct.TabIndex = 3;
            lblManageProduct.Text = "Manage Product";
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
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { rowNumber, productId, productCode, productBarcode, productDescription, productCategory, productCategoryId, productPrice, productQty, productReorder, scannedAt, Edit, Delete });
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
            dgvProduct.Size = new Size(982, 475);
            dgvProduct.TabIndex = 6;
            dgvProduct.RowPostPaint += dgvProduct_RowPostPaint;
            // 
            // rowNumber
            // 
            rowNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rowNumber.HeaderText = "No.";
            rowNumber.MinimumWidth = 6;
            rowNumber.Name = "rowNumber";
            rowNumber.Width = 67;
            // 
            // productId
            // 
            productId.DataPropertyName = "ProductId";
            productId.HeaderText = "ProductId";
            productId.MinimumWidth = 6;
            productId.Name = "productId";
            productId.Visible = false;
            productId.Width = 125;
            // 
            // productCode
            // 
            productCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productCode.DataPropertyName = "ProductCode";
            productCode.HeaderText = "Pcode";
            productCode.MinimumWidth = 6;
            productCode.Name = "productCode";
            productCode.Width = 96;
            // 
            // productBarcode
            // 
            productBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productBarcode.DataPropertyName = "BarcodeData";
            productBarcode.HeaderText = "Barcode";
            productBarcode.MinimumWidth = 6;
            productBarcode.Name = "productBarcode";
            productBarcode.Width = 112;
            // 
            // productDescription
            // 
            productDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productDescription.DataPropertyName = "ProductName";
            productDescription.HeaderText = "Description";
            productDescription.MinimumWidth = 6;
            productDescription.Name = "productDescription";
            // 
            // productCategory
            // 
            productCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productCategory.DataPropertyName = "CategoryName";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productCategory.DefaultCellStyle = dataGridViewCellStyle2;
            productCategory.HeaderText = "Category";
            productCategory.MinimumWidth = 6;
            productCategory.Name = "productCategory";
            productCategory.Width = 123;
            // 
            // productCategoryId
            // 
            productCategoryId.DataPropertyName = "CategoryId";
            productCategoryId.HeaderText = "Category Id";
            productCategoryId.MinimumWidth = 6;
            productCategoryId.Name = "productCategoryId";
            productCategoryId.Visible = false;
            productCategoryId.Width = 125;
            // 
            // productPrice
            // 
            productPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productPrice.DataPropertyName = "ProductPrice";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            productPrice.DefaultCellStyle = dataGridViewCellStyle3;
            productPrice.HeaderText = "Price";
            productPrice.MinimumWidth = 6;
            productPrice.Name = "productPrice";
            productPrice.Width = 80;
            // 
            // productQty
            // 
            productQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productQty.DataPropertyName = "ProductQuantity";
            productQty.HeaderText = "Qty";
            productQty.MinimumWidth = 6;
            productQty.Name = "productQty";
            productQty.Width = 71;
            // 
            // productReorder
            // 
            productReorder.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productReorder.DataPropertyName = "ProductPreOrder";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            productReorder.DefaultCellStyle = dataGridViewCellStyle4;
            productReorder.HeaderText = "Reorder";
            productReorder.MinimumWidth = 6;
            productReorder.Name = "productReorder";
            productReorder.Width = 106;
            // 
            // scannedAt
            // 
            scannedAt.DataPropertyName = "ScannedAt";
            scannedAt.HeaderText = "Scanned At:";
            scannedAt.MinimumWidth = 6;
            scannedAt.Name = "scannedAt";
            scannedAt.Visible = false;
            scannedAt.Width = 125;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lblManageProduct;
        private Button btnAdd;
        private TextBox txtSearch;
        private DataGridView dgvProduct;
        private DataGridViewTextBoxColumn rowNumber;
        private DataGridViewTextBoxColumn productId;
        private DataGridViewTextBoxColumn productCode;
        private DataGridViewTextBoxColumn productBarcode;
        private DataGridViewTextBoxColumn productDescription;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productCategoryId;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewTextBoxColumn productQty;
        private DataGridViewTextBoxColumn productReorder;
        private DataGridViewTextBoxColumn scannedAt;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
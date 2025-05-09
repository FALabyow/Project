﻿namespace ProjectForm
{
    partial class StockEntry
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
            panel1 = new Panel();
            lblManageProduct = new Label();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            btnEntry = new Button();
            dgvStockIn = new DataGridView();
            RowNumber1 = new DataGridViewTextBoxColumn();
            StockId = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            ReferenceNum1 = new DataGridViewTextBoxColumn();
            ProductCode1 = new DataGridViewTextBoxColumn();
            ProductName1 = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            ProductQuantity1 = new DataGridViewTextBoxColumn();
            StockInDate1 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            panel2 = new Panel();
            LinProduct = new LinkLabel();
            LinGenerate = new LinkLabel();
            dateTimePicker1 = new DateTimePicker();
            txtRefNo = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tabPage4 = new TabPage();
            dataStockIn = new DataGridView();
            RowNumber2 = new DataGridViewTextBoxColumn();
            ReferenceNum2 = new DataGridViewTextBoxColumn();
            ProductCode2 = new DataGridViewTextBoxColumn();
            ProductName2 = new DataGridViewTextBoxColumn();
            ProductCategory2 = new DataGridViewTextBoxColumn();
            StockInQty = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnLoad = new Button();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockIn).BeginInit();
            panel2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataStockIn).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(lblManageProduct);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 766);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 89);
            panel1.TabIndex = 3;
            // 
            // lblManageProduct
            // 
            lblManageProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblManageProduct.AutoSize = true;
            lblManageProduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblManageProduct.Location = new Point(14, 38);
            lblManageProduct.Name = "lblManageProduct";
            lblManageProduct.Size = new Size(168, 23);
            lblManageProduct.TabIndex = 3;
            lblManageProduct.Text = "Stock In Module";
            lblManageProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(982, 766);
            tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Gainsboro;
            tabPage3.Controls.Add(btnEntry);
            tabPage3.Controls.Add(dgvStockIn);
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(974, 732);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Stock In";
            // 
            // btnEntry
            // 
            btnEntry.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEntry.BackColor = Color.Peru;
            btnEntry.FlatAppearance.BorderSize = 0;
            btnEntry.FlatStyle = FlatStyle.Flat;
            btnEntry.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntry.Location = new Point(859, 680);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(107, 46);
            btnEntry.TabIndex = 9;
            btnEntry.Text = "Entry";
            btnEntry.UseVisualStyleBackColor = false;
            btnEntry.Click += btnEntry_Click;
            // 
            // dgvStockIn
            // 
            dgvStockIn.AllowUserToAddRows = false;
            dgvStockIn.BackgroundColor = Color.White;
            dgvStockIn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 236, 179);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStockIn.ColumnHeadersHeight = 40;
            dgvStockIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStockIn.Columns.AddRange(new DataGridViewColumn[] { RowNumber1, StockId, ProductId, ReferenceNum1, ProductCode1, ProductName1, CategoryName, ProductQuantity1, StockInDate1, Delete });
            dgvStockIn.Dock = DockStyle.Top;
            dgvStockIn.EnableHeadersVisualStyles = false;
            dgvStockIn.GridColor = Color.White;
            dgvStockIn.Location = new Point(3, 167);
            dgvStockIn.Name = "dgvStockIn";
            dgvStockIn.RowHeadersVisible = false;
            dgvStockIn.RowHeadersWidth = 51;
            dgvStockIn.Size = new Size(968, 437);
            dgvStockIn.TabIndex = 4;
            // 
            // RowNumber1
            // 
            RowNumber1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RowNumber1.DataPropertyName = "RowNumber";
            RowNumber1.HeaderText = "No.";
            RowNumber1.MinimumWidth = 6;
            RowNumber1.Name = "RowNumber1";
            RowNumber1.Width = 67;
            // 
            // StockId
            // 
            StockId.DataPropertyName = "StockId";
            StockId.HeaderText = "StockId";
            StockId.MinimumWidth = 6;
            StockId.Name = "StockId";
            StockId.Width = 125;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId1";
            ProductId.HeaderText = "Id";
            ProductId.MinimumWidth = 6;
            ProductId.Name = "ProductId";
            ProductId.Visible = false;
            ProductId.Width = 125;
            // 
            // ReferenceNum1
            // 
            ReferenceNum1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReferenceNum1.DataPropertyName = "ReferenceNum";
            ReferenceNum1.HeaderText = "ReferenceNo.";
            ReferenceNum1.MinimumWidth = 6;
            ReferenceNum1.Name = "ReferenceNum1";
            ReferenceNum1.Width = 160;
            // 
            // ProductCode1
            // 
            ProductCode1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductCode1.DataPropertyName = "ProductCode";
            ProductCode1.HeaderText = "Pcode";
            ProductCode1.MinimumWidth = 6;
            ProductCode1.Name = "ProductCode1";
            ProductCode1.Width = 96;
            // 
            // ProductName1
            // 
            ProductName1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName1.DataPropertyName = "ProductName";
            ProductName1.HeaderText = "Description";
            ProductName1.MinimumWidth = 6;
            ProductName1.Name = "ProductName1";
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Category";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            CategoryName.Width = 125;
            // 
            // ProductQuantity1
            // 
            ProductQuantity1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductQuantity1.DataPropertyName = "ProductQuantity";
            ProductQuantity1.HeaderText = "Qty";
            ProductQuantity1.MinimumWidth = 6;
            ProductQuantity1.Name = "ProductQuantity1";
            ProductQuantity1.Width = 71;
            // 
            // StockInDate1
            // 
            StockInDate1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StockInDate1.DataPropertyName = "StockInDate";
            StockInDate1.HeaderText = "Stock In Date";
            StockInDate1.MinimumWidth = 6;
            StockInDate1.Name = "StockInDate1";
            StockInDate1.Width = 156;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.bin;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(LinProduct);
            panel2.Controls.Add(LinGenerate);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtRefNo);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 164);
            panel2.TabIndex = 0;
            // 
            // LinProduct
            // 
            LinProduct.AutoSize = true;
            LinProduct.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinProduct.LinkColor = Color.DimGray;
            LinProduct.Location = new Point(173, 122);
            LinProduct.Name = "LinProduct";
            LinProduct.Size = new Size(196, 23);
            LinProduct.TabIndex = 7;
            LinProduct.TabStop = true;
            LinProduct.Text = "[ Browse Products ]";
            // 
            // LinGenerate
            // 
            LinGenerate.AutoSize = true;
            LinGenerate.LinkColor = Color.DimGray;
            LinGenerate.Location = new Point(383, 31);
            LinGenerate.Name = "LinGenerate";
            LinGenerate.Size = new Size(120, 21);
            LinGenerate.TabIndex = 6;
            LinGenerate.TabStop = true;
            LinGenerate.Text = "[ Generate ]";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 76);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(330, 30);
            dateTimePicker1.TabIndex = 5;
            // 
            // txtRefNo
            // 
            txtRefNo.Location = new Point(173, 25);
            txtRefNo.Name = "txtRefNo";
            txtRefNo.Size = new Size(193, 30);
            txtRefNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 83);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 2;
            label3.Text = "Stock In Date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 28);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 0;
            label1.Text = "Reference No :";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataStockIn);
            tabPage4.Controls.Add(panel3);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(974, 733);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Stock In Record";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataStockIn
            // 
            dataStockIn.AllowUserToAddRows = false;
            dataStockIn.BackgroundColor = Color.White;
            dataStockIn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 236, 179);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataStockIn.ColumnHeadersHeight = 40;
            dataStockIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataStockIn.Columns.AddRange(new DataGridViewColumn[] { RowNumber2, ReferenceNum2, ProductCode2, ProductName2, ProductCategory2, StockInQty, dataGridViewTextBoxColumn7 });
            dataStockIn.Dock = DockStyle.Top;
            dataStockIn.EnableHeadersVisualStyles = false;
            dataStockIn.GridColor = Color.White;
            dataStockIn.Location = new Point(3, 139);
            dataStockIn.Name = "dataStockIn";
            dataStockIn.RowHeadersVisible = false;
            dataStockIn.RowHeadersWidth = 51;
            dataStockIn.Size = new Size(968, 437);
            dataStockIn.TabIndex = 5;
            dataStockIn.RowPostPaint += dataStockIn_RowPostPaint;
            // 
            // RowNumber2
            // 
            RowNumber2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RowNumber2.DataPropertyName = "RowNumber";
            RowNumber2.HeaderText = "No.";
            RowNumber2.MinimumWidth = 6;
            RowNumber2.Name = "RowNumber2";
            RowNumber2.Width = 67;
            // 
            // ReferenceNum2
            // 
            ReferenceNum2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReferenceNum2.DataPropertyName = "ReferenceNum";
            ReferenceNum2.HeaderText = "ReferenceNo.";
            ReferenceNum2.MinimumWidth = 6;
            ReferenceNum2.Name = "ReferenceNum2";
            ReferenceNum2.Width = 160;
            // 
            // ProductCode2
            // 
            ProductCode2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductCode2.DataPropertyName = "ProductCode";
            ProductCode2.HeaderText = "Pcode";
            ProductCode2.MinimumWidth = 6;
            ProductCode2.Name = "ProductCode2";
            ProductCode2.Width = 96;
            // 
            // ProductName2
            // 
            ProductName2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName2.DataPropertyName = "ProductName";
            ProductName2.HeaderText = "Description";
            ProductName2.MinimumWidth = 6;
            ProductName2.Name = "ProductName2";
            // 
            // ProductCategory2
            // 
            ProductCategory2.DataPropertyName = "ProductCategory";
            ProductCategory2.HeaderText = "Category";
            ProductCategory2.MinimumWidth = 6;
            ProductCategory2.Name = "ProductCategory2";
            ProductCategory2.Width = 125;
            // 
            // StockInQty
            // 
            StockInQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StockInQty.DataPropertyName = "StockInQty";
            StockInQty.HeaderText = "Qty";
            StockInQty.MinimumWidth = 6;
            StockInQty.Name = "StockInQty";
            StockInQty.Width = 71;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn7.DataPropertyName = "StockInDate";
            dataGridViewTextBoxColumn7.HeaderText = "Stock In Date";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 156;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(btnLoad);
            panel3.Controls.Add(dateTimePicker3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 136);
            panel3.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoad.BackColor = Color.Peru;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(759, 48);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(167, 30);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load Record";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(482, 48);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 30);
            dateTimePicker3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 53);
            label4.Name = "label4";
            label4.Size = new Size(30, 21);
            label4.TabIndex = 2;
            label4.Text = "To";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(190, 48);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 30);
            dateTimePicker2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 53);
            label2.Name = "label2";
            label2.Size = new Size(177, 21);
            label2.TabIndex = 0;
            label2.Text = "Filter By Date: From";
            // 
            // StockEntry
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 855);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "StockEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Entry";
            Load += StockEntry_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockIn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataStockIn).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblManageProduct;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private Panel panel2;
        private TabPage tabPage4;
        private DataGridView dgvStockIn;
        private Label label1;
        private Label label3;
        private LinkLabel LinGenerate;
        private Button btnEntry;
        private LinkLabel LinProduct;
        public DateTimePicker dateTimePicker1;
        public TextBox txtRefNo;
        private DataGridView dataStockIn;
        private Panel panel3;
        private DateTimePicker dateTimePicker3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Button btnLoad;
        private DataGridViewTextBoxColumn RowNumber2;
        private DataGridViewTextBoxColumn ReferenceNum2;
        private DataGridViewTextBoxColumn ProductCode2;
        private DataGridViewTextBoxColumn ProductName2;
        private DataGridViewTextBoxColumn ProductCategory2;
        private DataGridViewTextBoxColumn StockInQty;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn RowNumber1;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ReferenceNum1;
        private DataGridViewTextBoxColumn ProductCode1;
        private DataGridViewTextBoxColumn ProductName1;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn ProductQuantity1;
        private DataGridViewTextBoxColumn StockInDate1;
        private DataGridViewImageColumn Delete;
    }
}
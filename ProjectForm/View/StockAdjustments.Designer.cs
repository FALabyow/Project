namespace ProjectForm
{
    partial class StockAdjustments
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
            panel1 = new Panel();
            btnAdd = new Button();
            txtSearch = new TextBox();
            lblManageProduct = new Label();
            panel2 = new Panel();
            txtQty = new TextBox();
            cmbAction = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            lblPcode = new Label();
            label3 = new Label();
            lblDescription = new Label();
            lblRefNo = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvAdjustment = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Select = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdjustment).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lblManageProduct);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 521);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 86);
            panel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Enabled = false;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(255, 230, 204);
            btnAdd.Location = new Point(977, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 56);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(323, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(464, 30);
            txtSearch.TabIndex = 6;
            // 
            // lblManageProduct
            // 
            lblManageProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblManageProduct.AutoSize = true;
            lblManageProduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblManageProduct.Location = new Point(25, 34);
            lblManageProduct.Name = "lblManageProduct";
            lblManageProduct.Size = new Size(180, 23);
            lblManageProduct.TabIndex = 3;
            lblManageProduct.Text = "Stock Adjustment";
            lblManageProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtQty);
            panel2.Controls.Add(cmbAction);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblPcode);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblDescription);
            panel2.Controls.Add(lblRefNo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 152);
            panel2.TabIndex = 5;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(799, 90);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(234, 30);
            txtQty.TabIndex = 10;
            // 
            // cmbAction
            // 
            cmbAction.FormattingEnabled = true;
            cmbAction.Items.AddRange(new object[] { "Add to Inventory", "Remove From Inventory" });
            cmbAction.Location = new Point(799, 32);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(234, 29);
            cmbAction.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(700, 93);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 8;
            label5.Text = "Qty :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(700, 36);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 7;
            label4.Text = "Action :";
            // 
            // lblPcode
            // 
            lblPcode.AutoSize = true;
            lblPcode.Location = new Point(445, 36);
            lblPcode.Name = "lblPcode";
            lblPcode.Size = new Size(131, 21);
            lblPcode.TabIndex = 6;
            lblPcode.Text = "ProductCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 36);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 5;
            label3.Text = "Pcode :";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(169, 99);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(182, 21);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Product Description";
            // 
            // lblRefNo
            // 
            lblRefNo.AutoSize = true;
            lblRefNo.Location = new Point(174, 35);
            lblRefNo.Name = "lblRefNo";
            lblRefNo.Size = new Size(64, 21);
            lblRefNo.TabIndex = 3;
            lblRefNo.Text = "RefNo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 99);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 2;
            label2.Text = "Description :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 1;
            label1.Text = "Reference No :";
            // 
            // dgvAdjustment
            // 
            dgvAdjustment.AllowUserToAddRows = false;
            dgvAdjustment.BackgroundColor = Color.White;
            dgvAdjustment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 236, 179);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAdjustment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdjustment.ColumnHeadersHeight = 40;
            dgvAdjustment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAdjustment.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Select });
            dgvAdjustment.Dock = DockStyle.Fill;
            dgvAdjustment.EnableHeadersVisualStyles = false;
            dgvAdjustment.GridColor = Color.White;
            dgvAdjustment.Location = new Point(0, 152);
            dgvAdjustment.Name = "dgvAdjustment";
            dgvAdjustment.RowHeadersVisible = false;
            dgvAdjustment.RowHeadersWidth = 51;
            dgvAdjustment.Size = new Size(1100, 369);
            dgvAdjustment.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 67;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Pcode";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 96;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Bardcode";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 124;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Description";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Category";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 123;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 80;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Stock On Hand";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 170;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Select.HeaderText = "";
            Select.Image = Properties.Resources.check;
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.Width = 6;
            // 
            // StockAdjustments
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 607);
            Controls.Add(dgvAdjustment);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "StockAdjustments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockAdjustments";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdjustment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblManageProduct;
        private TextBox txtSearch;
        private Button btnAdd;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label lblPcode;
        private Label label3;
        private Label lblDescription;
        private Label lblRefNo;
        private Label label2;
        private TextBox txtQty;
        private ComboBox cmbAction;
        private DataGridView dgvAdjustment;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Select;
    }
}
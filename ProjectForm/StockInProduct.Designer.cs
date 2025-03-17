namespace ProjectForm
{
    partial class StockInProduct
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Select = new DataGridViewImageColumn();
            panel1 = new Panel();
            btnClose = new Button();
            txtSearch = new TextBox();
            lblManageProduct = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 236, 179);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.ColumnHeadersHeight = 30;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column7, Select });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.GridColor = Color.White;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(838, 491);
            dgvProduct.TabIndex = 5;
            dgvProduct.CellContentClick += dgvCategory_CellContentClick;
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
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Description";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Qty";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 71;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lblManageProduct);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 491);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 78);
            panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.LightSalmon;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(719, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 46);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(244, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(415, 30);
            txtSearch.TabIndex = 5;
            // 
            // lblManageProduct
            // 
            lblManageProduct.AutoSize = true;
            lblManageProduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblManageProduct.Location = new Point(21, 30);
            lblManageProduct.Name = "lblManageProduct";
            lblManageProduct.Size = new Size(168, 23);
            lblManageProduct.TabIndex = 3;
            lblManageProduct.Text = "Product Stock In";
            // 
            // StockInProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 569);
            ControlBox = false;
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "StockInProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockInProduct";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProduct;
        private Panel panel1;
        private TextBox txtSearch;
        private Label lblManageProduct;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Select;
        private Button btnClose;
    }
}
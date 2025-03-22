namespace ProjectForm
{
    partial class Category
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
            lblManageCategory = new Label();
            btnAdd = new Button();
            dgvCategory = new DataGridView();
            numberCol = new DataGridViewTextBoxColumn();
            categoryId = new DataGridViewTextBoxColumn();
            categoryName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(lblManageCategory);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 475);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 78);
            panel1.TabIndex = 0;
            // 
            // lblManageCategory
            // 
            lblManageCategory.AutoSize = true;
            lblManageCategory.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblManageCategory.Location = new Point(12, 23);
            lblManageCategory.Name = "lblManageCategory";
            lblManageCategory.Size = new Size(190, 23);
            lblManageCategory.TabIndex = 3;
            lblManageCategory.Text = "Manage Category";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(916, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 56);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.BackgroundColor = Color.White;
            dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 64, 55);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 236, 179);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.ColumnHeadersHeight = 40;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { numberCol, categoryId, categoryName, Edit, Delete });
            dgvCategory.Dock = DockStyle.Fill;
            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.GridColor = Color.White;
            dgvCategory.Location = new Point(0, 0);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(1007, 475);
            dgvCategory.TabIndex = 1;
            // 
            // numberCol
            // 
            numberCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            numberCol.HeaderText = "No.";
            numberCol.MinimumWidth = 6;
            numberCol.Name = "numberCol";
            numberCol.Width = 67;
            // 
            // categoryId
            // 
            categoryId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            categoryId.HeaderText = "ID";
            categoryId.MinimumWidth = 6;
            categoryId.Name = "categoryId";
            categoryId.Visible = false;
            categoryId.Width = 125;
            // 
            // categoryName
            // 
            categoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoryName.HeaderText = "Category";
            categoryName.MinimumWidth = 6;
            categoryName.Name = "categoryName";
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.edit;
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1007, 553);
            ControlBox = false;
            Controls.Add(dgvCategory);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Category";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category";
            Load += Category_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvCategory;
        private Label lblManageCategory;
        private Button btnAdd;
        private DataGridViewTextBoxColumn numberCol;
        private DataGridViewTextBoxColumn categoryId;
        private DataGridViewTextBoxColumn categoryName;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
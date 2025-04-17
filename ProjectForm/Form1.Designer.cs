namespace ProjectForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSlide = new Panel();
            btnLogout = new Button();
            pnlSubSetting = new Panel();
            pnlSubRecord = new Panel();
            btnPOSrecord = new Button();
            btnSales = new Button();
            btnRecord = new Button();
            pnlSubStock = new Panel();
            btnManage = new Button();
            btnStockEntry = new Button();
            btnStock = new Button();
            pnlSubProduct = new Panel();
            btnCategory = new Button();
            btnProdlist = new Button();
            btnProduct = new Button();
            btnDashboard = new Button();
            pnlLogo = new Panel();
            lblName = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pnlTitle = new Panel();
            lblTitle = new Label();
            pnlMain = new Panel();
            pnlSlide.SuspendLayout();
            pnlSubRecord.SuspendLayout();
            pnlSubStock.SuspendLayout();
            pnlSubProduct.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSlide
            // 
            pnlSlide.AutoScroll = true;
            pnlSlide.BackColor = Color.FromArgb(160, 120, 90);
            pnlSlide.Controls.Add(btnLogout);
            pnlSlide.Controls.Add(pnlSubSetting);
            pnlSlide.Controls.Add(pnlSubRecord);
            pnlSlide.Controls.Add(btnRecord);
            pnlSlide.Controls.Add(pnlSubStock);
            pnlSlide.Controls.Add(btnStock);
            pnlSlide.Controls.Add(pnlSubProduct);
            pnlSlide.Controls.Add(btnProduct);
            pnlSlide.Controls.Add(btnDashboard);
            pnlSlide.Controls.Add(pnlLogo);
            pnlSlide.Dock = DockStyle.Left;
            pnlSlide.Location = new Point(0, 0);
            pnlSlide.Name = "pnlSlide";
            pnlSlide.Size = new Size(212, 653);
            pnlSlide.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Peru;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(0, 712);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(5, 0, 0, 0);
            btnLogout.Size = new Size(191, 45);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlSubSetting
            // 
            pnlSubSetting.Dock = DockStyle.Top;
            pnlSubSetting.Location = new Point(0, 622);
            pnlSubSetting.Name = "pnlSubSetting";
            pnlSubSetting.Size = new Size(191, 90);
            pnlSubSetting.TabIndex = 8;
            // 
            // pnlSubRecord
            // 
            pnlSubRecord.Controls.Add(btnPOSrecord);
            pnlSubRecord.Controls.Add(btnSales);
            pnlSubRecord.Dock = DockStyle.Top;
            pnlSubRecord.Location = new Point(0, 532);
            pnlSubRecord.Name = "pnlSubRecord";
            pnlSubRecord.Size = new Size(191, 90);
            pnlSubRecord.TabIndex = 6;
            // 
            // btnPOSrecord
            // 
            btnPOSrecord.BackColor = Color.Chocolate;
            btnPOSrecord.Dock = DockStyle.Top;
            btnPOSrecord.FlatStyle = FlatStyle.Flat;
            btnPOSrecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnPOSrecord.Location = new Point(0, 45);
            btnPOSrecord.Name = "btnPOSrecord";
            btnPOSrecord.Padding = new Padding(35, 0, 0, 0);
            btnPOSrecord.Size = new Size(191, 45);
            btnPOSrecord.TabIndex = 7;
            btnPOSrecord.Text = "POS Record";
            btnPOSrecord.TextAlign = ContentAlignment.MiddleLeft;
            btnPOSrecord.UseVisualStyleBackColor = false;
            btnPOSrecord.Click += btnPOSrecord_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.Chocolate;
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(0, 0);
            btnSales.Name = "btnSales";
            btnSales.Padding = new Padding(35, 0, 0, 0);
            btnSales.Size = new Size(191, 45);
            btnSales.TabIndex = 6;
            btnSales.Text = "Sale History";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.Peru;
            btnRecord.Dock = DockStyle.Top;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Location = new Point(0, 487);
            btnRecord.Name = "btnRecord";
            btnRecord.Padding = new Padding(5, 0, 0, 0);
            btnRecord.Size = new Size(191, 45);
            btnRecord.TabIndex = 5;
            btnRecord.Text = "Record";
            btnRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // pnlSubStock
            // 
            pnlSubStock.Controls.Add(btnManage);
            pnlSubStock.Controls.Add(btnStockEntry);
            pnlSubStock.Dock = DockStyle.Top;
            pnlSubStock.Location = new Point(0, 397);
            pnlSubStock.Name = "pnlSubStock";
            pnlSubStock.Size = new Size(191, 90);
            pnlSubStock.TabIndex = 0;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.Chocolate;
            btnManage.Dock = DockStyle.Top;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnManage.Location = new Point(0, 45);
            btnManage.Name = "btnManage";
            btnManage.Padding = new Padding(35, 0, 0, 0);
            btnManage.Size = new Size(191, 45);
            btnManage.TabIndex = 7;
            btnManage.Text = "Manage Stock ";
            btnManage.TextAlign = ContentAlignment.MiddleLeft;
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // btnStockEntry
            // 
            btnStockEntry.BackColor = Color.Chocolate;
            btnStockEntry.Dock = DockStyle.Top;
            btnStockEntry.FlatStyle = FlatStyle.Flat;
            btnStockEntry.ImageAlign = ContentAlignment.MiddleLeft;
            btnStockEntry.Location = new Point(0, 0);
            btnStockEntry.Name = "btnStockEntry";
            btnStockEntry.Padding = new Padding(35, 0, 0, 0);
            btnStockEntry.Size = new Size(191, 45);
            btnStockEntry.TabIndex = 6;
            btnStockEntry.Text = "Stock Entry";
            btnStockEntry.TextAlign = ContentAlignment.MiddleLeft;
            btnStockEntry.UseVisualStyleBackColor = false;
            btnStockEntry.Click += btnStockEntry_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.Peru;
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Location = new Point(0, 352);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(5, 0, 0, 0);
            btnStock.Size = new Size(191, 45);
            btnStock.TabIndex = 3;
            btnStock.Text = "In Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // pnlSubProduct
            // 
            pnlSubProduct.Controls.Add(btnCategory);
            pnlSubProduct.Controls.Add(btnProdlist);
            pnlSubProduct.Dock = DockStyle.Top;
            pnlSubProduct.Location = new Point(0, 260);
            pnlSubProduct.Name = "pnlSubProduct";
            pnlSubProduct.Size = new Size(191, 92);
            pnlSubProduct.TabIndex = 0;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.Chocolate;
            btnCategory.Dock = DockStyle.Top;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(0, 45);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(35, 0, 0, 0);
            btnCategory.Size = new Size(191, 45);
            btnCategory.TabIndex = 4;
            btnCategory.Text = "Category";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProdlist
            // 
            btnProdlist.BackColor = Color.Chocolate;
            btnProdlist.Dock = DockStyle.Top;
            btnProdlist.FlatStyle = FlatStyle.Flat;
            btnProdlist.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdlist.Location = new Point(0, 0);
            btnProdlist.Name = "btnProdlist";
            btnProdlist.Padding = new Padding(35, 0, 0, 0);
            btnProdlist.Size = new Size(191, 45);
            btnProdlist.TabIndex = 3;
            btnProdlist.Text = "Product List";
            btnProdlist.TextAlign = ContentAlignment.MiddleLeft;
            btnProdlist.UseVisualStyleBackColor = false;
            btnProdlist.Click += btnProdlist_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Peru;
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ImageAlign = ContentAlignment.MiddleRight;
            btnProduct.Location = new Point(0, 215);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(5, 0, 0, 0);
            btnProduct.Size = new Size(191, 45);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Product";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Peru;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(0, 170);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(5, 0, 0, 0);
            btnDashboard.Size = new Size(191, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(160, 120, 90);
            pnlLogo.Controls.Add(lblName);
            pnlLogo.Controls.Add(label2);
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(191, 170);
            pnlLogo.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(160, 120, 90);
            lblName.ForeColor = Color.FromArgb(255, 230, 204);
            lblName.Location = new Point(3, 66);
            lblName.Name = "lblName";
            lblName.Size = new Size(29, 21);
            lblName.TabIndex = 2;
            lblName.Text = "Ln";
            lblName.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(160, 120, 90);
            label2.ForeColor = Color.FromArgb(255, 230, 204);
            label2.Location = new Point(25, 135);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 1;
            label2.Text = "Administrator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.orangeuser;
            pictureBox1.Location = new Point(55, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(160, 120, 90);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(212, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(970, 40);
            pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(160, 120, 90);
            lblTitle.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(255, 230, 204);
            lblTitle.Location = new Point(768, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(332, 37);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Store";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(212, 40);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(970, 613);
            pnlMain.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(121, 85, 72);
            ClientSize = new Size(1182, 653);
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            Controls.Add(pnlSlide);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Point of Sales";
            WindowState = FormWindowState.Maximized;
            pnlSlide.ResumeLayout(false);
            pnlSubRecord.ResumeLayout(false);
            pnlSubStock.ResumeLayout(false);
            pnlSubProduct.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSlide;
        private Panel pnlLogo;
        private Panel pnlTitle;
        private Button btnDashboard;
        private Panel pnlMain;
        private Button btnProduct;
        private Panel pnlSubProduct;
        private Button btnCategory;
        private Button btnProdlist;
        private Panel pnlSubStock;
        private Button btnManage;
        private Button btnStockEntry;
        private Button btnStock;
        private Button btnRecord;
        private Panel pnlSubRecord;
        private Button btnPOSrecord;
        private Button btnSales;
        private Button btnLogout;
        private Panel pnlSubSetting;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblName;
        private Label lblTitle;
    }
}

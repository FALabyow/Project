namespace ProjectForm.View
{
    partial class Dashboard
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
            panel11 = new Panel();
            pictureBox4 = new PictureBox();
            totalProductLabel = new Label();
            label11 = new Label();
            label12 = new Label();
            panel13 = new Panel();
            panel8 = new Panel();
            pictureBox3 = new PictureBox();
            criticalProductsLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            panel10 = new Panel();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            stocksLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            panel7 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            dailySalesLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(0, 192, 0);
            panel11.Controls.Add(pictureBox4);
            panel11.Controls.Add(totalProductLabel);
            panel11.Controls.Add(label11);
            panel11.Controls.Add(label12);
            panel11.Controls.Add(panel13);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(787, 13);
            panel11.Name = "panel11";
            panel11.Size = new Size(255, 165);
            panel11.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_product_96;
            pictureBox4.Location = new Point(-1, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // totalProductLabel
            // 
            totalProductLabel.AutoSize = true;
            totalProductLabel.Dock = DockStyle.Right;
            totalProductLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalProductLabel.ForeColor = Color.White;
            totalProductLabel.Location = new Point(182, 0);
            totalProductLabel.Name = "totalProductLabel";
            totalProductLabel.Size = new Size(73, 38);
            totalProductLabel.TabIndex = 1;
            totalProductLabel.Text = "0.00";
            totalProductLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(73, 109);
            label11.Name = "label11";
            label11.Size = new Size(178, 45);
            label11.TabIndex = 2;
            label11.Text = "Total product recorded in the inventory.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(73, 72);
            label12.Name = "label12";
            label12.Size = new Size(126, 25);
            label12.TabIndex = 1;
            label12.Text = "Total Product";
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.Location = new Point(62, 14);
            panel13.Name = "panel13";
            panel13.Size = new Size(5, 140);
            panel13.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Red;
            panel8.Controls.Add(pictureBox3);
            panel8.Controls.Add(criticalProductsLabel);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(529, 13);
            panel8.Name = "panel8";
            panel8.Size = new Size(252, 165);
            panel8.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_warning_96;
            pictureBox3.Location = new Point(-1, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // criticalProductsLabel
            // 
            criticalProductsLabel.AutoSize = true;
            criticalProductsLabel.Dock = DockStyle.Right;
            criticalProductsLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            criticalProductsLabel.ForeColor = Color.White;
            criticalProductsLabel.Location = new Point(219, 0);
            criticalProductsLabel.Name = "criticalProductsLabel";
            criticalProductsLabel.Size = new Size(33, 38);
            criticalProductsLabel.TabIndex = 1;
            criticalProductsLabel.Text = "0";
            criticalProductsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(73, 109);
            label8.Name = "label8";
            label8.Size = new Size(178, 45);
            label8.TabIndex = 2;
            label8.Text = "Total critical products recorded in the inventory.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(73, 72);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 1;
            label9.Text = "Critical Products";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Location = new Point(62, 14);
            panel10.Name = "panel10";
            panel10.Size = new Size(5, 140);
            panel10.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 0);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(stocksLabel);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(271, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(252, 165);
            panel5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_storage_96;
            pictureBox2.Location = new Point(-1, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // stocksLabel
            // 
            stocksLabel.AutoSize = true;
            stocksLabel.Dock = DockStyle.Right;
            stocksLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stocksLabel.ForeColor = Color.White;
            stocksLabel.Location = new Point(219, 0);
            stocksLabel.Name = "stocksLabel";
            stocksLabel.Size = new Size(33, 38);
            stocksLabel.TabIndex = 1;
            stocksLabel.Text = "0";
            stocksLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(73, 109);
            label5.Name = "label5";
            label5.Size = new Size(178, 45);
            label5.TabIndex = 2;
            label5.Text = "Total available products recorded in the inventory.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(73, 72);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 1;
            label6.Text = "Stocks";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(62, 14);
            panel7.Name = "panel7";
            panel7.Size = new Size(5, 140);
            panel7.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(dailySalesLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(13, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 165);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.sales;
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(3, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dailySalesLabel
            // 
            dailySalesLabel.AutoSize = true;
            dailySalesLabel.Dock = DockStyle.Right;
            dailySalesLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dailySalesLabel.ForeColor = Color.White;
            dailySalesLabel.Location = new Point(179, 0);
            dailySalesLabel.Name = "dailySalesLabel";
            dailySalesLabel.Size = new Size(73, 38);
            dailySalesLabel.TabIndex = 1;
            dailySalesLabel.Text = "0.00";
            dailySalesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(73, 109);
            label2.Name = "label2";
            label2.Size = new Size(178, 45);
            label2.TabIndex = 2;
            label2.Text = "Total daily sales recorded in the inventory.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 72);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 1;
            label1.Text = "Daily Sales";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(62, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 140);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel11, 3, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel8, 2, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1055, 191);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 383);
            panel1.TabIndex = 2;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources._11593348;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Padding = new Padding(10);
            pictureBox5.Size = new Size(1055, 383);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 574);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Label dailySalesLabel;
        private Panel panel8;
        private Label criticalProductsLabel;
        private Label label8;
        private Label label9;
        private Panel panel10;
        private Panel panel5;
        private Label stocksLabel;
        private Label label5;
        private Label label6;
        private Panel panel7;
        private Panel panel11;
        private Label totalProductLabel;
        private Label label11;
        private Label label12;
        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private PictureBox pictureBox5;
    }
}
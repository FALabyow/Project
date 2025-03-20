namespace ProjectForm
{
    partial class ProductModule
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
            panel1 = new Panel();
            picClose = new PictureBox();
            label1 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            label2 = new Label();
            btnSave = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPcode = new TextBox();
            txtBarcode = new TextBox();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            nudReorder = new NumericUpDown();
            txtPrice = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudReorder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 85, 72);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 50);
            panel1.TabIndex = 6;
            
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.BackColor = Color.FromArgb(255, 128, 128);
            picClose.Image = Properties.Resources.close1;
            picClose.Location = new Point(829, 12);
            picClose.Name = "picClose";
            picClose.Size = new Size(39, 33);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 12;
            picClose.TabStop = false;
            picClose.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 18);
            label1.TabIndex = 1;
            label1.Text = "Product  Module";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.LightSalmon;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(616, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 46);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = Color.MistyRose;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(729, 354);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 46);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 95);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 9;
            label2.Text = "Pcode:\r\n";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.Peru;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(503, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 46);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 95);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 12;
            label3.Text = "Barcode :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 149);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 13;
            label4.Text = "Description :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 207);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 14;
            label5.Text = "Category :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 264);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 15;
            label6.Text = "Price :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(506, 264);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 16;
            label7.Text = "Reorder :";
            // 
            // txtPcode
            // 
            txtPcode.Location = new Point(170, 90);
            txtPcode.Name = "txtPcode";
            txtPcode.Size = new Size(240, 25);
            txtPcode.TabIndex = 7;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(558, 90);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(254, 25);
            txtBarcode.TabIndex = 17;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(170, 147);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(642, 25);
            txtDescription.TabIndex = 18;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(170, 204);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(642, 27);
            cmbCategory.TabIndex = 19;
            // 
            // nudReorder
            // 
            nudReorder.Location = new Point(659, 260);
            nudReorder.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudReorder.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudReorder.Name = "nudReorder";
            nudReorder.Size = new Size(150, 25);
            nudReorder.TabIndex = 21;
            nudReorder.TextAlign = HorizontalAlignment.Center;
            nudReorder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(170, 261);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(278, 25);
            txtPrice.TabIndex = 22;
            // 
            // ProductModule
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 412);
            Controls.Add(txtPrice);
            Controls.Add(nudReorder);
            Controls.Add(cmbCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtBarcode);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtPcode);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            Load += ProductModule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudReorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnUpdate;
        private Button btnClear;
        private Label label2;
        private Button btnSave;
        private PictureBox picClose;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPcode;
        private TextBox txtBarcode;
        private TextBox txtDescription;
        private TextBox txtPrice;
        public ComboBox cmbCategory;
        public NumericUpDown nudReorder;
    }
}
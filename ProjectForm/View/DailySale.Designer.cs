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
            btnPrint = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Cancel = new DataGridViewImageColumn();
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
            picboxClose.Click += picboxClose_Click;
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
            dgvCashier.Columns.AddRange(new DataGridViewColumn[] { Column1, Column9, Column2, Column4, Column6, Column3, Column7, Cancel });
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
            panel2.Controls.Add(btnPrint);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 813);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 105);
            panel2.TabIndex = 14;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Image = Properties.Resources.printer1;
            btnPrint.Location = new Point(571, 33);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(61, 45);
            btnPrint.TabIndex = 2;
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 67;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Invoice#";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 116;
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
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column6.DefaultCellStyle = dataGridViewCellStyle2;
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 80;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Qty";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 71;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle4;
            Column7.HeaderText = "Total";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 79;
            // 
            // Cancel
            // 
            Cancel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Cancel.HeaderText = "";
            Cancel.Image = Properties.Resources.multiply;
            Cancel.MinimumWidth = 6;
            Cancel.Name = "Cancel";
            Cancel.Width = 6;
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
            KeyDown += DailySale_KeyDown;
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
        private Button btnPrint;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Cancel;
    }
}
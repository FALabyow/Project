namespace ProjectForm
{
    partial class Qty
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
            txtQty = new TextBox();
            SuspendLayout();
            // 
            // txtQty
            // 
            txtQty.Dock = DockStyle.Fill;
            txtQty.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(0, 0);
            txtQty.Multiline = true;
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(149, 52);
            txtQty.TabIndex = 0;
            txtQty.Text = "1";
            txtQty.TextAlign = HorizontalAlignment.Center;
            // 
            // Qty
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(149, 52);
            Controls.Add(txtQty);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Qty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Qty";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQty;
    }
}
namespace ProjectForm
{
    partial class SettlePayment
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtSale = new TextBox();
            txtCash = new TextBox();
            txtChange = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtSale
            // 
            txtSale.Enabled = false;
            txtSale.Location = new Point(12, 23);
            txtSale.Multiline = true;
            txtSale.Name = "txtSale";
            txtSale.Size = new Size(412, 30);
            txtSale.TabIndex = 1;
            // 
            // txtCash
            // 
            txtCash.Location = new Point(12, 75);
            txtCash.Multiline = true;
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(412, 30);
            txtCash.TabIndex = 2;
            txtCash.TextChanged += txtCash_TextChanged;
            txtCash.KeyPress += txtCash_KeyPress;
            // 
            // txtChange
            // 
            txtChange.Enabled = false;
            txtChange.Location = new Point(12, 127);
            txtChange.Multiline = true;
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(412, 30);
            txtChange.TabIndex = 3;
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnter.BackColor = Color.Peru;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Location = new Point(148, 194);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(118, 46);
            btnEnter.TabIndex = 9;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            // 
            // SettlePayment
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 261);
            Controls.Add(btnEnter);
            Controls.Add(txtChange);
            Controls.Add(txtCash);
            Controls.Add(txtSale);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettlePayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettlePayment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtCash;
        private TextBox txtChange;
        private Button btnEnter;
        public TextBox txtSale;
    }
}
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
            button1 = new Button();
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
            txtSale.Location = new Point(12, 23);
            txtSale.Name = "txtSale";
            txtSale.Size = new Size(412, 30);
            txtSale.TabIndex = 1;
            // 
            // txtCash
            // 
            txtCash.Location = new Point(12, 75);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(412, 30);
            txtCash.TabIndex = 2;
            // 
            // txtChange
            // 
            txtChange.Location = new Point(12, 127);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(412, 30);
            txtChange.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 174);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // SettlePayment
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 522);
            Controls.Add(button1);
            Controls.Add(txtChange);
            Controls.Add(txtCash);
            Controls.Add(txtSale);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SettlePayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettlePayment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtSale;
        private TextBox txtCash;
        private TextBox txtChange;
        private Button button1;
    }
}
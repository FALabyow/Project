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
            pnlLogo = new Panel();
            pnlTitle = new Panel();
            pnlMain = new Panel();
            btnDashboard = new Button();
            pnlSlide.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSlide
            // 
            pnlSlide.Controls.Add(btnDashboard);
            pnlSlide.Controls.Add(pnlLogo);
            pnlSlide.Dock = DockStyle.Left;
            pnlSlide.Location = new Point(0, 0);
            pnlSlide.Name = "pnlSlide";
            pnlSlide.Size = new Size(200, 653);
            pnlSlide.TabIndex = 0;
            // 
            // pnlLogo
            // 
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(200, 170);
            pnlLogo.TabIndex = 1;
            // 
            // pnlTitle
            // 
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(200, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(982, 40);
            pnlTitle.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(200, 40);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(982, 613);
            pnlMain.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Peru;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(0, 170);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 40);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
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
            pnlSlide.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSlide;
        private Panel pnlLogo;
        private Panel pnlTitle;
        private Button btnDashboard;
        private Panel pnlMain;
    }
}

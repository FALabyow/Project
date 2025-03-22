using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm
{
    //part 6 of the tutorial
    //https://www.youtube.com/watch?v=iOc2_NeYF2g&t=490s
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void slide(Button button)
        {
            pnlSlide.BackColor = Color.SaddleBrown;
            pnlSlide.Height = button.Height;
            pnlSlide.Top = button.Top;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            slide(btnTransaction);
            GetTranNo();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        { 
            slide(btnSearchProduct);
            SearchProducts searchProducts = new SearchProducts();
            searchProducts.Show();
            
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            //should only be enable if there is an item in the cart
            //if not this button should be disabled
            slide(btnDiscount);
            Discount discount = new Discount();
            discount.txtTotalprice.Text = lblDisplaytotal.Text;
            discount.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            //should only be enable if there is an item in the cart
            //if not this button should be disabled
            slide(btnPayment);
            SettlePayment settlePayment = new SettlePayment();
            settlePayment.txtSale.Text = lblDisplaytotal.Text;
            settlePayment.ShowDialog();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            //should only be enable if there is an item in the cart
            //if not this button should be disabled
            slide(btnClearCart);
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            slide(btnDailySales);
            DailySale dailySale = new DailySale();
            dailySale.ShowDialog(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void GetTranNo()
        {
            string sdate = DateTime.Now.ToString("yyyyMMdd");
            string transNo = sdate + "1001";
            lblTranNo.Text = transNo;
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            //Tutorial Part 9 – Search product using Barcode
            //https://youtu.be/rPjDiwp-R8g?si=d0FGLXedW8AnlonY
        }

        
    }
}

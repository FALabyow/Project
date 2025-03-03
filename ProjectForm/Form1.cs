namespace ProjectForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        //side menu

        private void customizeDesign()
        {
            pnlSubProduct.Visible = false;
            pnlSubRecord.Visible = false;
            pnlSubSetting.Visible = false;
            pnlSubStock.Visible = false;

        }

        private void hideSubMenu()
        {
            if (pnlSubProduct.Visible == true)
                pnlSubProduct.Visible = false;
            if (pnlSubRecord.Visible == true)
                pnlSubRecord.Visible = false;
            if (pnlSubSetting.Visible == true)
                pnlSubSetting.Visible = false;
            if (pnlSubStock.Visible == true)
                pnlSubStock.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
           showSubMenu(pnlSubProduct);
        }

        private void btnProdlist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubStock);
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubRecord);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPOSrecord_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
           showSubMenu(pnlSubSetting);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace ProjectForm
{
    public partial class Form1 : Form
    {
        // part 1 of the tutorial
        //https://www.youtube.com/watch?v=TipJwf0-yLg&list=PLcDvtJ2MXvhy_YrXdO4VXqZBOADCRJhSc
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        

        private Form activeform = null;


        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitle.Text = childForm.Text;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            subMenu.Visible = !subMenu.Visible;
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
            openChildForm(new Product());
            hideSubMenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
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
            openChildForm(new StockEntry());
            hideSubMenu();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            openChildForm(new StockAdjustments());
            hideSubMenu();
        }


        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubRecord);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            openChildForm(new DailySale());
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
            Close();
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Project.Application.Services;
using ProjectForm.Model.DTOs;
using ProjectForm.Presenter;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ProjectForm
{
    //part 6 of the tutorial
    //https://www.youtube.com/watch?v=iOc2_NeYF2g&t=490s
    public partial class Cashier : Form, ICashierView
    {
        private readonly CashierPresenter _presenter;
        public event Action<string, int> QuantityUpdated;
        public Cashier()
        {
            InitializeComponent();
            HttpClient httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            CashierService cashierService = new CashierService(httpClient);
            _presenter = new CashierPresenter(this, cashierService);
            dgvCashier.AutoGenerateColumns = false;
            barcodetxt.TextChanged += cashiersearch_TextChanged;
            this.Load += async (s, e) => await _presenter.InitializeAsync();

          

            dgvCashier.Visible = true;
        }
        public void DisplayProducts(DataTable dataTable)
        {
            dgvCashier.DataSource = dataTable;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ClearProductList()
        {
            dgvCashier.DataSource = null;
        }

        public void UpdateTotal(decimal total)
        {
            lblSalesTotal.Text = $"{total:C}";
        }

        private void cashiersearch_TextChanged(object sender, EventArgs e)
        {
            _presenter.SearchProduct(barcodetxt.Text);
        }
        private void AddRemoveButtonColumn()
        {
            if (!dgvCashier.Columns.Contains("Remove"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Action",
                    Text = "Remove",
                    UseColumnTextForButtonValue = true,
                    Name = "Remove"
                };
                dgvCashier.Columns.Add(btnColumn);
            }
        }

        public void AddQuantityColumn()
        {
            if (dgvCashier.Columns["BuyerQuantity"] == null)
            {
                DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
                {
                    Name = "BuyerQuantity",
                    HeaderText = "Quantity",
                    ValueType = typeof(int),
                    DefaultCellStyle = { NullValue = 1 }
                };
                dgvCashier.Columns.Add(quantityColumn);
            }
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
            searchProducts.ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            slide(btnDiscount);
            Discount discount = new Discount();
            discount.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            slide(btnPayment);
            SettlePayment settlepayment = new SettlePayment();
            settlepayment.txtSale.Text = lblDisplaytotal.Text;
            settlepayment.ShowDialog();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
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
        private void dgvCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCashier.EndEdit();

            if (e.ColumnIndex >= 0)
            {
                // Handle Remove button click
                if (dgvCashier.Columns[e.ColumnIndex].Name == "Remove")
                {
                    string barcode = dgvCashier.Rows[e.RowIndex].Cells["BarcodeData"].Value?.ToString();
                    if (!string.IsNullOrEmpty(barcode))
                    {
                        _presenter.RemoveProduct(barcode);
                    }
                }

                // Handle BuyerQuantity column changes
                else if (e.ColumnIndex == dgvCashier.Columns["BuyerQuantity"].Index)
                {
                    var barcode = dgvCashier.Rows[e.RowIndex].Cells["BarcodeData"].Value?.ToString();
                    var quantityCell = dgvCashier.Rows[e.RowIndex].Cells["BuyerQuantity"].Value;

                    if (barcode != null && int.TryParse(quantityCell?.ToString(), out int newQuantity))
                    {
                        QuantityUpdated?.Invoke(barcode, newQuantity);
                    }
                }
            }
        }

        public void DisplayProductList(List<ProductDto> productList)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void barcodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        void ICashierView.AddRemoveButtonColumn()
        {
            AddRemoveButtonColumn();
        }

        
    }
}

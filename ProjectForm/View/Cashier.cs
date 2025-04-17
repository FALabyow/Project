using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Project.Application.DTOs;
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
        public Cashier()
        {
            InitializeComponent();
            _presenter = new CashierPresenter(this);
            dgvCashier.AutoGenerateColumns = false;
            picClose.Click += (s, e) => CloseClicked?.Invoke(this, EventArgs.Empty);
            timer1.Tick += (s, e) => TimerTicked?.Invoke(this, EventArgs.Empty);
            checkOutBtn.Click += (s, e) => CheckoutClicked?.Invoke(this, EventArgs.Empty);
            btnTransaction.Click += Transaction_Click;
            btnSearchProduct.Click += SearchProduct_Click;
            btnPayment.Click += Payment_Click;
            btnLogout.Click += Logout_Click;
            btnDailySales.Click += DailySales_Click;
            btnClearCart.Click += ClearCart_Click;
            adminBtn.Click += Admin_Click;
            barcodetxt.TextChanged += Barcode_TextChanged;
            barcodetxt.Select();
            dgvCashier.CellContentClick += DataGridCashierView_CellContentClick;

        }

        public event EventHandler? CloseClicked;
        public event EventHandler? TimerTicked;
        public event EventHandler<Button>? TransactionClicked;
        public event EventHandler<Button>? SearchProductClicked;
        public event EventHandler<Button>? PaymentClicked;
        public event EventHandler<Button>? DailySalesClicked;
        public event EventHandler<Button>? LogoutClicked;
        public event EventHandler<Button>? ClearCartClicked;
        public event EventHandler<Button>? AdminClicked;
        public event EventHandler? BarcodeTextChanged;
        public event EventHandler<DataGridViewCellEventArgs>? RemoveClicked;
        public event EventHandler? CheckoutClicked;
        public string TransactionNumber
        {
            get => lblTranNo.Text;
            set => lblTranNo.Text = value;
        }
        public string Timer
        {
            get => lblTimer.Text;
            set => lblTimer.Text = value;
        }
        public string Date
        {
            get => lblDate.Text;
            set => lblDate.Text = value;
        }
        public string DisplayTotal
        {
            get => lblDisplaytotal.Text;
            set => lblDisplaytotal.Text = value;
        }
        public string Total
        {
            get => lblSalesTotal.Text;  
            set => lblSalesTotal.Text = value;  
        }
        public string Cash
        {
            get => lblCash.Text;    
            set => lblCash.Text = value;
        }
        public string Change
        {
            get => lblChange.Text;
            set => lblChange.Text = value;
        }
        public string Barcode => barcodetxt.Text;
        public List<SalesDetail> Sales
        {
            get
            {
                var sales = new List<SalesDetail>();
                foreach (DataGridViewRow row in dgvCashier.Rows)
                {
                    if (row.IsNewRow) continue;

                    sales.Add(new SalesDetail
                    {
                        ProductCode = row.Cells["ProductCode"].Value?.ToString(),
                        ProductName = row.Cells["ProductName"].Value?.ToString(),
                        SalesHistoryId = lblTranNo.Text,
                        QuantitySold = (int)row.Cells["BuyerQuantity"].Value,
                        UnitPrice = (decimal)row.Cells["ProductPrice"].Value
                    });


                }

                return sales;
            }
        }
        public List<StockDto> Stocks
        {
            get
            {
                var stocks = new List<StockDto>();
                foreach (DataGridViewRow row in dgvCashier.Rows)
                {
                    if (row.IsNewRow) continue;

                    stocks.Add(new StockDto
                    {
                        StockId = (Guid)row.Cells["StockId"].Value,
                        ProductQuantity = (int)row.Cells["ProductQuantity"].Value,
                    });


                }
                return stocks;
            }
        }
        public void Slider(Button button)
        {
            pnlSlide.BackColor = Color.SaddleBrown;
            pnlSlide.Height = button.Height;
            pnlSlide.Top = button.Top;
        }
        public bool ProductExistsInGrid(string barcode)
        {
            foreach (DataGridViewRow row in dgvCashier.Rows)
            {
                if (row.Cells[0].Value?.ToString() == barcode)
                    return true;
            }
            return false;
        }
        public void UpdateProductQuantityInGrid(string barcode, int newQuantity)
        {
            foreach (DataGridViewRow row in dgvCashier.Rows)
            {
                if (row.Cells[0].Value?.ToString() == barcode)
                {
                    row.Cells[4].Value = newQuantity;
                    row.Cells[5].Value = newQuantity * (decimal)row.Cells[3].Value;
                    row.Cells[6].Value = (int)row.Cells[6].Value - 1;   
                    break;
                }
            }
            _presenter.CalculateTotal(dgvCashier);
        }
        public int GetProductQuantityFromGrid(string barcode)
        {
            foreach (DataGridViewRow row in dgvCashier.Rows)
            {
                if (row.Cells[0].Value?.ToString() == barcode)
                    return Convert.ToInt32(row.Cells[4].Value);
            }
            return 0;
        }
        public void DisplayProducts(DisplayAvailableProductsDto products)
        {

            dgvCashier.Rows.Add(products.BarcodeData, products.StockId, products.ProductName, products.ProductPrice, products.BuyersQuantity, products.SubTotal, products.ProductQuantity = products.ProductQuantity - 1, products.ProductCode);
            ClearBarcode();
            _presenter.CalculateTotal(dgvCashier);
        }
        public void ClearBarcode()
        {
            barcodetxt.Text = "";
        }
        private void Transaction_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                TransactionClicked?.Invoke(this, button);
                barcodetxt.Select();
            }
        }
        private void SearchProduct_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                SearchProductClicked?.Invoke(this, button);
                barcodetxt.Select();
            }
        }
        private void Payment_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                PaymentClicked?.Invoke(this, button);
                barcodetxt.Select();
            }
        }
        private void ClearCart_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                ClearCartClicked?.Invoke(this, button);
                barcodetxt.Select();
            }
        }
        private void DailySales_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DailySalesClicked?.Invoke(this, button);
                barcodetxt.Select();
            }
        }
        private void Admin_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                AdminClicked?.Invoke(this, button);
                barcodetxt.Select();
            }
        }
        private void Logout_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                LogoutClicked?.Invoke(this, button);
            }
        }
        private void Barcode_TextChanged(object? sender, EventArgs e)
        {
            BarcodeTextChanged?.Invoke(sender, e);
        }
        private async void Cashier_Load(object sender, EventArgs e)
        {
            await _presenter.LoadAllAvailableProducts();
        }
        private void DataGridCashierView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if(gridView == null || e.RowIndex < 0) return;

            if (gridView.Columns[e.ColumnIndex].Name == "Remove")
            {
                RemoveClicked?.Invoke(sender, e);
            }
        }

    }
}

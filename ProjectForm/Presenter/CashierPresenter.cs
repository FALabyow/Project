using Accessibility;
using ProjectForm.Model.DTOs;
using ProjectForm.Model.DTOs.ProductDtos;
using ProjectForm.View.IView;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class CashierPresenter
    {
        private readonly ICashierView _view;
        private readonly HttpClient _httpClient;
        public List<GetAllAvailableProductsDto> _availableProducts = new();
        private DataTable _dataTable;     
        public CashierPresenter(ICashierView view)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            _view = view;
            _dataTable = new DataTable();
            _view.CloseClicked += OnCloseClicked;
            _view.TimerTicked += OnTimerClicked;
            _view.TransactionClicked += OnTransactionClicked;
            _view.LogoutClicked += OnLogoutClicked;
            _view.SearchProductClicked += OnSearchProductClicked;
            _view.DailySalesClicked += OnDailySalesClicked;
            _view.PaymentClicked += OnPaymentClicked;
            _view.AdminClicked += OnAdminClicked;
            _view.BarcodeTextChanged += OnBarcodeTextChanged;   
            _view.RemoveClicked += OnRemoveClicked;
            _view.CheckoutClicked += OnCheckoutClicked;
            _view.Date = DateOnly.FromDateTime(DateTime.Now).ToString("MM-dd-yyyy");
        }
        private void OnCloseClicked(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void OnTimerClicked(object? sender, EventArgs e)
        {
            _view.Timer = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void OnTransactionClicked(object? sender, Button e)
        {
            _view.Slider(e);
            GetTranNo();
        }
        private void OnSearchProductClicked(object? sender, Button e)
        {
            _view.Slider(e);
            SearchProducts searchProducts = new SearchProducts(this, _view);
            //await LoadAllAvailableProducts();
            searchProducts.ShowDialog();
        }
        private void OnPaymentClicked(object? sender, Button e)
        {
            _view.Slider(e);
            SettlePayment settlepayment = new SettlePayment(_view);
            settlepayment.txtSale.Text = _view.DisplayTotal;
            settlepayment.ShowDialog();
        }
        private void OnDailySalesClicked(object? sender, Button e)
        {
            _view.Slider(e);
            DailySale dailySale = new DailySale();
            dailySale.ShowDialog();
        }
        private void OnLogoutClicked(object? sender, Button e)
        {
            _view.Slider(e);
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void OnAdminClicked(object? sender, Button e)
        {
            _view.Slider(e);
            Form1 form = new Form1();
            form.ShowDialog();
        }
        private void OnBarcodeTextChanged(object? sender, EventArgs e)
        {
            string barcode = _view.Barcode;
            SearchProduct(barcode);
        }
        private void OnRemoveClicked(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) return;

            gridView.Rows.RemoveAt(e.RowIndex);
        }
        private async void OnCheckoutClicked(object? sender, EventArgs e)
        {
            if (_view.TransactionNumber == "000000000")
            {
                MessageBox.Show("No transaction number is generated");
                return;
            }

            if (_view.Sales.Count <= 0)
            {
                MessageBox.Show("Transaction is empty");
                return;
            }

            if(decimal.Parse(_view.Total) == 0)
            {
                MessageBox.Show("Please settle the payment.");
                return;
            }

            await SendSalesHistory(_view.TransactionNumber, decimal.Parse(_view.Total));
            await SendSalesDetail();
            await SendStockQuantity();
            GetTranNo();
            _view.ClearTable();
        }
        private void GetTranNo()
        {
            string sdate = DateTime.Now.ToString("yyyyMMdd");
            Guid id = Guid.NewGuid();
            string shortId = id.ToString().Substring(0, 5);
            string transNo = sdate + shortId;
            _view.TransactionNumber = transNo;
        }
        public async Task LoadAllAvailableProducts()
        {
            try
            {
                var res = await _httpClient.GetAsync("/Products/Available");

                if (res.IsSuccessStatusCode)
                {
                    var products = await res.Content.ReadFromJsonAsync<List<GetAllAvailableProductsDto>>();

                    if (products == null)
                    {
                        return;
                    }

                    _availableProducts = products;
                   

                }
                else
                {
                    MessageBox.Show("Cannot fetch Data");
                }
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show("There's a problem with the server: " + ex.Message);
            }
        }
        public void SearchProduct(string barcode)
        {
            var product = _availableProducts.FirstOrDefault(p => p.BarcodeData == barcode);
            if (product == null)
                return;

            if (_view.ProductExistsInGrid(barcode))
            {
                int currentQty = _view.GetProductQuantityFromGrid(barcode);
                int newQty = currentQty + 1;
                if(product.ProductQuantity < newQty)
                {
                    MessageBox.Show("No Available stock");
                    return;
                }
                _view.UpdateProductQuantityInGrid(barcode, newQty);
                _view.ClearBarcode();
            }
            else
            {
                var productToDisplay = new DisplayAvailableProductsDto
                {
                    StockId = product.StockId,
                    BarcodeData = product.BarcodeData,
                    ProductName = product.ProductName,
                    ProductPrice = product.ProductPrice,
                    BuyersQuantity = 1,
                    SubTotal = product.ProductPrice,
                    ProductQuantity = product.ProductQuantity,
                    ProductCode = product.ProductCode,
                    
                };

                _view.DisplayProducts(productToDisplay);
            }
        }
        public void CalculateTotal(DataGridView dataGridView)
        {
            decimal grandTotal = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    decimal subTotal = Convert.ToDecimal(row.Cells[5].Value);
                    grandTotal += subTotal;
                }
            }

            _view.DisplayTotal = $"{grandTotal}";
        }
        private async Task SendSalesHistory(string salesHistoryId, decimal totalAmount)
        {
            
            var salesHistory = new SalesHistoryInfoDto
            {
                SalesHistoryId = salesHistoryId,
                TotalAmount = totalAmount,
            };

            try
            {
                var json = JsonSerializer.Serialize(salesHistory);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await _httpClient.PostAsync("/SalesHistory/AddSalesHistory", content);

                res.EnsureSuccessStatusCode();

            }catch(HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private async Task SendSalesDetail()
        {
            try
            {
                var json = JsonSerializer.Serialize(_view.Sales);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await _httpClient.PostAsync("/Sales/AddSales", content);

                res.EnsureSuccessStatusCode();

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task SendStockQuantity()
        {
            try
            {
                var json = JsonSerializer.Serialize(_view.Stocks);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await _httpClient.PatchAsync("/Stocks/UpdateStocks/Quantity", content);

                res.EnsureSuccessStatusCode();

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

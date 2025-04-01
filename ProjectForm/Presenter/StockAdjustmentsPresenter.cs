using ProjectForm.Model.DTOs;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class StockAdjustmentsPresenter
    {
        private readonly IStockAdjustmentsView _view;
        private readonly HttpClient _httpClient;
        private string? _selectedItem;
        public StockAdjustmentsPresenter(IStockAdjustmentsView view)
        {
            _view = view;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            _view.SelectedItemCombo += OnSelectedItemCombo;
            _view.SelectedClicked += OnSelectedClicked;
        }
        private void OnSelectedItemCombo(object? sender, EventArgs e)
        {
            _selectedItem = _view.SelectedItem;
        }    
        public async Task LoadStocksAsync()
        {
            try
            {
                var res = await _httpClient.GetAsync($"/Products/All");

                if (res.IsSuccessStatusCode)
                {
                    var stocks = await res.Content.ReadFromJsonAsync<List<ProductDto>>();

                    if(stocks == null)
                    {
                        return;
                    }

                    _view.DisplayStocks(stocks);


                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnSelectedClicked(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;

            if (gridView == null || e.RowIndex < 0)
            {
                return;
            }

            string productName = (string)gridView.Rows[e.RowIndex].Cells["ProductName"].Value;
            string barcode = (string)gridView.Rows[e.RowIndex].Cells["BarcodeData"].Value;
            string productCode = (string)gridView.Rows[e.RowIndex].Cells["ProductCode1"].Value;
            int productQuantity = (int)gridView.Rows[e.RowIndex].Cells["ProductQuantity1"].Value;

            _view.ProductCode = productCode;
            _view.Description = productName;
            _view.Barcode = barcode;
            _view.ProductQuantity = productQuantity;
        }
    }
}

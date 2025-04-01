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
        }
        private void OnSelectedItemCombo(object? sender, EventArgs e)
        {
            _selectedItem = _view.SelectedItem;
            MessageBox.Show(_selectedItem);
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
    }
}

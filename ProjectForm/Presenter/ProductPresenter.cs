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
    public class ProductPresenter
    {
        private readonly IProductView _view;
        private readonly HttpClient _httpClient;

        public ProductPresenter(IProductView view)
        {
            _view = view;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            _view.DeleteClicked += OnDeleteClicked;
            _view.EditClicked += OnEditClicked;
        }

        public async void LoadProductList()
        {
            try
            {
                var res = await _httpClient.GetAsync($"/Products/All");

                if (res.IsSuccessStatusCode)
                {
                    var products = await res.Content.ReadFromJsonAsync<List<ProductDto>>();

                    if(products == null)
                    {
                        return;
                    }

                    _view.DisplayProductList(products, 0);
                }
            }
            catch(HttpRequestException ex)
            {
                _view.ShowMessage(ex.Message);
            }
        }
        private async void OnDeleteClicked(object? sender, DataGridViewCellEventArgs e)
        {

        }
        private async void OnEditClicked(object? sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

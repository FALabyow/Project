using ProjectForm.Error;
using ProjectForm.Model.DTOs;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class ProductModulePresenter
    {
        private readonly IProductModuleView _view;
        private readonly HttpClient _httpClient;
        private readonly ProductPresenter _presenter;
        public ProductModulePresenter(IProductModuleView view, ProductPresenter presenter)
        {
            _view = view;
            _presenter = presenter;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api")};
            _view.SelectedIndexCategoryCombo += OnSelectedIndexCategoryCombo;
            _view.SaveClicked -= OnSaveClicked; //Unsubsccibe event
            _view.SaveClicked += OnSaveClicked; //subscribe event
            _view.ModuleCloseClicked += OnModuleCloseClicked;         
        }
        public async Task LoadCategoryAsync()
        {  
            try
            {
                _view.LoadingMessage("Waiting for category list...");
                var response = await _httpClient.GetAsync("/Categories/All");
                if (response.IsSuccessStatusCode)
                {
                    
                    var categories = await response.Content.ReadFromJsonAsync<List<CategoryDto>>();
                    if(categories == null || categories.Count == 0)
                    {
                        _view.LoadingMessage("Category list is empty.");
                        return;
                        
                    }

                    _view.LoadCategory(categories);
                    

                }
                else if(response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await response.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if(errorRes != null)
                    {
                        _view.ShowMessage(errorRes.Error);
                    }
                   
                    
                }
                else
                {
                    _view.ShowMessage("An unexpected error occured!");
                }
                _view.LoadingMessage("");
            }
            catch(Exception ex)
            {
                _view?.ShowMessage(ex.Message);
            }
        }
        private void OnSelectedIndexCategoryCombo(object? sender, EventArgs e)
        {
            Guid selectedCategoryId = _view.SelectedCategory;
            if (selectedCategoryId != Guid.Empty)
            {
                Debug.WriteLine($"Selected category: {selectedCategoryId}");
            }
        }
        private async void OnSaveClicked(object? sender, EventArgs e)
        {
            var product = new ProductDto
            {
                ProductName = _view.Description,
                BarcodeData = _view.Barcode,
                ScannedAt = DateTime.Now,
                ProductReOrder = _view.ReOrder,
                CategoryId = _view.SelectedCategory,
                ProductPrice = _view.Price,
                ProductCode = _view.Pcode,
                ProductId = Guid.NewGuid(),
            };

            var stock = new StockDto
            {
                ProductId = product.ProductId,

            };

            if (string.IsNullOrEmpty(product.ProductName) || string.IsNullOrEmpty(product.BarcodeData))
            {
                _view.ShowMessage("Field cannot be empty!");
                return;
            }

            if(product.CategoryId == Guid.Empty)
            {
                _view.ShowMessage("Please select category");
                return;
            }

            if(product.ProductPrice < 0)
            {
                _view.ShowMessage("Invalid price");
                return;
            }

            try
            {
                var json = JsonSerializer.Serialize(product);
                var stockJson = JsonSerializer.Serialize(stock);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var stockContent = new StringContent(stockJson, Encoding.UTF8, "application/json");
                var res = await _httpClient.PostAsync("/Product/AddProduct", content);
                var stockRes = await _httpClient.PostAsync("/Stock/AddStock", stockContent);

                if (res.IsSuccessStatusCode && stockRes.IsSuccessStatusCode)
                {
                    if (Application.OpenForms["Product"] is Product)
                    {
                        await _presenter.LoadProductList();
                    }
                }
                else if(res.StatusCode == HttpStatusCode.BadRequest )
                {
                    var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if(errorRes != null)
                    {
                        _view.ShowMessage(errorRes.Error);
                    }

                }
                else if(stockRes.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await stockRes.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if (errorRes != null)
                    {
                        _view.ShowMessage(errorRes.Error);
                    }
                }
                else
                {
                    _view?.ShowMessage("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                _view?.ShowMessage(ex.Message);
            }
        }
        private void OnModuleCloseClicked(object? sender, EventArgs e)
        {
            _view.ModuleClose();
        }
    }
}

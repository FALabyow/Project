using ProjectForm.Model.DTOs.ProductDtos;
using ProjectForm.Model.DTOs.StockDtos;
using ProjectForm.Error;
using ProjectForm.Model.DTOs;
using ProjectForm.Model.DTOs.CategoryDto;
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
using ProjectForm.Http;

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
            _httpClient = Connection.Instance;
            _view.SelectedIndexCategoryCombo += OnSelectedIndexCategoryCombo;
            _view.SaveClicked -= OnSaveClicked; //Unsubsccibe event
            _view.SaveClicked += OnSaveClicked; //subscribe event
            _view.ClearClicked += OnClearClicked;
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
                        //_view.ShowMessage(errorRes.Error);
                        MessageBox.Show(errorRes.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                    
                }
                else
                {
                    //_view.ShowMessage("An unexpected error occured!");
                    MessageBox.Show("An unexpected error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _view.LoadingMessage("");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var product = new AddProductDto
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

            var stock = new AddStockDto
            {
                ProductId = product.ProductId,

            };

            if (string.IsNullOrEmpty(product.ProductName) || string.IsNullOrEmpty(product.BarcodeData))
            {
                //_view.ShowMessage("Field cannot be empty!");
                MessageBox.Show("Field cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(product.CategoryId == Guid.Empty)
            {
                //_view.ShowMessage("Please select category");
                MessageBox.Show("Please select category", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(product.ProductPrice < 0)
            {
                //_view.ShowMessage("Invalid price");
                MessageBox.Show("Invalid price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        //_view.ShowMessage(errorRes.Error);
                        MessageBox.Show(errorRes.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else if(stockRes.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await stockRes.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if (errorRes != null)
                    {
                        //_view.ShowMessage(errorRes.Error);
                        MessageBox.Show(errorRes.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    //_view?.ShowMessage("Something went wrong");
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //_view?.ShowMessage(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnModuleCloseClicked(object? sender, EventArgs e)
        {
            _view.ModuleClose();
        }
        private void OnClearClicked(object? sender, EventArgs e)
        {
            _view?.Clear();
        }
    }
}

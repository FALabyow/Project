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
        private readonly IProductModuleView _productModuleView;
        private readonly HttpClient _httpClient;
        private readonly ProductPresenter _presenter;
        public ProductModulePresenter(IProductModuleView productModuleView, ProductPresenter presenter)
        {
            _productModuleView = productModuleView;
            _presenter = presenter;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api")};
            _productModuleView.SelectedIndexCategoryCombo += OnSelectedIndexCategoryCombo;
            _productModuleView.SaveClicked -= OnSaveClicked; //Unsubsccibe event
            _productModuleView.SaveClicked += OnSaveClicked; //subscribe event  
            
        }

        public async Task LoadCategoryAsync()
        {  
            try
            {
                _productModuleView.LoadingMessage("Waiting for category list...");
                var response = await _httpClient.GetAsync("/Categories/All");
                if (response.IsSuccessStatusCode)
                {
                    
                    var categories = await response.Content.ReadFromJsonAsync<List<CategoryDto>>();
                    if(categories == null || categories.Count == 0)
                    {
                        Debug.WriteLine("Categories is empty");
                        return;
                        
                    }
                    Debug.WriteLine("Categories is not empty");
                    _productModuleView.LoadCategory(categories);
                    

                }
                else if(response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await response.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    _productModuleView.ShowMessage(errorRes.Error);
                    
                }
                else
                {
                    _productModuleView.ShowMessage("An expected error occured!");
                }
                _productModuleView.LoadingMessage("");
            }
            catch(Exception ex)
            {
                _productModuleView?.ShowMessage(ex.Message);
            }
        }
        private void OnSelectedIndexCategoryCombo(object? sender, EventArgs e)
        {
            Guid selectedCategoryId = _productModuleView.Selectedcategory;
            if (selectedCategoryId != Guid.Empty)
            {
                Debug.WriteLine($"Selected category: {selectedCategoryId}");
            }
        }
        private async void OnSaveClicked(object? sender, EventArgs e)
        {
            Debug.WriteLine("Hey");
            var product = new AddProductDto
            {
                ProductName = _productModuleView.Description,
                BarcodeData = _productModuleView.Barcode,
                ScannedAt = DateTime.Now,
                ProductPreOrder = _productModuleView.Preorder,
                CategoryId = _productModuleView.Selectedcategory,
                ProductPrice = _productModuleView.Price,
                ProductQuantity = _productModuleView.Quantity,
                ProductCode = _productModuleView.Pcode,
            };

            if (string.IsNullOrEmpty(product.ProductName) || string.IsNullOrEmpty(product.BarcodeData))
            {
                _productModuleView.ShowMessage("Field cannot be empty!");
                return;
            }

            if(product.CategoryId == Guid.Empty)
            {
                _productModuleView.ShowMessage("Please select category");
                return;
            }

            if(product.ProductPrice < 0)
            {
                _productModuleView.ShowMessage("Invalid price");
                return;
            }

            if(product.ProductQuantity < 0)
            {
                _productModuleView.ShowMessage("Invalid Quantity");
                return;
            }

            try
            {
                var json = JsonSerializer.Serialize(product);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await _httpClient.PostAsync("/Product/AddProduct", content);

                if (res.IsSuccessStatusCode)
                {
                    if (Application.OpenForms["Product"] is Product)
                    {
                        _presenter.LoadProductList();
                    }
                }
                else if(res.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if(errorRes != null)
                    {
                        Debug.WriteLine(errorRes.Error);
                        _productModuleView.ShowMessage(errorRes.Error);
                    }

                }
                else
                {
                    Debug.WriteLine("Something went wrong");
                    _productModuleView?.ShowMessage("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                _productModuleView?.ShowMessage("error2");
            }
        }
    }
}

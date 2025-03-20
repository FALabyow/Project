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
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class ProductModulePresenter
    {
        private readonly IProductModuleView _productModuleView;
        private readonly HttpClient _httpClient;
        public ProductModulePresenter(IProductModuleView productModuleView)
        {
            _productModuleView = productModuleView;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api")};
            _productModuleView.SelectedIndexCategoryCombo += OnSelectedIndexCategoryCombo;
            
        }

        public async Task LoadCategoryAsync()
        {
            Debug.WriteLine("LoadCategoryAsyn() is loaded");
            try
            {
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
                    if (errorRes != null)
                    {
                        _productModuleView.ShowMessage(errorRes.Error);
                    }
                }
                else
                {
                    _productModuleView.ShowMessage("An expected error occured!");
                }
            }
            catch(Exception ex)
            {
                _productModuleView?.ShowMessage(ex.Message);
            }
        }
        private void OnSelectedIndexCategoryCombo(object sender, EventArgs e)
        {
            Guid selectedCategoryId = _productModuleView.Selectedcategory;
            if (selectedCategoryId != Guid.Empty)
            {
                Debug.WriteLine($"Selected category: {selectedCategoryId}");
            }
        }
        
    }
}

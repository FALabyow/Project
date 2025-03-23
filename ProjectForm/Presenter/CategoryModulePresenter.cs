using ProjectForm.Error;
using ProjectForm.Model.DTOs;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class CategoryModulePresenter
    {
        private readonly ICategoryModuleView _categoryModuleView;
        private readonly HttpClient _httpClient;
        private readonly CategoryPresenter _presenter;
        public CategoryModulePresenter(ICategoryModuleView categoryModuleView, CategoryPresenter presenter)
        {
            _categoryModuleView = categoryModuleView;
            _presenter = presenter;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            _categoryModuleView.SaveClicked += OnSaveClicked;
            _categoryModuleView.UpdateClicked += OnUpdateClicked;   
            _categoryModuleView.ClearClicked += OnClearClicked;
           
        }
        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var category = new CategoryDto
            {
                CategoryName = char.ToUpper(_categoryModuleView.CategoryName[0]) + _categoryModuleView.CategoryName.Substring(1),
            };

            if(category.CategoryName == "" )
            {
                _categoryModuleView.ShowMessage("Field cannot be empty!");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to add category?", "Confirm Add", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            try
            {
                var json = JsonSerializer.Serialize(category);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("/Category/AddCategory", content);
                if (response.IsSuccessStatusCode)
                {
                    if (Application.OpenForms["Category"] is Category categoryForm)
                    {                       
                        _presenter.LoadCategoryList();
                    }
                    
                }
                else if(response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await response.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if(errorRes != null)
                    {
                        _categoryModuleView.ShowMessage(errorRes.Error);
                    }
                    
                }
                


            }
            catch (Exception ex)
            {
                _categoryModuleView?.ShowMessage(ex.Message);
            }
        }
        private async void OnUpdateClicked(object sender, EventArgs e)
        {

        }
        private void OnClearClicked(object sender, EventArgs e)
        {
            _categoryModuleView.CategoryName = "";
            _categoryModuleView.ClearMessage();
        }

    }
}

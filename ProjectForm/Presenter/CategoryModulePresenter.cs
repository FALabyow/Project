using ProjectForm.Error;
using ProjectForm.Model.DTOs;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private readonly ICategoryModuleView _view;
        private readonly HttpClient _httpClient;
        private readonly CategoryPresenter _presenter;
        //private TextInfo? _textInfo = CultureInfo.CurrentCulture.TextInfo;
        //private string? _categoryName;
        public CategoryModulePresenter(ICategoryModuleView view, CategoryPresenter presenter)
        {
            _view = view;
            _presenter = presenter;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            _view.SaveClicked += OnSaveClicked;  
            _view.ClearClicked += OnClearClicked;
            _view.CloseClicked += OnCloseClicked;
           
        }
        private async void OnSaveClicked(object? sender, EventArgs e)
        {

            //if(_textInfo != null)
            //{
            //    _categoryName = _textInfo.ToTitleCase(_view.CategoryName.ToLower());
            //}
            var category = new CategoryDto
            {
                //CategoryName = char.ToUpper(_view.CategoryName[0]) + _view.CategoryName.Substring(1),
                CategoryName = _view.CategoryName
            };

            if (category.CategoryName == "" )
            {
                _view.ShowMessage("Field cannot be empty!");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to add this category?", "Confirm Add", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            try
            {
                var json = JsonSerializer.Serialize(category);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("/Category/AddCategory", content);
                if (response.IsSuccessStatusCode)
                {
                    if (Application.OpenForms["Category"] is Category)
                    {
                        await _presenter.LoadCategoryList();
                    }
                    
                }
                else if(response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await response.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if(errorRes != null)
                    {
                        _view.ShowMessage(errorRes.Error);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                _view?.ShowMessage(ex.Message);
            }
        }       
        private void OnClearClicked(object? sender, EventArgs e)
        {
            _view.CategoryName = "";
            _view.ClearMessage();
        }
        private void OnCloseClicked(object? sender, EventArgs e)
        {
            _view.CloseCategoryModule();
        }

    }
}

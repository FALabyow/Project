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
    public class CategoryPresenter
    {
        private readonly ICategoryView _view;
        private readonly HttpClient _httpClient;
        public CategoryPresenter(ICategoryView view)
        {
            _view = view;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api")};
        }

        public async void LoadCategoryList()
        {
            try
            {
                var res = await _httpClient.GetAsync($"/Categories/All");
                if (res.IsSuccessStatusCode)
                {
                    var categories = await res.Content.ReadFromJsonAsync<List<CategoryDto>>();
                    if(categories == null)
                    {
                        return;
                    }

                    _view.DisplayCategoryList(categories);
                }
            }
            catch (HttpRequestException ex)
            {
                _view.ShowMessage(ex.Message);  
            }
            catch(Exception ex)
            {
                _view?.ShowMessage(ex.Message);
            }
        }
    }
}

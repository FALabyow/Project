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
    public class CategoryPresenter
    {
        private readonly ICategoryView _view;
        private readonly HttpClient _httpClient;
        public CategoryPresenter(ICategoryView view)
        {
            _view = view;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api")};
            _view.DeleteClicked += OnDeleteClicked;
            _view.EditClicked += OnEditClicked;

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

                    _view.DisplayCategoryList(categories, 0);
                }
            }
            catch (HttpRequestException ex)
            {
                _view.ShowMessage(ex.Message);  
            }
        }
        private async void OnDeleteClicked(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var gridView = sender as DataGridView;
                if(gridView == null || e.RowIndex < 0)
                {
                    return;
                }

                var categoryId = (Guid)gridView.Rows[e.RowIndex].Cells["categoryId"].Value;
                var categoryName = gridView.Rows[e.RowIndex].Cells["categoryName"].Value;
                Debug.WriteLine(categoryId);
                var confirmResult = MessageBox.Show($"Do you want {categoryName} from this list?", "Confirm Delete", MessageBoxButtons.YesNo);

                if(confirmResult != DialogResult.Yes) return;

                var res = await _httpClient.DeleteAsync($"/Category/Delete/{categoryId}");
                if (res.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Deleted Successfully");
                    LoadCategoryList();
                }
                else if (res.StatusCode == HttpStatusCode.Conflict)
                {
                    var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if(errorRes != null)
                    {
                        _view.ShowMessage(errorRes.Error);
                    }
                }
                else
                {
                    _view.ShowMessage("Failed to delete category!");
                }
            }
            catch (HttpRequestException ex)
            {
                _view.ShowMessage("Failed to connect to a server: " + ex.Message);
            }
            catch( Exception ex )
            {
                _view.ShowMessage(ex.Message);
            }
        }
        private async void OnEditClicked(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var gridView = sender as DataGridView;
                if (gridView == null || e.RowIndex < 0)
                {
                    return;
                }

                var categoryId = (Guid)gridView.Rows[e.RowIndex].Cells["categoryId"].Value;
                var categoryName = (string)gridView.Rows[e.RowIndex].Cells["categoryName"].Value;

                var category = new CategoryDto
                {
                    CategoryId = categoryId,
                    CategoryName = categoryName
                };

                if(string.IsNullOrWhiteSpace(categoryName))
                {
                    _view.ShowMessage("Category name cannot be empty");
                    return;
                }
                
                var confirmResult = MessageBox.Show($"Do you want to updated this category?", "Confirm Update", MessageBoxButtons.YesNo);

                if (confirmResult != DialogResult.Yes) return;

                var json = JsonSerializer.Serialize(category);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await _httpClient.PutAsync($"/Category/Update/{categoryId}", content);

                if (res.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Update Successfully");
                    LoadCategoryList();
                }
                else if (res.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();

                    if (errorRes != null)
                    {
                        _view.ShowMessage(errorRes.Error);
                        LoadCategoryList();
                    }
                }
                else
                {
                    _view.ShowMessage("Failed to update category!");
                    LoadCategoryList();
                }
            }
            catch (HttpRequestException ex)
            {
                _view.ShowMessage("Failed to connect to a server: " + ex.Message);
                LoadCategoryList();
            }
            catch (Exception ex)
            {
                _view.ShowMessage(ex.Message);
                LoadCategoryList();
            }
        }
    }
}

using ProjectForm.Error;
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
            _view.AddClicked += OnAddClicked;
        }
        public async Task LoadCategoryList()
        {
            try
            {
                var res = await _httpClient.GetAsync($"/Categories/All");

                res.EnsureSuccessStatusCode();
                var categories = await res.Content.ReadFromJsonAsync<List<CategoryDto>>();
                
                if (categories == null)
                {
                    return;
                }

                _view.DisplayCategoryList(categories, 0);
                

            }
            catch (HttpRequestException ex)
            {
                _view.ShowMessage("Failed to connect to a server" + ex.Message);  
            }
            
        }
        private async void OnDeleteClicked(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) return;
            
            try
            {
                var categoryId = (Guid)gridView.Rows[e.RowIndex].Cells["categoryId"].Value;
                var categoryName = (string)gridView.Rows[e.RowIndex].Cells["categoryName"].Value;
                
                var confirmResult = MessageBox.Show($"Do you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo);

                if(confirmResult != DialogResult.Yes) return;

                var res = await _httpClient.DeleteAsync($"/Category/Delete/{categoryId}");

                if (res.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Deleted Successfully");
                    gridView.Rows.RemoveAt(e.RowIndex);
                    await LoadCategoryList();
                }
                else if (res.StatusCode == HttpStatusCode.Conflict)
                {
                    var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if (errorRes != null) 
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
        private async void OnEditClicked(object? sender, DataGridViewCellEventArgs e)
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

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                _view.ShowMessage("Category name cannot be empty");
                return;
            }

            var confirmResult = MessageBox.Show($"Do you want to update this category?", "Confirm Update", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            try
            {
                var json = JsonSerializer.Serialize(category);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await _httpClient.PutAsync($"/Category/Update/{categoryId}", content);

                if (res.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Updated Successfully");
                    await LoadCategoryList();
                }
                else if (res.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();

                    if (errorRes != null)
                    {
                        _view.ShowMessage(errorRes.Error);
                        await LoadCategoryList();
                    }
                }
                else
                {
                    _view.ShowMessage("Failed to update category!");
                    await LoadCategoryList();
                }
            }
            catch (HttpRequestException ex)
            {
                _view.ShowMessage("Failed to connect to a server: " + ex.Message);
                await LoadCategoryList();
            }
            catch (Exception ex)
            {
                _view.ShowMessage(ex.Message);
                await LoadCategoryList();
            }
        }
        private void OnAddClicked(object? sender, EventArgs e)
        {
            var categoryModule = new CategoryModule(this);
            categoryModule.Show();
        }
    }
}

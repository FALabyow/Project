using ProjectForm.Model.DTOs.ProductDtos;
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
using ProjectForm.Http;

namespace ProjectForm.Presenter
{
    public class ProductPresenter
    {
        private readonly IProductView _view;
        private readonly HttpClient _httpClient;
        private List<GetAllProductDto> _allProducts = new();
        public ProductPresenter(IProductView view)
        {
            _view = view;
            _httpClient = Connection.Instance;
            _view.DeleteClicked += OnDeleteClicked;
            _view.EditClicked += OnEditClicked;
            _view.ProductSearched += OnProductSearched;
            _view.RowNumber += OnRowNumber;
            _view.AddClicked += OnAddClicked;
        }
        public async Task LoadProductList()
        {
            try
            {
                var res = await _httpClient.GetAsync($"/Products/All");

                if (res.IsSuccessStatusCode)
                {
                    var products = await res.Content.ReadFromJsonAsync<List<GetAllProductDto>>();

                    if(products == null)
                    {
                        return;
                    }

                    _allProducts = products;
                    _view.DisplayProductList(products);
                }
            }
            catch(HttpRequestException ex)
            {
                //_view.ShowMessage(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void OnDeleteClicked(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0)
            {
                return;
            }

            var productId = (Guid)gridView.Rows[e.RowIndex].Cells["productId"].Value;
            var productName = gridView.Rows[e.RowIndex].Cells["productDescription"].Value;
            var productQuantity = (int)gridView.Rows[e.RowIndex].Cells["ProductQuantity"].Value;

            var confirmResult = MessageBox.Show($"Do you want to delete {productName} from this list?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            if (productQuantity > 0)
            {
                //MessageBox.Show("This product can't be deleted because it is currently in stock.");
                MessageBox.Show("This product can't be deleted because it is currently in stock.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var res = await _httpClient.DeleteAsync($"/Product/Delete/{productId}");
                if (res.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Deleted Successfully");
                    gridView.Rows.RemoveAt(e.RowIndex);
                    await LoadProductList();
                }
                else if (res.StatusCode == HttpStatusCode.Conflict)
                {
                    var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    if (errorRes != null)
                    {
                        //_view.ShowMessage(errorRes.Error);
                        MessageBox.Show(errorRes.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    //_view.ShowMessage("Failed to delete product!");
                    MessageBox.Show("Failed to delete product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                //_view.ShowMessage("Failed to connect to a server: " + ex.Message);  
                MessageBox.Show("Failed to connect to a server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void OnEditClicked(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;

            if (gridView == null || e.RowIndex < 0)
            {
                return;
            }

            var productId = (Guid)gridView.Rows[e.RowIndex].Cells["productId"].Value;
            var productName = (string)gridView.Rows[e.RowIndex].Cells["productDescription"].Value;
            var productPrice = (Decimal)gridView.Rows[e.RowIndex].Cells["productPrice"].Value;
            var productReorder = (int)gridView.Rows[e.RowIndex].Cells["productReorder"].Value;

            var product = new UpdateProductDto
            {
                ProductId = productId,
                ProductName = productName.ToUpper(),
                ProductPrice = productPrice,
                ProductReOrder = productReorder,
            };

            

            if (string.IsNullOrWhiteSpace(product.ProductName))
            {
                //_view.ShowMessage("Product name cannot be empty");
                MessageBox.Show("Product name cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (product.ProductPrice <= 0)
            {
                //_view.ShowMessage("Invalid Price Value!");
                MessageBox.Show("Invalid Price Value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
               
            }

            if (product.ProductReOrder <= 0)
            {
                //_view.ShowMessage("Invalid Re-order Value!");
                MessageBox.Show("Invalid Re-order Value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }


            var confirmResult = MessageBox.Show($"Do you want to update this product?", "Confirm Update", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            try
            {
                
                var json = JsonSerializer.Serialize(product);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await _httpClient.PutAsync($"/Product/Update/{productId}", content);

                if (res.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Updated Successfully");
                    await LoadProductList();
                }
                else if (res.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();

                    if (errorRes != null)
                    {
                        MessageBox.Show(errorRes.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        await LoadProductList();
                    }
                }
                else
                {
                    //_view.ShowMessage("Failed to update product!");
                    MessageBox.Show("Failed to update product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await LoadProductList();
                }
            }
            catch (HttpRequestException ex)
            {
                //_view.ShowMessage("Failed to connect to a server: " + ex.Message);
                MessageBox.Show("Failed to connect to a server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await LoadProductList();
            }
        }
        private void OnProductSearched(object? sender, EventArgs e)
        {
            string searchText = _view.SearchText;
            var filteredList = _allProducts;

            if (decimal.TryParse(searchText, out decimal price))
            {
                filteredList = _allProducts.Where(c => c.ProductPrice == price).ToList();
            }
            else
            {
                filteredList = _allProducts
                    .Where(
                        c => c.ProductName != null && c.ProductName.ToLower().Contains(searchText) ||
                        c.CategoryName != null && c.CategoryName.ToLower().Contains(searchText)
                    )
                    .ToList();
            }

            _view.DisplayProductList(filteredList);
        }
        private void OnAddClicked(object? sender, EventArgs e)
        {
            var productModule = new ProductModule(this);
            productModule.ShowDialog();
        }
        private void OnRowNumber(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            var gridView = sender as DataGridView;

            if (gridView == null || e.RowIndex < 0) return;

            using (SolidBrush brush = new SolidBrush(gridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString();
                e.Graphics.DrawString(rowNumber, gridView.Font, brush, e.RowBounds.Left + 10, e.RowBounds.Top + 4);
            }           
        }
    }
}

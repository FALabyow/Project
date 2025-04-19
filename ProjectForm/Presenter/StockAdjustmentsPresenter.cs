using ProjectForm.Error;
using ProjectForm.Model.DTOs;
using ProjectForm.Model.DTOs.StockDtos;
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
    public class StockAdjustmentsPresenter
    {
        private readonly IStockAdjustmentsView _view;
        private readonly HttpClient _httpClient;
        private string? _selectedItem;
        private Guid _stockId = Guid.Empty;
        public StockAdjustmentsPresenter(IStockAdjustmentsView view)
        {
            _view = view;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            _view.SelectedItemCombo += OnSelectedItemCombo;
            _view.SelectedClicked += OnSelectedClicked;
            _view.SaveClicked += OnSaveClicked;
            _view.RowNumber += OnRowNumber;
        }
        private void OnSelectedItemCombo(object? sender, EventArgs e)
        {
            _selectedItem = _view.SelectedItem;
        }    
        public async Task LoadStocksAsync()
        {
            try
            {
                var res = await _httpClient.GetAsync("/Stocks/Adjustments/All");

                if (res.IsSuccessStatusCode)
                {
                    var stocks = await res.Content.ReadFromJsonAsync<List<GetAllStockAdjustmentsDto>>();

                    if(stocks == null)
                    {
                        return;
                    }

                    _view.DisplayStocks(stocks);


                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnSelectedClicked(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;

            if (gridView == null || e.RowIndex < 0)
            {
                return;
            }

            string productName = (string)gridView.Rows[e.RowIndex].Cells["ProductName"].Value;
            string barcode = (string)gridView.Rows[e.RowIndex].Cells["ProductBarcode"].Value;
            string productCode = (string)gridView.Rows[e.RowIndex].Cells["ProductCode1"].Value;
            int productQuantity = (int)gridView.Rows[e.RowIndex].Cells["ProductQuantity1"].Value;
            _stockId = (Guid)gridView.Rows[e.RowIndex].Cells["StockId"].Value;

            _view.ProductCode = productCode;
            _view.Description = productName;
            _view.Barcode = barcode;
            _view.ProductQuantity = productQuantity;
        }
        private async void OnSaveClicked(object? sender, EventArgs e)
        {
            var stock = new UpdateStocksDto
            {
                StockId = _stockId,
                ProductQuantity = _view.ProductQuantity,
            };

            var stockId = new DeleteStockDto
            {
                StockId = _stockId,
            };

            if(stock.ProductQuantity < 0)
            {
                MessageBox.Show("Invalid Quantity Value!");
                return;
            }

            if(stock.StockId == Guid.Empty)
            {
                MessageBox.Show("No stock id detected!");
            }

            try
            {
                if (_selectedItem == "Add to Inventory")
                {
                    var confirmResult = MessageBox.Show("Do you want to add this to the inventory?", "Confirm Action", MessageBoxButtons.YesNo);

                    if (confirmResult != DialogResult.Yes) return;

                    var json = JsonSerializer.Serialize(stock);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var res = await _httpClient.PutAsync($"/Stock/StockAdjustments/UpdateStock/{stock.StockId}", content);

                    if (res.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Successfully Added to Inventory");
                        await LoadStocksAsync();
                    }
                    else if(res.StatusCode == HttpStatusCode.BadRequest)
                    {
                        var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();
                        if(errorRes != null)
                        {
                            MessageBox.Show(errorRes.Error);
                            await LoadStocksAsync();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to add this to the inventory");
                        await LoadStocksAsync();
                    }
                }
                else if (_selectedItem == "Remove From Inventory")
                {
                    var confirmResult = MessageBox.Show("Do you want to remove this from the inventory?", "Confirm Action", MessageBoxButtons.YesNo);

                    if (confirmResult != DialogResult.Yes) return;

                    var json = JsonSerializer.Serialize(stockId);
                    var content = new StringContent(json, Encoding .UTF8, "application/json");
                    var res = await _httpClient.DeleteAsync($"/Stock/StockAdjustments/DeleteStock/{stockId.StockId}");

                    if (res.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Successfully Removed from Inventory");
                        await LoadStocksAsync();
                    }
                    else if (res.StatusCode == HttpStatusCode.BadRequest)
                    {
                        var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();
                        if (errorRes != null)
                        {
                            MessageBox.Show(errorRes.Error);
                            await LoadStocksAsync();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove from inventory");
                        await LoadStocksAsync();
                    }
                }
                else
                {
                    MessageBox.Show("Please select action!");
                    return;
                }
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
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

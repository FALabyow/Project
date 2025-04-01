using ProjectForm.Model;
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
    
    public class StockEntryPresenter
    {
        private readonly ReferenceModel _model;
        private readonly IStockEntryView _view;
        private string? newRef;
        private readonly StockInProductDto? date;
        private readonly HttpClient _httpClient;
        private List<StockRecordDto>? _records;
        public StockEntryPresenter(IStockEntryView view)
        {
            _view = view;
            _model = new ReferenceModel();
            _view.DeleteClicked += OnDeleteClicked;
            _view.LoadFilteredRecordsClicked += OnLoadFilteredRecordsClicked;
            //_view.StockEntryFormLoad += OnStockEntryLoad;
            _view.LinkReferenceClicked += OnLinkReferenceClicked;
            _view.LinkProductClicked += OnLinkProductClicked;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };

        }
        public void GenerateReference()
        {
            newRef = _model.GenerateReferenceNumber();
            _view.DisplayReferenceNumber(newRef);
        }
        public void AddStockEntry(ProductDto productList)
        {
            if(newRef != null)
            {
                var stockEntry = new ProductDto
                {
                    ProductCode = productList.ProductCode,
                    ProductId = productList.ProductId,
                    ProductName = productList.ProductName,
                    ReferenceNum = newRef,
                    ProductQuantity = productList.ProductQuantity,
                    StockInDate = DateOnly.FromDateTime(_view.DatePicker.Value),
                    CategoryName = productList.CategoryName,
                    StockId = productList.StockId,


                };
                _view.DisplayStockEntry(stockEntry);
            }
        }
        private void OnDeleteClicked(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0)
            {
                return;
            }
            gridView.Rows.RemoveAt(e.RowIndex);
        }

        public List<StockRecordDto> GetStockRecords(DataGridView dgvStockIn)
        {
            var stockRecords = new List<StockRecordDto>();
            foreach (DataGridViewRow row in dgvStockIn.Rows)
            {
                if (row.Cells["ProductQuantity1"].Value != null)
                {
                    DateOnly stockInDate = row.Cells["StockInDate1"].Value != null &&
                                           DateTime.TryParse(row.Cells["StockInDate1"].Value.ToString(), out DateTime tempDate)
                                           ? DateOnly.FromDateTime(tempDate)
                                           : DateOnly.MinValue;

                    stockRecords.Add(new StockRecordDto
                    {
                        ReferenceNum = row.Cells["ReferenceNum1"].Value?.ToString() ?? string.Empty,
                        StockInQty = Convert.ToInt32(row.Cells["ProductQuantity1"].Value),
                        StockInDate = stockInDate,
                        ProductCode = row.Cells["ProductCode1"].Value?.ToString() ?? string.Empty,
                        ProductName = row.Cells["ProductName1"].Value?.ToString() ?? string.Empty,
                        ProductCategory = row.Cells["CategoryName"].Value?.ToString() ?? string.Empty,
                        StockId = Guid.TryParse(row.Cells["StockId"].Value?.ToString(), out Guid stockId)
                            ? stockId
                            : Guid.Empty,

                    });
                }
            }

            return stockRecords;
        }
        public async Task SendStockRecordsAsync()
        {
            var data = _view.GetStockRecordsFromGrid();
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No records to send.");
                return;
            }

            var stockRecords = data.Select(d => new StockRecordDto
            {
                ReferenceNum = d.ReferenceNum,
                StockInQty = d.StockInQty,  
                StockInDate = d.StockInDate,
                ProductCode = d.ProductCode,
                ProductName =d.ProductName,
                ProductCategory = d.ProductCategory 

            }).ToList();

            var productQty = data.Select(d => new StockDto
            {
                ProductQuantity = d.StockInQty,
                StockId = d.StockId
            }).ToList();

            try
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to save this records?", "POS", MessageBoxButtons.YesNo);

                if (confirmResult != DialogResult.Yes) return;

                
                var response = await _httpClient.PostAsJsonAsync("/StockRecord/AddMultipleRecords", stockRecords);
                var response1 = await _httpClient.PatchAsJsonAsync("/Stocks/UpdateStocks", productQty);

                if (response.IsSuccessStatusCode && response1.IsSuccessStatusCode)
                {
                    MessageBox.Show("Stock records added successfully!");
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    var errorMessage2 = await response1.Content.ReadAsStringAsync();

                    MessageBox.Show($"Failed to add records: {(string.IsNullOrWhiteSpace(errorMessage) ? errorMessage2 : errorMessage)}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        public async Task LoadStockRecords()
        {
            try
            {
                var res = await _httpClient.GetAsync($"/StockRecords/All");

                if (res.IsSuccessStatusCode)
                {
                    var records = await res.Content.ReadFromJsonAsync<List<StockRecordDto>> ();

                    if (records == null)
                    {
                        return;
                    }

                    _records = records;
                    _view.DisplayStockRecords(_records);

                   
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void OnLoadFilteredRecordsClicked(object? sender, EventArgs e)
        {
            DateOnly startDate = _view.StartDate;
            DateOnly endDate = _view.EndDate;
            
            await LoadStockRecords();

            if (startDate > endDate)
            {
                MessageBox.Show("Invalid date range. 'From' date must be before 'To' date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_records == null)
            {
                MessageBox.Show("records is empty");
                return;
            }

            var filteredRecords = _records
                .Where(record => record.StockInDate >= _view.StartDate
                              && record.StockInDate <= _view.EndDate)
                .ToList();

            _view.DisplayStockRecords(filteredRecords);
        }
        private void OnLinkReferenceClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            GenerateReference();
        }
        private void OnLinkProductClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(_view.ReferenceNum))
            {
                MessageBox.Show("Reference number is empty");
                return;
            }
            var stockInProduct = new StockInProduct();
            stockInProduct.ShowDialog();
        }

        //private async void OnStockEntryLoad(object? sender, EventArgs e)
        //{
        //    await LoadStockRecords();
        //}

        
    }

   
}

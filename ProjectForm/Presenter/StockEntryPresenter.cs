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
        private List<StockRecordInfoDto>? _records;
        public StockEntryPresenter(IStockEntryView view)
        {
            _view = view;
            _model = new ReferenceModel();
            _view.DeleteClicked += OnDeleteClicked;
            _view.LoadFilteredRecordsClicked += OnLoadFilteredRecordsClicked;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };

        }

        public void GenerateReference()
        {
            newRef = _model.GenerateReferenceNumber();
            _view.DisplayReferenceNumber(newRef);
        }

        public void AddStockEntry(StockInDto stockInDto)
        {
            if(newRef != null)
            {
                var stockEntry = new StockInDto
                {
                    ProductCode = stockInDto.ProductCode,
                    ProductId = stockInDto.ProductId,
                    ProductName = stockInDto.ProductName,
                    ReferenceNum = newRef,
                    ProductQuantity = stockInDto.ProductQuantity,
                    StockInDate = DateOnly.FromDateTime(_view.DatePicker.Value)


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

        public async Task SendStockRecordsAsync()
        {
            var stockRecords = _view.GetStockRecordsFromGrid();
            if (stockRecords == null || stockRecords.Count == 0)
            {
                MessageBox.Show("No records to send.");
                return;
            }


            try
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to save this records?", "POS", MessageBoxButtons.YesNo);

                if (confirmResult != DialogResult.Yes) return;

                
                var response = await _httpClient.PostAsJsonAsync("/StockRecord/AddMultipleRecords", stockRecords);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Stock records added successfully!");
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to add records: {errorMessage}");
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
                    var records = await res.Content.ReadFromJsonAsync<List<StockRecordInfoDto>> ();

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
    }

   
}

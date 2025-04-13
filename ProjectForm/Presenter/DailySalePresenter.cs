using Project.Application.DTOs;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class DailySalePresenter
    {
        private readonly IDailySaleView _view;
        private readonly HttpClient _httpClient;
        public DailySalePresenter(IDailySaleView view)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            _view = view;
            //_view.KeyDownPressed += OnKeyDownPressed;
            _view.CloseClicked += OnCloseClicked;
            _view.LoadSalesClicked += OnLoadSalesClicked;
            _view.RowNumber += OnRowNumber;
            //LoadSalesAsync();
        }
        private void OnCloseClicked(object? sender, EventArgs e)
        {
            if (Application.OpenForms["DailySale"] is DailySale dailySale)
            {
                dailySale.Dispose();
            }
        }
        private async Task LoadSalesAsync(string startDate, string endDate)
        {
            try
            {
                var res = await _httpClient.GetAsync($"/Sales/All/FilteredBy?startDate={startDate}&endDate={endDate}");

                res.EnsureSuccessStatusCode();

                var sales = await res.Content.ReadFromJsonAsync<List<GetSalesDetailDto>>();

                if (sales == null)
                {
                    return;
                }

                _view.DisplayDailySales(sales);

            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void OnLoadSalesClicked(object? sender, EventArgs e)
        {
            string dateFrom = _view.StartDate.ToString("MM-dd-yyyy");
            string dateTo = _view.EndDate.ToString("MM-dd-yyyy");
            await LoadSalesAsync(dateFrom, dateTo);
        }
        private void OnRowNumber(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) return;

            using(SolidBrush brush = new SolidBrush(gridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString();
                e.Graphics.DrawString(rowNumber, gridView.Font, brush, e.RowBounds.Left + 10, e.RowBounds.Top + 4);
            }
        }

        //private void OnKeyDownPressed(object? sender, KeyEventArgs e)
        //{
        //    if (Application.OpenForms["DailySale"] is DailySale dailysale)
        //    {
        //        if(e.KeyCode == Keys.Escape)
        //        {
        //            dailysale.Dispose();
        //        }
        //    }
        //}
    }
}

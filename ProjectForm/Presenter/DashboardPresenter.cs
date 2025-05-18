using ProjectForm.Http;
using ProjectForm.View.IView;
using ProjectForm.Model.DTOs.SalesDetailDtos;
using ProjectForm.Model.DTOs.StockDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ProjectForm.Error;

namespace ProjectForm.Presenter
{
    public class DashboardPresenter
    {
        private readonly IDashboardView _view;
        private readonly HttpClient _httpClient;
        
        public DashboardPresenter(IDashboardView view)
        {
            _view = view;
            _httpClient = Connection.Instance;
        }
        public async void LoadDailSalesAsync()
        {
            try
            {
                DateOnly date = DateOnly.FromDateTime(DateTime.Now);
                string dateString = date.ToString("MM-dd-yyyy");
                 
                var res = await _httpClient.GetAsync($"/Sales/DailySales/FilteredBY?date={dateString}");

                if (res.IsSuccessStatusCode)
                {
                    var sales = await res.Content.ReadFromJsonAsync<GetDailySalesDto>();

                    if (sales == null)
                    {
                        return;
                    }

                    _view.ShowDailySales(sales.TotalAmount);
                }
                else if(res.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    var errorRes  = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();

                    if(errorRes != null)
                    {
                        MessageBox.Show(errorRes.Error);
                    }             
                }                              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public async void LoadStocksOnHandAsync()
        {
            try
            {
                var res = await _httpClient.GetAsync("/Stocks/count");

                if (res.IsSuccessStatusCode)
                {
                    var count = await res.Content.ReadFromJsonAsync<StockOnHandDto>();

                    if (count == null)
                    {
                        return;
                    }

                    _view.ShowStocksOnHand(count.count);
                }
                else if (res.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    var errorRes = await res.Content.ReadFromJsonAsync<ApiErrorResponse>();

                    if (errorRes != null)
                    {
                        MessageBox.Show(errorRes.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

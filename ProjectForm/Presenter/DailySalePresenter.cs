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
            LoadSalesAsync();
        }
        private void OnCloseClicked(object? sender, EventArgs e)
        {
            if (Application.OpenForms["DailySale"] is DailySale dailySale)
            {
                dailySale.Dispose();
            }
        }

        private void LoadSalesAsync()
        {
            //try
            //{
            //    var res = await _httpClient.GetFromJsonAsync<GetAllSalesByDateDto>($"/Sales/All/FilteredBy?startDate={_view.StartDate}endDate={_view.EndDate}");

            //}
            //catch(Exception ex) 
            MessageBox.Show($"Start Date: {_view.StartDate}---End Date: {_view.EndDate}");  
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

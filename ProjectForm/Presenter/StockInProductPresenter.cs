﻿using ProjectForm.Model.DTOs;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class StockInProductPresenter
    {
        private readonly IStockInProductView _view;
        private readonly HttpClient _httpClient;
        
        public StockInProductPresenter(IStockInProductView view)
        {
            _view = view;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            _view.SelectProductClicked += OnSelectProductClicked;
        }

        public async Task LoadProductList()
        {
            try
            {
                var res = await _httpClient.GetAsync($"/Products/All");

                if (res.IsSuccessStatusCode)
                {
                    var products = await res.Content.ReadFromJsonAsync<List<ProductDto>>();

                    if (products == null)
                    {
                        return;
                    }

                    var _allProducts = products.Select(p => new StockInProductDto
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        ProductQuantity = p.ProductQuantity,
                        ProductCode = p.ProductCode,
                    }).ToList();
                    _view.DisplayProductList(_allProducts);
                }
            }
            catch (HttpRequestException ex)
            {
                _view.ShowMessage(ex.Message);
            }
        }
        private void OnSelectProductClicked(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0)
            {
                return;
            }

            var productId = (Guid)gridView.Rows[e.RowIndex].Cells["ProductId"].Value;
            var productName = (string)gridView.Rows[e.RowIndex].Cells["ProductName"].Value;
            var productCode = (string)gridView.Rows[e.RowIndex].Cells["ProductCode"].Value;
            var productQty = (int)gridView.Rows[e.RowIndex].Cells["ProductQuantity"].Value;

            var confirmResult = MessageBox.Show($"Add this item?", "POS", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            var product = new StockInProductDto
            {
                ProductId = productId,
                ProductName = productName,
                ProductCode =productCode,
                ProductQuantity = productQty,
                
            };

            if (Application.OpenForms["StockEntry"] is StockEntry entry)
            {
                
                entry.presenter?.AddStockEntry(product);
                entry.presenter?.GenerateReference();
            }

        }
    }
}

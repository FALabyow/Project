using ProjectForm.Model;
using ProjectForm.Model.DTOs;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public StockEntryPresenter(IStockEntryView view)
        {
            _view = view;
            _model = new ReferenceModel();
            _view.DeleteClicked += OnDeleteClicked;
        }

        public void GenerateReference()
        {
            newRef = _model.GenerateReferenceNumber();
            _view.DisplayReferenceNumber(newRef);
        }

        public void AddStockEntry(StockInProductDto stockInProduct)
        {
            var stockEntry = new StockInProductDto
            {
                ProductCode = stockInProduct.ProductCode,
                ProductId = stockInProduct.ProductId,
                ProductName = stockInProduct.ProductName,
                ReferenceNum = newRef,
                ProductQuantity = stockInProduct.ProductQuantity,
                StockInDate = DateOnly.FromDateTime(_view.DatePicker.Value)
                
                
            };

            _view.DisplayStockEntry(stockEntry);
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
    }

   
}

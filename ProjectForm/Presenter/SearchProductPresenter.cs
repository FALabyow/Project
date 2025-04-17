using ProjectForm.Model.DTOs;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class SearchProductPresenter
    {
        private readonly CashierPresenter _cashierPresenter;
        private readonly ISearchProductView _view;
        private readonly ICashierView _cashierView;
        public SearchProductPresenter(CashierPresenter cashierPresenter, ISearchProductView view, ICashierView cashierView)
        {
            _cashierPresenter = cashierPresenter;
            _view = view;
            _view.RefreshClicked += OnRefreshClicked;
            _view.RowNumber += OnRowNumber;
            _view.AddToCartClicked += OnAddToCartClicked;
            _cashierView = cashierView;
            _view.ProductSearchTextChanged += OnProductSearchTextChanged;
             
        }

        private async void OnRefreshClicked(object? sender, EventArgs e)
        {
            await _cashierPresenter.LoadAllAvailableProducts();
            _view.DisplayProducts(_cashierPresenter._availableProducts);
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
        private void OnAddToCartClicked(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            
            if (gridView == null || e.RowIndex < 0) { return; }

            string barcode = (string)gridView.Rows[e.RowIndex].Cells["BarcodeData"].Value;
            int productQty = (int)gridView.Rows[e.RowIndex].Cells["ProductQuantity"].Value;
           
            if (_cashierView.ProductExistsInGrid(barcode))
            {
                int currentQty = _cashierView.GetProductQuantityFromGrid(barcode);
                int newQty = currentQty + 1;
                
                if (newQty > productQty)
                {
                    MessageBox.Show("No Available stock");
                    return;
                }
                _cashierView.UpdateProductQuantityInGrid(barcode, newQty);
            }
            else
            {
                var addedToCart = new DisplayAvailableProductsDto
                {
                    StockId = (Guid)gridView.Rows[e.RowIndex].Cells["StockId"].Value,
                    BarcodeData = (string)gridView.Rows[e.RowIndex].Cells["BarcodeData"].Value,
                    ProductName = (string)gridView.Rows[e.RowIndex].Cells["ProductName"].Value,
                    ProductPrice = (decimal)gridView.Rows[e.RowIndex].Cells["ProductPrice"].Value,
                    BuyersQuantity = 1,
                    SubTotal = (decimal)gridView.Rows[e.RowIndex].Cells["ProductPrice"].Value,
                    ProductQuantity = (int)gridView.Rows[e.RowIndex].Cells["ProductQuantity"].Value,
                };

                _cashierView.DisplayProducts(addedToCart);
            }
            

           
        }
        private void OnProductSearchTextChanged(object? sender, EventArgs e)
        {
            string searchText = _view.SearchText;
            var filteredList = _cashierPresenter._availableProducts;

            if (decimal.TryParse(searchText, out decimal price))
            {
                filteredList = _cashierPresenter._availableProducts.Where(c => c.ProductPrice == price).ToList();
            }
            else
            {
                filteredList = _cashierPresenter._availableProducts
                    .Where(
                        c => c.ProductName != null && c.ProductName.ToLower().Contains(searchText) ||
                        c.ProductCode != null && c.ProductCode.ToLower().Contains(searchText)
                    )
                    .ToList();
            }

            _view.DisplayProducts(filteredList);
        }
    }
}

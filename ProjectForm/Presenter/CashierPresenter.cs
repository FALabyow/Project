using Project.Application.DTOs;
using Project.Application.Services;
using ProjectForm.View.IView;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class CashierPresenter
    {
        private readonly ICashierView _view;
        private readonly CashierService _cashierService;
        private List<ProductDto> _allProducts;
        private List<CategoryDto> _allCategories;
        private DataTable _dataTable;

        public CashierPresenter(ICashierView view, CashierService cashierService)
        {
            _view = view;
            _cashierService = cashierService;
            _dataTable = new DataTable();
            _view.DisplayProducts(_dataTable);
            _view.AddRemoveButtonColumn(); // Add the Remove button
        }

        public async Task InitializeAsync()
        {
            _dataTable.Columns.Add("BarcodeData", typeof(string));
            _dataTable.Columns.Add("ProductName", typeof(string));
            _dataTable.Columns.Add("ProductPrice", typeof(decimal));
            _dataTable.Columns.Add("ProductQuantity", typeof(int));
            _dataTable.Columns.Add("CategoryName", typeof(string));

            try
            {
                _allProducts = await _cashierService.GetAllProductsAsync();
                _allCategories = await _cashierService.GetAllCategoriesAsync();
                _view.DisplayProducts(_dataTable);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Failed to load data: {ex.Message}");
            }
        }

        public void SearchProduct(string barcode)
        {
            if (_allProducts == null || _allCategories == null)
            {
               // _view.ShowError("Product or category data is missing.");
                return;
            }

            if (_dataTable.AsEnumerable().Any(row => row.Field<string>("BarcodeData") == barcode))
            {
                //_view.ShowError("This product is already added to the table.");
                return;
            }

            var matchedProducts = _allProducts
                .Where(p => p.BarcodeData == barcode)
                .ToList();

            if (matchedProducts.Count == 0)
            {
            
                return;
            }

            var productWithCategory = matchedProducts.Select(p => new
            {
                p.BarcodeData,
                p.ProductName,
                p.ProductPrice,
                p.ProductQuantity,
                CategoryName = _allCategories.FirstOrDefault(c => c.CategoryId == p.CategoryId)?.CategoryName ?? "Unknown"
            });

            foreach (var product in productWithCategory)
            {
                _dataTable.Rows.Add(product.BarcodeData, product.ProductName, product.ProductPrice, product.ProductQuantity, product.CategoryName);
            }

            _view.DisplayProducts(_dataTable);
            _view.UpdateTotal(matchedProducts.Sum(p => p.ProductPrice));
        }

        public void RemoveProduct(string barcode)
        {
            if (string.IsNullOrEmpty(barcode)) return;

            // Find the row in the DataTable using the barcode
            var rows = _dataTable.AsEnumerable()
                                  .Where(row => row.Field<string>("BarcodeData") == barcode)
                                  .ToList();

            if (rows.Any())
            {
                foreach (var row in rows)
                {
                    _dataTable.Rows.Remove(row);
                }
                _view.DisplayProducts(_dataTable);

                // Update total price
                var remainingProducts = _allProducts
                    .Where(p => _dataTable.AsEnumerable().Any(r => r.Field<string>("BarcodeData") == p.BarcodeData))
                    .ToList();

                _view.UpdateTotal(remainingProducts.Sum(p => p.ProductPrice));
            }
        }
    }
}

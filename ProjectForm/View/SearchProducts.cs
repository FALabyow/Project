using ProjectForm.Model.DTOs.ProductDtos;
using ProjectForm.Presenter;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm
{
    public partial class SearchProducts : Form, ISearchProductView
    {
        private readonly CashierPresenter _cashierPresenter;
        private readonly SearchProductPresenter _searchProductPresenter;
        private readonly ICashierView _view;
        public SearchProducts(CashierPresenter cashierPresenter, ICashierView view)
        {
            InitializeComponent();
            _view = view;
            _cashierPresenter = cashierPresenter;
            _searchProductPresenter = new SearchProductPresenter(_cashierPresenter, this, _view);
            dgvProduct.AutoGenerateColumns = false;
            DisplayProducts(_cashierPresenter._availableProducts);
            dgvProduct.RowPostPaint += DataGridSearchProductView_RowPostPaint;
            dgvProduct.CellContentClick += DataGridSearchProductView_CellContentClick;
            refreshBtn.Click += (s, e) => RefreshClicked?.Invoke(this, EventArgs.Empty);
            txtSearch.TextChanged += (s, e) => ProductSearchTextChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? RefreshClicked;
        public event EventHandler<DataGridViewRowPostPaintEventArgs>? RowNumber;
        public event EventHandler<DataGridViewCellEventArgs>? AddToCartClicked;
        public event EventHandler? ProductSearchTextChanged;
        public void DisplayProducts(List<GetAllAvailableProductsDto> _products)
        {
            dgvProduct.DataSource = _products;
        }
        public string SearchText => txtSearch.Text.ToLower();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void DataGridSearchProductView_RowPostPaint(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) return;

            RowNumber?.Invoke(sender, e);

        }
        private void DataGridSearchProductView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) { return; }

            if (gridView.Columns[e.ColumnIndex].Name == "Select")
            {
                AddToCartClicked?.Invoke(sender, e);
            }

        }
    }
}

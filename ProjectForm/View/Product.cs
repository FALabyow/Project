using ProjectForm.Model.DTOs;
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
    //part 3 of the tutorial
    //https://www.youtube.com/watch?v=9LdU5zA5agA&list=PLcDvtJ2MXvhy_YrXdO4VXqZBOADCRJhSc&index=4
    public partial class Product : Form, IProductView
    {
        private ProductPresenter? presenter;
        public Product()
        {
            InitializeComponent();
            dgvProduct.CellContentClick += DataGridProductView_CellContentClick;
        }
        public event EventHandler<DataGridViewCellEventArgs>? DeleteClicked;
        public event EventHandler<DataGridViewCellEventArgs>? EditClicked;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(presenter != null)
            {
                ProductModule productModule = new ProductModule(presenter);
                productModule.ShowDialog();
            }
            
        }
        public void DisplayProductList(List<ProductDto> productList, int rowNumber)
        {
            dgvProduct.Rows.Clear();
            foreach(var product in productList)
            {
                rowNumber++;

                int rowIndex = dgvProduct
                    .Rows
                    .Add(rowNumber, product.CategoryId, product.ProductCode, product.BarcodeData, product.ProductName, product.CategoryName, product.CategoryId, product.ProductPrice, product.ProductQuantity, product.ProductPreOrder, product.ScannedAt);

                dgvProduct.Rows[rowIndex].Cells["Edit"].Value = Properties.Resources.edit;
                dgvProduct.Rows[rowIndex].Cells["Delete"].Value = Properties.Resources.delete;

            }
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private void DataGridProductView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) return;

            if (gridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteClicked?.Invoke(sender, e);

            }

            if (gridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                EditClicked?.Invoke(sender, e);
            }
        }
        private void Product_Load(object sender, EventArgs e)
        {
            presenter = new ProductPresenter(this);
            presenter.LoadProductList();
        }
    }
}

using Microsoft.EntityFrameworkCore.Query.Internal;
using ProjectForm.Model.DTOs.StockDtos;
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


//part 9 of the turorial
//https://www.youtube.com/watch?v=38DQirrwaIU&list=PLcDvtJ2MXvhy_YrXdO4VXqZBOADCRJhSc&index=9


namespace ProjectForm
{
    public partial class StockInProduct : Form, IStockInProductView
    {
        private BindingSource _bindingSource = new BindingSource();
        private StockInProductPresenter? _presenter;
        public StockInProduct()
        {
            InitializeComponent();
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = _bindingSource;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
        }

        public event EventHandler<DataGridViewCellEventArgs>? SelectProductClicked;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dgvProduct_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0)
            {
                return;
            }

            if (gridView.Columns[e.ColumnIndex].Name == "Select")
            {
                SelectProductClicked?.Invoke(sender, e);

            }
        }
        public void DisplayProductList(List<GetAllStocksDto> productsList)
        {
            _bindingSource.DataSource = productsList;
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                row.Cells["Select"].Value = Properties.Resources.add;
            }
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private async void StockInProduct_Load(object sender, EventArgs e)
        {
            _presenter = new StockInProductPresenter(this);
            await _presenter.LoadProductList();
        }
        private void dgvProduct_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(dgvProduct.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString();
                e.Graphics.DrawString(rowNumber, dgvProduct.Font, brush, e.RowBounds.Left + 10, e.RowBounds.Top + 4);
            }
        }
    }
}

using Project.Application.DTOs.StockDtos;
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

//Part 19 of the tutorial
//https://youtu.be/cltkbMvuQHo?si=7W5-42c1ITNjEcsg


namespace ProjectForm
{
    public partial class StockAdjustments : Form, IStockAdjustmentsView
    {
        private BindingSource _bindingSource = new BindingSource();
        public StockAdjustments()
        {
            InitializeComponent();
            dgvAdjustment.AutoGenerateColumns = false;
            dgvAdjustment.DataSource = _bindingSource;
            dgvAdjustment.CellContentClick += DataGridStockAdjustmentsView_CellContentClick;
            dgvAdjustment.RowPostPaint += DataGridStockAdjustmentsView_RowPostPaint;
            cmbAction.SelectedIndexChanged += (s, e) => SelectedItemCombo?.Invoke(this, EventArgs.Empty);
            btnAdd.Click += (s, e) => SaveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DgvAdjustment_RowPostPaint(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        public string SelectedItem
        {
            get
            {
                return cmbAction.SelectedItem?.ToString() ?? string.Empty;
            }
        }
        public string Barcode
        {
            get => lblBarcode.Text;
            set => lblBarcode.Text = value;
        }
        public string Description
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }
        public string ProductCode
        {
            get => lblPcode.Text;
            set => lblPcode.Text = value;
        }
        public int ProductQuantity
        {
            get
            {
                if(int.TryParse(txtQty.Text, out var quantity))
                {
                    return quantity;
                }
                else
                {
                    return 0;
                }
            }

            set => txtQty.Text = value.ToString();
        }

        public event EventHandler? SelectedItemCombo;
        public event EventHandler<DataGridViewCellEventArgs>? SelectedClicked;
        public event EventHandler? SaveClicked;
        public event EventHandler<DataGridViewRowPostPaintEventArgs>? RowNumber;
        private async void StockAdjustments_Load(object? sender, EventArgs e)
        {
            var presenter = new StockAdjustmentsPresenter(this);
            if(presenter != null)
            {
                await presenter.LoadStocksAsync();
            }
        }
        public void DisplayStocks(List<GetAllStockAdjustmentsDto> stocks)
        {
            _bindingSource.DataSource = stocks;
            foreach (DataGridViewRow row in dgvAdjustment.Rows)
            {
                row.Cells["Select"].Value = Properties.Resources.edit;
            }
        }
        private void DataGridStockAdjustmentsView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            
            if (gridView == null || e.RowIndex < 0) return;

            if (gridView.Columns[e.ColumnIndex].Name == "Select")
            {
                SelectedClicked?.Invoke(sender, e);

            }

        }
        private void DataGridStockAdjustmentsView_RowPostPaint(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) return;

            RowNumber?.Invoke(sender, e);

        }
    }
}

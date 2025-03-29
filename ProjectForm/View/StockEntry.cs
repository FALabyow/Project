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
    //part 8 of the tutorial
    //https://youtu.be/38DQirrwaIU?si=g2XwXaBx19D-AKEA
    public partial class StockEntry : Form, IStockEntryView
    {
        public StockEntryPresenter? presenter;
        public StockEntry()
        {
            InitializeComponent();
            LinProduct.LinkClicked += LinProduct_LinkClicked;
            dataStockIn.AutoGenerateColumns = false;
            dateTimePicker1.ValueChanged += (s, e) => OnDateSelected?.Invoke();
            dgvStockIn.CellContentClick += DataGridProductView_CellContentClick;
            btnLoad.Click += (s, e) => LoadFilteredRecordsClicked?.Invoke(this, EventArgs.Empty);

        }

        public event EventHandler<LinkLabelLinkClickedEventArgs>? LinkLabelLinkClicked;
        public event Action? OnDateSelected;
        public event EventHandler<DataGridViewCellEventArgs>? DeleteClicked;
        public event EventHandler? LoadFilteredRecordsClicked;
        public DateTimePicker DatePicker => dateTimePicker1;
        public DateOnly StartDate => DateOnly.FromDateTime(dateTimePicker2.Value);
        public DateOnly EndDate => DateOnly.FromDateTime(dateTimePicker3.Value);

        public string ReferenceNum
        {
            get => txtRefNo.Text;
            set => txtRefNo.Text = value;
        }

        private void StockEntry_Load(object sender, EventArgs e)
        {
            presenter = new StockEntryPresenter(this);
        }

        public void DisplayReferenceNumber(string referenceNumber)
        {
            txtRefNo.Text = referenceNumber;
        }

        private void LinGenerate_LinkClicked_1(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (presenter != null)
            {
                presenter.GenerateReference();
            }

        }

        private void LinProduct_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRefNo.Text))
            {
                MessageBox.Show("Reference number is empty");
                return;
            }
            var stockInProduct = new StockInProduct();
            stockInProduct.ShowDialog();
        }

        public void DisplayStockEntry(ProductDto stockList)
        {
            dgvStockIn.Rows
                      .Add(dgvStockIn.Rows.Count + 1, stockList.ProductId, stockList.ReferenceNum, stockList.ProductCode, stockList.ProductName, stockList.CategoryName, stockList.ProductQuantity, stockList.StockInDate);
        }
        public void DisplayStockRecords(List<StockRecordInfoDto> filteredRecords)
        {

            dataStockIn.DataSource = filteredRecords;
        }

        private void DataGridProductView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) return;

            if (gridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteClicked?.Invoke(sender, e);

            }
        }
        public List<StockRecordInfoDto> GetStockRecordsFromGrid()
        {
            var stockRecords = new List<StockRecordInfoDto>();

            foreach (DataGridViewRow row in dgvStockIn.Rows)
            {
                if (row.Cells["ProductId"].Value != null && row.Cells["productQty"].Value != null)
                {
                    DateOnly stockInDate = row.Cells["stockInDate"].Value != null &&
                                           DateTime.TryParse(row.Cells["stockInDate"].Value.ToString(), out DateTime tempDate)
                                           ? DateOnly.FromDateTime(tempDate)
                                           : DateOnly.MinValue;

                    stockRecords.Add(new StockRecordInfoDto
                    {
                        ProductId = Guid.TryParse(row.Cells["ProductId"].Value?.ToString(), out Guid productId)
                            ? productId
                            : Guid.Empty,

                        StockInQty = Convert.ToInt32(row.Cells["productQty"].Value),

                        StockInDate = stockInDate,

                        ReferenceNum = row.Cells["referenceNum"].Value?.ToString() ?? string.Empty
                    });
                }
            }

            return stockRecords;
        }

        private async void btnEntry_Click(object sender, EventArgs e)
        {
            if (presenter != null)
            {
                await presenter.SendStockRecordsAsync();
            }

        }

        private void dataStockIn_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(dataStockIn.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString();
                e.Graphics.DrawString(rowNumber, dataStockIn.Font, brush, e.RowBounds.Left + 10, e.RowBounds.Top + 4);
            }
        }
    }
}

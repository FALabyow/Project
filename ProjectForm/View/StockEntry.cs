using ProjectForm.Model.DTOs;
using ProjectForm.Model.DTOs.StockDtos;
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
            //this.Load += (s, e) => StockEntryFormLoad?.Invoke(this, EventArgs.Empty);
            LinProduct.LinkClicked += LinProduct_LinkClicked;
            LinGenerate.LinkClicked += LinGenerate_LinkClicked;
            dataStockIn.AutoGenerateColumns = false;
            dateTimePicker1.ValueChanged += (s, e) => OnDateSelected?.Invoke();
            dgvStockIn.CellContentClick += DataGridProductView_CellContentClick;
            btnLoad.Click += (s, e) => LoadFilteredRecordsClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<LinkLabelLinkClickedEventArgs>? LinkLabelLinkClicked;
        public event Action? OnDateSelected;
        public event EventHandler<DataGridViewCellEventArgs>? DeleteClicked;
        public event EventHandler? LoadFilteredRecordsClicked;
        public event EventHandler<LinkLabelLinkClickedEventArgs>? LinkReferenceClicked;
        public event EventHandler<LinkLabelLinkClickedEventArgs>? LinkProductClicked;
        //public event EventHandler? StockEntryFormLoad;
        public DateTimePicker DatePicker => dateTimePicker1;
        public DateOnly StartDate => DateOnly.FromDateTime(dateTimePicker2.Value);
        public DateOnly EndDate => DateOnly.FromDateTime(dateTimePicker3.Value);
        public string ReferenceNum
        {
            get => txtRefNo.Text;
            set => txtRefNo.Text = value;
        }
        public void DisplayReferenceNumber(string referenceNumber)
        {
            txtRefNo.Text = referenceNumber;
        }
        private void LinGenerate_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkReferenceClicked?.Invoke(sender, e);
        }
        private void LinProduct_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkProductClicked?.Invoke(sender, e);
        }
        public void DisplayStockEntry(AddStockEntryDto stockList)
        {
            dgvStockIn.Rows
                      .Add(dgvStockIn.Rows.Count + 1, stockList.StockId, stockList.ProductId, stockList.ReferenceNum, stockList.ProductCode, stockList.ProductName, stockList.CategoryName, stockList.ProductQuantity, stockList.StockInDate);
        }
        public void DisplayStockRecords(List<StockRecordDto> filteredRecords)
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
        public List<StockRecordDto> GetStockRecordsFromGrid()
        {
            var dgv = dgvStockIn as DataGridView;
            if (presenter != null)
            {
                var rec = presenter.GetStockRecords(dgv);
                return rec;
            }

            return new List<StockRecordDto>();

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
        private async void StockEntry_Load(object sender, EventArgs e)
        {
            presenter = new StockEntryPresenter(this);
            if (presenter != null)
            {
                await presenter.LoadStockRecords();
            }
        }
    }
}

using Project.Application.DTOs.ProductDtos;
using ProjectForm.Model.DTOs;
using ProjectForm.Model.DTOs.ProductDtos;
using ProjectForm.Model.DTOs.StockRecordDtos;
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
    public partial class POSrecord : Form, IPOSrecordView
    {
        private readonly POSrecordPresenter _presenter;
        private DateOnly dateFrom;
        private DateOnly dateTo;
        public string selectedComboBox = string.Empty;
        private List<GetAllCriticalProductsDto> criticalItems = new List<GetAllCriticalProductsDto>();
        private List<GetInventoryListDto> inventoryList = new List<GetInventoryListDto>();
        public POSrecord()
        {
            InitializeComponent();
            _presenter = new POSrecordPresenter(this, this);
            
            cbTopsell.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            //comboBox1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            dtFromtopsell.ValueChanged += DatePickerFrom_ValueChanged;
            dtFromSolditem.ValueChanged += DatePickerFrom_ValueChanged;
            dtFromstockin.ValueChanged += DatePickerFrom_ValueChanged;
            dtTotopsell.ValueChanged += DatePickerTo_ValueChanged;
            dtToSolditem.ValueChanged += DatePickerTo_ValueChanged;
            dtTostockin.ValueChanged += DatePickerTo_ValueChanged;
            btnLoad.Click += ButtonLoad_Clicked;
            btnLoadSolditem.Click += ButtonLoad_Clicked;
            btnLoadstockin.Click += ButtonLoad_Clicked;
            dgvTopselling.RowPostPaint += DataGridPOSrecordView_RowPostPaint;
            dgvStockin.RowPostPaint += DataGridPOSrecordView_RowPostPaint;
            dgvCriticalitem.RowPostPaint += DataGridPOSrecordView_RowPostPaint;
            dgvInventorylist.RowPostPaint += DataGridPOSrecordView_RowPostPaint;
            dgvSolditem.RowPostPaint += DataGridPOSrecordView_RowPostPaint;
        }

        public event EventHandler<DataGridViewRowPostPaintEventArgs>? RowNumber;

        public void DisplayTopSellingItems(List<POSrecordDto1> topSelling)
        {
            dgvTopselling.DataSource = topSelling;
        }
        public void DisplaySoldItems(List<POSrecordDto1> sold)
        {
            dgvSolditem.DataSource = sold;
        }
        public void DisplayCriticalItems(List<GetAllCriticalProductsDto> criticalItems)
        {
            dgvCriticalitem.DataSource = criticalItems;
        }
        public void DisplayInventoryList(List<GetInventoryListDto> inventoryList)
        {
            dgvInventorylist.DataSource = inventoryList;
        }
        public void DisplayStockInHistory(List<GetStockInHistoryDto> stockInHistory)
        {
            dgvStockin.DataSource = stockInHistory;
        }

        public string SelectedItem(ComboBox comboBox)
        {
            return comboBox.SelectedItem?.ToString() ?? string.Empty;
        }
        public DateOnly StartDate(DateTimePicker dateTimePicker)
        {
            return DateOnly.FromDateTime(dateTimePicker.Value);
        }
        public DateOnly EndDate(DateTimePicker dateTimePicker)
        {
            return DateOnly.FromDateTime(dateTimePicker.Value);
        }
        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                selectedComboBox = SelectedItem(comboBox);

            }
        }
        private void DatePickerFrom_ValueChanged(object? sender, EventArgs e)
        {
            if (sender is DateTimePicker dateTimePicker)
            {
                dateTimePicker.Format = DateTimePickerFormat.Short;
                dateFrom = StartDate(dateTimePicker);

            }
        }
        private void DatePickerTo_ValueChanged(object? sender, EventArgs e)
        {
            if (sender is DateTimePicker dateTimePicker)
            {
                dateTimePicker.Format = DateTimePickerFormat.Short;
                dateTo = EndDate(dateTimePicker);

            }
        }
        private async void ButtonLoad_Clicked(object? sender, EventArgs e)
        {

            if (sender is Button button)
            {
                string buttonName = button.Name;
                await _presenter.LoadDataAsync(buttonName, dateFrom, dateTo, selectedComboBox);
            }
        }
        private void DataGridPOSrecordView_RowPostPaint(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) return;

            RowNumber?.Invoke(sender, e);
        }
        private async void POSrecord_Load(object sender, EventArgs e)
        {
            dtFromtopsell.Format = DateTimePickerFormat.Custom;
            dtFromtopsell.CustomFormat = " ";
            dtTotopsell.Format = DateTimePickerFormat.Custom;
            dtTotopsell.CustomFormat = " ";
            dtFromSolditem.Format = DateTimePickerFormat.Custom;
            dtFromSolditem.CustomFormat = " ";
            dtToSolditem.Format= DateTimePickerFormat.Custom;
            dtToSolditem.CustomFormat= " ";
            dtFromstockin.Format = DateTimePickerFormat.Custom;
            dtFromstockin.CustomFormat= " ";
            dtTostockin.Format= DateTimePickerFormat.Custom;
            dtTostockin.CustomFormat = " ";

            if(_presenter != null)
            {
                criticalItems = await _presenter.LoadCriticalItemAsync();
                inventoryList = await _presenter.LoadInventoryListAsync();
                DisplayInventoryList(inventoryList);
                DisplayCriticalItems(criticalItems);
            }
        }
    }
}

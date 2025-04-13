using Project.Application.DTOs;
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
    public partial class DailySale : Form, IDailySaleView
    {
        private readonly BindingSource _bindingSource;
        private readonly DailySalePresenter _presenter;
        public DailySale()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            dgvCashier.DataSource = _bindingSource;
            dgvCashier.AutoGenerateColumns = false;
            _presenter = new DailySalePresenter(this);
            picboxClose.Click += (s, e) => CloseClicked?.Invoke(this, EventArgs.Empty);
            loadSalesBtn.Click += (s, e) => LoadSalesClicked?.Invoke(this, EventArgs.Empty);
            dgvCashier.RowPostPaint += DataGridCashierView_RowPostPaint;
        }

        public event EventHandler? LoadSalesClicked;
        public event EventHandler? CloseClicked;
        public event EventHandler<DataGridViewRowPostPaintEventArgs>? RowNumber;

        public DateOnly StartDate => DateOnly.FromDateTime(dtFrom.Value);
        public DateOnly EndDate => DateOnly.FromDateTime(dtTo.Value);
        public void DisplayDailySales(List<GetSalesDetailDto> sales)
        {
            _bindingSource.DataSource = sales;
        }
        private void DataGridCashierView_RowPostPaint(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            var gridView = sender as DataGridView;
            if(gridView == null || e.RowIndex < 0) return;

            RowNumber?.Invoke(sender, e );
        }

        //private void DailySale_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        this.Dispose();
        //    }
        //}

        //private void picboxClose_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //} 
    }
}

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
            cmbAction.SelectedIndexChanged += (s, e) => SelectedItemCombo?.Invoke(this, EventArgs.Empty);
        }
        public string SelectedItem
        {
            get
            {
                return cmbAction.SelectedItem?.ToString() ?? string.Empty;
            }
        }

        public event EventHandler? SelectedItemCombo;
        private async void StockAdjustments_Load(object sender, EventArgs e)
        {
            var presenter = new StockAdjustmentsPresenter(this);
            if(presenter != null)
            {
                await presenter.LoadStocksAsync();
            }
        }
        public void DisplayStocks(List<ProductDto> stocks)
        {
            _bindingSource.DataSource = stocks;
            foreach (DataGridViewRow row in dgvAdjustment.Rows)
            {
                row.Cells["Select"].Value = Properties.Resources.edit;
            }
        }
    }
}

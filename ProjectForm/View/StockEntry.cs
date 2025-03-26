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
            dateTimePicker1.ValueChanged += (s, e) => OnDateSelected?.Invoke();
            dgvStockIn.CellContentClick += DataGridProductView_CellContentClick;

        }

        public event EventHandler<LinkLabelLinkClickedEventArgs>? LinkLabelLinkClicked;
        public event Action? OnDateSelected;
        public event EventHandler<DataGridViewCellEventArgs>? DeleteClicked;
        public DateTimePicker DatePicker => dateTimePicker1;

        public string ReferenceNum
        {
            get => txtRefNo.Text;
            set => txtRefNo.Text = value;
        }

        public void GetRefNo()
        {
            Random rnd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rnd.Next();
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

        public void DisplayStockEntry(StockInProductDto stockInList)
        {
           
            dgvStockIn.Rows
                      .Add(dgvStockIn.Rows.Count + 1, stockInList.ProductId, stockInList.ReferenceNum, stockInList.ProductCode, stockInList.ProductName, stockInList.ProductQuantity, stockInList.StockInDate);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}

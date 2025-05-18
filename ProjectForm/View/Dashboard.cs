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

namespace ProjectForm.View
{
    public partial class Dashboard : Form, IDashboardView
    {
        private readonly DashboardPresenter _presenter;
       
        public Dashboard()
        {
            InitializeComponent();
            _presenter = new DashboardPresenter(this);
            
        }
        public void ShowDailySales(decimal sales)
        {
            dailySalesLabel.Text = sales.ToString();
        }

        public void ShowStocksOnHand(int total)
        {
            stocksLabel.Text = total.ToString();
        }

        public void ShowCriticalStocksCount(int total)
        {
            criticalProductsLabel.Text = total.ToString();
        }
        public void ShowProductsCount(int total)
        {
            totalProductLabel.Text = total.ToString();  
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (_presenter != null)
            {
                _presenter.LoadDailSalesAsync();
                _presenter.LoadStocksOnHandAsync();
                _presenter?.LoadCriticalStocksCountAsync();
                _presenter?.LoadProductssCountAsync();
            }
        }
    }
}

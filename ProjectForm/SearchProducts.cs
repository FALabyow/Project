using Project.Application.DTOs;
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
    public partial class SearchProducts : Form
    {
        private List<GetAllAvailableProductsDto> _products;
        public SearchProducts(List<GetAllAvailableProductsDto> products)
        {
            InitializeComponent();
            _products = products;
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = _products;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

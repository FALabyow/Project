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
    //part 3 of the tutorial
    //https://www.youtube.com/watch?v=9LdU5zA5agA&list=PLcDvtJ2MXvhy_YrXdO4VXqZBOADCRJhSc&index=4
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule();
            productModule.ShowDialog();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblManageProduct_Click(object sender, EventArgs e)
        {

        }
    }
}

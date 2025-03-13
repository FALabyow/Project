using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//part 9 of the turorial
//https://www.youtube.com/watch?v=38DQirrwaIU&list=PLcDvtJ2MXvhy_YrXdO4VXqZBOADCRJhSc&index=9


namespace ProjectForm
{
    public partial class StockInProduct : Form
    {
        public StockInProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //part 9 of the turorial 26:32
            //https://www.youtube.com/watch?v=38DQirrwaIU&list=PLcDvtJ2MXvhy_YrXdO4VXqZBOADCRJhSc&index=9
           
        }
    }
}

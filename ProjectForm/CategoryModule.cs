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
    public partial class CategoryModule : Form
    {
        public CategoryModule()
        {
            InitializeComponent();
        }

        //Part 2 of the tutorial
        // https://youtu.be/bwLZAB8VT2Y?si=2yvkCOgqmHRAri6S

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtCategoryName.Clear();
        }
    }
}

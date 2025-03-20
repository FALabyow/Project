using ProjectForm.Presenter;
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
        //Part 2 of the tutorial
        // https://youtu.be/bwLZAB8VT2Y?si=2yvkCOgqmHRAri6S
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModule categoryModule = new CategoryModule();
            var presenter = new CategoryModulePresenter(categoryModule);
            categoryModule.ShowDialog();    
        }
    }
}

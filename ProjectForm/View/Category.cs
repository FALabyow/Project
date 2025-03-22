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
    //Part 2 of the tutorial
    // https://youtu.be/bwLZAB8VT2Y?si=2yvkCOgqmHRAri6S
    
    //------------------->Please buhata<---------------------
    //dapat with color ang edit and delete button sa grid
    //pagbutang ug loading na UI para while fetching sa data kay loading ang ma display instead of blank grid
    public partial class Category : Form, ICategoryView
    {
        public int rowNumber = 0;
        public CategoryPresenter presenter;
        public Category()
        {
            InitializeComponent();
        }

        public void DisplayCategoryList(List<CategoryDto> categortList)
        {
            dgvCategory.Rows.Clear();
            foreach (var category in categortList)
            {
                rowNumber++;
                int rowIndex = dgvCategory
                    .Rows
                    .Add(rowNumber, category.CategoryId, category.CategoryName);

                dgvCategory.Rows[rowIndex].Cells["edit"].Value = Properties.Resources.edit;
                dgvCategory.Rows[rowIndex].Cells["delete"].Value = Properties.Resources.delete;
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModule categoryModule = new CategoryModule();
            //var presenter = new CategoryModulePresenter(categoryModule);
            categoryModule.ShowDialog();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            presenter = new CategoryPresenter(this);
            presenter.LoadCategoryList();
        }
    }
}

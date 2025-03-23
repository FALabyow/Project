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
        
        private CategoryPresenter presenter;
        public Category()
        {
            InitializeComponent();
            dgvCategory.CellContentClick += DataGridCategoryView_CellContentClick;
        }

        public void DisplayCategoryList(List<CategoryDto> categortList, int rowNumber)
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
            CategoryModule categoryModule = new CategoryModule(presenter);
            //var presenter = new CategoryModulePresenter(categoryModule);
            categoryModule.ShowDialog();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            presenter = new CategoryPresenter(this);
            presenter.LoadCategoryList();
        }

        public event EventHandler<DataGridViewCellEventArgs> DeleteClicked;
        public event EventHandler<DataGridViewCellEventArgs> EditClicked;

        private void DataGridCategoryView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var gridView = sender as DataGridView;
            if (gridView == null || e.RowIndex < 0) return;

            if (gridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteClicked?.Invoke(sender, e);
                
            }

            if (gridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                EditClicked?.Invoke(sender, e);
            }
        }
    }
}

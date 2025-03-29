using ProjectForm.Model.DTOs;
using ProjectForm.Presenter;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm
{
    public partial class ProductModule : Form, IProductModuleView
    {
        //Part 3 of the tutorial
        //https://www.youtube.com/watch?v=9LdU5zA5agA&list=PLcDvtJ2MXvhy_YrXdO4VXqZBOADCRJhSc&index=4
        private readonly HttpClient _httpClient;
        private Guid _productId;
        private ProductModulePresenter? _presenter;
        private readonly ProductPresenter presenterPresenter;

        public ProductModule(ProductPresenter presenterPresenter)
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            cmbCategory.SelectedIndexChanged += (s, e) => SelectedIndexCategoryCombo?.Invoke(this, EventArgs.Empty);
            btnSave.Click += (s, e) => SaveClicked?.Invoke(this, EventArgs.Empty);
            btnClear.Click += (s, e) => ClearClicked?.Invoke(this, EventArgs.Empty);
            cmbCategory.Text = "Select Category";
            this.presenterPresenter = presenterPresenter;


        }
        private async void ProductModule_Load(object sender, EventArgs e)
        {
            if (_presenter == null)
            {
                _presenter = new ProductModulePresenter(this, presenterPresenter);
            }
            await _presenter.LoadCategoryAsync();
        }

        public event EventHandler? ClearClicked;
        public event EventHandler? SelectedIndexCategoryCombo;
        public event EventHandler? SaveClicked;
        public Guid Selectedcategory
        {
            get
            {
                if (cmbCategory.SelectedValue != null && Guid.TryParse(cmbCategory.SelectedValue.ToString(), out Guid categoryId))
                {
                    return categoryId;
                }
                return Guid.Empty;
            }
        }
        public string Pcode
        {
            get => txtPcode.Text;
            set => txtPcode.Text = value;
        }
        public string Barcode
        {
            get => txtBarcode.Text;
            set => txtBarcode.Text = value;
        }
        public string Description
        {
            get => txtDescription.Text;
            set => txtDescription.Text = value;
        }
        public int ReOrder
        {
            get
            {
                return (int)nudReorder.Value;
            }
            set
            {
                nudReorder.Value = value;
            }
        }
        public decimal Price
        {
            get
            {
                if(decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    return price;
                }
                else
                {
                    return 1m;
                }
            }

            set
            {
                txtPrice.Text = value.ToString("0.00");
            }
        }        
        public void LoadCategory(List<CategoryDto> categoryDto)
        {
            categoryDto.Insert(0, new CategoryDto { CategoryId = Guid.Empty, CategoryName = "Select Category" });
            cmbCategory.DataSource = categoryDto;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = 0;

        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void LoadingMessage(string message)
        {
            categoryLoadingMessageLabel.Text = message;
        }
        public void Clear()
        {
            txtPcode.Text = "";
            txtBarcode.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            nudReorder.Value = 1;
            categoryLoadingMessageLabel.Text = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        
    }
}

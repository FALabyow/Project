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

        public ProductModule()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };
            cmbCategory.SelectedIndexChanged += (s, e) => SelectedIndexCategoryCombo?.Invoke(this, EventArgs.Empty);
            btnSave.Click += (s, e) => SaveClicked?.Invoke(this, EventArgs.Empty);
            btnUpdate.Click += (s, e) => UpdateClicked?.Invoke(this, EventArgs.Empty);
            btnClear.Click += (s, e) => ClearClicked?.Invoke(this, EventArgs.Empty);

        }
        public event EventHandler ClearClicked;
        public event EventHandler SelectedIndexCategoryCombo;
        public event EventHandler SaveClicked;
        public event EventHandler UpdateClicked;
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
        public int Preorder
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

        public int Quantity
        {
            get
            {
                if(int.TryParse(textQty.Text, out int quantity))
                {
                    return quantity;
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                textQty.Text = value.ToString();
            }
        }
        public void LoadCategory(List<CategoryDto> categoryDto)
        {
            cmbCategory.DataSource = categoryDto;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

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
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void ProductModule_Load(object sender, EventArgs e)
        {
            var presenter = new ProductModulePresenter(this);
            //Debug.WriteLine("loading...");
            await presenter.LoadCategoryAsync();
        }
    }
}

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

        }
        public event EventHandler ClearClicked;
        public event EventHandler SelectedIndexCategoryCombo;
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            decimal price;
            if (decimal.TryParse(txtPrice.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out price))
            {
                Debug.WriteLine($"Converted Price: {price}");
            }
            else
            {
                Debug.WriteLine("Invalid input.");
            }
            int preOrderValue = (int)nudReorder.Value;
            var Product = new AddProductDto
            {
                BarcodeData = txtBarcode.Text,
                ProductName = txtDescription.Text,
                ProductPrice = price,
                ScannedAt = DateTime.Now,
                ProductPreOrder = preOrderValue,
                CategoryId = _productId,

            };

            var json = JsonSerializer.Serialize(Product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/Product/AddProduct", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine("Error Adding Category");
            }
            Debug.WriteLine(_productId);
        }

        private async void ProductModule_Load(object sender, EventArgs e)
        {
            var presenter = new ProductModulePresenter(this);
            //Debug.WriteLine("loading...");
            await presenter.LoadCategoryAsync();
        }
    }
}

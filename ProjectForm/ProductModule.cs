using ProjectForm.Model.DTOs;
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
    public partial class ProductModule : Form
    {
        //Part 3 of the tutorial
        //https://www.youtube.com/watch?v=9LdU5zA5agA&list=PLcDvtJ2MXvhy_YrXdO4VXqZBOADCRJhSc&index=4
        private readonly HttpClient _httpClient;
        private Guid _productId;
        public ProductModule()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };

        }

        public void Clear()
        {
            txtPcode.Text = "";
            txtBarcode.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            nudReorder.Value = 1;
        }

        private async void ProductModule_Load(object sender, EventArgs e)
        {

            await LoadCategoriesAsync();
        }

        private async Task LoadCategoriesAsync()
        {
            var response = await _httpClient.GetAsync("/Categories/All");

            if(response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var categories = JsonSerializer.Deserialize<List<CategoryDto>>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (categories != null && categories.Count > 0)
                {
                    cmbCategory.DataSource = categories;
                    cmbCategory.DisplayMember = nameof(CategoryDto.CategoryName); 
                    cmbCategory.ValueMember = nameof(CategoryDto.CategoryId); 
                }
                else
                {
                    Debug.WriteLine("No categories found.");
                }
            }
            else
            {
                Debug.WriteLine($"Error: {response.StatusCode}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem is CategoryDto selectedCategory)
            {
                Debug.WriteLine($"Selected Category: {selectedCategory.CategoryName} (ID: {selectedCategory.CategoryId})");
                _productId = selectedCategory.CategoryId;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}

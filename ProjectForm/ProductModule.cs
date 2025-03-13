using ProjectForm.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

            if(response != null)
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
                    MessageBox.Show("No categories found.");
                }
            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode}");
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
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Product Saved!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm
{
    public partial class CategoryModule : Form
    {
        private readonly HttpClient _httpClient;
        public CategoryModule()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7014/api") };

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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var category = new
            {
                CategoryName = txtCategoryName.Text,
            };

            var json = JsonSerializer.Serialize(category);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/Category/AddCategory", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine("Error Adding Category");
            }
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

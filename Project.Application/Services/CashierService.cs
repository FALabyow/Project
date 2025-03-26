using System.Net.Http.Json;
using Project.Application.DTOs;

namespace Project.Application.Services
{
    public class CashierService
    {
        private readonly HttpClient _httpClient;

        public CashierService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            var response = await _httpClient.GetAsync("/Products/All");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<ProductDto>>() ?? new List<ProductDto>();
        }

        public async Task<List<CategoryDto>> GetAllCategoriesAsync()
        {
            var response = await _httpClient.GetAsync("/Categories/All");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<CategoryDto>>() ?? new List<CategoryDto>();
        }
    }
}



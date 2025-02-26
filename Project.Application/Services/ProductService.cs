using Project.Application.DTOs;
using Project.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(b => new ProductDTO
            {
                Id = b.Id,
                Name = b.Name,
                Price = b.Price,
                CategoryId = b.CategoryId

            }).ToList();
        }
    }
}

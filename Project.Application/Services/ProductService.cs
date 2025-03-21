using Project.Application.DTOs;
using Project.Application.Interfaces;
using Project.Domain.Entities;
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
        public async Task<List<ProductDto>> GetAllProductAsync()
        {
            var products = await _productRepository.GetAllProductAsync();
            return products.Select(b => new ProductDto
            {
                ProductId = b.ProductId,
                BarcodeData = b.BarcodeData,
                CategoryId = b.CategoryId,
                ProductName = b.ProductName,
                ProductPreOrder = b.ProductPreOrder,
                ProductPrice = b.ProductPrice,
                ProductQuantity = b.ProductQuantity,
                ScannedAt = b.ScannedAt,
            }).ToList();
        }
        public async Task AddProductAsync(ProductInfoDto productInfoDto)
        {
            try
            {
                var product = new Product
                {
                    BarcodeData = productInfoDto.BarcodeData,
                    CategoryId = productInfoDto.CategoryId,
                    ProductName = productInfoDto.ProductName,
                    ScannedAt = productInfoDto.ScannedAt,
                    ProductPreOrder = productInfoDto.ProductPreOrder,
                    ProductPrice = productInfoDto.ProductPrice,
                    ProductQuantity = productInfoDto.ProductQuantity,
                    ProductCode = productInfoDto.ProductCode,

                };

                await _productRepository.AddProductAsync(product);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            
            
        }
    }
}

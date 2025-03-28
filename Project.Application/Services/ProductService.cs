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
        //public ProductService(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}
        //public async Task<List<ProductDto>> GetAllProductAsync()
        //{
        //    try
        //    {
        //        var products = await _productRepository.GetAllProductAsync();
        //        if(!products.Any())
        //            throw new InvalidOperationException("No products found in the database!");
        //        return products.Select(b => new ProductDto
        //        {
        //            ProductId = b.ProductId,
        //            BarcodeData = b.BarcodeData,
        //            CategoryId = b.CategoryId,
        //            ProductName = b.ProductName,
        //            ProductPreOrder = b.ProductPreOrder,
        //            ProductPrice = b.ProductPrice,
        //            ProductQuantity = b.ProductQuantity,
        //            ScannedAt = b.ScannedAt,
        //            CategoryName = b.Category.CategoryName,
        //            ProductCode = b.ProductCode,
        //        }).ToList();

        //    }
        //    catch (InvalidOperationException)
        //    {
        //        throw;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new InvalidOperationException("Unexpected error in service layer", ex);
        //    }


        //}
        //public async Task AddProductAsync(ProductInfoDto productInfoDto)
        //{
        //    try
        //    {
        //        var product = new Product
        //        {
        //            BarcodeData = productInfoDto.BarcodeData,
        //            CategoryId = productInfoDto.CategoryId,
        //            ProductName = productInfoDto.ProductName,
        //            ScannedAt = productInfoDto.ScannedAt,
        //            ProductPreOrder = productInfoDto.ProductPreOrder,
        //            ProductPrice = productInfoDto.ProductPrice,
        //            ProductQuantity = productInfoDto.ProductQuantity,
        //            ProductCode = productInfoDto.ProductCode,

        //        };

        //        await _productRepository.AddProductAsync(product);
        //    }
        //    catch (InvalidOperationException)
        //    {
        //        throw;
        //    }
            
            
        //}
        //public async Task<ProductDto> GetProductByIdAsync(Guid id)
        //{
        //    try
        //    {
        //        var product = await _productRepository.GetProductByIdAsync(id);
        //        return new ProductDto
        //        {
        //            ProductId = product.ProductId,
        //        };
        //    }
        //    catch (KeyNotFoundException)
        //    {
        //        throw;
        //    }

        //}
        //public async Task DeleteProductAsync(Guid id)
        //{
        //    try
        //    {

        //        await _productRepository.DeleteProductAsync(id);
        //    }
        //    catch (InvalidOperationException)
        //    {
        //        throw;
        //    }
        //}
        //public async Task UpdateProductAsync(UpdateProductDto productDto)
        //{
        //    try
        //    {
        //        var product = await _productRepository.GetProductByIdAsync(productDto.ProductId);

        //        product.ProductName = productDto.ProductName;
        //        product.ProductPrice = productDto.ProductPrice;
        //        product.ProductPreOrder = productDto.ProductPreOrder;
        //        product.ProductQuantity = productDto.ProductQuantity;

        //        await _productRepository.UpdateProductAsync(product);
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        throw;
        //    }
        //    catch (InvalidOperationException)
        //    {
        //        throw;
        //    }
        //}
    }
}

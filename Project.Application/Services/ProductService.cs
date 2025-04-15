using Project.Application.DTOs;
using Project.Application.Interfaces;
using Project.Domain.Entities;
using ProjectForm.Model.DTOs;

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
            try
            {
                var products = await _productRepository.GetAllProductAsync();
                //if (!products.Any())
                //    throw new InvalidOperationException("No products found in the database!");
  
                return products.Select(b => new ProductDto
                {
                    ProductId = b.ProductId,    
                    ProductCode = b.ProductCode,
                    BarcodeData = b.BarcodeData,
                    ProductName = b.ProductName,
                    ProductPrice = b.ProductPrice,
                    ProductReOrder = b.ProductReOrder,
                    ScannedAt = b.ScannedAt,
                    CategoryId = b.CategoryId,
                    CategoryName = b.Category?.CategoryName,
                    ProductQuantity = b.Stock?.ProductQuantity ?? 0
                }).ToList();

            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }


        }
        public async Task<List<ProductDto>> GetAllCriticalProductAsync()
        {
            try
            {
                var products = await _productRepository.GetAllProductAsync();
                //if (!products.Any())
                //    throw new InvalidOperationException("No products found in the database!");

                return products
                       .Where(b => b.Stock != null && b.Stock.ProductQuantity <= b.ProductReOrder)
                       .Select(b=> new ProductDto
                       {
                           ProductCode = b.ProductCode,
                           BarcodeData = b.BarcodeData,
                           ProductName = b.ProductName,
                           ProductPrice = b.ProductPrice,
                           ProductReOrder = b.ProductReOrder,
                           CategoryName = b.Category?.CategoryName,
                           ProductQuantity = b.Stock?.ProductQuantity ?? 0
                       })
                       .ToList();   

            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<GetInventoryListDto>> GetAllInventoryListAsync()
        {
            try
            {
                var products = await _productRepository.GetAllProductAsync();
                //if (!products.Any())
                //    throw new InvalidOperationException("No products found in the database!");

                return products
                       .Where(b => b.Stock != null && b.Stock.ProductQuantity >= 1)
                       .Select(b => new GetInventoryListDto
                       {
                           ProductCode = b.ProductCode,
                           BarcodeData = b.BarcodeData,
                           ProductName = b.ProductName,
                           ProductPrice = b.ProductPrice,
                           ProductReOrder = b.ProductReOrder,
                           CategoryName = b.Category?.CategoryName,
                           ProductQuantity = b.Stock?.ProductQuantity ?? 0
                       })
                       .ToList();

            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task AddProductAsync(ProductDto productDto)
        {
            try
            {
                var product = new Product
                { 
                    ProductId = productDto.ProductId,
                    ProductCode = productDto.ProductCode,
                    BarcodeData = productDto.BarcodeData,
                    ProductName = productDto.ProductName,
                    ProductPrice = productDto.ProductPrice,
                    ProductReOrder = productDto.ProductReOrder,
                    ScannedAt = productDto.ScannedAt,
                    CategoryId = productDto.CategoryId,
                };

                await _productRepository.AddProductAsync(product);
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }


        }
        public async Task<ProductDto> GetProductByIdAsync(Guid id)
        {
            try
            {
                var product = await _productRepository.GetProductByIdAsync(id);
                return new ProductDto
                {
                    ProductId = product.ProductId,
                };
            }
            catch (KeyNotFoundException)
            {
                throw;
            }

        }
        public async Task UpdateProductAsync(ProductDto productDto)
        {
            try
            {
                var product = await _productRepository.GetProductByIdAsync(productDto.ProductId);

                product.ProductName = productDto.ProductName;
                product.ProductPrice = productDto.ProductPrice;
                product.ProductReOrder = productDto.ProductReOrder;

                await _productRepository.UpdateProductAsync(product);
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }
        public async Task DeleteProductAsync(Guid id)
        {
            try
            {
               await _productRepository.DeleteProductAsync(id);
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }
        
    }
}

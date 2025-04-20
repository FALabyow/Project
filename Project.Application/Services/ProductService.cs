using Project.Application.DTOs.ProductDtos;
using Project.Application.Interfaces;
using Project.Domain.Entities;

namespace Project.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<GetAllProductDto>> GetAllProductAsync()
        {
            try
            {
                var products = await _productRepository.GetAllProductAsync();
                //if (!products.Any())
                //    throw new InvalidOperationException("No products found in the database!");
  
                return products.Select(b => new GetAllProductDto
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
        public async Task<List<GetAllCriticalProductsDto>> GetAllCriticalProductAsync()
        {
            try
            {
                var products = await _productRepository.GetAllProductAsync();
                //if (!products.Any())
                //    throw new InvalidOperationException("No products found in the database!");

                return products
                       .Where(b => b.Stock != null && b.Stock.ProductQuantity <= b.ProductReOrder)
                       .Select(b=> new GetAllCriticalProductsDto
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
        public async Task<List<GetAllAvailableProductsDto>> GetAllAvailableProductsAsync()
        {
            try
            {
                var products = await _productRepository.GetAllProductAsync();
                //if (!products.Any())
                //    throw new InvalidOperationException("No products found in the database!");

                return products
                       .Where(b => b.Stock != null && b.Stock.ProductQuantity >= 1)
                       .Select(b => new GetAllAvailableProductsDto
                       {
                           
                           StockId = b.Stock?.StockId ?? Guid.Empty,
                           ProductCode = b.ProductCode,
                           BarcodeData = b.BarcodeData,
                           ProductName = b.ProductName,
                           ProductPrice = b.ProductPrice,
                           ProductCategory = b.Category?.CategoryName,
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
        public async Task AddProductAsync(AddProductDto addProductDto)
        {
            try
            {
                var product = new Product
                { 
                    ProductId = addProductDto.ProductId,
                    ProductCode = addProductDto.ProductCode,
                    BarcodeData = addProductDto.BarcodeData,
                    ProductName = addProductDto.ProductName,
                    ProductPrice = addProductDto.ProductPrice,
                    ProductReOrder = addProductDto.ProductReOrder,
                    ScannedAt = addProductDto.ScannedAt,
                    CategoryId = addProductDto.CategoryId,
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
        public async Task UpdateProductAsync(UpdateProductDto updateproductDto)
        {
            try
            {
                var product = await _productRepository.GetProductByIdAsync(updateproductDto.ProductId);

                product.ProductName = updateproductDto.ProductName;
                product.ProductPrice = updateproductDto.ProductPrice;
                product.ProductReOrder = updateproductDto.ProductReOrder;

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

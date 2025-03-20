using Project.Application.DTOs;
using Project.Application.Interfaces;
using Project.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Project.Application.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<CategoryDto>> GetAllCategoryAsync()
        {
            try
            {
                var categories = await _categoryRepository.GetAllCategoryAsync();
                if (!categories.Any())
                    throw new InvalidOperationException("No categories found in the database!");

                return categories.Select(b => new CategoryDto
                {
                    CategoryId = b.CategoryId,
                    CategoryName = b.CategoryName,
                }).ToList();
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Unexpected error in service layer", ex);
            }
        }

        public async Task AddCategoryAsync(CategoryInfoDto categoryInfoDto)
        {
            var category = new Category
            {
                CategoryName = categoryInfoDto.CategoryName,
            };

            try
            {
                await _categoryRepository.AddCategoryAsync(category);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            


        }
    }
}

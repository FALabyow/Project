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
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<CategoryDto>> GetAllCategoryAsync()
        {
            var categories = await _categoryRepository.GetAllCategoryAsync();
            return categories.Select(b => new CategoryDto
            {
                CategoryId = b.CategoryId,
                CategoryName = b.CategoryName,
            }).ToList();
        }
        public async Task AddCategoryAsync(CategoryInfoDto categoryInfoDto)
        {
            var category = new Category
            {
                CategoryName = categoryInfoDto.CategoryName,
            };

            await _categoryRepository.AddCategoryAsync(category);
        }
    }
}

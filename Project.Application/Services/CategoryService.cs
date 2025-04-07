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
                //if (!categories.Any())
                //    throw new InvalidOperationException("No categories found in the database!");

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
        public async Task<CategoryDto> GetCategoryByIdAsync(Guid id)
        {
            try
            {
                var category = await _categoryRepository.GetCategoryByIdAsync(id);
                return new CategoryDto
                {
                    CategoryId = category.CategoryId,
                };
            }
            catch (KeyNotFoundException)
            {
                throw;
            }

        }
        public async Task AddCategoryAsync(CategoryDto categoryDto)
        {
            var category = new Category
            {
                CategoryName = categoryDto.CategoryName,
            };

            try
            {
                await _categoryRepository.AddCategoryAsync(category);
            }
            catch(ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            


        }
        public async Task UpdateCategoryAsync(CategoryDto categoryDto)
        {
            try
            {
                var category = await _categoryRepository.GetCategoryByIdAsync(categoryDto.CategoryId);

                category.CategoryName = categoryDto.CategoryName;

                await _categoryRepository.UpdateCategoryAsync(category);
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }  
        public async Task DeleteCategoryAsync(Guid id)
        {
            try
            {

                await _categoryRepository.DeleteCategoryAsync(id);
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

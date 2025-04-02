using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces;
using Project.Domain.Entities;
using Project.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProjectDbContext _context;
        public CategoryRepository(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetAllCategoryAsync()
        {
            try
            {
                var res = await _context.Categories.ToListAsync();
                return res;
            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
            {
                throw new InvalidOperationException("Database does not exist or access denied!", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while fetching categories.", ex);
            }
        }

        public async Task<Category> GetCategoryByIdAsync(Guid id)
        {
            var category = await _context.Categories.FindAsync(id) ?? throw new KeyNotFoundException("Category name does not exist");
            return category;
        }
        public async Task AddCategoryAsync(Category category)
        {
            try
            {
                if(category == null)
                {
                    throw new ArgumentNullException(nameof(category), "The object cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(category.CategoryName))
                {
                    throw new ArgumentException("Category name cannot be null or empty.", nameof(category.CategoryName));
                }
                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                {
                    throw new InvalidOperationException("Duplicate category name detected!" + ex.Message);
                }

                throw new InvalidOperationException("Error saving categorty! " + ex.Message);

            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
            {
                throw new InvalidOperationException("Database does not exist: " + ex.Message);
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException("An error occurred while adding category." + ex.Message);
            }
           
        }
        public async Task UpdateCategoryAsync(Category category)
        {
            try
            {
                if(string.IsNullOrEmpty(category.CategoryName))
                {
                    throw new ArgumentException(nameof(category), "Category cannot be empty");
                }

                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException ex)
            {
                throw new InvalidOperationException("The category cannot be updated because the name already exists. " + ex.Message);
            }
           
        }
        public async Task DeleteCategoryAsync(Guid id)
        {
            try
            {
                var category = await _context.Categories.FindAsync(id);
                if (category == null)
                {
                    throw new KeyNotFoundException("Category name cannot be found!");
                }

                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("Unable to delete the category because it has related products. Please delete or reassign the products before deleting the category: " + ex.Message);
            }
        }

    }
}

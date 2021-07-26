using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class CategoryRepository : ICategory
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public CategoryRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public async Task AddCategory(Category category)
        {
            using var context = DbFactory.CreateDbContext();
            context.Category.Add(category);
            await context.SaveChangesAsync();
        }

        public void DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class IngredientCategoryRepository : IIngredientCategory
    {
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public IngredientCategoryRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public async Task<List<IngredientCategory>> GetAll()
        {
            return await DbFactory.CreateDbContext().IngredientCategory.ToListAsync();
        }
    }
}

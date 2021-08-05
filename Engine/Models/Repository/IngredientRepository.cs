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
    public class IngredientRepository : IIngredient
    {
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public IngredientRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public async Task<List<Ingredient>> GetByCategory(IngredientCategory category)
        {
            return await DbFactory.CreateDbContext().Ingredient.Where(i => i.Category == category).ToListAsync();
        }

        public async Task CreateIngredient(Ingredient ingredient)
        {
            var context = DbFactory.CreateDbContext();
            context.Ingredient.Add(ingredient);
            await context.SaveChangesAsync();
        }

        public async Task UpdateIngredient(Ingredient ingredient)
        {
            var context = DbFactory.CreateDbContext();
            context.Ingredient.Update(ingredient);
            await context.SaveChangesAsync();
        }

        public async Task DeleteIngredients(List<Ingredient> ingredients)
        {
            var context = DbFactory.CreateDbContext();
            context.Ingredient.RemoveRange(ingredients);
            await context.SaveChangesAsync();
        }
    }
}

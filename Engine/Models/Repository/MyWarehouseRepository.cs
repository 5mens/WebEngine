using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class MyWarehouseRepository : IMyWarehouse
    {
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public MyWarehouseRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public async Task<MyWarehouse> GetUserWarehouse(User user)
        {
            return await DbFactory.CreateDbContext().Warehouse.Where(i => i.User == user).FirstOrDefaultAsync();
        }

        public void CreateUserWarehouse(MyWarehouse warehouse)
        {
            var context = DbFactory.CreateDbContext();
            context.Warehouse.Add(warehouse);
            context.SaveChanges();
        }

        public async Task UpdateUserWarehouse(MyWarehouse warehouse)
        {
            var context = DbFactory.CreateDbContext();
            context.Warehouse.Update(warehouse);
            await context.SaveChangesAsync();
        }

        public async Task<IList<UserIngredient>> GetUserIngredients(MyWarehouse warehouse)
        {
            return await DbFactory.CreateDbContext().UserIngredient.Where(i => i.MyWarehouse.Id == warehouse.Id).ToListAsync();
        }

        public async Task UpdateUserIngredient(UserIngredient ingredient)
        {
            var context = DbFactory.CreateDbContext();
            context.UserIngredient.Update(ingredient);
            await context.SaveChangesAsync();
        }

        public Ingredient GetIngredient(int id) {
            return DbFactory.CreateDbContext().UserIngredient.Where(p => p.Id == id).FirstOrDefault().Ingredient;
        }
    }
}

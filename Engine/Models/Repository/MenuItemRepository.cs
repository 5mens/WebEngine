using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class MenuItemRepository : IMenuItem
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public MenuItemRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public async Task<List<MenuItem>> GetMenuItemsById(int id)
        {
            var context = DbFactory.CreateDbContext();
            return await context.MenuItem.Where(p => p.MenuId == id).ToListAsync();
        }
        public async Task AddNewMenuItem(MenuItem menuItem)
        {
            var context = DbFactory.CreateDbContext();
            context.MenuItem.Add(menuItem);
            await context.SaveChangesAsync();
        }

        public async Task DeleteMenuItem(List<MenuItem> menu)
        {
            var context = DbFactory.CreateDbContext();
            foreach (var item in menu)
            {
                context.MenuItem.Remove(item);
            }
            await context.SaveChangesAsync();
        }
        public async Task<MenuItem> GetMenuItem(int id)
        {
            var context = DbFactory.CreateDbContext();
            return await context.MenuItem.Where(p => p.Id == id).FirstOrDefaultAsync();
        }
        public async Task UpdateMenuItem(MenuItem menuItem)
        {
            var context = DbFactory.CreateDbContext();
            context.Update(menuItem);
            await context.SaveChangesAsync();
        }
    }
}

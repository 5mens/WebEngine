using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class MenuRepository : IMenu
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public MenuRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }
        public async Task<List<Menu>> GetMenus()
        {
            var context = DbFactory.CreateDbContext();
            return await context.Menu.ToListAsync();
        }

        public async Task AddNewMenu(Menu menu)
        {
            var context = DbFactory.CreateDbContext();
            context.Menu.Add(menu);
            await context.SaveChangesAsync();
        }

        public async Task DeleteMenu(List<Menu> menu)
        {
            var context = DbFactory.CreateDbContext();
            foreach (var item in menu)
            {
                context.Menu.Remove(item);
            }            
            await context.SaveChangesAsync();
        }

        public async Task<Menu> GetMenu(int id)
        {
            var context = DbFactory.CreateDbContext();
            return await context.Menu.Where(p => p.Id == id).FirstOrDefaultAsync();
        }
        public Menu GetMainMenu()
        {
            var context = DbFactory.CreateDbContext();
            return context.Menu.Where(p => p.IsMain == true).First();
        }

        public async Task UpdateMenu(Menu menu)
        {
            var context = DbFactory.CreateDbContext();
            context.Update(menu);
            await context.SaveChangesAsync();
        }
    }
}

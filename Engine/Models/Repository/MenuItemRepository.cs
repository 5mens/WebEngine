using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;

namespace Engine.Models.Repository
{
    public class MenuItemRepository : IMenuItem
    {
        private readonly IDbContextFactory<AppDbContext> DbFactory;

        public MenuItemRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        //Необходимо отладить
        public IEnumerable<MenuItem> GetMenuItemsById(int id) => null; //applicationDbContext.MenuItem.Where(p => p.MenuId == id).Include(c => c.Menu);

        public MenuItem GetMenuItem(int id) => null;//applicationDbContext.MenuItem.FirstOrDefault(p => p.Id == id);
    }
}

using EngineModels.Models.Menus;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using EngineModels.Interfaces.Menus;
using EngineModels;

namespace EngineModel.Repository.Menus
{
    public class MenuItemRepository : IMenuItem
    {
        private readonly ApplicationDbContext applicationDbContext;
        public MenuItemRepository(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }

        //Необходимо отладить
        public IEnumerable<MenuItem> GetMenuItemsById(int id) => applicationDbContext.MenuItem.Where(p => p.MenuId == id).Include(c => c.Menu);

        public MenuItem GetMenuItem(int id) => applicationDbContext.MenuItem.FirstOrDefault(p => p.Id == id);
    }
}

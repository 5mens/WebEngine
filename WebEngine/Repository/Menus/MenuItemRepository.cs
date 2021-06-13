using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEngine.Data;
using WebEngine.Interfaces.Menus;
using WebEngine.Models.Menus;

namespace WebEngine.Repository.Menus
{
    public class MenuItemRepository : IMenuItem
    {
        private readonly ApplicationDbContext applicationDbContext;
        public MenuItemRepository(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }
        //Необходимо отладить
        public IEnumerable<MenuItem> AllMenuItemsById(int id) => applicationDbContext.MenuItem.Where(p => p.MenuId == id).Include(c => c.Menu);

        public MenuItem MenuItem(int id) => applicationDbContext.MenuItem.FirstOrDefault(p => p.Id == id);
    }
}

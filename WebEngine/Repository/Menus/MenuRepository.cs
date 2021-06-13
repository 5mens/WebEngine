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
    public class MenuRepository : IMenu
    {
        private readonly ApplicationDbContext applicationDbContext;
        public MenuRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Menu> AllMenus => applicationDbContext.Menu;

        public void AddNewMenu(string title, string desc, string menutype)
        {
            throw new NotImplementedException();
        }

        public void DeleteMenu(int id)
        {
            throw new NotImplementedException();
        }

        public Menu GetMenu(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMenu(int id, string title, string desc, string menutype)
        {
            throw new NotImplementedException();
        }
    }
}

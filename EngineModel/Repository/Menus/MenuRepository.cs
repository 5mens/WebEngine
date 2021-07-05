using EngineModel.Models.Menus;
using System;
using System.Collections.Generic;
using WebEngine.Interfaces.Menus;

namespace EngineModel.Repository.Menus
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

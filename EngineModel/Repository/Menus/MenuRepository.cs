using EngineModels.Models.Menus;
using System;
using System.Collections.Generic;
using EngineModels.Interfaces.Menus;

namespace EngineModels.Repository.Menus
{
    public class MenuRepository : IMenu
    {
        private readonly ApplicationDbContext applicationDbContext;
        public MenuRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Menu> GetMenus => applicationDbContext.Menu;

        public void AddNewMenu(Menu menu)
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

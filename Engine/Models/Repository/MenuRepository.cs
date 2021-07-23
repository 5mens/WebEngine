using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class MenuRepository : IMenu
    {
        private readonly IDbContextFactory<AppDbContext> DbFactory;

        public MenuRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }
        //Некорректная реализация
        public async Task<List<Menu>> GetMenus()
        {
            var context = DbFactory.CreateDbContext();            
            return await context.Menu.ToListAsync();
        }

        public async Task AddNewMenu(Menu menu)
        {
            using var context = DbFactory.CreateDbContext();
            context.Menu.Add(menu);
            await context.SaveChangesAsync();
        }

        public void DeleteMenu(List<Menu> menu)
        {
            //throw new NotImplementedException();
        }

        public Menu GetMenu(int id)
        {
            //throw new NotImplementedException();
            return null;
        }

        public void UpdateMenu(int id, string title, string desc, string menutype)
        {
            //throw new NotImplementedException();
        }


    }
}

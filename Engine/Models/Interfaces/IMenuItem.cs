using Engine.Models.BaseClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Models.Interfaces
{
    interface IMenuItem
    {
        /// <summary>
        /// Получить элементы меню по Id
        /// </summary>
        Task<List<MenuItem>> GetMenuItemsById(int id);
        /// <summary>
        /// Добавить новый элемент меню
        /// </summary>
        Task AddNewMenuItem(MenuItem menuItem);
        /// <summary>
        /// Удаление элементов меню
        /// </summary>
        Task DeleteMenuItem(List<MenuItem> menu);
        /// <summary>
        /// Получить элемент меню по его Id
        /// </summary>       
        Task<MenuItem> GetMenuItem(int id);
        /// <summary>
        /// Изменить элемент меню
        /// </summary>        
        Task UpdateMenuItem(MenuItem menuItem);
    }
}
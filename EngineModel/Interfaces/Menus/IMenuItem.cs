using EngineModels.Models.Menus;
using System.Collections.Generic;

namespace EngineModels.Interfaces.Menus
{
    interface IMenuItem
    {
        /// <summary>
        /// Получить элементы меню по Id
        /// </summary>
        IEnumerable<MenuItem> GetMenuItemsById(int id);
        /// <summary>
        /// Получить элемент меню по его Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MenuItem GetMenuItem(int id);
    }
}
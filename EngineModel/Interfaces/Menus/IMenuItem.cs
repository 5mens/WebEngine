using EngineModel.Models.Menus;
using System.Collections.Generic;

namespace WebEngine.Interfaces.Menus
{
    interface IMenuItem
    {
        /// <summary>
        /// Получить элементы меню по Id
        /// </summary>
        IEnumerable<MenuItem> AllMenuItemsById(int id);
        /// <summary>
        /// Получить элемент меню по его Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MenuItem MenuItem(int id);
    }
}
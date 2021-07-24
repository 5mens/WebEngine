using Engine.Models.BaseClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Models.Interfaces
{
    interface IMenu
    {
        /// <summary>
        /// Получить все меню
        /// </summary>
        Task<List<Menu>> GetMenus();
        /// <summary>
        /// Получить меню по его Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Menu> GetMenu(int id);
        /// <summary>
        /// Добавить новое меню
        /// </summary>
        /// <param name="title">Наименование</param>
        Task AddNewMenu(Menu menu);
        /// <summary>
        /// Удаление меню по Id
        /// </summary>
        /// <param name="id">Идентификатор</param>
        Task DeleteMenu(List<Menu> menu);
        /// <summary>
        /// Обновление меню
        /// </summary>
        Task UpdateMenu(Menu menu);

    }
}

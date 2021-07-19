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
        List<Menu> GetMenus { get; }
        /// <summary>
        /// Получить меню по его Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Menu GetMenu(int id);
        /// <summary>
        /// Добавить новое меню
        /// </summary>
        /// <param name="title">Наименование</param>
        Task AddNewMenu(Menu menu);
        /// <summary>
        /// Удаление меню по Id
        /// </summary>
        /// <param name="id">Идентификатор</param>
        void DeleteMenu(int id);
        /// <summary>
        /// Обновление меню
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="title">Наименование</param>
        /// <param name="desc">Описание</param>
        /// <param name="menutype">Тип меню</param>
        void UpdateMenu(int id, string title, string desc, string menutype);

    }
}

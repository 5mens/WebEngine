using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEngine.Models.Menus
{
    /// <summary>
    /// Элементы меню
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Тип меню
        /// </summary>
        public string Menutype { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Ссылка
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// Статус публикации меню
        /// </summary>
        public bool Published { get; set; }
        /// <summary>
        /// Главная страница
        /// </summary>
        public bool IsHome { get; set; }
        /// <summary>
        /// Сортировка
        /// </summary>
        public int Ordering { get; set; }
        /// <summary>
        /// Родительский элемент
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// Идентификатор меню, в котором расположен элемент
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// Меню
        /// </summary>
        public virtual Menu Menu { get; set; }
    }
}

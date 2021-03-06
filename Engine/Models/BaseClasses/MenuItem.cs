using MudBlazor;
using System.ComponentModel.DataAnnotations.Schema;

namespace Engine.Models.BaseClasses
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
        [Column("Descr")]
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
        [Column("sort")]
        public int Ordering { get; set; }
        /// <summary>
        /// Родительский элемент
        /// </summary>
        public MenuItem ParentId { get; set; }
        /// <summary>
        /// Идентификатор меню, в котором расположен элемент
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// Меню
        /// </summary>
        public virtual Menu Menu { get; set; }
        /// <summary>
        /// Иконка
        /// </summary>
        public string Icon { get; set; }
    }
}

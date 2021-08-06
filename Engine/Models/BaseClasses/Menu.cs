using MudBlazor;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Engine.Models.BaseClasses
{
    /// <summary>
    /// Меню
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        [Column("Descr")]
        public string Desc { get; set; }
        /// <summary>
        /// Элементы меню
        /// </summary>
        public List<MenuItem> MenuItems { get; set; }
        /// <summary>
        /// Тип меню
        /// </summary>
        public string Menutype { get; set; }
        /// <summary>
        /// Опубликован
        /// </summary>
        public bool Published { get; set; }
        /// <summary>
        /// Главное меню?
        /// </summary>
        public bool IsMain { get; set; }        
    }
}

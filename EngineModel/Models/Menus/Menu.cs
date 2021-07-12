﻿using System.Collections.Generic;
//пвапва
namespace EngineModel.Models.Menus
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
        public string Desc { get; set; }
        /// <summary>
        /// Элементы меню
        /// </summary>
        public List<MenuItem> MenuItems { get; set; }
        /// <summary>
        /// Тип меню
        /// </summary>
        public string Menutype { get; set; }

    }
}
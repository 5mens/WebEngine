using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    /// <summary>
    /// Инструменты, столовые приборы
    /// </summary>
    public class Tableware
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        public string Image { get; set; }
    }
}

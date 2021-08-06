using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column("Descr")]
        public string Desc { get; set; }
        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        [Column("ImagePath")]
        public string Image { get; set; }
    }
}

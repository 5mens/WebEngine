using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    public class Country
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Столица
        /// </summary>
        public string Capital { get; set; }        
        /// <summary>
        /// Регионы, штаты
        /// </summary>
        public List<Region> Regions { get; set; }
    }
}

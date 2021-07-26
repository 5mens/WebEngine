using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    public class City
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
        /// Район
        /// </summary>
        public District District { get; set; }
        /// <summary>
        /// Почтовый код города
        /// </summary>
        public string PostalCode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Models.BaseClasses;

namespace Engine.Models.Interfaces
{
    interface IRegion
    {
        /// <summary>
        /// Получить все Регионы/Штаты в выбранной стране
        /// </summary>
        Task<List<Region>> GetRegionsByCountryId(Country country);
        /// <summary>
        /// Получить Регион/Штат по Id
        /// </summary>
        Task<Region> GetRegion(int id);
    }
}

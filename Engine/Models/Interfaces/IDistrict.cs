using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Models.BaseClasses;

namespace Engine.Models.Interfaces
{
    interface IDistrict
    {
        /// <summary>
        /// Получить все районы по Региону/Штату
        /// </summary>
        Task<List<District>> GetDistrictsByRegionId(District district);
        /// <summary>
        /// Получить район по Id
        /// </summary>
        Task<District> GetDistrict(int id);
    }
}

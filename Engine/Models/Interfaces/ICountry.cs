using Engine.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Interfaces
{
    interface ICountry
    {
        /// <summary>
        /// Получить список всех стран
        /// </summary>
        Task<List<Country>> GetCountrys();
        /// <summary>
        /// Получить страну по его Id
        /// </summary>
        Task<Country> GetCountryById(int id);
    }
}

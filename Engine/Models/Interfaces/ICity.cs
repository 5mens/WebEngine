using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Models.BaseClasses;

namespace Engine.Models.Interfaces
{
    interface ICity
    {
        /// <summary>
        /// Получить список городов по району
        /// </summary>
        Task<List<City>> GetCitiesByDistrict(District district);
        /// <summary>
        /// Загрузка городов из файла CSV
        /// </summary>
        Task ImportFromCSV();
        /// <summary>
        /// Получить город по его Id
        /// </summary>
        Task GetCityById(int id);
        /// <summary>
        /// Получить список всех городов
        /// </summary>
        Task<List<City>> GetCities();
    }
}

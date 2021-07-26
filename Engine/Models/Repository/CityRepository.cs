using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class CityRepository:ICity
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public CityRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public Task<List<City>> GetCitiesByDistrict(District district)
        {
            throw new NotImplementedException();
        }

        public Task ImportFromCSV()
        {
            throw new NotImplementedException();
        }

        public Task GetCityById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetCities()
        {
            throw new NotImplementedException();
        }
    }
}

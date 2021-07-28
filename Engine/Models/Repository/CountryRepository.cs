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
    public class CountryRepository : ICountry
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public CountryRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public Task<List<Country>> GetCountrys()
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetCountryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class RegionRepository : IRegion
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public RegionRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public Task<List<Region>> GetRegionsByCountryId(Country country)
        {
            throw new NotImplementedException();
        }

        public Task<Region> GetRegion(int id)
        {
            throw new NotImplementedException();
        }
    }
}

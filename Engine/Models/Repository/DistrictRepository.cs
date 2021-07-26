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
    public class DistrictRepository:IDistrict
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public DistrictRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public Task<List<District>> GetDistrictsByRegionId(District district)
        {
            throw new NotImplementedException();
        }

        public Task<District> GetDistrict(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using Engine.Data;
using Engine.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class MyWarehouseRepository : IMyWarehouse
    {
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public MyWarehouseRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }
    }
}

using Engine.Data;
using Engine.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class OrderRepository : IOrder
    {
        private readonly IDbContextFactory<AppDbContext> DbFactory;

        public OrderRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }
    }
}

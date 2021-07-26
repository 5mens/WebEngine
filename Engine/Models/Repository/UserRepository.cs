using Engine.Data;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class UserRepository : IUser
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public UserRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }
    }
}

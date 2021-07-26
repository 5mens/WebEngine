using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
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

        public async Task<List<User>> GetUsers()
        {
            //var context = DbFactory.CreateDbContext();
            //return await context.AspNetUsers.ToListAsync();
            return null;
        }

        public Task BanUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser()
        {
            throw new NotImplementedException();
        }

        public Task DeleteUsers(User users)
        {
            throw new NotImplementedException();
        }
    }
}

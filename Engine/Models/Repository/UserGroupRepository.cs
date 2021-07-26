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
    public class UserGroupRepository : IUserGroup
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public UserGroupRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public Task<List<UserGroup>> GetUserGroups()
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserGroup(UserGroup userGroup)
        {
            throw new NotImplementedException();
        }
    }
}

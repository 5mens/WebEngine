using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class TagRepository : ITag
    {
        private readonly IDbContextFactory<AppDbContext> DbFactory;

        public TagRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public async Task AddTag(Tag tag)
        {
            using var context = DbFactory.CreateDbContext();
            context.Tag.Add(tag);
            await context.SaveChangesAsync();
        }

        public void DeleteTag()
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetTags()
        {
            throw new NotImplementedException();
        }
    }
}

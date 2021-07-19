using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Engine.Models.Repository
{
    public class ArticleRepository : IArticle
    {
        private readonly IDbContextFactory<AppDbContext> DbFactory;

        public ArticleRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public Article GetArticleById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticles()
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticlesByAuthor(IdentityUser author)
        {
            throw new NotImplementedException();
        }
    }
}

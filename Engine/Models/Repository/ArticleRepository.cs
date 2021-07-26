using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Models.Repository
{
    public class ArticleRepository : IArticle
    {
        [Inject]
        private IDbContextFactory<AppDbContext> DbFactory { get; set; }

        public ArticleRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public async Task AddArticle(Article article)
        {
            using var context = DbFactory.CreateDbContext();
            context.Article.Add(article);
            await context.SaveChangesAsync();
        }

        public void DeleteArticle(Article article)
        {
            throw new NotImplementedException();
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

        public List<Article> GetArticlesByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticlesByTag(List<Tag> tag)
        {
            throw new NotImplementedException();
        }
    }
}

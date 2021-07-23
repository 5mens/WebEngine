using System;
using System.Collections.Generic;
using EngineModels.Interfaces.Articles;
using EngineModels.Models.Articles;
using EngineModels.Models.Users;

namespace EngineModels.Repository.Articles
{
    public class ArticleRepository : IArticle
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ArticleRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public Article GetArticleById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticles()
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticlesByAuthor(User author)
        {
            throw new NotImplementedException();
        }
    }
}

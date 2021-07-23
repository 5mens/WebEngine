using System.Collections.Generic;
using EngineModels.Models.Articles;
using EngineModels.Models.Users;

namespace EngineModels.Interfaces.Articles
{
    interface IArticle
    {
        /// <summary>
        /// Получить все статьи
        /// </summary>
        /// <returns></returns>
        List<Article> GetArticles();

        /// <summary>
        /// Получить статью по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Article GetArticleById(int id);

        /// <summary>
        /// Получить все статьи автора
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<Article> GetArticlesByAuthor(User author);
    }
}

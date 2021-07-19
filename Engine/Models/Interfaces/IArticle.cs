using System.Collections.Generic;
using Engine.Models.BaseClasses;
using Microsoft.AspNetCore.Identity;

namespace Engine.Models.Interfaces
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
        List<Article> GetArticlesByAuthor(IdentityUser author);
    }
}

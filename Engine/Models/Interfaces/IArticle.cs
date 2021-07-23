using System.Collections.Generic;
using System.Threading.Tasks;
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

        /// <summary>
        /// Получить все статьи категории
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        List<Article> GetArticlesByCategory(Category category);

        /// <summary>
        /// Получить все статьи с тегами
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        List<Article> GetArticlesByTag(List<Tag> tag);

        /// <summary>
        /// Добавить статью
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        Task AddArticle(Article article);

        /// <summary>
        /// Удалить статью
        /// </summary>
        /// <param name="article"></param>
        void DeleteArticle(Article article);
    }
}

using Engine.Models.BaseClasses;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Engine.Models.Interfaces
{
    interface IComment
    {
        /// <summary>
        /// Получить все комментарии пользователя
        /// </summary>
        /// <returns></returns>
        List<Comment> GetCommentsByAuthor(IdentityUser author);

        /// <summary>
        /// Получить все комментарии к статье
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        List<Comment> GetCommentsByContent(Article article);
        
        /// <summary>
        /// Оставить комментарий
        /// </summary>
        /// <param name="comment"></param>
        void AddComment(Comment comment);

        /// <summary>
        /// Редактировать комментарий
        /// </summary>
        /// <param name="comment"></param>
        void UpdateComment(Comment comment);

        /// <summary>
        /// Удалить комментарий
        /// </summary>
        /// <param name="id"></param>
        void DeleteComment(int id);


    }

}

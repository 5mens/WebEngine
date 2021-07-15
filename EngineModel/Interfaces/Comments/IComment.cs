using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineModels.Models.Articles;
using EngineModels.Models.Comments;
using EngineModels.Models.Users;

namespace EngineModels.Interfaces.Comments
{
    interface IComment
    {
        /// <summary>
        /// Получить все комментарии пользователя
        /// </summary>
        /// <returns></returns>
        List<Comment> GetCommentsByAuthor(User author);

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

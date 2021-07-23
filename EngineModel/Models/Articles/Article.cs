using EngineModels.Models.Users;
using System;

namespace EngineModels.Models.Articles
{
    public class Article
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Текст
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Автор
        /// </summary>
        public User Author { get; set; }

    }
}

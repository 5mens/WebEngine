using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Engine.Models.BaseClasses
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
        [Column("ArticleText")]
        public string Text { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Автор
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Теги
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}

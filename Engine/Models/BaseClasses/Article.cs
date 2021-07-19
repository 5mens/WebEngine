﻿using Microsoft.AspNetCore.Identity;
using System;

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
        public string Text { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Автор
        /// </summary>
        public IdentityUser Author { get; set; }

    }
}

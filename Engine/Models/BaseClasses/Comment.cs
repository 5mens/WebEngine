using Microsoft.AspNetCore.Identity;
using System;

namespace Engine.Models.BaseClasses
{
    public class Comment
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Пользователь оставивший комментарий
        /// </summary>
        public User Author { get; set; }
        /// <summary>
        /// Id Контента, к которому относится комментарий
        /// </summary>
        public Article Content { get; set; }
        /// <summary>
        /// Id родительского комментария
        /// </summary>
        public int IdParentComment { get; set; }
        /// <summary>
        /// Содержимое комментария
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Дата создания комментария 
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}

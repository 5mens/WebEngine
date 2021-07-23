using System.Collections.Generic;

namespace Engine.Models.BaseClasses
{
    public class Category
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наменование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Принадлежащие статьи
        /// </summary>
        public List<Article> Articles { get; set; }
    }
}

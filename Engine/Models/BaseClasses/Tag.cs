using System.Collections.Generic;

namespace Engine.Models.BaseClasses
{
    public class Tag
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Статьи
        /// </summary>
        public List<Article> MyProperty { get; set; }
    }
}

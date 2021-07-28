using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    public class UserRecipeCategory
    {
        public int Id { get; set; }
        /// <summary>
        /// Наименование категории
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание категории
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// Родительская категория
        /// </summary>
        public UserRecipeCategory ParentCategoy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column("Descr")]
        public string Desc { get; set; }
        /// <summary>
        /// Дочерние категории
        /// </summary>
        public List<UserRecipeCategory> Category { get; set; }
        /// <summary>
        /// Показать детали
        /// </summary>
        public bool ShowDetails { get; set; }
    }
}

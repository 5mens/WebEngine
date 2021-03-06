using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    public class Ingredient
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание ингредиента
        /// </summary>
        [Column("Descr")]
        public string Desc { get; set; }
        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        [Column("ImagePath")]
        public string Image { get; set; }
        /// <summary>
        /// Категория ингредиента
        /// </summary>
        public IngredientCategory Category { get; set; }
    }
}

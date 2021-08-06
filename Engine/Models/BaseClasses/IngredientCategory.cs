using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    public class IngredientCategory
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
        /// Ссылка на изображение
        /// </summary>
        [Column("ImagePath")]
        public string Image { get; set; }
        /// <summary>
        /// Ингридиенты категори
        /// </summary>
        public List<Ingredient> Ingredients { get; set; }
    }
}

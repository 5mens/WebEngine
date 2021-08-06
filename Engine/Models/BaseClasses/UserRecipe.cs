using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    public class UserRecipe
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
        /// Категория рецепта
        /// </summary>
        public UserRecipeCategory Category { get; set; }
        /// <summary>
        /// Автор
        /// </summary>
        public User Author { get; set; }
        /// <summary>
        /// Дата публикации
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Описание рецепта
        /// </summary>
        [Column("Descr")]
        public string Desc { get; set; }
        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Ингредиенты
        /// </summary>
        public List<Ingredient> Ingredients { get; set; }
        /// <summary>
        /// Инструменты, столовые приборы
        /// </summary>
        public List<Tableware> Tablewares { get; set; }
    }
}

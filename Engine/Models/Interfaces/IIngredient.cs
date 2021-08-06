using Engine.Models.BaseClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Models.Interfaces
{
    public interface IIngredient
    {
        /// <summary>
        /// Возвращает все ингредиенты переданной категории
        /// </summary>
        /// <param name="ingredientCategory">Категория ингридиентов</param>
        /// <returns>Список ингридиентов категории</returns>
        Task<List<Ingredient>> GetByCategory(IngredientCategory category);

        /// <summary>
        /// Возвращает все ингредиенты LazyLoad
        /// </summary>
        Task<List<Ingredient>> GetAllIngredientLazy();

        /// <summary>
        /// Создает нвоый ингредиент
        /// </summary>
        /// <param name="ingredient">Ингредиент</param>
        /// <returns></returns>
        Task CreateIngredient(Ingredient ingredient);

        /// <summary>
        /// Обновляет существующий ингредиент
        /// </summary>
        /// <param name="ingredient">Ингредиент</param>
        /// <returns></returns>
        Task UpdateIngredient(Ingredient ingredient);

        /// <summary>
        /// Удаляет ингридиенты
        /// </summary>
        /// <param name="ingredients">Список ингридиентов</param>
        /// <returns></returns>
        Task DeleteIngredients(List<Ingredient> ingredients);
    }
}

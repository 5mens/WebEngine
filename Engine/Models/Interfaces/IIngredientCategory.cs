using Engine.Models.BaseClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Models.Interfaces
{
    public interface IIngredientCategory
    {
        /// <summary>
        /// Возвращает все категории ингредиентов
        /// </summary>
        /// <returns>Список категорий ингредиентов</returns>
        Task<List<IngredientCategory>> GetAll();
    }
}

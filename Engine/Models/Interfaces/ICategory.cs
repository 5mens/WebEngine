using Engine.Models.BaseClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Models.Interfaces
{
    interface ICategory
    {
        /// <summary>
        /// Получить все категории
        /// </summary>
        /// <returns></returns>
        List<Category> GetCategories();

        /// <summary>
        /// Получить категорию по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Category GetCategoryById(int id);

        /// <summary>
        /// Добавить категорию
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Task AddCategory(Category category);

        /// <summary>
        /// Удалить категорию
        /// </summary>
        /// <param name="category"></param>
        void DeleteCategory(Category category);
    }
}

using Engine.Models.BaseClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engine.Models.Interfaces
{
    interface ITag
    {
        /// <summary>
        /// Получить все теги
        /// </summary>
        /// <returns></returns>
        List<Tag> GetTags();

        /// <summary>
        /// Добавить тег
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        Task AddTag(Tag tag);

        /// <summary>
        /// Удалить тег
        /// </summary>
        void DeleteTag();
    }
}

using Engine.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Interfaces
{
    interface IMyWarehouse
    {
        /// <summary>
        /// Получить склад пользователя
        /// </summary>
        Task<MyWarehouse> GetUserWarehouse(User user);

        /// <summary>
        /// Создать склад пользователя
        /// </summary>
        void CreateUserWarehouse(MyWarehouse warehouse);

        /// <summary>
        /// Обновить склад пользователя
        /// </summary>        
        Task UpdateUserWarehouse(MyWarehouse warehouse);
    }
}

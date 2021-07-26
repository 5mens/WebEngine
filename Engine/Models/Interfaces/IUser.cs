using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Models.BaseClasses;

namespace Engine.Models.Interfaces
{
    interface IUser
    {
        /// <summary>
        /// Получить список всех пользователей
        /// </summary>
        Task<List<User>> GetUsers();
        /// <summary>
        /// Заблокировать пользователя
        /// </summary>
        Task BanUser(User user);
        /// <summary>
        /// Обновить сведения о пользователе
        /// </summary>
        Task UpdateUser();
        /// <summary>
        /// Удалить пользователя
        /// </summary>
        Task DeleteUsers(User users);
    }
}

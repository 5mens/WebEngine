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
    }
}

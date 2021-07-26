using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engine.Models.BaseClasses;

namespace Engine.Models.Interfaces
{
    interface IUserGroup
    {
        /// <summary>
        /// Получить группы пользователей
        /// </summary>
        Task<List<UserGroup>> GetUserGroups();
        /// <summary>
        /// Удалить группу пользователей
        /// </summary>
        Task DeleteUserGroup(UserGroup userGroup);
    }
}

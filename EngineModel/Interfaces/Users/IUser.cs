using EngineModels.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineModels.Interfaces.Users
{
    interface IUser
    {
        /// <summary>
        /// Получить пользователя по id
        /// </summary>
        /// <param name="id"></param>
        void GetUser(int id);
        /// <summary>
        /// Добавить пользователя
        /// </summary>
        void AddUser(User user);
        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="id"></param>
        void DeleteUser(int id);
        /// <summary>
        /// Обновить пользователя
        /// </summary>
        /// <param name="user"></param>
        void UpdateUser(User user);
        /// <summary>
        /// Получить список пользователей в группе
        /// </summary>
        /// <param name="id">id группы пользователей</param>
        /// <returns></returns>
        IEnumerable<User> GetUsers(int id);
    }
}

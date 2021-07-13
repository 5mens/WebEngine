using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineModels.Models.Users
{
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Группа пользователей
        /// </summary>
        public List<UserGroup> UserGroups { get; set; }
    }
}

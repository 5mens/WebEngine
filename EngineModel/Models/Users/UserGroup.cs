using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineModels.Models.Users
{
    public class UserGroup
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование группы
        /// </summary>
        public string NameGroup { get; set; }
        /// <summary>
        /// Id родительской группы
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// Пользователи
        /// </summary>
        public List<User> Users { get; set; }
    }
}

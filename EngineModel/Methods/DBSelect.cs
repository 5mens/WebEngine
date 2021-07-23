/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineModels.Methods
{
    public class DBSelect
    {
        /// <summary>
        /// Выборка записи из БД
        /// </summary>
        public static IQueryable<TEntity> Select<TEntity>()
            where TEntity : class
        {
            ApplicationDbContext context = new ApplicationDbContext();
            // Загрузка данных с помощью универсального метода Set
            return context.Set<TEntity>();
        }
    }
}*/

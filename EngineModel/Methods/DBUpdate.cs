//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EngineModels.Methods
//{
//    public class DBUpdate
//    {
//        /// <summary>
//        /// Обновление записи в БД
//        /// </summary>
//        public static void Update<TEntity>(TEntity entity)
//    where TEntity : class
//        {
//            ApplicationDbContext context = new ApplicationDbContext();
//            context.Entry<TEntity>(entity).State = EntityState.Modified;
//            context.SaveChanges();
//        }
//    }
//}

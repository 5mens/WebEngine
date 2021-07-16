//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EngineModels.Methods
//{
//    public class DBInsert
//    {
//        /*На данный момент не самый оптимальный способ вставки значений через EF6*/
//        /// <summary>
//        /// Вставка записи в БД
//        /// </summary>        
//        public static void Insert<TEntity>(TEntity entity) where TEntity : class
//        {
//            ApplicationDbContext context = new ApplicationDbContext();

//            context.Entry(entity).State = EntityState.Added;
//            context.SaveChanges();
//        }
//        /// <summary>
//        /// Вставка нескольких полей в БД
//        /// </summary>
//        public static void Inserts<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
//        {
//            ApplicationDbContext context = new ApplicationDbContext();

//            foreach (TEntity entity in entities)
//                context.Entry(entity).State = EntityState.Added;
//            context.SaveChanges();
//        }
//    }
//}

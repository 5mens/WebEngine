using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    public class MyWarehouse
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Список ингредиентов
        /// </summary>
        public List<UserIngredient> Ingredients { get; set; }
        /// <summary>
        /// Список инструментов
        /// </summary>
        public List<UserTableware> Tablewares { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public User User { get; set; }
    }
    [Table("UserIngredient")]
    public class UserIngredient: Ingredient
    { 
        /// <summary>
        /// Цена
        /// </summary>
        public double? Price { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public decimal Count { get; set; }
        /// <summary>
        /// Пользовательское наименование
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Единица измерения (кг, грамм и т.д.) (Сделать справочник)
        /// </summary>
        public string UserUnit { get; set; }
    }
    [Table("UserTableware")]
    public class UserTableware : Tableware {
        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public decimal Count { get; set; }
        /// <summary>
        /// Пользовательское наименование
        /// </summary>
        public string UserName { get; set; }
    }
}

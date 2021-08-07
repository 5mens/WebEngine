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
    public class UserIngredient
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public double? Price { get; set; }
        /// <summary>
        /// Вес/объем
        /// </summary>
        public decimal? Weight { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Пользовательское наименование
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Единица измерения (кг, грамм и т.д.) (Сделать справочник)
        /// </summary>
        public string UserUnit { get; set; }
        /// <summary>
        /// Склад
        /// </summary>
        public MyWarehouse MyWarehouse { get; set; }
        /// <summary>
        /// Id ингредиента
        /// </summary>
        [Column("IngredientId")]
        public int IngredientId { get; set; }
        /// <summary>
        /// Ингредиент
        /// </summary>
        public Ingredient Ingredient { get; set; }
    }
    [Table("UserTableware")]
    public class UserTableware 
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
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
        /// <summary>
        /// Склад
        /// </summary>
        public MyWarehouse MyWarehouse { get; set; }
        /// <summary>
        /// Id ингредиента
        /// </summary>
        [Column("TablewareId")]
        public int TablewareId { get; set; }
        /// <summary>
        /// Столовый прибор
        /// </summary>
        public Tableware Tableware { get; set; }
    }
}

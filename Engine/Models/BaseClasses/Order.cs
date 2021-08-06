using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.BaseClasses
{
    public class Order
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Рецепты
        /// </summary>
        public List<UserRecipe> Recipes { get; set; }
        /// <summary>
        /// Дата заказа (начало)
        /// </summary>
        public DateTime OrderDateBegin { get; set; }
        /// <summary>
        /// Дата заказа (исполнения)
        /// </summary>
        public DateTime OrderDateEnd { get; set; }
        /// <summary>
        /// Описание заказа краткое
        /// </summary>
        [Column("Descr")]
        public string Desc { get; set; }
        /// <summary>
        /// Заказчик
        /// </summary>
        public string Сustomer { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Статус заказа
        /// </summary>
        public string OrderState { get; set; }
    }
}

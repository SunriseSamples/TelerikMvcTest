using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTest.Models
{
    /// <summary>
    /// Product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Category
        /// </summary>
        public string Category { get; set; }
    }
}
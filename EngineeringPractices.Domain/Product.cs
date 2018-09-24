using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringPractices.Domain
{
    /// <summary>
    /// Producto de la tienda
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

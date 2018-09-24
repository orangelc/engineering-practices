using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringPractices.Domain
{
    public class Inventory
    {
        public bool Create(Product product)
        {
            if (product == null)
            {
                throw new Exception("No hay un producto.");
            }
            if(product.Name.Equals(string.Empty))
            {
                throw new Exception("El producto no tiene nombre.");
            }
            return true;
        }
    }
}

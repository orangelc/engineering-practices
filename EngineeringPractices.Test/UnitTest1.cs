using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineeringPractices.Domain;

namespace EngineeringPractices.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cuando_AgregoProductoNulo_Entonces_LanzarException()
        {
            Inventory inventory = new Inventory();
            inventory.Create(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cuando_AgregoProductoSinNombre_Entonces_LanzarException()
        {
            Inventory inventory = new Inventory();
            inventory.Create(new Product { Id=1, Name=string.Empty, Price=10.0 });
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cuando_AgregoProductoConUnPrecioMayorACien_Entonces_LanzarException()
        {
            Inventory inventory = new Inventory();
            inventory.Create(new Product { Id = 1, Name = "P001", Price = 101.0 });
        }

    }
}

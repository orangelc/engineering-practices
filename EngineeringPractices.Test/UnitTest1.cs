using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineeringPractices.Domain;
using Moq;

namespace EngineeringPractices.Test
{
    [TestClass]
    public class UnitTest1
    {

        Inventory inventory;

        [TestInitialize]
        public void Setup()
        {
            inventory = new Inventory();
        }

        [TestCleanup]
        public void Dispose()
        {
            inventory = null;
        }

        [TestMethod]
        [TestCategory("Integracion")]
        [ExpectedException(typeof(Exception))]
        public void Cuando_AgregoProductoNulo_Entonces_LanzarException()
        {
            inventory.Create(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cuando_AgregoProductoSinNombre_Entonces_LanzarException()
        {
            inventory.Create(new Product { Id=1, Name=string.Empty, Price=10.0 });
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cuando_AgregoProductoConUnPrecioMayorACien_Entonces_LanzarException()
        {
            inventory.Create(new Product { Id = 1, Name = "P001", Price = 101.0 });
        }

    }
}

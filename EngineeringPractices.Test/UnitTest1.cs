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
        public void TestMethod1()
        {
            Inventory inventory = new Inventory();
            inventory.Create(null);
        }
    }
}

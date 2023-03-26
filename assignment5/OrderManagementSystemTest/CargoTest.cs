using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrderManagementSystem;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class CargoTest
    {
        [TestMethod]
        public void TestCargo()
        {
            string name = "钢笔";
            uint price = 20;
            uint quantity = 5;
            Cargo cargo = new Cargo(name, price, quantity);
            CollectionAssert.Equals(cargo.CargoName, name);
            CollectionAssert.Equals(cargo.CargoPrice, price);
            CollectionAssert.Equals(cargo.CargoQuantity, quantity);
        }
    }
}

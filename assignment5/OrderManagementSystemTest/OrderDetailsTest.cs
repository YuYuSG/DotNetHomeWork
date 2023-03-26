using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrderManagementSystem;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class OrderDetailsTest
    {
        [TestMethod]
        public void TestOrderDetails()
        {
            Client client = new Client("小方");
            Cargo cargo = new Cargo("钢笔", 20, 5);
            uint price = 20 * 5;
            OrderDetails orderDetail = new OrderDetails(client, cargo);
            CollectionAssert.Equals(orderDetail.OrderClient, client);
            CollectionAssert.Equals(orderDetail.OrderCargo, cargo);
            CollectionAssert.Equals(orderDetail.OrderPrice, price);

        }
    }
}

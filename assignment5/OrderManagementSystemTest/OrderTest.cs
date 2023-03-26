using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrderManagementSystem;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void TestOrder()
        {
            ulong number = 15;
            Client client = new Client("小方");
            Cargo cargo = new Cargo("钢笔", 20, 5);
            OrderDetails orderDetail = new OrderDetails(client, cargo);
            Order order = new Order(number, orderDetail);
            CollectionAssert.Equals(order.OrderNumber, number);
            CollectionAssert.Equals(order.OrderDetail, orderDetail);

        }
    }
}

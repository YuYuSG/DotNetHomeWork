using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagementSystem;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class OrderServiceTest
    {
        

        [TestMethod]
        public void TestSortOrder()
        {
            Cargo cargo;
            Client client;
            OrderDetails orderDetail;
            Order order;
            OrderService orderServiceI = new OrderService();
            
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceI.orderList.Add(order); 
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceI.orderList.Add(order); 
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceI.orderList.Add(order); 
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceI.orderList.Add(order); 
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceI.orderList.Add(order);
            
            OrderService orderServiceO = new OrderService();
            //按照订单号将订单排序
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order); 
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order); 
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceO.orderList.Add(order); 
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order); 
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            orderServiceI.SortOrder(0);
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
            //按照订单金额将订单排序
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order);
            orderServiceI.SortOrder(1);
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
            //按照货物名称将订单排序
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            orderServiceI.SortOrder(2);
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
            //按照货物单价将订单排序
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order);
            orderServiceI.SortOrder(3);
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
            //按照货物数量将订单排序
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order);
            orderServiceI.SortOrder(4);
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
            //按照客户名字将订单排序
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order);
            orderServiceI.SortOrder(5);
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
            //默认按照订单号将订单排序
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            orderServiceI.SortOrder();
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
        }

        [TestMethod]
        public void TestAddOrder()
        {
            Cargo cargo;
            Client client;
            OrderDetails orderDetail;
            Order order;
            OrderService orderServiceI = new OrderService();

            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceI.orderList.Add(order);

            OrderService orderServiceO = new OrderService();
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("粉笔", 2, 100); client = new Client("小贾"); orderDetail = new OrderDetails(client, cargo); order = new Order(5, orderDetail); orderServiceO.orderList.Add(order);

            cargo = new Cargo("粉笔", 2, 100); client = new Client("小贾"); orderDetail = new OrderDetails(client, cargo); order = new Order(5, orderDetail);
            orderServiceI.AddOrder(order);
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
        }

        [TestMethod]
        public void TestSearchOrder()
        {
            Cargo cargo;
            Client client;
            OrderDetails orderDetail;
            Order order;
            OrderService orderServiceI = new OrderService();

            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceI.orderList.Add(order);

            //按照订单号查询
            List<Order> ordersI = null;
            List<Order> ordersO = null;
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail);
            ordersO.Add(order);
            orderServiceI.SearchOrder(0, 2, ordersI);
            CollectionAssert.AreEqual(ordersI, ordersO);
            //按照订单金额查询
            ordersI.Clear();
            ordersO.Clear();
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail);
            ordersO.Add(order);
            orderServiceI.SearchOrder(1, 300, ordersI);
            CollectionAssert.AreEqual(ordersI, ordersO);
            //按照货物名称查询
            ordersI.Clear();
            ordersO.Clear();
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail);
            ordersO.Add(order);
            orderServiceI.SearchOrder(2, "水彩笔", ordersI);
            CollectionAssert.AreEqual(ordersI, ordersO);
            //按照货物单价查询
            ordersI.Clear();
            ordersO.Clear();
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail);
            ordersO.Add(order);
            orderServiceI.SearchOrder(3, 15, ordersI);
            CollectionAssert.AreEqual(ordersI, ordersO);
            //按照货物数量查询
            ordersI.Clear();
            ordersO.Clear();
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); 
            ordersO.Add(order);
            orderServiceI.SearchOrder(4, 23, ordersI);
            CollectionAssert.AreEqual(ordersI, ordersO);
            //按照客户名字查询
            ordersI.Clear();
            ordersO.Clear();
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail);
            ordersO.Add(order);
            orderServiceI.SearchOrder(5, "小俞", ordersI);
            CollectionAssert.AreEqual(ordersI, ordersO);
        }

        [TestMethod]
        public void TestDeleteOrder()
        {
            Cargo cargo;
            Client client;
            OrderDetails orderDetail;
            Order order;
            OrderService orderServiceI = new OrderService();

            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceI.orderList.Add(order);

            OrderService orderServiceO = new OrderService();
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order);
            orderServiceI.DeleteOrder(2);
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
        }

        [TestMethod]
        public void TestEditOrder()
        {
            Cargo cargo;
            Client client;
            OrderDetails orderDetail;
            Order order;
            OrderService orderServiceI = new OrderService();

            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceI.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceI.orderList.Add(order);

            OrderService orderServiceO = new OrderService();
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(4, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(3, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("签字笔", 3, 75); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(2, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(1, orderDetail); orderServiceO.orderList.Add(order);
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(0, orderDetail); orderServiceO.orderList.Add(order);

            cargo = new Cargo("签字笔", 3, 75); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo);
            orderServiceI.EditOrder(2, orderDetail);
            CollectionAssert.AreEqual(orderServiceI.orderList, orderServiceO.orderList);
        }


    }
}

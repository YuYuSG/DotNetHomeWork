using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    //订单服务类
    public class OrderService
    {
        //订单数据表模拟订单数据库
        public List<Order> orderList;

        //默认初始化订单数据库
        public void DefaultInitializeOrderList()
        {
            Cargo cargo;
            Client client;
            OrderDetails orderDetail;
            Order order;
            ulong number = 0;
            cargo = new Cargo("签字笔", 5, 20); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("铅笔", 3, 120); client = new Client("小李"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("圆珠笔", 7, 320); client = new Client("小刚"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("钢笔", 20, 2); client = new Client("小张"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("圆珠笔", 10, 23); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("水彩笔", 6, 40); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("铅笔", 2, 60); client = new Client("小朱"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("钢笔", 15, 5); client = new Client("小明"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("签字笔", 4, 25); client = new Client("小俞"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("水彩笔", 8, 120); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;
            cargo = new Cargo("毛笔", 30, 10); client = new Client("小王"); orderDetail = new OrderDetails(client, cargo); order = new Order(number, orderDetail); orderList.Add(order); number++;

        }

        //排序订单
        //默认按照订单号排序
        public void SortOrder()
        {
           
            orderList.Sort((x, y) => x.OrderNumber.CompareTo(y.OrderNumber));
            foreach (var order in orderList) { Console.WriteLine(order); }
            
        }
        //关键字为0按照订单号查询，关键字为1按照订单金额查询，关键字为2按照货物名称查询，关键字为3按照货物单价查询，关键字为4按照货物数量查询，关键字为5按照客户名字查询
        public void SortOrder(int key)
        {
            switch (key)
            {
                case 0:
                    {
                        //按照订单号将订单排序
                        orderList.Sort((x, y) => x.OrderNumber.CompareTo(y.OrderNumber));
                        foreach (var order in orderList) { Console.WriteLine(order); }
                        
                        break;
                    }
                case 1:
                    {
                        //按照订单金额将订单排序
                        orderList.Sort((x, y) => x.OrderDetail.OrderPrice.CompareTo(y.OrderDetail.OrderPrice));
                        foreach (var order in orderList) { Console.WriteLine(order); }
                        
                        break;
                    }
                case 2:
                    {
                        //按照货物名称将订单排序
                        orderList.Sort((x, y) => x.OrderDetail.OrderCargo.CargoName.CompareTo(y.OrderDetail.OrderCargo.CargoName));
                        foreach (var order in orderList) { Console.WriteLine(order); }
                        
                        break;

                    }
                case 3:
                    {
                        //按照货物单价将订单排序
                        orderList.Sort((x, y) => x.OrderDetail.OrderCargo.CargoPrice.CompareTo(y.OrderDetail.OrderCargo.CargoPrice));
                        foreach (var order in orderList) { Console.WriteLine(order); }
                        
                        break;

                    }
                case 4:
                    {
                        //按照货物数量将订单排序
                        orderList.Sort((x, y) => x.OrderDetail.OrderCargo.CargoQuantity.CompareTo(y.OrderDetail.OrderCargo.CargoQuantity));
                        foreach (var order in orderList) { Console.WriteLine(order); }
                        
                        break;
                    }
                case 5:
                    {
                        //按照客户名字将订单排序
                        orderList.Sort((x, y) => x.OrderDetail.OrderClient.ClientName.CompareTo(y.OrderDetail.OrderClient.ClientName));
                        foreach (var order in orderList) { Console.WriteLine(order); }
                        
                        break;
                    }
                default:
                    {
                        throw new OrderException("排序关键字无效，查询失败！", 3);
                        break;
                    }
            }
        }

        //增加订单
        public void AddOrder(Order orderToAdd)
        {
            var orders = from order in orderList
                         where order.OrderNumber == orderToAdd.OrderNumber
                         select order;
            if (orders != null)
            {
                throw new OrderException("订单编号已存在，添加失败！", 1);
                return;
            }
            orderList.Add(orderToAdd);
            
        }

        //查询订单(LINQ语言)
        //关键字为0按照订单号查询
        public void SearchOrder(int key, ulong number,List<Order> orders)
        {
            switch (key)
            {
                case 0:
                    {
                        //按照订单号查询
                        var tempOrders = from order in orderList
                                     where order.OrderNumber == number
                                     select order;
                        if (orders == null)
                        {
                            throw new OrderException("无符合要求的订单，查询失败！", 5);
                            break;
                        }
                        foreach (var order in tempOrders) { orders.Add(order); }
                        
                        break;
                    }
                default:
                    {
                        throw new OrderException("查询关键字无效，查询失败！", 4);
                        break;
                    }
            }
        }
        //关键字为1按照订单金额查询，关键字为3按照货物单价查询，关键字为4按照货物数量查询
        public void SearchOrder(int key, uint priceOrQuantity, List<Order> orders)
        {
            switch (key)
            {
                case 1:
                    {
                        //按照订单金额查询
                        var tempOrders = from order in orderList
                                     where order.OrderDetail.OrderPrice == priceOrQuantity
                                     select order;
                        if (tempOrders == null)
                        {
                            throw new OrderException("无符合要求的订单，查询失败！", 5);
                            break;
                        }
                        foreach (var order in tempOrders) { orders.Add(order); }
                        
                        break;
                    }
                case 3:
                    {
                        //按照货物单价查询
                        var tempOrders = from order in orderList
                                     where order.OrderDetail.OrderCargo.CargoPrice == priceOrQuantity
                                     select order;
                        if (tempOrders == null)
                        {
                            throw new OrderException("无符合要求的订单，查询失败！", 5);
                            break;
                        }
                        foreach (var order in tempOrders) { orders.Add(order); }
                        
                        break;
                    }
                case 4:
                    {
                        //按照货物数量查询
                        var tempOrders = from order in orderList
                                     where order.OrderDetail.OrderCargo.CargoQuantity == priceOrQuantity
                                     select order;
                        if (tempOrders == null)
                        {
                            throw new OrderException("无符合要求的订单，查询失败！", 5);
                            break;
                        }
                        foreach (var order in tempOrders) { orders.Add(order); }
                        
                        break;
                    }
                default:
                    {
                        throw new OrderException("查询关键字无效，查询失败！", 4);
                        break;
                    }
            }
        }
        //关键字为2按照货物名称查询，关键字为5按照客户名字查询
        public void SearchOrder(int key, string name, List<Order> orders)
        {
            switch (key)
            {
                case 2:
                    {
                        //按照货物名称查询
                        var tempOrders = from order in orderList
                                     where order.OrderDetail.OrderCargo.CargoName == name
                                     select order;
                        if (tempOrders == null)
                        {
                            throw new OrderException("无符合要求的订单，查询失败！", 5);
                            break;
                        }
                        foreach (var order in tempOrders) { orders.Add(order); }
                        
                        break;
                    }
                case 5:
                    {
                        //按照客户名字查询
                        var tempOrders = from order in orderList
                                     where order.OrderDetail.OrderClient.ClientName == name
                                     select order;
                        if (tempOrders == null)
                        {
                            throw new OrderException("无符合要求的订单，查询失败！", 5);
                            break;
                        }
                        foreach (var order in tempOrders) { orders.Add(order); }
                        
                        break;
                    }
                default:
                    {
                        throw new OrderException("查询关键字无效，查询失败！", 4);
                        break;
                    }
            }
        }

        //删除订单
        public void DeleteOrder(ulong number)
        {
            var orderIndexes = from order in orderList
                               where order.OrderNumber == number
                               select orderList.IndexOf(order);
            if (orderIndexes == null)
            {
                throw new OrderException("订单编号不存在，删除失败！", 2);
                return;
            }
            foreach (var orderIndex in orderIndexes) { orderList.RemoveAt(orderIndex); }
            
        }

        //修改订单
        public void EditOrder(ulong number, OrderDetails orderDetail)
        {
            var orders = from order in orderList
                         where order.OrderNumber == number
                         select order;
            if (orders == null)
            {
                throw new OrderException("订单编号不存在，修改失败！", 2);
                return;
            }
            foreach (var order in orders) { order.OrderDetail = orderDetail; }
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace OrderApp {

    /**
     * The service class to manage orders
     * */
    public class OrderService {

      
        

        public List<Order> Orders
        {
            get
            {
                using (OrderingContext context = new OrderingContext())
                {
                    return context.Orders
                      .Include(o => o.Details.Select(d => d.GoodsItem))
                      .Include(o => o.Customer)
                      .ToList<Order>();
                }       
            }
        }

        public OrderService() {
            using (OrderingContext context = new OrderingContext())
            {
                
                if (context.Goodss.Count() == 0)
                {
                    context.Goodss.Add(new Goods("apple", 100.0));
                    context.Goodss.Add(new Goods("egg", 200.0));
                    context.SaveChanges();
                }
                if (context.Customers.Count() == 0)
                {
                    context.Customers.Add(new Customer("li"));
                    context.Customers.Add(new Customer("zhang"));
                    context.SaveChanges();
                }
            }
        }

        
        public List<Order> GetAllOrders() {
            using (OrderingContext context = new OrderingContext())
            {
                return context.Orders.ToList();
            }      
        }
        

        public Order GetOrder(string id) {
            using (OrderingContext context = new OrderingContext())
            {
                return context.Orders
                .Include(o => o.Details.Select(d => d.GoodsItem))
                .Include(o => o.Customer)
                .SingleOrDefault(o => o.OrderId == id);
            }                
        }

        //避免级联添加或修改Customer和Goods
        private static void FixOrder(Order newOrder)
        {
            newOrder.CustomerId = newOrder.Customer.ID;
            newOrder.Customer = null;
            newOrder.Details.ForEach(d => {
                d.GoodsId = d.GoodsItem.ID;
                d.GoodsItem = null;
            });
        }

        public void AddOrder(Order order) {
            FixOrder(order);
            using (OrderingContext context = new OrderingContext())
            {
                context.Entry(order).State = EntityState.Added;
                context.SaveChanges();
            }        
        }

        public void RemoveOrder(string orderId) {
            using (OrderingContext context = new OrderingContext())
            {
                var order = context.Orders.Include("Details")
                  .SingleOrDefault(o => o.OrderId == orderId);
                if (order == null) return;
                context.OrderDetails.RemoveRange(order.Details);
                context.Orders.Remove(order);
                context.SaveChanges();
            }        
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName) {
            using (OrderingContext context = new OrderingContext())
            {
              return context.Orders
              .Include(o => o.Details.Select(d => d.GoodsItem))
              .Include(o => o.Customer)
              .Where(order => order.Details.Any(item => item.GoodsItem.Name == goodsName))
              .ToList();
            }
        }

        public List<Order> QueryOrdersByCustomerName(string customerName) {
            using (OrderingContext context = new OrderingContext())
            {
                return context.Orders
                .Include(o => o.Details.Select(d => d.GoodsItem))
                .Include(o => o.Customer)
                .Where(order => order.CustomerName == customerName)
                .ToList();
            }               
        }

        public void UpdateOrder(Order newOrder) {
            RemoveOrder(newOrder.OrderId);
            AddOrder(newOrder);
        }

        public void Export(String fileName) {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, Orders);
            }
        }

        public void Import(string path) {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (OrderingContext context = new OrderingContext())
                {
                    List<Order> temp = (List<Order>)xs.Deserialize(fs);
                    temp.ForEach(order => {
                        if (context.Orders.SingleOrDefault(o => o.OrderId == order.OrderId) == null)
                        {
                            FixOrder(order);
                            context.Orders.Add(order);
                        }
                    });
                    context.SaveChanges();
                }                   
            }
        }

        public object QueryByTotalAmount(float amout) {
            using (OrderingContext context = new OrderingContext())
            {
              return context.Orders
              .Include(o => o.Details.Select(d => d.GoodsItem))
              .Include("Customer")
              .Where(order => order.TotalPrice >= amout)
              .ToList();
            }               
        }
    }
}

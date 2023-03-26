using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    //订单类
    public class Order
    {
        public ulong OrderNumber { get; set; }  //订单号
        public OrderDetails OrderDetail { get; set; }  //订单明细

        //订单类构造函数
        public Order(ulong number, OrderDetails orderDetail)
        {
            OrderNumber = number;
            OrderDetail = orderDetail;
        }

        public override string ToString()
        {
            return "订单号：" + OrderNumber + ";" + "订单明细：{" + OrderDetail + "}";
        }

        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && m.OrderNumber == OrderNumber && m.OrderDetail.Equals(OrderDetail);
        }
    }
}

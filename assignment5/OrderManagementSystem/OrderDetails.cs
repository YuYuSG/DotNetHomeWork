using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    //订单明细类
    public class OrderDetails
    {
        public Client OrderClient { get; set; }  //订单客户
        public Cargo OrderCargo { get; set; }  //订单货物
        public uint OrderPrice { get; set; }  //订单金额

        //订单明细类构造函数
        public OrderDetails(Client client, Cargo cargo)
        {
            OrderClient = client;
            OrderCargo = cargo;
            OrderPrice = cargo.CargoPrice * cargo.CargoQuantity;
        }

        public override string ToString()
        {
            return "订单客户：（" + OrderClient + "）；" + "订单货物：（" + OrderCargo + "）；" + "订单金额：" + OrderPrice;
        }

        public override bool Equals(object obj)
        {
            OrderDetails m = obj as OrderDetails;
            return m != null && m.OrderPrice == OrderPrice && m.OrderCargo.Equals(OrderCargo) && m.OrderClient.Equals(OrderClient);
        }
    }
}

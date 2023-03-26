using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    //货物类
    public class Cargo
    {
        public string CargoName { get; set; }  //货物名称
        public uint CargoPrice { get; set; }  //货物单价
        public uint CargoQuantity { get; set; }  //货物数量

        //货物类构造函数
        public Cargo(string name, uint price, uint quantity)
        {
            CargoName = name;
            CargoPrice = price;
            CargoQuantity = quantity;
        }

        public override string ToString()
        {
            return "货物名称：" + CargoName + "；" + "货物单价：" + CargoPrice + "；" + "货物数量：" + CargoQuantity;
        }

        public override bool Equals(object obj)
        {
            Cargo m = obj as Cargo;
            return m != null && m.CargoName == CargoName && m.CargoPrice == CargoPrice && m.CargoQuantity == CargoQuantity;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    //客户类
    public class Client
    {
        public string ClientName { get; set; }  //客户名字

        //客户类构造函数
        public Client(string name)
        {
            ClientName = name;
        }

        public override string ToString()
        {
            return "客户名字：" + ClientName;
        }

        public override bool Equals(object obj)
        {
            Client m = obj as Client;
            return m != null && m.ClientName == ClientName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    //订单异常类
    public class OrderException : ApplicationException
    {
        private int code;
        public OrderException(String message, int code)
         : base(message)
        {
            this.code = code;
        }
        public int Code { get => code; }
    }
}

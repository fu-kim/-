using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public string OrderId { get; set; } //订单号
        public int Table { get; set; }//桌号
        public decimal Price { get; set; }//总价
        public DateTime PayTime { get; set; }//下单时间
        public string Remarks { get; set; }//备注
        public bool IsPay { get; set; }//是否买单
    }
}

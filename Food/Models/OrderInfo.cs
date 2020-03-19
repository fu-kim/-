using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderInfo
    {
        public int TableId { get; set; }
        public string OrderId { get; set; }
        public decimal Price { get; set; }
        public DateTime PayTime { get; set; }
        public string Remarks { get; set; }
        public string IsPay { get; set; }

       
    }
}

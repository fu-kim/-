using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderInfos
    {
        public int TableId { get; set; }
        public string OrderId { get; set; }
        public string FName { get; set; }
        public decimal FPrice { get; set; }
        public int FNumber { get; set; }
    }
}

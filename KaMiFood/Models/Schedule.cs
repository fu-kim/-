using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Schedule
    {
        public string OrderId { get; set; }
        public string FName { get; set; }
        public string FTime { get; set; }
        public int FNumber { get; set; }
        public bool IsPay { get; set; }

        public string PayTime { get; set; }
    }
}

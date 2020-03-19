using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string AName { get; set; }
        public DateTime ATime { get; set; }
        public DateTime ATimeEnd { get; set; }
        public string FName { get; set; }
        public int FNumber { get; set; }
        public decimal Price { get; set; }
        public string FoodImage { get; set; }
    }
}

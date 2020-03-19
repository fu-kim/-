using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Food
    { 
        public int FoodId { get; set; }
        public int FoodType { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string FoodImage { get; set; }
        public string FoodTime { get; set; }
    }
}

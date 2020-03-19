using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StaffInfo
    {
        public int StaffId { get; set; }
        public int StaffPasd { get; set; }
        public string StaffName { get; set; }
        public string StaffSex { get; set; }
        public int StaffAge { get; set; }
        public DateTime StaffBirthday { get; set; }
        public string StaffAddress { get; set; }
        public string StaffTel { get; set; }
        public string StaffCardId { get; set; }
        public string EContact { get; set; }
        public string EContactTel { get; set; }
        public string StaffPot { get; set; }
        public string TypeId { get; set; }
        public string StaffTypeName { get; set; }
    }
}

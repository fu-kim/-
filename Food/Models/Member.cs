using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemName { get; set; }
        public string MemTel { get; set; }
        public string MemPwd { get; set; }
        public string MemSex { get; set; }
        public int MemAge { get; set; }
        public DateTime MemBirthday { get; set; }
    }
}

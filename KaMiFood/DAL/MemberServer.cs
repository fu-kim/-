using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MemberServer
    {
        #region 查询会员电话是否存在
        public static List<Member> SelectMemberTelbyAll(string Tel)
        {
            List<Member> mbs = new List<Member>();
            string sql = "select * from MemberInfo where MemTel='" + Tel + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                Member mb = new Member();
                mb.MemberId = (int)dr["MemberId"];
                mb.MemName = (string)dr["MemName"];
                mb.MemTel = (string)dr["MemTel"];
                mb.MemPwd = (string)dr["MemPwd"];
                mb.MemAge = (int)dr["MemAge"];
                mb.MemSex = (string)dr["MemSex"];
                mb.MemBirthday = (DateTime)dr["MemBirthday"];
                mbs.Add(mb);
            }
            dr.Close();
            DBHelper.Closecon();
            return mbs;
        }
        #endregion
    }
}

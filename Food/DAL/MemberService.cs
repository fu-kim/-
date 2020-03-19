using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MemberService
    {
        #region 查询所有会员信息
        public static List<Member> SelectMemberAll()
        {
            List<Member> mbs = new List<Member>();
            string sql = "select * from MemberInfo";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
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

        #region 添加会员
        public static int InsertMember(string MemberName, string MemberTel, string MemberPwd, string MemberSex, string MemberAge, DateTime OpenCardTime)
        {
            int n = 0;
            string sql = "insert MemberInfo values('" + MemberName + "','" + MemberTel + "','" + MemberPwd + "','" + MemberSex + "','" + MemberAge + "','" + OpenCardTime + "')";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 修改会员
        public static int UpdateMember(int MemberId, string MemberName, string MemberTel, string MemberPwd, string MemberSex, string MemberAge, DateTime OpenCardTime)
        {
            int n = 0;
            string sql = "update MemberInfo set MemName='"+ MemberName + "', MemTel='" + MemberTel + "', MemPwd='" + MemberPwd + "', MemSex='" + MemberSex + "', MemAge='" + MemberAge + "', MemBirthday='" + OpenCardTime + "' where MemberId='"+ MemberId + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 删除会员
        public static int DeleteMember(int MemberId)
        {
            int n = 0;
            string sql = "delete from MemberInfo where  MemberId='" + MemberId + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 查询会员电话是否存在
        public static bool SelectMemberTel(string Tel)
        {
            string sql = "select count(*) from MemberInfo where MemTel='" + Tel + "'";
            int n = (int)DBHelper.ExecuteScalar(sql);
            if (n>0)
            {
                return false;
            }
            return true;
        }
        #endregion

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

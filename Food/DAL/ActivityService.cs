using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ActivityService
    {
        #region 查询所有特殊活动
        public static List<Actiivity> SelectActivityAll()
        {
            List<Actiivity> tb = new List<Actiivity>();
            string sql = "select top 200 * from ActivityInfo";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Actiivity tbs = new Actiivity();
                tbs.AName = (string)dr["AName"];
                tbs.ATime = (DateTime)dr["ATime"];
                tbs.ATimeEnd = (DateTime)dr["ATimeEnd"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 查询所有节日活动
        public static List<Actiivity> SelectFestivalActivityAll()
        {
            List<Actiivity> tb = new List<Actiivity>();
            string sql = "select top 200 * from TextActivityInfo";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Actiivity tbs = new Actiivity();
                tbs.AName = (string)dr["AName"];
                tbs.ATime = (DateTime)dr["ATime"];
                tbs.ATimeEnd = (DateTime)dr["ATimeEnd"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 根据名称删除
        public static int DeleteActivityByAName(string Aname)
        {
            int n = 0;
            string sql = "delete from TextActivityInfo where AName ='"+Aname+"'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
        #region 根据名称删除
        public static int DeleteTextActivityByAName(string Aname)
        {
            int n = 0;
            string sql = "delete from ActivityInfo where AName ='" + Aname + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
        #region 更具名称修改
        public static int UpdateActivityByAName(string Aname)
        {
            int n = 0;
            string sql = "delete from TextActivityInfo where AName ='" + Aname + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
        #region 修改       
        public static int UpdateActivity(string name,DateTime time, DateTime time2,string name2)
        {
            int n = 0;
            string sql = "Update TextActivityInfo Set AName='"+name+ "',ATime='" + time + "',";
            sql += "ATimeEnd='" + time2 + "' Where AName='" + name2 + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
        #region 修改       
        public static int UpdateTextActivity(string name, DateTime time, DateTime time2, string name2)
        {
            int n = 0;
            string sql = "Update ActivityInfo Set AName='" + name + "',ATime='" + time + "',";
            sql += "ATimeEnd='" + time2 + "' Where AName='" + name2 + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
    }
}

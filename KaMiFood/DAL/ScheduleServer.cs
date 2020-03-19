using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ScheduleServer
    {
        #region 查询所有菜品进度信息（从别的表多表连接）
        public static List<Schedule> selectScheduleValues()
        {
            List<Schedule> sd = new List<Schedule>();
            string sql = "select * from OrderInfo o,Food f,Pay p where o.FName=f.FoodName and o.OrderId=p.PayId";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);

            while (dr.Read())
            {
                Schedule sds = new Schedule();
                sds.OrderId = dr["OrderId"].ToString();
                sds.FName = dr["FName"].ToString();
                sds.FTime = dr["FoodTime"].ToString();
                sds.FNumber = (int)dr["FNumber"];
                sds.IsPay = (bool)dr["IsPay"];
                sds.PayTime = dr["PayTime"].ToString();
                sd.Add(sds);
            }

            dr.Close();
            DBHelper.Closecon();

            return sd;
        }
        #endregion

        #region 添加进度信息
        public static int InsertSchedule(int TableId,string OrderId, string FName, string FTime, int FNumber, bool IsPay)
        {
            int n = 0;
            string sql = "insert ScheduleInfo values('" + TableId + "','" + OrderId + "','" + FName + "','" + FTime + "','" + FNumber + "','" + IsPay + "')";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 查询所有菜品进度信息
        public static List<Schedule> selectSchedule()
        {
            List<Schedule> sd = new List<Schedule>();
            string sql = "select * from ScheduleInfo";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);

            while (dr.Read())
            {
                Schedule sds = new Schedule();
                sds.OrderId = dr["OrderId"].ToString();
                sds.FName = dr["Fname"].ToString();
                sds.FTime = dr["FTime"].ToString();
                sds.FNumber = (int)dr["FNumber"];
                sds.IsPay = (bool)dr["IsPay"];
                sd.Add(sds);
            }

            dr.Close();
            DBHelper.Closecon();

            return sd;
        }
        #endregion

        #region 根据订单号菜名查询菜品进度信息
        public static List<Schedule> selectScheduleByOrderIdFName(string OrderId,string Fname)
        {
            List<Schedule> sd = new List<Schedule>();
            string sql = "select * from ScheduleInfo where OrderId='"+ OrderId + "' and Fname='"+Fname+"'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);

            while (dr.Read())
            {
                Schedule sds = new Schedule();
                sds.OrderId = dr["OrderId"].ToString();
                sds.FName = dr["Fname"].ToString();
                sds.FTime = dr["FTime"].ToString();
                sds.FNumber = (int)dr["FNumber"];
                sds.IsPay = (bool)dr["IsPay"];
                sd.Add(sds);
            }

            dr.Close();
            DBHelper.Closecon();

            return sd;
        }
        #endregion

        #region 删除所有进度信息
        public static int DeleteSchedule()
        {
            int n = 0;
            string sql = "delete from ScheduleInfo";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
    }
}

using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class ActivityServer
    {
        #region 查询所有活动信息
        public static List<Activity> SelectActivityAll()
        {
            List<Activity> tay = new List<Activity>();
            string sql = "select * from ActivityInfo";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Activity ays = new Activity();
                ays.ActivityId = (int)dr["ActivityId"];
                ays.AName = (string)dr["AName"];
                ays.ATime = (DateTime)dr["ATime"];
                ays.ATimeEnd = (DateTime)dr["ATimeEnd"];
                tay.Add(ays);
            }
            dr.Close();
            DBHelper.Closecon();
            return tay;
        }
        #endregion

        #region 根据活动名称查询所有活动菜品信息
        public static List<Activity> SelectActivityFoodAll(string AName)
        {
            List<Activity> tay = new List<Activity>();
            string sql = "select * from SetmealFoodInfo where SetmealId in (select ActivityId from ActivityInfo where AName='"+ AName + "')";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Activity ays = new Activity();
                ays.FName = (string)dr["FName"];
                ays.FNumber = (int)dr["FNumber"];
                ays.Price = (decimal)dr["Price"];
                tay.Add(ays);
            }
            dr.Close();
            DBHelper.Closecon();
            return tay;
        }
        #endregion
    }
}

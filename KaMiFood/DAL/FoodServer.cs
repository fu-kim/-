using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodServer
    {
        #region 查询所有菜品
        /// <summary>
        /// 查询所有菜品
        /// </summary>
        /// <returns></returns>
        public static List<Food> SelectFoodAll()
        {
            List<Food> fds = new List<Food>();
            string sql = "select * from Food";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                string strTime = dr["FoodTime"].ToString();
                DateTime date = Convert.ToDateTime(strTime);
                Food fd = new Food();
                fd.FoodId = (int)dr["FoodId"];
                fd.FoodImage = (string)dr["FoodImage"];
                fd.FoodName = (string)dr["FoodName"];
                fd.FoodTime = date.ToLongTimeString();
                fd.FoodType = (int)dr["FoodType"];
                fd.Price = (decimal)dr["Price"];
                fds.Add(fd);
            }
            dr.Close();
            DBHelper.Closecon();
            return fds;
        }
        #endregion

        #region 根据类型查询所有菜品
        /// <summary>
        /// 根据类型查询所有菜品
        /// </summary>
        /// <returns></returns>
        public static List<Food> SelectFoodbyType(string type)
        {
            List<Food> fds = new List<Food>();
            string sql = "select * from Food where FoodType='" + type + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                string strTime = dr["FoodTime"].ToString();
                DateTime date = Convert.ToDateTime(strTime);
                Food fd = new Food();
                fd.FoodId = (int)dr["FoodId"];
                fd.FoodImage = (string)dr["FoodImage"];
                fd.FoodName = (string)dr["FoodName"];
                fd.FoodTime = date.ToLongTimeString();
                fd.FoodType = (int)dr["FoodType"];
                fd.Price = (decimal)dr["Price"];
                fds.Add(fd);
            }
            dr.Close();
            DBHelper.Closecon();
            return fds;
        }
        #endregion

        #region 查询菜品的类型
        public static object SelectFoodType(string FoodName)
        {
            object oj = "";
            string sql = "select FoodType from Food where FoodName='"+ FoodName + "'";
            oj = DBHelper.ExecuteScalar(sql);
            return oj;
        }
        #endregion

        #region 查询菜品名称
        public static List<string> SelectFoodName()
        {
            List<string> fd = new List<string>();
            //List<Food> fd = new List<Food>();
            string sql = "select FoodName from Food";
            SqlDataReader dr= DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {

                fd.Add(dr["FoodName"].ToString());
                
            }
            dr.Close();
            DBHelper.Closecon();
            return fd;
        }
        #endregion

        #region 根据菜品姓名查询菜品
        public static List<Food> SelectFoodbyFoodName(string FoodName)
        {
            List<Food> fds = new List<Food>();
            string sql = "select * from Food where FoodName='" + FoodName + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                string strTime = dr["FoodTime"].ToString();
                DateTime date = Convert.ToDateTime(strTime);
                Food fd = new Food();
                fd.FoodId = (int)dr["FoodId"];
                fd.FoodImage = (string)dr["FoodImage"];
                fd.FoodName = (string)dr["FoodName"];
                fd.FoodTime = date.ToLongTimeString();
                fd.FoodType = (int)dr["FoodType"];
                fd.Price = (decimal)dr["Price"];
                fds.Add(fd);
            }
            dr.Close();
            DBHelper.Closecon();
            return fds;
        }
        #endregion
    }
}

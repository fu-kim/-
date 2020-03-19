using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class FoodService
    {
        #region 查询所有食物信息
        //查询所有菜品信息
        public static List<Foods> SelectFoodAll()
        {
            List<Foods> tb = new List<Foods>();
            string sql = "Select f.FoodId,ft.Ftype,f.FoodName,f.Price,f.FoodTime ";
            sql += "From Food f,FoodType ft Where f.FoodType = ft.FoodTypeId";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Foods tbs = new Foods();
                tbs.FoodId = (int)dr["FoodId"];
                tbs.FoodName = (string)dr["FoodName"];
                tbs.FoodPrice = (decimal)dr["Price"];
                tbs.FoodTime = (TimeSpan)dr["FoodTime"];
                tbs.FoodType = (string)dr["Ftype"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 添加菜品
        public static int InsertFood(Foods F)
        {
            int n = 0;
            string sql = "Insert Food(FoodName,Price,FoodType,FoodTime,FoodImage) ";
            sql += "Values ('{0}','{1}','{2}','{3}','{4}')";
            sql = string.Format(sql, F.FoodName, F.FoodPrice, F.FoodType, F.FoodTime, F.FoodName);
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
        #region 删除菜品
        public static int DeleteFood(string FoodId)
        {
            int n = 0;
            string sql = "delete from Food where FoodId=@FoodId";
            n = DBHelper.ExecutNonQuery(sql, CommandType.Text,
                new SqlParameter[] {
                    new SqlParameter("@FoodId",FoodId)
                });
            return n;
        }
        #endregion
        #region 查询所有热菜食物信息
        //查询所有菜品信息
        public static List<Foods> SelectHotFoodAll()
        {
            List<Foods> tb = new List<Foods>();
            string sql = "Select f.FoodId,ft.Ftype,f.FoodName,f.Price,f.FoodTime ";
            sql += "From Food f,FoodType ft Where f.FoodType = ft.FoodTypeId and ft.FType='热菜'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Foods tbs = new Foods();
                tbs.FoodId = (int)dr["FoodId"];
                tbs.FoodName = (string)dr["FoodName"];
                tbs.FoodPrice = (decimal)dr["Price"];
                tbs.FoodTime = (TimeSpan)dr["FoodTime"];
                tbs.FoodType = (string)dr["Ftype"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 查询所有凉食物信息
        //查询所有菜品信息
        public static List<Foods> SelectColdFoodAll()
        {
            List<Foods> tb = new List<Foods>();
            string sql = "Select f.FoodId,ft.Ftype,f.FoodName,f.Price,f.FoodTime ";
            sql += "From Food f,FoodType ft Where f.FoodType = ft.FoodTypeId and ft.FType='凉菜'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Foods tbs = new Foods();
                tbs.FoodId = (int)dr["FoodId"];
                tbs.FoodName = (string)dr["FoodName"];
                tbs.FoodPrice = (decimal)dr["Price"];
                tbs.FoodTime = (TimeSpan)dr["FoodTime"];
                tbs.FoodType = (string)dr["Ftype"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 查询所有汤食物信息
        //查询所有菜品信息
        public static List<Foods> SelectSoupFoodAll()
        {
            List<Foods> tb = new List<Foods>();
            string sql = "Select f.FoodId,ft.Ftype,f.FoodName,f.Price,f.FoodTime ";
            sql += "From Food f,FoodType ft Where f.FoodType = ft.FoodTypeId and ft.FType='汤'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Foods tbs = new Foods();
                tbs.FoodId = (int)dr["FoodId"];
                tbs.FoodName = (string)dr["FoodName"];
                tbs.FoodPrice = (decimal)dr["Price"];
                tbs.FoodTime = (TimeSpan)dr["FoodTime"];
                tbs.FoodType = (string)dr["Ftype"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 查询所有饮料食物信息
        //查询所有菜品信息
        public static List<Foods> SelectWineFoodAll()
        {
            List<Foods> tb = new List<Foods>();
            string sql = "Select f.FoodId,ft.Ftype,f.FoodName,f.Price,f.FoodTime ";
            sql += "From Food f,FoodType ft Where f.FoodType = ft.FoodTypeId and ft.FType='饮品'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Foods tbs = new Foods();
                tbs.FoodId = (int)dr["FoodId"];
                tbs.FoodName = (string)dr["FoodName"];
                tbs.FoodPrice = (decimal)dr["Price"];
                tbs.FoodTime = (TimeSpan)dr["FoodTime"];
                tbs.FoodType = (string)dr["Ftype"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 查询所有其他食物信息
        //查询所有菜品信息
        public static List<Foods> SelectElseFoodAll()
        {
            List<Foods> tb = new List<Foods>();
            string sql = "Select f.FoodId,ft.Ftype,f.FoodName,f.Price,f.FoodTime ";
            sql += "From Food f,FoodType ft Where f.FoodType = ft.FoodTypeId and ft.FType='其他'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Foods tbs = new Foods();
                tbs.FoodId = (int)dr["FoodId"];
                tbs.FoodName = (string)dr["FoodName"];
                tbs.FoodPrice = (decimal)dr["Price"];
                tbs.FoodTime = (TimeSpan)dr["FoodTime"];
                tbs.FoodType = (string)dr["Ftype"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 修改菜品      
        public static int UpdateFood(Foods CII)
        {
            int n = 0;
            string sql = "Update Food Set FoodName='{0}',Price='{1}',";
            sql += "FoodType='{2}',FoodTime='{3}' Where FoodId='{4}'";
            sql = string.Format(sql, CII.FoodName, CII.FoodPrice, CII.FoodType, CII.FoodTime, CII.FoodId);
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
    }
}

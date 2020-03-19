using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class OrderServer
    {
        #region 添加订单
        public static int InsertOrder(string OrderID, int Table)
        {
            int n = 0;
            string sql = "insert OrderID values('" + OrderID + "','" + Table + "')";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 添加订单信息
        public static int InsertOrderInfo(int TableId, string OrderId, string FName, decimal FPrice, int FNumber)
        {
            int n = 0;
            string sql = "insert OrderInfo values('" + TableId + "','" + OrderId + "','" + FName + "','" + FPrice + "','" + FNumber + "');";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 查询菜品是否存在
        public static object selectFName(string OrderId,string FName)
        {
            object od = "";
            string sql = "select FName from OrderInfo where OrderId = '"+ OrderId + "' and FName = '"+ FName + "'";
            od = DBHelper.ExecuteScalar(sql);
            return od;
        }
        #endregion

        #region 查询订单号是否存在
        public static object selectOrderId(string OrderId)
        {
            object od = "";
            string sql = "select OrderId from OrderInfo where OrderId = '" + OrderId + "'";
            od = DBHelper.ExecuteScalar(sql);
            return od;
        }
        #endregion

        #region 增加菜品份数
        public static int UpdateAddFNumber(string FName,string OrderId)
        {
            string sql = sql = "update OrderInfo set FNumber+=1 where FName='" + FName + "' and OrderId='" + OrderId + "'";
            int n= 0;
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 减少菜品份数
        public static int UpdateMinusFNumber(string FName, string OrderId)
        {
            int n = 0;
            string sql = "update OrderInfo set FNumber-=1 where FName='" + FName + "' and OrderId='" + OrderId + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 查询所有订单信息
        public static List<Order> SelectOrderInfo(string OrderId)
        {
            List<Order> n = new List<Order>();
            string sql = "select * from OrderInfo where OrderId='"+ OrderId + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Order od = new Order();
                od.FName = dr["FName"].ToString();
                od.OrderId = dr["OrderId"].ToString();
                od.FNumber =(int) dr["FNumber"];
                od.FPrice =(decimal)dr["FPrice"];
                n.Add(od);
            }
            dr.Close();
            DBHelper.Closecon();
            return n;
        }
        #endregion

        #region 删除订单
        public static int DeleteOrder(string OrderId, string FName)
        {
            int n = 0;
            string sql = "delete from OrderInfo where OrderId='" + OrderId + "' and FName='" + FName + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 删除所有订单
        public static int DeleteOrderAll()
        {
            int n = 0;
            string sql = "delete from OrderInfo";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 结账
        public static int InsertPayInfo(int TableId, string OrderId,decimal Price,DateTime PayTime,string Remarks,bool IsPay)
        {
            int n = 0;
            string sql = "insert PayInfo values('" + TableId + "','" + OrderId + "','"+ Price + "','"+ PayTime + "','"+ Remarks + "','"+ IsPay + "')";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 结账（伪）
        public static int InsertPay(string OrderId,DateTime PayTime, bool IsPay)
        {
            int n = 0;
            string sql = "insert Pay values('" + OrderId + "','" + PayTime + "','" + IsPay + "')";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 删除结账（伪）
        public static int DeletePay()
        {
            int n = 0;
            string sql = "delete from pay";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 判断是否付款
        public static object SelectIsPay(string PayId)
        {
            object ob = "";
            string sql = "select IsPay from PayInfo where PayId='"+ PayId + "'";
            ob = DBHelper.ExecuteScalar(sql);
            return ob;
        }
        #endregion

        #region 添加口味信息
        public static int InsertSpicyInfo(string OrderId, string FName, int FNumber, string Spicy)
        {
            int n = 0;
            string sql = "insert SpicyInfo values('" + OrderId + "','" + FName + "','" + FNumber + "','" + Spicy + "')";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;

        }
        #endregion

        #region 查询菜品份数
        public static object SelectFNumBer(string OrderId, string FName)
        {
            object oj = "";
            string sql = "select FNumBer from OrderInfo where OrderId = '" + OrderId + "' and FName = '" + FName + "'";
            oj = DBHelper.ExecuteScalar(sql);
            return oj;
        }
        #endregion

        #region 查询所有口味信息
        public static List<Order> SelectSpicy(string OrderId,string FName)
        {
            List<Order> od = new List<Order>();
            string sql = "select * from SpicyInfo where OrderId='"+ OrderId + "' and FName='"+ FName + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Order ods = new Order();
                ods.OrderId =(string) dr["OrderId"];
                ods.FName = (string)dr["FName"];
                ods.FNumber = (int)dr["FNumber"];
                ods.Spicy = (string)dr["Spicy"];
                od.Add(ods);
            }
            dr.Close();
            DBHelper.Closecon();
            return od;
        }
        #endregion

        #region 删除口味信息
        public static int DeleteSpicy(string OrderId,string FName, int FNumber)
        {
            int n = 0;
            string sql = "delete from SpicyInfo where OrderId='" + OrderId + "' and FName='"+ FName + "' and FNumber='" + FNumber + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 修改口味份数
        public static int UpdateSpicyFNumber(int FNumber, string OrderId, string FName,int oldFNumber)
        {
            int n = 0;
            string sql = "update Spicyinfo set FNumber='" + FNumber + "' where OrderId='" + OrderId + "' and FName='" + FName + "' and FNumber='"+ oldFNumber + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
    }
}

using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderService
    {
        #region 查询所有订单信息
        //查询所有订单信息
        public static List<OrderInfo> SelectOrderAll()
        {
            List<OrderInfo> lo = new List<OrderInfo>();
            string sql = "select top 200 * from PayInfo";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                OrderInfo o = new OrderInfo();
                o.TableId = (int)dr["TableId"];
                o.OrderId = (string)dr["OrderId"];
                o.Price = (decimal)dr["Price"];
                o.PayTime = (DateTime)dr["PayTime"];
                string ss = dr["Remarks"].ToString();
                if (ss!=null)
                {
                    ss = "无";
                    o.Remarks = ss;
                }
                string s = dr["IsPay"].ToString();
                o.IsPay = s == "True" ? "是" : "否";
                lo.Add(o);
            }
            dr.Close();
            DBHelper.Closecon();
            return lo;
        }
        #endregion

        #region 查询所有订单详细信息
        //查询所有订单信息
        public static List<OrderInfos> SelectOrdersAll()
        {
            List<OrderInfos> lo = new List<OrderInfos>();
            string sql = "select top 200 * from OrderInfo";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                OrderInfos o = new OrderInfos();
                o.TableId = (int)dr["TableId"];
                o.OrderId = (string)dr["OrderId"];
                o.FPrice = (decimal)dr["FPrice"];
                o.FName = (string)dr["FName"];
                o.FNumber = (int)dr["FNumber"];
                lo.Add(o);
            }
            dr.Close();
            DBHelper.Closecon();
            return lo;
        }
        #endregion

        #region 选中的订单的订单详细信息
        public static List<OrderInfos> SelectOrderInfo(string orderId)
        {
            List<OrderInfos> los = new List<OrderInfos>();
            string sql = "select top 200 * from OrderInfo where OrderId='" + orderId+"'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                OrderInfos os = new OrderInfos();
                os.TableId = (int)dr["TableId"];
                os.OrderId = (string)dr["OrderId"];
                os.FPrice = (decimal)dr["FPrice"];
                os.FName = (string)dr["FName"];
                os.FNumber = (int)dr["FNumber"];

                los.Add(os);
            }
            dr.Close();
            DBHelper.Closecon();
            return los;
        }
        #endregion

        #region 订单桌号模糊查询查询
        public static List<OrderInfo> SelectOrderBycon(OrderInfo o)
        {
            List<OrderInfo> loi = new List<OrderInfo>();
            string sql = "select * from PayInfo where TableId like '%"+o.TableId+"%' and OrderId  like '%"+o.OrderId+"%'  ";
            sql += "and datediff(dd,'"+ o.PayTime + "',PayTime)=0 ";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                o = new OrderInfo();
                o.TableId = (int)dr["TableId"];
                o.OrderId = (string)dr["OrderId"];
                o.Price = (decimal)dr["Price"];
                o.PayTime = (DateTime)dr["PayTime"];
                string ss = dr["Remarks"].ToString();
                if (ss != null)
                {
                    ss = "无";
                    o.Remarks = ss;
                }
                string s = dr["IsPay"].ToString();
                o.IsPay = s == "True" ? "是" : "否";

                loi.Add(o);
            }
            dr.Close();
            DBHelper.Closecon();
            return loi;
        }
        #endregion

        #region 根据日期查询订单
        public static List<OrderInfo> SelectOrderByDate(string time,string time2)
        {
            List<OrderInfo> los = new List<OrderInfo>();
            string sql = "select * from PayInfo where PayTime between '"+time+ "' and  '" + time2 + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                OrderInfo o = new OrderInfo();
                o.TableId = (int)dr["TableId"];
                o.OrderId = (string)dr["OrderId"];
                o.Price = (decimal)dr["Price"];
                o.PayTime = (DateTime)dr["PayTime"];
                string ss = dr["Remarks"].ToString();
                if (ss != null)
                {
                    ss = "无";
                    o.Remarks = ss;
                }
                string s = dr["IsPay"].ToString();
                o.IsPay = s == "True" ? "是" : "否";

                los.Add(o);
            }
            dr.Close();
            DBHelper.Closecon();
            return los;
        }
        #endregion

        #region 根据日期删除订单
        public static int DeleteOrderByDate(string time, string time2)
        {
            int n = 0;
            string sql = "delete from PayInfo where PayTime between '" + time + "' and  '" + time2 + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 根据单个日期查询订单
        public static List<OrderInfo> SelectOrderByDateOne(OrderInfo time)
        {
            List<OrderInfo> los = new List<OrderInfo>();
            string sql = "select * from PayInfo where datediff(dd,'" + time.PayTime + "',PayTime)=0";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while(dr.Read())
            {
                OrderInfo o = new OrderInfo();
                o.TableId = (int)dr["TableId"];
                o.OrderId = (string)dr["OrderId"];
                o.Price = (decimal)dr["Price"];
                o.PayTime = (DateTime)dr["PayTime"];
                string ss = dr["Remarks"].ToString();
                if (ss != null)
                {
                    ss = "无";
                    o.Remarks = ss;
                }
                string s = dr["IsPay"].ToString();
                o.IsPay = s == "True" ? "是" : "否";
                los.Add(o);
            }
            dr.Close();
            DBHelper.Closecon();
            return los;
        }
        #endregion

    }
}

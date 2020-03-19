using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class TableService
    {
        #region 查询所有餐桌信息
        //查询所有餐桌信息
        public static List<Table> SelectTableAll()
        {
            List<Table> tb = new List<Table>();
            string sql = "select top 200 * from TableInfo";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Table tbs = new Table();
                tbs.TableId = (int)dr["TableId"];
                tbs.TableTypeId = (int)dr["TableTypeId"];
                tbs.IsService = (int)dr["IsService"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion

        #region 根据桌号查询桌状态
        public static object SelectTypebyId(string TableId)
        {
            object oj = null;
            string sql= "select TableState from TableType where TableTypeId in( select TableTypeId from TableInfo where TableId='"+ TableId + "')";
            oj = DBHelper.ExecuteScalar(sql);
            return oj;
        }
        #endregion

        #region 选中的餐桌订单信息
        public static List<Order> SelectOrderInfo(string TableId)
        {
            List<Order> od = new List<Order>();
            string sql = "select * from TableNowInfo t,TableInfo tt where tt.TableId=t.TableId and t.TableId='"+ TableId + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                Order ods = new Order();
                ods.OrderId = (string)dr["OrderId"];
                ods.IsPay = (bool)dr["IsPay"];
                ods.Price = (decimal)dr["Price"];
                ods.PayTime = (DateTime)dr["PayTime"];
                ods.Remarks = (string)dr["Remarks"];
                od.Add(ods);
            }
            dr.Close();
            DBHelper.Closecon();
            return od;
        }
        #endregion

        #region 查询餐桌是否要服务
        /// <summary>
        /// 查询餐桌是否要服务
        /// </summary>
        /// <returns></returns>
        public static List<Table> SelectTableIsService()
        {
            List<Table> tb = new List<Table>();
            string sql = "select TableId from TableInfo where IsService != 0";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Table tbs = new Table();
                tbs.TableId = (int)dr["TableId"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 查询餐桌是否要服务类型
        /// <summary>
        /// 查询餐桌是否要服务类型
        /// </summary>
        /// <returns></returns>
        public static List<Table> SelectTableIsServiceType(string TableId)
        {
            List<Table> tb = new List<Table>();
            string sql = "select IsService from TableInfo where TableId = '" + TableId + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Table tbs = new Table();
                tbs.IsService = (int)dr["IsService"];
                tb.Add(tbs);
            }
            dr.Close();
            DBHelper.Closecon();
            return tb;
        }
        #endregion
        #region 服务状态
        public static int UpdateIsService(string TableId, int IsService)
        {
            int n = 0;
            string sql = "update TableInfo set IsService='" + IsService + "' where TableId='" + TableId + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;

        }
        #endregion

        #region 根据桌号改变状态
        public static int UpdateTypebyTableId(int Tablestate, string TableId)
        {
            int n = 0;
            string sql = "update TableInfo set TableTypeId='" + Tablestate + "',IsService='0' where TableId='" + TableId + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion
    }
}

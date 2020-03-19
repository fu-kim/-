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
     public class TableServer
    {
        #region 根据桌号改变状态
        public static int UpdateTypebyTableId(int Tablestate, string TableId)
        {
            int n = 0;
            string sql = "update TableInfo set TableTypeId='"+ Tablestate + "' where TableId='" + TableId+"'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 添加当前桌状态信息
        public static int InsertTableNowInfo(string TableId,string OrderId,DateTime PayTime,decimal Price,string Remarks,bool IsPay)
        {
            int n = 0;
            string sql = "insert TableNowInfo values('"+ TableId + "','"+ OrderId + "','"+ PayTime + "','"+ Price + "',"+ Remarks + "'','"+ IsPay + "')";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 查询当前桌状态信息
        public static List<Tables> SelectTableNowInfo(string TableId)
        {
            List<Tables> tbs = new List<Tables>();
            string sql = "select * from TableNowInfo where TableId='"+ TableId + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                Tables tb = new Tables();
                tb.TableId = (int)dr["TableId"];
                tb.OrderId = (string)dr["OrderId"];
                tb.PayTime = (DateTime)dr["PayTime"];
                tb.Price = (decimal)dr["Price"];
                tb.Remarks = (string)dr["Remarks"];
                tb.IsPay = (bool)dr["IsPay"];
                tbs.Add(tb);
            }
            dr.Close();
            DBHelper.Closecon();
            return tbs;
        }
        #endregion
        #region 修改当前桌状态信息
        public static int  UpdateTableNowInfo(string TableId, string OrderId, DateTime PayTime, decimal Price, string Remarks, bool IsPay)
        {
            int n = 0;
            string sql = "update TableNowInfo set OrderId='" + OrderId + "',PayTime='"+ PayTime + "',Price='"+ Price + "',Remarks='"+ Remarks + "',IsPay='"+ IsPay + "' where TableId='" + TableId + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 修改服务状态
        public static int UpdateIsService(string TableId,int IsService)
        {
            int n = 0;
            string sql = "update TableInfo set IsService='" + IsService + "' where TableId='"+ TableId + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;

        }
        #endregion

        #region 查询是否服务
        public static object SelectTableIsService(string TableId)
        {
            object n = null;
            string sql = "select IsService from TableInfo where TableId='" + TableId + "'";
            n = DBHelper.ExecuteScalar(sql);
            return n;
        }
        #endregion

        #region 查询桌子状态
        public static object SelectTableTypeId(string TableId)
        {
            object n = null;
            string sql = "select TableTypeId from TableInfo where TableId='" + TableId + "'";
            n = DBHelper.ExecuteScalar(sql);
            return n;
        }
        #endregion
    }
}

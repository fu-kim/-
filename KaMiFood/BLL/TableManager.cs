using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TableManager
    {
        #region 根据桌号改变状态
        public static int UpdateTypebyTableId(int Tablestate,string TableId)
        {
            return TableServer.UpdateTypebyTableId(Tablestate,TableId);
        }
        #endregion

        #region 添加当前桌状态信息
        public static int InsertTableNowInfo(string TableId, string OrderId, DateTime PayTime, decimal Price, string Remarks, bool IsPay)
        {
            return TableServer.InsertTableNowInfo(TableId, OrderId, PayTime, Price, Remarks, IsPay);
        }
        #endregion

        #region 查询当前桌状态信息
        public static List<Tables> SelectTableNowInfo(string TableId)
        {
            return TableServer.SelectTableNowInfo(TableId);
        }
        #endregion
        #region 修改当前桌状态信息
        public static int UpdateTableNowInfo(string TableId, string OrderId, DateTime PayTime, decimal Price, string Remarks, bool IsPay)
        {
            return TableServer.UpdateTableNowInfo(TableId, OrderId, PayTime, Price, Remarks, IsPay);
        }
        #endregion

        #region 服务状态
        public static int UpdateIsService(string TableId, int IsService)
        {
            return TableServer.UpdateIsService(TableId, IsService);
        }
        #endregion

        #region 查询是否服务
        public static object SelectTableIsService(string TableId)
        {
            return TableServer.SelectTableIsService(TableId);
        }
        #endregion

        #region 查询桌子状态
        public static object SelectTableTypeId(string TableId)
        {
            return TableServer.SelectTableTypeId(TableId);
        }
        #endregion

    }
}

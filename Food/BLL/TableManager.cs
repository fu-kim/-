using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class TableManager
    {
        #region 查询所有餐桌信息
        //查询所有餐桌信息
        public static List<Table> SelectTableAll()
        {
            return TableService.SelectTableAll();
        }
        #endregion

        #region 根据桌号查询桌状态
        public static object SelectTypebyId(string TableId)
        {
            return TableService.SelectTypebyId(TableId);
        }
        #endregion

        #region 选中的餐桌订单信息
        public static List<Order> SelectOrderInfo(string TableId)
        {
            return TableService.SelectOrderInfo(TableId);
        }
        #endregion

        #region 查询餐桌是否要服务
        /// <summary>
        /// 查询餐桌是否要服务
        /// </summary>
        /// <returns></returns>
        public static List<Table> SelectTableIsService()
        {
            return TableService.SelectTableIsService();
        }
        #endregion

        #region 查询餐桌是否要服务类型
        /// <summary>
        /// 查询餐桌是否要服务类型
        /// </summary>
        /// <returns></returns>
        public static List<Table> SelectTableIsServiceType(string TableId)
        {
            return TableService.SelectTableIsServiceType(TableId);
        }
        #endregion

        #region 服务状态
        public static int UpdateIsService(string TableId, int IsService)
        {
            return TableService.UpdateIsService(TableId, IsService);
        }
        #endregion

        #region 根据桌号改变状态
        public static int UpdateTypebyTableId(int Tablestate, string TableId)
        {
            return TableService.UpdateTypebyTableId(Tablestate, TableId);
        }
        #endregion
    }
}

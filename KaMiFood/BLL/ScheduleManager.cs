using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ScheduleManager
    {
        #region 查询所有菜品进度信息（从别的表多表连接）
        public static List<Schedule> selectScheduleValues()
        {
            return ScheduleServer.selectScheduleValues();
        }
        #endregion

        #region 添加进度信息
        public static int InsertSchedule(int TableId,string OrderId, string FName, string FTime, int FNumber, bool IsPay)
        {
            return ScheduleServer.InsertSchedule(TableId,OrderId, FName, FTime, FNumber, IsPay);
        }
        #endregion

        #region 查询所有菜品进度信息
        public static List<Schedule> selectSchedule()
        {
            return ScheduleServer.selectSchedule();
        }
        #endregion
        #region 根据订单号菜名查询菜品进度信息
        public static List<Schedule> selectScheduleByOrderIdFName(string OrderId, string Fname)
        {
            return ScheduleServer.selectScheduleByOrderIdFName(OrderId, Fname);
        }
        #endregion
        #region 删除所有进度信息
        public static int DeleteSchedule()
        {
            return ScheduleServer.DeleteSchedule();
        }
        #endregion
    }
}

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
    public class ActivityManager
    {
        #region 查询所有活动信息
        public static List<Activity> SelectActivityAll()
        {
            return ActivityServer.SelectActivityAll() ;
        }
        #endregion

        #region 根据活动名称查找菜品
        public static List<Activity> SelectActivityFoodAll(string AName)
        {
            return ActivityServer.SelectActivityFoodAll(AName);
        } 
        #endregion
    }
}

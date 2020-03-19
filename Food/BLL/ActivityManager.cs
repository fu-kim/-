using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ActivityManager
    {
        #region 查询所有特殊活动
        public static List<Actiivity> SelectActivityAll()
        {
            return ActivityService.SelectActivityAll();
        }
        #endregion
        #region 查询所有及日日活动
        public static List<Actiivity> SelectFestivalActivityAll()
        {
            return ActivityService.SelectFestivalActivityAll();
        }
        #endregion
        #region 根据名称删除
        public static int DeleteActivityByAName(string Aname)
        {
            return ActivityService.DeleteActivityByAName(Aname);
        }
        #endregion
        #region 根据名称删除
        public static int DeleteTextActivityByAName(string Aname)
        {
            return ActivityService.DeleteTextActivityByAName(Aname);
        }
        #endregion
        #region 更新        
        public static int UpdateActivity(string name, DateTime time, DateTime time2, string name2)
        {
            return ActivityService.UpdateActivity(name,time,time2,name2);
        }
        #endregion
        #region 更新        
        public static int UpdateTextActivity(string name, DateTime time, DateTime time2, string name2)
        {
            return ActivityService.UpdateTextActivity(name, time, time2, name2);
        }
        #endregion
    }
}

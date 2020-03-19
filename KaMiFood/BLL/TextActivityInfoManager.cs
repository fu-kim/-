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
    public class TextActivityInfoManager
    {
        #region 查询所有活动信息
        public static List<TextActivityInfo> SelectTextActivityAll()
        {
            return TextActivityInfoServer.SelectTextActivityAll() ;
        }
        #endregion
    }
}

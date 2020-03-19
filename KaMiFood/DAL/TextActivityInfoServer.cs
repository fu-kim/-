using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TextActivityInfoServer
    {
        #region 查询文本所有活动信息
        public static List<TextActivityInfo> SelectTextActivityAll()
        {
            List<TextActivityInfo> ay = new List<TextActivityInfo>();
            string sql = "select * from TextActivityInfo";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                TextActivityInfo ays = new TextActivityInfo();
                ays.ActivityId = (int)dr["ActivityId"];
                ays.AName = (string)dr["AName"];
                ays.ATime = (DateTime)dr["ATime"];
                ays.ATimeEnd = (DateTime)dr["ATimeEnd"];
                ay.Add(ays);
            }
            dr.Close();
            DBHelper.Closecon();
            return ay;
        }
        #endregion
    }
}

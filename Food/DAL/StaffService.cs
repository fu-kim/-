using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffService
    {

        #region 查询所有员工信息
        public static List<StaffInfo> SelectStaffAll()
        {
            List<StaffInfo> ls = new List<StaffInfo>();
            string sql = " select o.*,s.StaffType from StaffTypeInfo s,StaffInfo o where  s.TypeId=o.TypeId";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                StaffInfo si = new StaffInfo();
                si.StaffId = (int)dr["StaffId"];
                si.StaffPasd = (int)dr["StaffPasd"];
                si.StaffName = (string)dr["StaffName"];
                si.StaffSex = (string)dr["StaffSex"];
                si.StaffAge = (int)dr["StaffAge"];
                si.StaffBirthday = Convert.ToDateTime(dr["StaffBirthday"]);
                string ad = (string)dr["StaffAddress"];
                if (ad!=null)
                {
                    si.StaffAddress = ad;
                }
                
                si.StaffTel = (string)dr["StaffTel"];
                si.StaffCardId = (string)dr["StaffCardId"];
                string ec= (string)dr["EContact"]; ;
                if (ec!= null)
                {
                    si.EContact = ec;
                }
                string et= (string)dr["EContactTel"];
                if (et!= null)
                {
                    si.EContactTel = et;
                }
                string sp = (string)dr["StaffPot"];
                if (sp!= null)
                {
                    si.StaffPot = sp;
                }
                si.TypeId = (string)dr["TypeId"];

                ls.Add(si);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
        #endregion

        #region 查询所有员工类型
        public static List<StaffType> SelectStaffTypeAll()
        {
            List<StaffType> ls = new List<StaffType>();
            string sql = "select * from StaffTypeInfo ";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                StaffType si = new StaffType();
                si.TypeId = (string)dr["TypeId"];
                si.StaffTypeName = (string)dr["StaffTypeName"];
                ls.Add(si);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
        #endregion

        #region 根据ID查询员工类型
        //根据ID查询员工类型
        public static StaffInfo SelectStaffTypeByStaffId(string Id)
        {
            StaffInfo si = null;
            string sql = "select * from StaffTypeInfo where StaffId='"+Id+"'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                si = new StaffInfo();
                si.StaffId = (int)dr["StaffId"];
            }
            dr.Close();
            DBHelper.Closecon();
            return si;
        }
        #endregion
        
        #region 根据ID删除员工
        public static int DeleteStaff(string id)
        {
            int n = 0;
            string sql = "delete from StaffInfo where StaffId='" + id + "'";
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 添加员工
        public static int InsertStaff(StaffInfo s)
        {
            int n = 0;
            string sql = "insert into StaffInfo(StaffName,StaffSex,StaffAge,StaffBirthday,";
            sql+= "StaffTel,StaffCardId,TypeId,StaffAddress,EContact,EContactTel) ";
            sql += "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')";
            sql = string.Format(sql,s.StaffName,s.StaffSex,s.StaffAge,s.StaffBirthday,s.StaffTel
                ,s.StaffCardId,s.TypeId,s.StaffAddress,s.EContact,s.EContactTel);
            n = DBHelper.ExecuteNonQuery(sql);
           return n;
        }
        #endregion

        #region 修改信息
        public static int UpdateStaff(StaffInfo s)
        {
            int n = 0;
            string sql = "update StaffInfo set StaffName='{1}',StaffSex='{2}',StaffAge='{3}',";
            sql += "StaffBirthday='{4}',StaffTel='{5}',StaffCardId='{6}',TypeId='{7}',";
            sql += "StaffAddress='{8}',EContact='{9}',EContactTel='{10}' where StaffId='{0}'";
            sql = string.Format(sql,s.StaffId, s.StaffName, s.StaffSex, s.StaffAge, 
                s.StaffBirthday,s.StaffTel, s.StaffCardId, s.TypeId, s.StaffAddress, 
                s.EContact, s.EContactTel);
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion

        #region 查询身份证
        public static StaffInfo SelectStaffByCID(string s)
        {
            StaffInfo si = null;
            string sql = "select StaffCardId from StaffInfo where StaffCardId='" + s + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                si = new StaffInfo();
                si.StaffCardId = (string)dr["StaffCardId"];
            }
            dr.Close();
            DBHelper.Closecon();
            return si;
        }
        #endregion

        #region 根据ID查询员工信息
        //根据ID查询员工信息
        public static StaffInfo SelectStaffByStaffId(string id)
        {
            StaffInfo si = null;
            string sql = " select o.*,s.StaffType from StaffTypeInfo s,StaffInfo o where  s.TypeId=o.TypeId and StaffId='" + id+"'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                si = new StaffInfo();
                si.StaffId = (int)dr["StaffId"];
                si.StaffName = (string)dr["StaffName"];
                si.StaffSex = (string)dr["StaffSex"];
                si.StaffAge = (int)dr["StaffAge"];
                si.StaffBirthday = Convert.ToDateTime(dr["StaffBirthday"]);
                string ad = (string)dr["StaffAddress"];
                if (ad != null)
                {
                    si.StaffAddress = ad;
                }

                si.StaffTel = (string)dr["StaffTel"];
                si.StaffCardId = (string)dr["StaffCardId"];
                string ec = (string)dr["EContact"]; ;
                if (ec != null)
                {
                    si.EContact = ec;
                }
                string et = (string)dr["EContactTel"];
                if (et != null)
                {
                    si.EContactTel = et;
                }
                string sp = (string)dr["StaffPot"];
                if (sp != null)
                {
                    si.StaffPot = sp;
                }
                si.TypeId = (string)dr["TypeId"];
            }
            dr.Close();
            DBHelper.Closecon();
            return si;
        }
        #endregion
        public static List<StaffInfo> SelectStaffByIDNAME(StaffInfo c)
        {
            List<StaffInfo> ls = new List<StaffInfo>();
            string sql = "select* from StaffInfo  where  StaffId like '%" + c.StaffId + "%' ";
            sql += " and StaffName like '%" + c.StaffName + "%' and StaffTel like '%" + c.StaffTel + "%' and StaffCardId like '%" + c.StaffCardId + "%'";
            SqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                StaffInfo si = new StaffInfo();
                si.StaffId = (int)dr["StaffId"];
                si.StaffName = (string)dr["StaffName"];
                si.StaffSex = (string)dr["StaffSex"];
                si.StaffAge = (int)dr["StaffAge"];
                si.StaffBirthday = Convert.ToDateTime(dr["StaffBirthday"]);
                string ad = (string)dr["StaffAddress"];
                if (ad != null)
                {
                    si.StaffAddress = ad;
                }

                si.StaffTel = (string)dr["StaffTel"];
                si.StaffCardId = (string)dr["StaffCardId"];
                string ec = (string)dr["EContact"]; ;
                if (ec != null)
                {
                    si.EContact = ec;
                }
                string et = (string)dr["EContactTel"];
                if (et != null)
                {
                    si.EContactTel = et;
                }
                string sp = (string)dr["StaffPot"];
                if (sp != null)
                {
                    si.StaffPot = sp;
                }
                si.TypeId = (string)dr["TypeId"];

                ls.Add(si);
            }
            dr.Close();
            DBHelper.Closecon();
            return ls;
        }
    }
}

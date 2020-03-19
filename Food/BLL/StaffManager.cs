using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StaffManager
    {
        //所有员工信息
        public static List<StaffInfo> SelectStaffAll()
        {
            return StaffService.SelectStaffAll();
        }
        //所有类型信息
        public static List<StaffType> SelectStaffTypeAll()
        {
            return StaffService.SelectStaffTypeAll();
        }
        //根据ID查询员工类型
        public static StaffInfo SelectStaffByStaffId(string id)
        {
            return StaffService.SelectStaffTypeByStaffId(id);
        }

         //根据ID删除员工
        public static int DeleteStaffInfo(string id)
        {
            return StaffService.DeleteStaff(id);
        }

        //添加员工
        public static int InsertStaff(StaffInfo s)
        {
            return StaffService.InsertStaff(s);
        }

        //修改员工
        public static int UpdateStaff(StaffInfo s)
        {
            return StaffService.UpdateStaff(s);
        }
        //根据身份证查询员工
        public static StaffInfo SelectStaffByCID(string id)
        {
            return StaffService.SelectStaffByCID(id);
        }
        //根据ID查员工
        public static StaffInfo SelectStaffInfoByStaffId(string id)
        {
            return StaffService.SelectStaffByStaffId(id);
        }
        //根据ID姓名手机号身份证查员工
        public static List<StaffInfo> SelectStaffByIDNAME(StaffInfo id)
        {
            return StaffService.SelectStaffByIDNAME(id);
        }
    }
}

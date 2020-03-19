using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MemberManager
    {
        #region 查询所有会员信息
        public static List<Member> SelectMemberAll()
        {
            return MemberService.SelectMemberAll();
        }
        #endregion

        #region 添加会员
        public static int InsertMember(string MemberName, string MemberTel, string MemberPwd, string MemberSex, string MemberAge, DateTime OpenCardTime)
        {
            return MemberService.InsertMember(MemberName, MemberTel, MemberPwd, MemberSex, MemberAge, OpenCardTime);
        }
        #endregion

        #region 修改会员
        public static int UpdateMember(int MemberId, string MemberName, string MemberTel, string MemberPwd, string MemberSex, string MemberAge, DateTime OpenCardTime)
        {
            return MemberService.UpdateMember( MemberId,  MemberName,  MemberTel,  MemberPwd,  MemberSex,  MemberAge,  OpenCardTime);
        }
        #endregion

        #region 删除会员
        public static int DeleteMember(int MemberId)
        {
            return MemberService.DeleteMember(MemberId);
        }
        #endregion

        #region 查询会员电话是否存在
        public static bool SelectMemberTel(string Tel)
        {
            return MemberService.SelectMemberTel(Tel);
        }
        #endregion

        public static List<Member> SelectMemberTelbyAll(string Tel)
        {
            return MemberService.SelectMemberTelbyAll(Tel);
        }
    }
}

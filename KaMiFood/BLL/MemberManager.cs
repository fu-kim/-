﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class MemberManager
    {
        public static List<Member> SelectMemberTelbyAll(string Tel)
        {
            return MemberServer.SelectMemberTelbyAll(Tel);
        }
    }
}

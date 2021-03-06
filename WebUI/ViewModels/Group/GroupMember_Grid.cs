﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.ViewModels.Group
{
    public class GroupMember_Grid
    {
        public int GroupID { get; set; }
        public long GroupMemberID { get; set; }
        public long PersonID { get; set; }
        public string GroupMemberType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string MemberType { get; set; }
        public DateTime Birthday { get; set; }
        public int CurrentAge { get; set; }
        public string HasLogin { get; set; }

        public GroupMember_Grid()
        {
            CurrentAge = Helpers.MathHelpers.GetAnniversaryCount(Birthday);
        }

        public GroupMember_Grid(long personID)
        {
            CurrentAge = Helpers.MathHelpers.GetAnniversaryCount(Birthday);
        }



    }
}


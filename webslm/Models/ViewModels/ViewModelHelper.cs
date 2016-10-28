using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSLMMembership;

namespace WebSLM.Models.ViewModels
{
    public static class ViewModelHelper
    {
        public static MemberViewModel ToViewModel (this Member member)
        {
            var memberViewModel = new MemberViewModel
            {
                FirstName = member.Firstname,
                MemberID = member.MemberID,
                LastName = member.Lastname

            };
            return memberViewModel;
        }

        public static Member ToDomainModel (this MemberViewModel memberViewModel)
        {
            var member = new Member();
            member.Firstname = memberViewModel.FirstName;
            member.Lastname = memberViewModel.LastName;
            member.MemberID = memberViewModel.MemberID;


            return member;

        }

    }
}
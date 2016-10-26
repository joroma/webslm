using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSLMMembership
{

    private enum Types { regular, associate };

    public class Member
    {
        public int MemberID { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string MemberType { get; set; }

        public ICollection<MembershipFee> MemFee { get; set; }


    }
}

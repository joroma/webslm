using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSLMDomain;

namespace WebSLMMembership
{

    //private enum Types { regular, associate };

    public class Member
    {
        public int MemberID { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Middlename { get; set; }
        public virtual string Lastname { get; set; }
        public virtual DateTime Birthdate { get; set; }
        public virtual string MemberType { get; set; }
        public virtual bool IsApproved  { get; set; }

        public int RecordLogID { get; set; }

        public virtual ICollection<MembershipFee> MemFee { get; set; }
        public virtual ICollection<MemberAddress> MemberAddress { get; set; }

        public virtual RecordLog RecordLog {get; set;}

        
    }
}

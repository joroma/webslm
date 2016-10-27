using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSLMMembership
{
    class MemberAddress
    {
        public int AddresssID { get; set; }
        public int MemberID { get; set; }
        public string AddressType { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        public int CountryID { get; set; }

    }
}

using System.Data.Entity;
using WebSLMMembership;



namespace WebSLMDatabase
{
    public class WebSLMContext : DbContext
    {

        public WebSLMContext() : base("DefaultConnection")
        {

        }

        public DbSet<Member> Members { get; set; }
        public DbSet<MemberAddress> MemberAddresses { get; set; }

        public System.Data.Entity.DbSet<WebSLMDomain.RecordLog> RecordLogs { get; set; }


    }
}

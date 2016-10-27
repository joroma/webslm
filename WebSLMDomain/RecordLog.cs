using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSLMDomain
{
    public class RecordLog
    {
        public int RecordLogID { get; set; }

        public string CreationOperator { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public void AssignLog (DateTime createDate, DateTime updateDate, string Operator)
        {
            CreationOperator = Operator;
            if (createDate != null)
            {
                CreationDate = createDate;
            }
            LastUpdateDate = updateDate;
        }

        

    }
}

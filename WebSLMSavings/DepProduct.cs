using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSLMSavings
{
    class DepProduct
    {
        public int DepProductID { get; set; }
        public string Description { get; set; }

        public int ChartID { get; set; }

        public decimal MaintainingBalance { get; set; }

    }
}

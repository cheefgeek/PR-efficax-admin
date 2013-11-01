using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class Price
    {
        public int PriceID { get; set; }
        public int PriceListID { get; set; }
        public enumBillingInterval BillingInterval { get; set; }
        public decimal Amount { get; set; }
    }
}

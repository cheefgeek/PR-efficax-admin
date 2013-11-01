using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class Address
    {
        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        public int LocationID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string StateProv { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByPersonID { get; set; }

    }
}

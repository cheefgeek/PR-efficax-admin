using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class Location
    {
        public int LocationID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int AddressID { get; set; }
        public Address Address { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string OrgName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProv { get; set; }
        public string PostalCode { get; set; }
        public int ParentCustomerID { get; set; }
        public virtual List<Address> Addresses { get; set; }
        public virtual List<Group> Groups { get; set; }
        public virtual List<Person> People { get; set; }
        //public virtual List<Role> Roles { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Person CreatedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public Person ModifiedBy { get; set; }
    }
}

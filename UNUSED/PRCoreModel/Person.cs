using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class Person
    {
        public int PersonID { get; set; }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        //public enumPersonType PersonType { get; set; }
        public virtual List<Group> Groups { get; set; }
        public virtual List<Role> Roles { get; set; }
        public virtual List<ImportantDate> ImportantDates { get; set; }
        public virtual List<GroupLeader> LeadershipPositions { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedByPersonID { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedByPersonID { get; set; }

        //public Person()
        //{
        //    CreatedDateTime = DateTime.Now;
        //}
   }


}
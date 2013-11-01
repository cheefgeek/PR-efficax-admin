using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class Group
    {
        public int GroupID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public enumGroupType GroupType { get; set; }
        public int ParentID { get; set; }
        public Group Parent { get; set; }
        public virtual List<Person> People { get; set; }
        public virtual List<GroupLeader> Leaders { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Person CreatedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public Person ModifiedBy { get; set; }

    }
}

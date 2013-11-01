using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class Role
    {
        public int RoleID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public virtual List<Right> Rights { get; set; }
        public virtual List<Person> People { get; set; }
    }
}
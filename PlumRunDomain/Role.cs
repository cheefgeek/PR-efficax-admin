//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlumRunDomain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public Role()
        {
            this.People = new HashSet<Person>();
            this.Rights = new HashSet<Right>();
        }
    
        public int RoleID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Right> Rights { get; set; }
    }
}

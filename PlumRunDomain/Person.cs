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
    
    public partial class Person
    {
        public Person()
        {
            this.GroupMembers = new HashSet<GroupMember>();
            this.Roles = new HashSet<Role>();
        }
    
        public int PersonID { get; set; }
        public int CustomerID { get; set; }
        public Nullable<int> AddressID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ImageThumbnail { get; set; }
        public string ImageHiRes { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<System.DateTime> ModifiedByDateTime { get; set; }
        public Nullable<int> CreatedByPersonID { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
    
        public virtual ICollection<GroupMember> GroupMembers { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

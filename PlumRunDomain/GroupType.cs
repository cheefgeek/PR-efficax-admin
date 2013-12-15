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
    
    public partial class GroupType
    {
        public GroupType()
        {
            this.Groups = new HashSet<Group>();
            this.GroupMemberTypes = new HashSet<GroupMemberType>();
        }
    
        public int GroupTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<long> CreateByPersonID { get; set; }
        public Nullable<long> ModifiedByPersonID { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    
        public virtual ICollection<Group> Groups { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person Person1 { get; set; }
        public virtual ICollection<GroupMemberType> GroupMemberTypes { get; set; }
    }
}

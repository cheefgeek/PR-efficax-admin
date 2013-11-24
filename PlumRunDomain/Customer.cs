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
    
    public partial class Customer
    {
        public Customer()
        {
            this.Addresses = new HashSet<Address>();
            this.CustomerPayments = new HashSet<CustomerPayment>();
            this.Groups = new HashSet<Group>();
            this.GroupMembers = new HashSet<GroupMember>();
            this.Locations = new HashSet<Location>();
            this.People = new HashSet<Person>();
        }
    
        public int CustomerID { get; set; }
        public string AROrgName { get; set; }
        public string ARAddress1 { get; set; }
        public string ARAddress2 { get; set; }
        public string ARAddress3 { get; set; }
        public string ARCity { get; set; }
        public int ARStateProvID { get; set; }
        public string ARPostalCode { get; set; }
        public int CountryID { get; set; }
        public int PriceID { get; set; }
        public Nullable<System.DateTime> PymtSubscriptionActiveDate { get; set; }
        public string PymtSubscriptionID { get; set; }
        public Nullable<System.DateTime> PymtSubscriptionExpireDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual Price Price { get; set; }
        public virtual StateProvince StateProvince { get; set; }
        public virtual ICollection<CustomerPayment> CustomerPayments { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<GroupMember> GroupMembers { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}

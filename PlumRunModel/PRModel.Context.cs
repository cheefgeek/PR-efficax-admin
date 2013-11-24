﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlumRunModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using PlumRunDomain;
    
    
    public partial class PREntities : DbContext
    {
        public PREntities()
            : base("name=PREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CustomerPayment> CustomerPayments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<BillingInterval> BillingIntervals { get; set; }
        public DbSet<GroupMemberType> GroupMemberTypes { get; set; }
        public DbSet<GroupType> GroupTypes { get; set; }
        public DbSet<Right> Rights { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<RecurringPayment> RecurringPayments { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

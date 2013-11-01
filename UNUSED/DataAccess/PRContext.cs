using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRCoreModel;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccess
{
    public class PRContext : DbContext
    {
        //PRCore
        public DbSet<Address> Address { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupLeader> PersonGroup { get; set; }
        public DbSet<ImportantDate> ImportantDate { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RightDB> RightDB { get; set; }
        public DbSet<Right> Right { get; set; }
        public DbSet<Location> Location { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Code First to ignore PluralizingTableName convention
            // If you keep this convention then the generated tables will have pluralized names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

        //Accounting
        //public DbSet<AccountSetup> AccountSetups { get; set; }
        //public DbSet<NoticeSubscription> NoticeSubscriptions { get; set; }

        //Task Manager

        //Messaging

    }
}

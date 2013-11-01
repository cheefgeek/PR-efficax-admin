using PRCoreModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configs
{
    public class CustomerConfig : ComplexTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //}




    }
}






//namespace DataAccessFluent.Configurations
//{
//    public class AddressConfig : ComplexTypeConfiguration<Address>
//    {
//        public AddressConfig()
//        {
//            Property(a => a.StreetAddress).HasMaxLength(150);
//        }
//    }
//}

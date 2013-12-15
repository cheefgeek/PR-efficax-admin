using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.ViewModels.Person
{
    public class AddressMember_Grid
    {
        public Nullable<int> AddressID { get; set; }
        public long PersonID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string HasLogin { get; set; }
    }
}
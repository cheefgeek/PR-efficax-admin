using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChurchWeb.ViewModels
{
    public class CustomerList_VM : IEnumerable
    {
        public int CustomerID { get; set; }
        public string OrgName { get; set; }
        public string City { get; set; }
        public string StateProv { get; set; }
        public DateTime CreatedDateTime { get; set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
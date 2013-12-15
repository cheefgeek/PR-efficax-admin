using System;
using System.Linq;
using PlumRunDomain;

namespace WebUI.ViewModels.Customer
{
    public class CustomerDelete
    {
        public long CustomerID { get; set; }
        public string AROrgName { get; set; }
        public string ARAddress1 { get; set; }
        public string ARAddress2 { get; set; }
        public string ARAddress3 { get; set; }
        public string ARCity { get; set; }
        public int ARStateProvID { get; set; }
        public string StateProvName { get; set; }
        public string ARPostalCode { get; set; }
    }
}
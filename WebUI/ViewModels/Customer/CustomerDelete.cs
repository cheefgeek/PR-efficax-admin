using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.ViewModels.Customer
{
    public class CustomerDelete
    {
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

        public virtual StateProvince StateProvince { get; set; }
    }
}
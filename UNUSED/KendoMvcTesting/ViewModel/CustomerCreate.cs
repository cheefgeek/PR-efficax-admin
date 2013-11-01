using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.ViewModels
{
    public class CustomerCreate
    {   
        public string AROrgName { get; set; }
        public string ARAddress1 { get; set; }
        public string ARAddress2 { get; set; }
        public string ARAddress3 { get; set; }
        public string ARCity { get; set; }
        public int ARStateProvID { get; set; }
        public string ARPostalCode { get; set; }
        public int CountryID { get; set; }
        public int PriceID { get; set; }
        public System.DateTime ActiveDate { get; set; }
        public Nullable<int> CardTypeID { get; set; }
        public string CardNumber { get; set; }
        public string CardSecurityCode { get; set; }
        public Nullable<int> CardExpMonth { get; set; }
        public Nullable<int> CardExpYear { get; set; }
        public int CreatedByPersonID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
    }
}
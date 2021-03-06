﻿using System;
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
        public Nullable<System.DateTime> ActiveDate { get; set; }
    }
}



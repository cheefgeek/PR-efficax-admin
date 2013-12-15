using System;
using System.Collections.Generic;
using System.Linq;
using PlumRunModel;

namespace WebUI.ViewModels.Address
{
    public class AddressDetail
    {
        public string Attention { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string AddressPhone { get; set; }

        public AddressDetail(int addressID)
        {
            PREntities db = new PREntities();
            PlumRunDomain.Address address = db.Addresses.Find(addressID);

            Attention = address.Attention;
            
    



        }



    }
}
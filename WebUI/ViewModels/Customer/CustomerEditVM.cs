using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.ViewModels.Customer
{
    public class CustomerEditVM
    {
        public Customer.CustomerEdit customerEdit { get; set; }
        public DropDownLists.PricesDropDown pricesDropDown { get; set; }
        public DropDownLists.StateDropDown stateDropDown { get; set; }
        public DropDownLists.CountryDropDown countryDropDown { get; set; }

        public CustomerEditVM(int priceID, int stateProvinceID, int countryID )
        {
            customerEdit = new CustomerEdit();
            pricesDropDown = new DropDownLists.PricesDropDown(priceID);
            stateDropDown = new DropDownLists.StateDropDown(stateProvinceID);
            countryDropDown = new DropDownLists.CountryDropDown(countryID);
        }
    }
}
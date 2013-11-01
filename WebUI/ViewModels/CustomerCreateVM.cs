using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.ViewModels
{
    public class CustomerCreateVM
    {
        public CustomerCreate CustomerCreate { get; set; }
        public DropDownLists.PricesDropDown pricesDropDown { get; set; }


        public CustomerCreateVM()
        {
            pricesDropDown = new DropDownLists.PricesDropDown();
        }

    }
}
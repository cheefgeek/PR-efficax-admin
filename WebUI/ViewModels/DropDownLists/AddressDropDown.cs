using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PlumRunModel;

namespace WebUI.ViewModels.DropDownLists
{
    public class AddressDropDown
    {
        public int SelectedID { get; set; }
        public IEnumerable<SelectListItem> List { get; set; }

        public AddressDropDown()
        {   
            this.List = PopulateList();
        }

        public AddressDropDown(int selectedID)
        { 
            this.SelectedID = selectedID;
            this.List = PopulateList();
        }

        private IEnumerable<SelectListItem> PopulateList()
        { 
            PREntities db = new PREntities();
            IEnumerable<SelectListItem> l = new SelectList(db.Addresses.OrderBy(x => x.Address1).ToList().Select(y =>
                    new SelectListItem
                    {
                        Value = y.AddressID.ToString(),
                        Text = y.Address1.ToString() + ", " + y.City.ToString() + ", " + y.StateProvince.ToString(),
                    }), "Value", "Text");

            return l;
        }

    }
}
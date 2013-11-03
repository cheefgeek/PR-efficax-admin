using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlumRunModel;


namespace WebUI.ViewModels.DropDownLists
{
    public class CountryDropDown
    {
        public int SelectedID { get; set; }
        public IEnumerable<SelectListItem> List { get; set; }

        public CountryDropDown()
        {   
            this.List = PopulateList();
        }

        public CountryDropDown(int selectedID)
        { 
            this.SelectedID = selectedID;
            this.List = PopulateList();
        }

        private IEnumerable<SelectListItem> PopulateList()
        { 
            PREntities db = new PREntities();
            IEnumerable<SelectListItem> l = new SelectList(db.Countries.OrderBy(x => x.Country1).ToList().Select(y =>
                    new SelectListItem
                    {
                        Value = y.CountryID.ToString(),
                        Text = y.Country1.ToString()
                    }), "Value", "Text");

            return l;
        }

    }
}
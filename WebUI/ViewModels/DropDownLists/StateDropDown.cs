using PlumRunModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.ViewModels.DropDownLists
{
    public class StateDropDown
    {
        public int SelectedID { get; set; }
        public IEnumerable<SelectListItem> List { get; set; }

        public StateDropDown()
        {   
            this.List = PopulateList();
        }

        public StateDropDown(int selectedID)
        { 
            this.SelectedID = selectedID;
            this.List = PopulateList();
        }

        private IEnumerable<SelectListItem> PopulateList()
        { 
            PREntities db = new PREntities();
            IEnumerable<SelectListItem> l = new SelectList(db.StateProvinces.OrderBy(x => x.name).ToList().Select(y =>
                    new SelectListItem
                    {
                        Value = y.id.ToString(),
                        Text = y.name.ToString()
                    }), "Value", "Text");

            return l;
        }

    }
}
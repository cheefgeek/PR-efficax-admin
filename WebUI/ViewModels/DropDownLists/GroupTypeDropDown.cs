using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PlumRunModel;

namespace WebUI.ViewModels.DropDownLists
{
    public class GroupTypeDropDown
    {
        public int SelectedID { get; set; }
        public IEnumerable<SelectListItem> List { get; set; }

        public GroupTypeDropDown()
        {   
            this.List = PopulateList();
        }

        public GroupTypeDropDown(int selectedID)
        { 
            this.SelectedID = selectedID;
            this.List = PopulateList();
        }

        private IEnumerable<SelectListItem> PopulateList()
        { 
            PREntities db = new PREntities();
            IEnumerable<SelectListItem> l = new SelectList(db.GroupTypes.OrderBy(x => x.Name).ToList().Select(y =>
                    new SelectListItem
                    {
                        Value = y.GroupTypeID.ToString(),
                        Text = y.Name.ToString()
                    }), "Value", "Text");

            return l;
        }

    }
}
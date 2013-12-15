using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlumRunModel;


namespace WebUI.ViewModels.DropDownLists
{
    public class MaritalStatus
    {
        public int SelectedID { get; set; }
        public IEnumerable<SelectListItem> List { get; set; }

        public MaritalStatus()
        {   
            this.List = PopulateList();
        }

        public MaritalStatus(int selectedID)
        { 
            this.SelectedID = selectedID;
            this.List = PopulateList();
        }

        private IEnumerable<SelectListItem> PopulateList()
        { 
            PREntities db = new PREntities();
            IEnumerable<SelectListItem> l = new SelectList(db.MaritalStatus.OrderBy(x => x.Name).ToList().Select(y =>
                    new SelectListItem
                    {
                        Value = y.MaritalStatusID.ToString(),
                        Text = y.Name.ToString()
                    }), "Value", "Text");

            return l;
        }

    }
}
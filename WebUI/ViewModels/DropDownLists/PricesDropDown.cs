﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlumRunModel;

namespace WebUI.ViewModels.DropDownLists
{
    public class PricesDropDown
    {
        public int SelectedID { get; set; }
        public IEnumerable<SelectListItem> List { get; set; }

        public PricesDropDown()
        {   
            this.List = PopulateList();
        }

        public PricesDropDown(int selectedID)
        { 
            this.SelectedID = selectedID;
            this.List = PopulateList();
        }

        private IEnumerable<SelectListItem> PopulateList()
        { 
            PREntities db = new PREntities();
            IEnumerable<SelectListItem> l = new SelectList(db.Prices
                .OrderBy(x => x.Price1)
                .ToList()
                .Select(y =>
                    new SelectListItem
                    {
                        Value = y.PriceID.ToString(),
                        Text = y.Price1.ToString()
                    }), "Value", "Text");

            return l;
        }
    }
}
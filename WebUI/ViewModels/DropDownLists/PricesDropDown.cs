using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlumRunModel;

namespace WebUI.ViewModels.DropDownLists
{
    public class PricesDropDown
    {
        public int SelectedPriceID { get; set; }
        public IEnumerable<SelectListItem> PriceList { get; set; }

        public PricesDropDown()
        {   
            this.PriceList = PopulatePriceList();
        }

        public PricesDropDown(int selectedPriceID)
        { 
            this.SelectedPriceID = selectedPriceID;
            this.PriceList = PopulatePriceList();
        }

        private IEnumerable<SelectListItem> PopulatePriceList()
        { 
            PREntities db = new PREntities();
            IEnumerable<SelectListItem> pl = new SelectList(db.Prices.OrderBy(x => x.Price1).ToList().Select(p =>
                    new SelectListItem
                    {
                        Value = p.PriceID.ToString(),
                        Text = p.Price1.ToString()
                    }), "Value", "Text");

            return pl;
        }
    }
}
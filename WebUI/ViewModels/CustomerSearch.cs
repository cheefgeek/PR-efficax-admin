using PlumRunModel;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Kendo.Mvc.Grid.CRUD.Models
{
    public class CustomerSearch
    {
        public int CustomerID { get; set; }
        public string AROrgName { get; set; }
        public string ARCity { get; set; }
        public int ARStateProvID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string State { get; set; }  
    }          
 




}

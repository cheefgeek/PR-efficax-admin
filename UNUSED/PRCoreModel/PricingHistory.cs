using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class PricingHistory
    {
        public int PricingHistoryID { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Price> Prices { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByPersonID { get; set; }
        //public Person CreatedByPerson { get; set; }
        public int ModifiedByPersonID { get; set; }
        //public Person ModifiedByPerson { get; set; }
        public DateTime ModifiedByDate { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCoreModel
{
    public class ImportantDate
    {
        public int ImportantDateID { get; set; }
        public int PersonID { get; set; }
        public DateTime Date { get; set; }
        public enumImportantDateTypes Event { get; set; }
    }
}

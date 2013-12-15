using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlumRunDomain;

namespace WebUI.Helpers
{
    public static class MathHelpers
    {
        public static int GetAnniversaryCount(DateTime beginDate)
        {
            DateTime today = DateTime.Today;
            int calcYears  = today.Year - beginDate.Year;
            if (beginDate > today.AddYears(-calcYears)) calcYears--;
            return calcYears;
        }

    }

}

using System.Web;
using System.Web.Mvc;
using WebUI.Business;

namespace WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new RedirectOnErrorAttribute());
        }
    }
}
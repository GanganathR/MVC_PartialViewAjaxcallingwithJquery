using System.Web;
using System.Web.Mvc;

namespace PartialView_AjaxCalling_Jquerry
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

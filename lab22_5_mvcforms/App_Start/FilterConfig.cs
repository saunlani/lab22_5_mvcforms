using System.Web;
using System.Web.Mvc;

namespace lab22_5_mvcforms
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

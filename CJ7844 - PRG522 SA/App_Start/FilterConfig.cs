using System.Web;
using System.Web.Mvc;

namespace CJ7844___PRG522_SA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace TP_02_Module_05_P1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

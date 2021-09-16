using System.Web;
using System.Web.Mvc;

namespace CG171105_CR150934_desafio01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web.Mvc;

namespace LoanModule
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
           // filters.Add(new System.Web.Mvc.AuthorizeAttribute()); //this is the global authorization attribute
           // filters.Add(new RequireHttpsAttribute()); //Require https
        }
    }
}

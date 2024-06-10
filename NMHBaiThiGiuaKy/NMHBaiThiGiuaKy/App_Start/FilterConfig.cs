using System.Web;
using System.Web.Mvc;

namespace NMHBaiThiGiuaKy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

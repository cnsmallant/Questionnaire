using System.Web.Mvc;

namespace WebUI.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller="login",action = "Index", id = UrlParameter.Optional },
                 new string[] { "WebUI.Areas.Admin.Controllers" }
            );
        }
    }
}

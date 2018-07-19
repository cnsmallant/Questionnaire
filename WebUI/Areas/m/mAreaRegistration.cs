using System.Web.Mvc;

namespace WebUI.Areas.m
{
    public class mAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "m";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "m_default",
                "m/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                 new string[] { "WebUI.Areas.m.Controllers" }
            );
        }
    }
}

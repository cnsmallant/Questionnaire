using EFClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/// <summary>
/// 登录过滤
/// </summary>
public class AdminVerificationAttribute : ActionFilterAttribute
{
    QuestionnaireDBEntities db = new QuestionnaireDBEntities();
    public override void OnActionExecuting(ActionExecutingContext context)
    {

        if (HttpContext.Current.Request.Cookies["uname"] == null || HttpContext.Current.Request.Cookies["upwd"] == null)
        {
            context.Result = new RedirectResult("/Admin/Login");
            return;
        }
        else
        {
            var query = db.AdminInfo;

            var uname = TDESHelper.DecryptString(HttpContext.Current.Request.Cookies["uname"].Value);
            var upwd = HttpContext.Current.Request.Cookies["upwd"].Value;
            var sys_admin = query.Where(u => u.AdminName == uname & u.AdminPwd == upwd).SingleOrDefault();
            string result = string.Empty;
            if (sys_admin == null)
            {
                context.Result = new RedirectResult("/Admin/Login");
                return;
            }
            else
            {
                    base.OnActionExecuting(context);
                

            }
        }
    }
}

using EFClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    [AdminVerification]

    public class profileController : Controller
    {
        QuestionnaireDBEntities db = new QuestionnaireDBEntities();

        //
        // GET: /Admin/profile/

        public ActionResult changepassword()
        {
            return View();
        }

        public JsonResult change()
        {
            try
            {
                  var uname = TDESHelper.DecryptString(HttpContext.Request.Cookies["uname"].Value);
                var upwd = HttpContext.Request.Cookies["upwd"].Value;
                var admin = db.AdminInfo.Where(u => u.AdminName == uname & u.AdminPwd == upwd).SingleOrDefault();
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var AdminPwd = JSONHelper.JsonToString(jsonstr, "AdminPwd");
                admin.AdminPwd = TDESHelper.EncryptString(AdminPwd);
                db.Configuration.ValidateOnSaveEnabled = false;
                int result = db.SaveChanges();
                db.Configuration.ValidateOnSaveEnabled = true;
                if (result > 0)
                {
                    Response.Cookies["uname"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["upwd"].Expires = DateTime.Now.AddDays(-1);
                    return Json("OK", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json("NO", JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public ActionResult signout()
        {
        
            Response.Cookies["uname"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["upwd"].Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("Index","login");
        }
    }
}

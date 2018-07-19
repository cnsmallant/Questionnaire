using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFClassLibrary;

namespace WebUI.Areas.Admin.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /Admin/login/
        QuestionnaireDBEntities db = new QuestionnaireDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult UserLogin()
        {
            try
            {
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var uname = JSONHelper.JsonToString(jsonstr, "uname");
                var upwd = TDESHelper.EncryptString(JSONHelper.JsonToString(jsonstr, "upwd"));
                var query = db.AdminInfo;
                var ant_admin = query.Where(u => u.AdminName == uname & u.AdminPwd == upwd).SingleOrDefault();
                string result = string.Empty;
                if (ant_admin != null)
                {
                    Response.Cookies["uname"].Value = TDESHelper.EncryptString(uname);
                    Response.Cookies["uname"].Expires = DateTime.Now.AddDays(1);
                    Response.Cookies["upwd"].Value = upwd;
                    Response.Cookies["upwd"].Expires = DateTime.Now.AddDays(1);
                    result = "OK";
                }
                else
                {
                    result = "NO";
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

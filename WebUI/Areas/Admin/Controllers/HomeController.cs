using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFClassLibrary;

namespace WebUI.Areas.Admin.Controllers
{
    [AdminVerification]
    public class HomeController : Controller
    {
        //
        // GET: /Admin/Home/
        QuestionnaireDBEntities db = new QuestionnaireDBEntities();
        public ActionResult Index()
        {
            ViewBag.p = db.PapersInfo.Count();//问卷
            ViewBag.s = db.SubjectInfo.Count();//题目
            ViewBag.u = db.UserInfo.Count();//用户
            ViewBag.c = db.CommentInfo.Count();//评论
            return View();
        }

    }
}

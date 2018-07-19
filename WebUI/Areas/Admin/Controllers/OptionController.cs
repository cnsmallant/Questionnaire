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
    public class OptionController : Controller
    {
        QuestionnaireDBEntities db = new QuestionnaireDBEntities();
        //
        // GET: /Admin/Option/

        public ActionResult Index(int SubjectId, int PapersId)
        {
            try
            {
                var list = db.OptionInfo.Where(s => s.SubjectId == SubjectId).OrderBy(p => p.OptionDate).ToList();
                ViewBag.SubjectId = SubjectId;
                ViewBag.PapersId = PapersId;
                return View(list);
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        /// <summary>
        /// 新建选项
        /// </summary>
        /// <returns></returns>
        public ActionResult create(int SubjectId)
        {
            try
            {
                var sub = db.SubjectInfo.Where(s => s.SubjectId == SubjectId).SingleOrDefault();
                ViewBag.SubjectId = SubjectId;
                ViewBag.PapersId = sub.PapersId;
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 新增选项
        /// </summary>
        /// <returns></returns>
        public JsonResult add()
        {
            try
            {
                var uname = TDESHelper.DecryptString(HttpContext.Request.Cookies["uname"].Value);
                var upwd = HttpContext.Request.Cookies["upwd"].Value;
                var admin = db.AdminInfo.Where(u => u.AdminName == uname & u.AdminPwd == upwd).SingleOrDefault();
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var OptionContent = JSONHelper.JsonToString(jsonstr, "OptionContent");
                var SubjectId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "SubjectId"));
                OptionInfo opt = new OptionInfo();
                opt.OptionId = Guid.NewGuid().ToString("N");
                opt.OptionContent = OptionContent;
                opt.SubjectId = SubjectId;
                opt.OptionDate = DateTime.Now;
                opt.AdminId = admin.AdminId;
                db.OptionInfo.Add(opt);
                db.Configuration.ValidateOnSaveEnabled = false;
                int result = db.SaveChanges();
                db.Configuration.ValidateOnSaveEnabled = true;
                if (result > 0)
                {

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



        public ActionResult modify(string  OptionId)
        {
            try
            {
               
                var opt = db.OptionInfo.Where(s => s.OptionId == OptionId).SingleOrDefault();
                ViewBag.OptionId = opt.OptionId;
                ViewBag.SubjectId = opt.SubjectId;
                var sub = db.SubjectInfo.Where(s => s.SubjectId ==opt. SubjectId).SingleOrDefault();
                ViewBag.PapersId = sub.PapersId;
                return View(opt);
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public JsonResult edit()
        {
            try
            {
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var OptionContent = JSONHelper.JsonToString(jsonstr, "OptionContent");
                var OptionId = JSONHelper.JsonToString(jsonstr, "OptionId");
                OptionInfo opt = db.OptionInfo.Where(o => o.OptionId == OptionId).SingleOrDefault();
                opt.OptionId = OptionId;
                opt.OptionContent = OptionContent;
                db.Configuration.ValidateOnSaveEnabled = false;
                int result = db.SaveChanges();
                db.Configuration.ValidateOnSaveEnabled = true;
                if (result > 0)
                {

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
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public JsonResult delete()
        {
            try
            {
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var OptionId =JSONHelper.JsonToString(jsonstr, "OptionId");
                var sub = db.OptionInfo.Where(s => s.OptionId == OptionId).SingleOrDefault();
                db.OptionInfo.Remove(sub);
                int result = db.SaveChanges();
                db.Configuration.ValidateOnSaveEnabled = true;
                if (result > 0)
                {

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
    }
}

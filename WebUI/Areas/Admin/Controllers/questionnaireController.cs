using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFClassLibrary;
using System.IO;

namespace WebUI.Areas.Admin.Controllers
{
    [AdminVerification]
    public class questionnaireController : Controller
    {
        QuestionnaireDBEntities db = new QuestionnaireDBEntities();

        /// <summary>
        /// 扩展类
        /// </summary>
        [Serializable]
        public class PapersInfos : PapersInfo
        {
            public int SubjectCount { get; set; }
        }
        #region 问卷管理


        //
        // GET: /Admin/questionnaire/
        /// <summary>
        /// 读取问卷
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Index(int id = 1)
        {
            try
            {
                var list = db.PapersInfo.OrderByDescending(p => p.PapersDate).ToList();
                var lists = new List<PapersInfos>();
                foreach (var item in list)
                {
                    PapersInfos pap = new PapersInfos();
                    pap.PapersId = item.PapersId;
                    pap.PapersTitle = item.PapersTitle;
                    pap.PapersDepict = item.PapersDepict;
                    pap.StartDate = item.StartDate;
                    pap.EndDate = item.EndDate;
                    pap.SubjectCount = db.SubjectInfo.Where(s => s.PapersId == item.PapersId).ToList().Count;
                    pap.PapersDate = item.PapersDate;
                    pap.AdminId = item.AdminId;
                    lists.Add(pap);
                }
                var Page = PageCommon.PageList(id, 10, lists);
                return View(Page);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 新建问卷
        /// </summary>
        /// <returns></returns>
        public ActionResult create()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 新增问卷
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
                var PapersTitle = JSONHelper.JsonToString(jsonstr, "PapersTitle");
                var PapersDepict = JSONHelper.JsonToString(jsonstr, "PapersDepict");
                var StartDate = Convert.ToDateTime(JSONHelper.JsonToString(jsonstr, "StartDate"));
                var EndDate = Convert.ToDateTime(JSONHelper.JsonToString(jsonstr, "EndDate"));
                PapersInfo pap = new PapersInfo();
                pap.PapersTitle = PapersTitle;
                pap.PapersDepict = PapersDepict;
                pap.StartDate = StartDate;
                pap.EndDate = EndDate;
                pap.PapersDate = DateTime.Now;
                pap.AdminId = admin.AdminId;
                pap.PapersDate = DateTime.Now;
                db.PapersInfo.Add(pap);
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
        /// 修改
        /// </summary>
        /// <returns></returns>
        public ActionResult modify(int id)
        {
            try
            {
                var pap = db.PapersInfo.Where(p => p.PapersId == id).SingleOrDefault();
                ViewBag.pap = pap;
                ViewBag.PapersId = pap.PapersId;
                return View();
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
                var PapersTitle = JSONHelper.JsonToString(jsonstr, "PapersTitle");
                var PapersDepict = JSONHelper.JsonToString(jsonstr, "PapersDepict");
                var PapersId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "PapersId"));
                var StartDate = Convert.ToDateTime(JSONHelper.JsonToString(jsonstr, "StartDate"));
                var EndDate = Convert.ToDateTime(JSONHelper.JsonToString(jsonstr, "EndDate"));
                PapersInfo pap = db.PapersInfo.Where(p => p.PapersId == PapersId).SingleOrDefault();
                pap.PapersId = PapersId;
                pap.PapersTitle = PapersTitle;
                pap.PapersDepict = PapersDepict;
                pap.StartDate = StartDate;
                pap.EndDate = EndDate;
                pap.PapersDate = DateTime.Now;
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
        #endregion
    }
}

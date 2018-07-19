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
    public class SubjectController : Controller
    {
        QuestionnaireDBEntities db = new QuestionnaireDBEntities();
        /// <summary>
        /// 扩展类
        /// </summary>
        [Serializable]
        public class SubjectInfos : SubjectInfo
        {
            public int OptionCount { get; set; }
        }
        //
        #region 题目管理
        // GET: /Admin/Subject/
        /// <summary>
        /// 题目列表
        /// </summary>
        /// <param name="PapersId"></param>
        /// <param name="pageid"></param>
        /// <returns></returns>
        public ActionResult Index(int PapersId, int pageid = 1)
        {
            try
            {
                var list = db.SubjectInfo.Where(s => s.PapersId == PapersId).OrderBy(p => p.SubjectId).ToList();
                var lists = new List<SubjectInfos>();
                foreach (var item in list)
                {
                    SubjectInfos pap = new SubjectInfos();
                    pap.SubjectId = item.SubjectId;
                    pap.SubjectDepict = item.SubjectDepict;
                    pap.SubjectType = item.SubjectType;
                    pap.SubjectDate = item.SubjectDate;
                    pap.PapersId = item.PapersId;
                    pap.OptionCount = db.OptionInfo.Where(s => s.SubjectId == item.SubjectId).ToList().Count;
                    pap.AdminId = item.AdminId;
                    lists.Add(pap);
                }
                ViewBag.PapersId = PapersId;
                var Page = PageCommon.PageList(pageid, 20, lists);
                return View(Page);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 新建题目
        /// </summary>
        /// <returns></returns>
        public ActionResult create(int PapersId)
        {
            try
            {
                ViewBag.PapersId = PapersId;
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 新增题目
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
                var SubjectDepict = JSONHelper.JsonToString(jsonstr, "SubjectDepict");
                var SubjectType = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "SubjectType"));
                var PapersId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "PapersId"));
                SubjectInfo pap = new SubjectInfo();
                pap.SubjectDepict = SubjectDepict;
                pap.SubjectType = SubjectType;
                pap.PapersId = PapersId;
                pap.SubjectDate = DateTime.Now;
                pap.AdminId = admin.AdminId;
                db.SubjectInfo.Add(pap);
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
        public ActionResult modify(int SubjectId)
        {
            try
            {
                var sub = db.SubjectInfo.Where(s => s.SubjectId == SubjectId).SingleOrDefault();
                ViewBag.PapersId = sub.PapersId;
                ViewBag.SubjectId = sub.SubjectId;
                return View(sub);
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 修改题目
        /// </summary>
        /// <returns></returns>
        public JsonResult edit()
        {
            try
            {
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var SubjectDepict = JSONHelper.JsonToString(jsonstr, "SubjectDepict");
                var SubjectType = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "SubjectType"));
                var PapersId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "PapersId"));
                var SubjectId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "SubjectId"));
                SubjectInfo pap = db.SubjectInfo.Where(s => s.SubjectId == SubjectId).SingleOrDefault();
                pap.SubjectDepict = SubjectDepict;
                pap.SubjectType = SubjectType;
                pap.SubjectId = SubjectId;
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
                var SubjectId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "SubjectId"));
                var sub = db.SubjectInfo.Where(s => s.SubjectId == SubjectId).SingleOrDefault();
                db.SubjectInfo.Remove(sub);
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

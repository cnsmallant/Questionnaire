using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFClassLibrary;
using System.IO;
using System.Text;

namespace WebUI.Areas.Admin.Controllers
{
    [AdminVerification]
    public class analysisController : Controller
    {
        [Serializable]
        public class CommentInfos : CommentInfo
        {
            public int LaudCount { get; set; }
            public string UserName { get; set; }
            public string UserPhone { get; set; }

        }
        QuestionnaireDBEntities db = new QuestionnaireDBEntities();

        /// <summary>
        /// 扩展类
        /// </summary>
        [Serializable]
        public class PapersInfos : PapersInfo
        {
            public int SubjectCount { get; set; }
        }
        //
        // GET: /Admin/analysis/
        /// <summary>
        /// 问卷列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int id = 1)
        {

            try
            {
                var list = db.PapersInfo.OrderByDescending(p => p.PapersDate).Take(1).ToList();
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

        #region 投票
        /// <summary>
        /// 投票
        /// </summary>
        /// <returns></returns>
        public ActionResult vote(int id)
        {
            try
            {
                var plist = db.PapersInfo.Where(p => p.PapersId == id).Take(1).ToList();
                return View(plist);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region 评论
        /// <summary>
        /// 评论
        /// </summary>
        /// <returns></returns>
        public ActionResult comment(int id, int pageIndx = 1)
        {
            try
            {
                var list = CommentList().Where(c => c.PapersId == id).OrderByDescending(c => c.CommentDate).ToList();
                var page = PageCommon.PageList(pageIndx, 20, list);
                return View(page);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 删除评论
        /// </summary>
        /// <returns></returns>
        public JsonResult cdelete()
        {
            try
            {
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var CommentId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "CommentId"));
                var cm = db.CommentInfo.Where(c => c.CommentId == CommentId).SingleOrDefault();
                StringBuilder sb = new StringBuilder();
                sb.Append("DELETE FROM CommentInfo WHERE CommentId='" + CommentId + "';");
                sb.Append("DELETE FROM UserInfo WHERE UserId='" + cm.UserId + "';");
                string sql = sb.ToString();
                int result = db.Database.ExecuteSqlCommand(sql);
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
        #region 点赞
        public ActionResult laud(int id)
        {
            try
            {
                var list = CommentList().Where(c => c.PapersId == id).OrderByDescending(c => c.LaudCount).ToList();
                var lists = CommentList().Where(c => c.PapersId == id).OrderBy(c => c.LaudCount).ToList();

                var ys = db.LaudInfo.Where(l => l.City != "人工加票").Count();
                var rg = db.LaudInfo.Where(l => l.City == "人工加票").Count();
                ViewBag.ys = db.LaudInfo.Where(l => l.City != "人工加票").Count();
                ViewBag.rg = db.LaudInfo.Where(l => l.City == "人工加票").Count();
                ViewBag.zh = ys + rg;
                var names = string.Empty;
                var lands = string.Empty;
                var jiapiaos = string.Empty;



                foreach (var item in lists)
                {
                    names += "'"+item.UserName +"',";
                    lands += item.LaudCount + ",";
                    jiapiaos += db.LaudInfo.Where(l => l.CommentId == item.CommentId && l.City == "人工加票").Count()+",";
                }
                ViewBag.names = names.TrimEnd(',');
                ViewBag.lands = lands.TrimEnd(',');
                ViewBag.jiapiaos = jiapiaos.TrimEnd(',');
                ViewBag.count = list.Count;
                ViewBag.lcount = db.LaudInfo.Where(l => l.City == "济南市" || l.City == "青岛市" || l.City == "烟台市" || l.City == "潍坊市" || l.City == "日照市" || l.City == "威海市" || l.City == "临沂市" || l.City == "枣庄市" || l.City == "淄博市" || l.City == "济宁市" || l.City == "泰安市" || l.City == "莱芜市" || l.City == "滨州市" || l.City == "东营市" || l.City == "德州市" || l.City == "聊城市" || l.City == "菏泽市").Count();
                ViewBag.jinan = db.LaudInfo.Where(l => l.PapersId == id && l.City == "济南市").Count();
                ViewBag.qingdao = db.LaudInfo.Where(l => l.PapersId == id && l.City == "青岛市").Count();
                ViewBag.yantai = db.LaudInfo.Where(l => l.PapersId == id && l.City == "烟台市").Count();
                ViewBag.weifang = db.LaudInfo.Where(l => l.PapersId == id && l.City == "潍坊市").Count();
                ViewBag.rizhao = db.LaudInfo.Where(l => l.PapersId == id && l.City == "日照市").Count();
                ViewBag.weihai = db.LaudInfo.Where(l => l.PapersId == id && l.City == "威海市").Count();
                ViewBag.linyi = db.LaudInfo.Where(l => l.PapersId == id && l.City == "临沂市").Count();
                ViewBag.zaozhuang = db.LaudInfo.Where(l => l.PapersId == id && l.City == "枣庄市").Count();
                ViewBag.zibo = db.LaudInfo.Where(l => l.PapersId == id && l.City == "淄博市").Count();
                ViewBag.jining = db.LaudInfo.Where(l => l.PapersId == id && l.City == "济宁市").Count();
                ViewBag.taian = db.LaudInfo.Where(l => l.PapersId == id && l.City == "泰安市").Count();
                ViewBag.lanwu = db.LaudInfo.Where(l => l.PapersId == id && l.City == "莱芜市").Count();
                ViewBag.binzhou = db.LaudInfo.Where(l => l.PapersId == id && l.City == "滨州市").Count();
                ViewBag.dongying = db.LaudInfo.Where(l => l.PapersId == id && l.City == "东营市").Count();
                ViewBag.dezhou = db.LaudInfo.Where(l => l.PapersId == id && l.City == "德州市").Count();
                ViewBag.liaocheng = db.LaudInfo.Where(l => l.PapersId == id && l.City == "聊城市").Count();
                ViewBag.heze = db.LaudInfo.Where(l => l.PapersId == id && l.City == "菏泽市").Count();
                return View(list);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private IList<CommentInfos> CommentList()
        {
            try
            {
                var list = db.CommentInfo.ToList();
                IList<CommentInfos> lists = new List<CommentInfos>();
                foreach (var item in list)
                {
                    CommentInfos com = new CommentInfos();
                    com.CommentId = item.CommentId;
                    com.CommentDepict = item.CommentDepict;
                    com.LaudCount = db.LaudInfo.Where(l => l.CommentId == item.CommentId).Count();
                    var username = db.UserInfo.Where(u => u.UserId == item.UserId).SingleOrDefault().UserName;
                    if (string.IsNullOrEmpty(username))
                    {
                        com.UserName = "";
                    }
                    else
                    {
                        com.UserName = username;
                    }
                    var userphone = db.UserInfo.Where(u => u.UserId == item.UserId).SingleOrDefault().UserPhone;
                    if (string.IsNullOrEmpty(username))
                    {
                        com.UserPhone = "";
                    }
                    else
                    {
                        com.UserPhone = userphone;
                    }

                    com.UserId = item.UserId;
                    com.PapersId = item.PapersId;
                    com.CommentDate = item.CommentDate;
                    lists.Add(com);
                }
                return lists;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 加票
        /// <summary>
        /// 加票
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult jiapiao()
        {
            try
            {
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var CommentId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "id"));
                var iid = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "iid"));
                var cm = db.CommentInfo.Where(c => c.CommentId == CommentId).SingleOrDefault();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < iid; i++)
                {
                    sb.Append("INSERT INTO LaudInfo (CommentId, IPAddress, City, LaudDate,PapersId) VALUES ('" + CommentId + "','192.168.1.1','人工加票','" + DateTime.Now + "','" + cm.PapersId + "');");
                }
                string sql = sb.ToString();
                int result = db.Database.ExecuteSqlCommand(sql);
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

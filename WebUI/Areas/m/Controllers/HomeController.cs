using EFClassLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.m.Controllers
{
    public class HomeController : Controller
    {
        [Serializable]
        public class CommentInfos : CommentInfo
        {
            public int LaudCount { get; set; }
            public string UserName { get; set; }

        }

        QuestionnaireDBEntities db = new QuestionnaireDBEntities();
        //
        // GET: /Home/



        public ActionResult Index()
        {
            try
            {
                var pap = db.PapersInfo.OrderByDescending(p => p.PapersDate).Take(1).SingleOrDefault();
                ViewBag.pap = pap;
                ViewBag.PapersId = pap.PapersId;
                var list = db.SubjectInfo.Where(s => s.PapersId == pap.PapersId).OrderBy(s => s.PapersId).ToList();
                ViewBag.comlist = CommentList().OrderByDescending(c => c.LaudCount).ToList();
                ViewBag.ccou = db.CommentInfo.Where(c => c.PapersId == pap.PapersId).Count();
                ViewBag.laudcou = db.LaudInfo.Where(c => c.PapersId == pap.PapersId).Count();
                return View(list);
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// 评论列表
        /// </summary>
        /// <returns></returns>
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
                        if (username.Length == 1)
                        {
                            com.UserName = "*";
                        }
                        else
                        {
                            var leg = (username.Length - 1);
                            com.UserName = sta(leg) + username.Substring(leg);
                        }
                    }

                    com.UserId = item.UserId;
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

        private string sta(int leg)
        {
            try
            {
                string s = string.Empty;
                for (int i = 0; i < leg; i++)
                {
                    s += "*";
                }
                return s;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 投票
        /// </summary>
        /// <returns></returns>
        public JsonResult Vote()
        {
            try
            {
                var pap = db.PapersInfo.OrderByDescending(p => p.PapersDate).Take(1).SingleOrDefault();
                var sdate = Convert.ToDateTime(Convert.ToDateTime(pap.EndDate).ToString("yyyy-MM-dd"));
                var edate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                if (sdate > edate)
                {
                    var stre = HttpContext.Request.InputStream;
                    var jsonstr = new StreamReader(stre).ReadToEnd();
                    var str = JSONHelper.JsonToString(jsonstr, "OptionId");
                    string ip = GetIP();
                    string[] OptionId = str.Split(',');
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < OptionId.Length; i++)
                    {

                        if (!string.IsNullOrEmpty(OptionId[i]))
                        {
                            var opid = OptionId[i].ToString();
                            var op = db.OptionInfo.Where(o => o.OptionId == opid).SingleOrDefault();
                            sb.Append("INSERT INTO VoteInfo (SubjectId, OptionId,IPAddress,VoteDate) VALUES ('" + op.SubjectId + "','" + OptionId[i] + "','" + ip + "','" + DateTime.Now + "');");
                        }
                    }
                    string sql = sb.ToString();
                    int result = db.Database.ExecuteSqlCommand(sql);
                    if (result > 0)
                    {
                        return Json("OK", JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json("NO", JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json("N", JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 评论
        /// </summary>
        /// <returns></returns>
        public JsonResult Comment()
        {
            try
            {
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var CommentDepict = JSONHelper.JsonToString(jsonstr, "CommentDepict");
                var UserPhone = JSONHelper.JsonToString(jsonstr, "UserPhone");
                var UserName = JSONHelper.JsonToString(jsonstr, "UserName");
                var PapersId = JSONHelper.JsonToString(jsonstr, "PapersId");
                var userid = Guid.NewGuid().ToString("N");
                var userinfo = db.UserInfo.Where(u => u.UserPhone == UserPhone).SingleOrDefault();
                if (userinfo == null)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO UserInfo (UserId, UserName, UserPhone, UserDate) VALUES ('" + userid + "','" + UserName + "','" + UserPhone + "','" + DateTime.Now + "');");
                    sb.Append("INSERT INTO CommentInfo  (CommentDepict, UserId,PapersId,CommentDate) VALUES ('" + CommentDepict + "','" + userid + "','" + PapersId + "','" + DateTime.Now + "');");
                    string sql = sb.ToString();
                    int result = db.Database.ExecuteSqlCommand(sql);
                    if (result > 0)
                    {
                        string url = "http://" + HttpContext.Request.Url.Host + "/" + "#" + userid;
                        return Json(url, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json("NO", JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json("YUSER", JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {

                return Json("NO", JsonRequestBehavior.AllowGet);
            }
        }

        /// <summary>
        /// 点赞操作
        /// </summary>
        /// <returns></returns>
        public JsonResult Laud()
        {
            try
            {
                var stre = HttpContext.Request.InputStream;
                var jsonstr = new StreamReader(stre).ReadToEnd();
                var CommentId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "CommentId"));
                var PapersId = Convert.ToInt32(JSONHelper.JsonToString(jsonstr, "PapersId"));
                var host = "http://" + JSONHelper.JsonToString(jsonstr, "host");
                if (host == "http://tp.whinfo.net")
                {
                    var sdate = DateTime.Now.AddDays(-1);
                    var edate = DateTime.Now.AddDays(1);
                    var ip = GetIP();
                    var json = IP(Server.UrlDecode(ip));
                    JObject ja = (JObject)JsonConvert.DeserializeObject(json);
                    string status = ja["status"].ToString();
                    string info = ja["info"].ToString();
                    string infocode = ja["infocode"].ToString();
                    string province = ja["province"].ToString();
                    string city = ja["city"].ToString();
                    string sqlip = "SELECT LaudId, CommentId, IPAddress, City, LaudDate, PapersId FROM LaudInfo where CONVERT(varchar(100), LaudDate, 23)<CONVERT(varchar(100), dateadd(d,1,getdate()), 23)and CONVERT(varchar(100), LaudDate, 23)>CONVERT(varchar(100), dateadd(d,-1,getdate()), 23) and City='威海市' and CommentId='" + CommentId + "'";
                    var ipcount = db.Database.SqlQuery<LaudInfo>(sqlip).ToList().Count;//获取非威海市IP
                    string sql = "SELECT LaudId, CommentId, IPAddress, City, LaudDate, PapersId FROM LaudInfo where CONVERT(varchar(100), LaudDate, 23)<CONVERT(varchar(100), dateadd(d,1,getdate()), 23)and CONVERT(varchar(100), LaudDate, 23)>CONVERT(varchar(100), dateadd(d,-1,getdate()), 23) and IPAddress='" + ip + "' and CommentId='" + CommentId + "'";

                    var LaudInfo = db.Database.SqlQuery<LaudInfo>(sql).ToList().Count;

                    var nowdate = DateTime.Now;
                    var enddate = Convert.ToDateTime("2017-07-12");
                    if (nowdate < enddate)
                    {
                        if (city == "[]")
                        {
                            city = "";
                        }
                        string adcode = ja["adcode"].ToString();
                        string rectangle = ja["rectangle"].ToString();
                        if (city == "威海市")
                        {
                            return OperLaud(CommentId, PapersId, LaudInfo, ip, city);
                        }
                        else
                        {
                            if (ipcount < 50)
                            {
                                return OperLaud(CommentId, PapersId, LaudInfo, ip, city);
                            }
                            else
                            {
                                return Json("C", JsonRequestBehavior.AllowGet);
                            }
                        }

                    }
                    else
                    {
                        return Json("E", JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json("W", JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {

                return Json("N", JsonRequestBehavior.AllowGet);
            }
        }
        /// <summary>
        /// 点赞方法
        /// </summary>
        /// <param name="CommentId">评论ID</param>
        /// <param name="PapersId">问卷ID</param>
        /// <param name="LaudInfo">点赞表</param>
        /// <param name="ip">IP</param>
        /// <param name="city">城市</param>
        /// <returns>json</returns>
        private JsonResult OperLaud(int CommentId, int PapersId, int LaudInfo, string ip, string city)
        {
            if (LaudInfo < 1)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO LaudInfo (CommentId, IPAddress, City, LaudDate,PapersId) VALUES ('" + CommentId + "','" + ip + "','" + city + "','" + DateTime.Now + "','" + PapersId + "');");
                string sql = sb.ToString();
                int result = db.Database.ExecuteSqlCommand(sql);
                if (result > 0)
                {
                    var lcou = db.LaudInfo.Where(l => l.CommentId == CommentId).Count();
                    return Json(lcou, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json("N", JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json("Y", JsonRequestBehavior.AllowGet);
            }
        }
        /// <summary>
        /// 获取IP信息
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static string IP(string ip)
        {
            try
            {
                string url = "http://restapi.amap.com/v3/ip?ip=" + ip + "&output=json&key=50cb578b821613e3c086ba3b892d5ba4";
                string jsonContent = RequestApi(url, WebRequestMethods.Http.Get, Encoding.UTF8);
                return jsonContent;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 链接API
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Method"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        private static string RequestApi(string url, string Method, Encoding encoding)
        {
            string code = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = Method;// WebRequestMethods.Http.Get;
                request.ProtocolVersion = new Version(1, 1);//Http/1.1版本
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), encoding))
                {
                    code = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return code;
        }


        /// <summary>
        /// 获取IP
        /// </summary>
        /// <returns></returns>
        private string GetIP()
        {
            string ip = string.Empty;
            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"]))
                ip = Convert.ToString(System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"]);
            if (string.IsNullOrEmpty(ip))
                ip = Convert.ToString(System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]);
            return ip;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using EFClassLibrary;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WebUI.Controllers
{
    public class spController : Controller
    {
        QuestionnaireDBEntities db = new QuestionnaireDBEntities();
        //
        // GET: /sp/
        //http://localhost:11460/sp
        //LaudId	CommentId	IPAddress	City	LaudDate	PapersId
        //118	1003	221.2.137.52	威海市	2017-06-20 16:40:18.687	10000
        public ActionResult Index()
        {

            var ip = getRandomIp();
            var json = IP(Server.UrlDecode(ip));
            JObject ja = (JObject)JsonConvert.DeserializeObject(json);
            string status = ja["status"].ToString();
            string info = ja["info"].ToString();
            string infocode = ja["infocode"].ToString();
            string province = ja["province"].ToString();
            string city = ja["city"].ToString();
            var c = string.Empty;
            if (city == "" || city == "[]")
            {
                c = "";
            }
            else
            {
                c = city;
            }
            LaudInfo la = new LaudInfo();
            la.CommentId = 1071;
            la.IPAddress = ip;
            la.City = c;
            la.LaudDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            la.PapersId = 10000;
            db.LaudInfo.Add(la);
            int result = db.SaveChanges();
            if (result > 0)
            {
                ViewBag.ip = ip;
            }
            else
            {
                ViewBag.ip = "N";
            }
            return View();
        }

        public string getRandomIp()
        {     /*
     int[][]
     这个叫交错数组,白话文就是数组的数组.
    初始化的方法:
     int[][] numbers = new int[][] { new int[] {2,3,4}, new int[] {5,6,7,8,9} };
当然也可以使用{}初始化器初始化
             int[][] numbers = { new int[] {2,3,4}, 
                            new int[] {5,6,7,8,9} 
                          };
     */
            int[][] range = {new int[]{607649792,608174079},//36.56.0.0-36.63.255.255
new int[]{1038614528,1039007743},//61.232.0.0-61.237.255.255
new int[]{1783627776,1784676351},//106.80.0.0-106.95.255.255
new int[]{2035023872,2035154943},//121.76.0.0-121.77.255.255
new int[]{2078801920,2079064063},//123.232.0.0-123.235.255.255
new int[]{-1950089216,-1948778497},//139.196.0.0-139.215.255.255
new int[]{-1425539072,-1425014785},//171.8.0.0-171.15.255.255
new int[]{-1236271104,-1235419137},//182.80.0.0-182.92.255.255
new int[]{-770113536,-768606209},//210.25.0.0-210.47.255.255
 new int[]{-569376768,-564133889}, //222.16.0.0-222.95.255.255
};

            Random rdint = new Random();
            int index = rdint.Next(10);
            string ip = num2ip(range[index][0] + new Random().Next(range[index][1] - range[index][0]));
            return ip;
        }

        /*
         * 将十进制转换成ip地址
        */
        public string num2ip(int ip)
        {
            int[] b = new int[4];
            string x = "";
            //位移然后与255 做高低位转换
            b[0] = (int)((ip >> 24) & 0xff);
            b[1] = (int)((ip >> 16) & 0xff);
            b[2] = (int)((ip >> 8) & 0xff);
            b[3] = (int)(ip & 0xff);
            x = (b[0]).ToString() + "." + (b[1]).ToString() + "." + (b[2]).ToString() + "." + (b[3]).ToString();

            return x;
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
    }
}

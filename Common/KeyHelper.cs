using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    /// <summary>
    /// 密钥
    /// </summary>
    public class KeyHelper : MD5Pwd
    {
        public static string sKey = MD5("whinfocn");//密钥
        static byte[] bytes = Encoding.ASCII.GetBytes("cnwhinfo");
        public static string sIV = Convert.ToBase64String(bytes);//向量
    }


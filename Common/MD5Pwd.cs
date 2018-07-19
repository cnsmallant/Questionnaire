using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


   /// <summary>
   /// MD5加密类
   /// </summary>
    public class MD5Pwd
    {
        /// <summary>
        /// MD5加密方法
        /// </summary>
        /// <param name="Md5Str">加密字符</param>
        /// <returns>string</returns>
        public static string MD5(string Md5Str)
        {
            try
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] theSrc = Encoding.UTF8.GetBytes(Md5Str);
                byte[] theResBytes = md5.ComputeHash(theSrc);
                string[] theResStrings = BitConverter.ToString(theResBytes).Split('-');
                return string.Concat(theResStrings);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

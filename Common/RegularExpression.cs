using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


/// <summary>
/// 正则表达式验证
/// </summary>
public class RegularExpression
{
    #region QQ
    /// <summary>
    /// 验证QQ
    /// </summary>
    public static Regex regxQQ = new Regex(@"^[1-9][0-9]{4,}$");
    #endregion
    #region 验证邮箱
    /// <summary>
    /// 验证邮箱
    /// </summary>
    public static Regex regxEml = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
    #endregion
    #region 验证url(http://)
    /// <summary>
    /// 验证url(http://)
    /// </summary>
    public static Regex regxUrl = new Regex(@"^(https?|ftp):\/\/(((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:)*@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)(:\d*)?)(\/((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)+(\/(([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)*)*)?)?(\?((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|[\uE000-\uF8FF]|\/|\?)*)?(\#((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|\/|\?)*)?$");
    #endregion
    #region 验证邮编
    /// <summary>
    /// 验证邮编
    /// </summary>
    public static Regex regxZipCode = new Regex(@"^\d{6}$");
    #endregion
    #region 验证身份证号码
    /// <summary>
    /// 验证身份证号码
    /// </summary>
    public static Regex regxIdCode = new Regex(@"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
    #endregion
    #region 验证密码(字母开头，允许5-16字节，允许字母数字下划线)
    /// <summary>
    /// 验证密码(字母开头，允许5-16字节，允许字母数字下划线)
    /// </summary>
    public static Regex regxPwd = new Regex(@"^[a-zA-Z][a-zA-Z0-9_]{4,15}$");
    #endregion
    #region 匹配中文
    /// <summary>
    /// 匹配中文
    /// </summary>
    public static Regex regxCN = new Regex(@"^[\u4e00-\u9fa5]$");
    #endregion
    #region 验证国内电话号码（匹配形式如 05114405222 或 02187888822 ）
    /// <summary>
    /// 验证国内电话号码（匹配形式如 0511-4405222 或 0211-87888822 ）
    /// </summary>
    public static Regex regxTel = new Regex(@"^(\(?\d{3,4}\)?)?[\s-]?\d{7,8}[\s-]?\d{0,4}$");
    #endregion
    #region 匹配正浮点数
    /// <summary>
    /// 匹配正浮点数
    /// </summary>
    public static Regex regxPfNum = new Regex(@"^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*))$");
    #endregion
    #region 匹配非正浮点数
    /// <summary>
    /// 匹配非正浮点数
    /// </summary>
    public static Regex regxNfNum = new Regex(@"^((-\d+(\.\d+)?)|(0+(\.0+)?))$");
    #endregion
    #region 匹配负浮点数
    /// <summary>
    /// 匹配负浮点数
    /// </summary>
    public static Regex regxFNum = new Regex(@"^(-(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*)))$");
    #endregion

    #region 验证手机号码
    /// <summary>
    /// 验证手机号码
    /// </summary>
    public static Regex regxPhone = new Regex(@"^((\d{11})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$)$");
    #endregion
    #region 验证价格
    /// <summary>
    /// 验证价格
    /// </summary>
    public static Regex regxPrice = new Regex(@"^(d*.d{0,2}|d+).*$");
    #endregion
    #region 匹配正整数
    /// <summary>
    /// 匹配正整数
    /// </summary>
    public static Regex regxNum = new Regex(@"^[1-9]\d*$");
    #endregion


    #region 截取Html中的图片
    /// <summary>
    /// 截取Html中第一张图片
    /// </summary>
    /// <param name="articleContent"></param>
    /// <returns></returns>
    public static string GetImageUrlFromArticle(string articleContent)
    {
        Regex r = new Regex(@"<IMG[^>]+src=\s*(?:'(?<src>[^']+)'|""(?<src>[^""]+)""|(?<src>[^>\s]+))\s*[^>]*>", RegexOptions.IgnoreCase);
        MatchCollection mc = r.Matches(articleContent);
        if (mc.Count != 0)
        {
            return mc[0].Groups["src"].Value.ToLower();
        }
        else
        {
            return "";
        }
    }

    /// <summary>
    /// 截取Html中所有图片,有循环
    /// </summary>
    /// <param name="articleContent"></param>
    /// <returns></returns>
    public static string GetImageUrl(string articleContent)
    {
        try
        {
            string imgStr = string.Empty;
            string str = articleContent;
            string Pattern = @"<\s?img[^>]+?>";

            MatchCollection mc = Regex.Matches(str, Pattern, RegexOptions.IgnoreCase);
            foreach (Match m in mc)
            {
                if (!string.IsNullOrEmpty(m.Value))
                {
                    imgStr += m.Value;
                }
                else
                {
                    imgStr = "";
                }
            }
            return imgStr;
        }
        catch (Exception)
        {

            throw;
        }
    }


    /// <summary>
    /// 截取Html中所有图片,无循环
    /// </summary>
    /// <param name="articleContent"></param>
    /// <returns></returns>
    public static MatchCollection GetImageUrlStr(string articleContent)
    {
        try
        {

            string str = articleContent;
            string Pattern = @"<\s?img[^>]+?>";

            MatchCollection mc = Regex.Matches(str, Pattern, RegexOptions.IgnoreCase);
            return mc;
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion

    #region 截取Html中第一个Flash
    /// <summary>
    /// 截取Html中第一个Flash
    /// </summary>
    /// <param name="articleContent"></param>
    /// <returns></returns>
    public static string GetFlashUrlFromArticle(string articleContent)
    {
        Regex r = new Regex(@"<embed[^>]+src=\s*(?:'(?<src>[^']+)'|""(?<src>[^""]+)""|(?<src>[^>\s]+))\s*[^>]*>", RegexOptions.IgnoreCase);
        MatchCollection mc = r.Matches(articleContent);
        if (mc.Count != 0)
        {
            return mc[0].Groups["src"].Value.ToLower();
        }
        else
        {
            return "";
        }
    }

    #endregion


    #region 清空Html标签，获取纯字符串

    /// <summary>
    /// 清空Html标签，获取纯字符串
    /// </summary>
    /// <param name="HtmlStr">Html字符串</param>
    /// <returns>String</returns>
    public static string NullHtmlStr(string HtmlStr)
    {
        try
        {
            string str = Regex.Replace(HtmlStr, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
            if (str != "")
            {
                return str;
            }
            else
            {
                return "";
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
}



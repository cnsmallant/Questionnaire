using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// json字符串组合类
/// </summary>
public class JsonStringPlus
{
    /// <summary>
    /// json字符串组合类FULL单体
    /// </summary>
    /// <param name="Message">提示信息向</param>
    /// <param name="result">提示状态 OK：成功 NO：失败</param>
    /// <param name="value">数据库获取的值</param>
    /// <param name="token">token</param>
    /// <returns></returns>
    public static string JsonString(string Message, string result, string value, string token)
    {
        try
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"message\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(Message);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"result\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(result);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"token\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(token);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"value\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(value);
            sb.Append("\"");
            sb.Append("}");
            string json = sb.ToString();
            return json;

        }
        catch (Exception)
        {

            throw;
        }
    }

    /// <summary>
    ///  json字符串组合类FULL实体
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="result"></param>
    /// <param name="value"></param>
    /// <param name="token"></param>
    /// <returns></returns>
    public static string JsonStringEnty(string Message, string result, string value, string token)
    {
        try
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"message\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(Message);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"result\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(result);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"token\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(token);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"value\"");
            sb.Append(":");
            sb.Append(value);
            sb.Append("}");
            string json = sb.ToString();
            return json;

        }
        catch (Exception)
        {

            throw;
        }
    }
    /// <summary>
    ///  json字符串组合类(不包含 token)
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="result"></param>
    /// <param name="value"></param>
    /// <param name="token"></param>
    /// <returns></returns>
    public static string JsonValueString(string Message, string result, string value)
    {
        try
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"message\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(Message);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"result\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(result);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"value\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(value);
            sb.Append("\"");
            sb.Append("}");
            string json = sb.ToString();
            return json;

        }
        catch (Exception)
        {

            throw;
        }
    }

    /// <summary>
    ///  json字符串组合类-不包含value和token
    /// </summary>
    /// <param name="Message">提示信息向</param>
    /// <param name="result">提示状态 OK：成功 NO：失败</param>
    /// <returns></returns>
    public static string JsonString(string Message, string result)
    {
        try
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"message\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(Message);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"result\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(result);
            sb.Append("\"");
            sb.Append("}");
            string json = sb.ToString();
            return json;

        }
        catch (Exception)
        {

            throw;
        }
    }
    /// <summary>
    /// json字符串组合类-不包含value
    /// </summary>
    /// <param name="Message">提示信息向</param>
    /// <param name="result">提示状态 OK：成功 NO：失败</param>
    /// <param name="token">token</param>
    /// <returns></returns>
    public static string JsonString(string Message, string result, string token)
    {
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"message\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(Message);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"result\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(result);
            sb.Append("\"");
            sb.Append(",");
            sb.Append("\"token\"");
            sb.Append(":");
            sb.Append("\"");
            sb.Append(token);
            sb.Append("\"");
            sb.Append("}");
            string json = sb.ToString();
            return json;
        }
        catch (Exception)
        {

            throw;
        }
    }

}


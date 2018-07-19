using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


/// <summary>
/// 时间处理类
/// </summary>
public class TimeParserCommon
{

    /// <summary>
    /// DateTime时间格式转换为Unix时间戳格式
    /// </summary>
    /// <param name="time"> DateTime时间格式</param>
    /// <returns>Unix时间戳格式</returns>
    public static int ConvertDateTimeInt(System.DateTime time)
    {
        try
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    /// <summary>
    /// 时间戳转为C#格式时间
    /// </summary>
    /// <param name="timeStamp">Unix时间戳格式</param>
    /// <returns>C#格式时间</returns>
    public static DateTime GetTime(string timeStamp)
    {
        try
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    /// <summary>
    /// 本月月初
    /// </summary>
    /// <param name="dt">当前时间</param>
    /// <returns>DateTime</returns>
    public static DateTime StartMonth(DateTime dt)
    {
        try
        {
            DateTime startMonth = dt.AddDays(1 - dt.Day); //本月月初
            return startMonth;
        }
        catch (Exception)
        {

            throw;
        }
    }
    /// <summary>
    /// 本月月末
    /// </summary>
    /// <param name="dt">当前时间</param>
    /// <returns>DateTime</returns>
    public static DateTime EndMonth(DateTime dt)
    {
        try
        {
            DateTime startMonth = dt.AddDays(1 - dt.Day); //本月月初
            DateTime endMonth = startMonth.AddMonths(1).AddDays(-1); //本月月末
            return endMonth;
        }
        catch (Exception)
        {

            throw;
        }
    }


    /// <summary>
    /// 获取某一日期是该年中的第几周
    /// </summary>
    /// <param name="dt">日期</param>
    /// <returns>该日期在该年中的周数</returns>
    public static int GetWeekOfYear(DateTime dt)
    {
        GregorianCalendar gc = new GregorianCalendar();
        return gc.GetWeekOfYear(dt, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
    }
    /// <summary>
    /// 获取某一年有多少周
    /// </summary>
    /// <param name="year">年份</param>
    /// <returns>该年周数</returns>
    public static int GetWeekAmount(int year)
    {
        DateTime end = new DateTime(year, 12, 31);  //该年最后一天
        System.Globalization.GregorianCalendar gc = new GregorianCalendar();
        return gc.GetWeekOfYear(end, CalendarWeekRule.FirstDay, DayOfWeek.Monday);  //该年星期数
    }


    /// <summary>
    /// 把秒转换成分钟
    /// </summary>
    /// <returns></returns>
    public static int SecondToMinute(int Second)
    {
        decimal mm = (decimal)((decimal)Second / (decimal)60);
        return Convert.ToInt32(Math.Ceiling(mm));
    }

    #region 返回某年某月最后一天
    /// <summary>
    /// 返回某年某月最后一天
    /// </summary>
    /// <param name="year">年份</param>
    /// <param name="month">月份</param>
    /// <returns>日</returns>
    public static int GetMonthLastDate(int year, int month)
    {
        DateTime lastDay = new DateTime(year, month, new System.Globalization.GregorianCalendar().GetDaysInMonth(year, month));
        int Day = lastDay.Day;
        return Day;
    }
    #endregion

    #region 返回时间差
    /// <summary>
    /// 返回时间差
    /// </summary>
    /// <param name="DateTime1">第一个日期</param>
    /// <param name="DateTime2">第二个日期</param>
    /// <returns></returns>
    public static string DateDiff(DateTime DateTime1, DateTime DateTime2)
    {
        string dateDiff = null;
        try
        {
            //TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
            //TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
            //TimeSpan ts = ts1.Subtract(ts2).Duration();
            TimeSpan ts = DateTime2 - DateTime1;
            if (ts.Days >= 1)
            {
                dateDiff = DateTime1.Month.ToString() + "月" + DateTime1.Day.ToString() + "日";
            }
            else
            {
                if (ts.Hours > 1)
                {
                    dateDiff = ts.Hours.ToString() + "小时前";
                }
                else
                {
                    dateDiff = ts.Minutes.ToString() + "分钟前";
                }
            }
        }
        catch
        { }
        return dateDiff;
    }
    #endregion
}


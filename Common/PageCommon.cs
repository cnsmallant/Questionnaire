using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webdiyer.WebControls.Mvc;

/// <summary>
/// 分页
/// </summary>
public class PageCommon
{
    /// <summary>
    /// 分页操作
    /// </summary>
    /// <typeparam name="T">实体类</typeparam>
    /// <param name="pageIndx">页码</param>
    /// <param name="pageSize">每页显示</param>
    /// <param name="list">集合</param>
    /// <returns></returns>
    public static IList<T> PageList<T>(int pageIndx, int pageSize, IList<T> list) where T : class
    {

        try
        {
            int pageIndex = pageIndx;
            PagedList<T> mPage = list.AsQueryable().ToPagedList(pageIndx, pageSize);
            mPage.TotalItemCount = list.Count;
            mPage.CurrentPageIndex = pageIndx;
            return mPage;
        }
        catch (Exception)
        {
            
            throw;
        }


    }
}

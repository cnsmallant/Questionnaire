using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// 文件操作辅助类
/// </summary>
public class FileHelper
{

    /// <summary>
    ///利用 IO流读取所有文件
    /// </summary>
    /// <param name="path">路径</param>
    /// <param name="filter">格式 所有文件写  *.* 指定文件例如jpg:*.jpg</param>
    /// <returns>返回string数组</returns>
    public static string[] GetFile(string path, string filter)
    {
        try
        {
            string[] files = System.IO.Directory.GetFiles(path, filter, System.IO.SearchOption.TopDirectoryOnly);//获取该目录下的文件
            return files;
           
        }
        catch (Exception)
        {

            throw;
        }
    }

    /// <summary>
    /// 创建文件夹
    /// </summary>
    /// <param name="dirName">文件夹名称（含有路径）</param>
    /// <returns>true：成功；false:失败</returns>
    public static bool CreateDir(string dirName)
    {
        if (!Directory.Exists(dirName))
        {
            Directory.CreateDirectory(dirName);
        }
        return true;
    }


    /// <summary>
    /// 创建文件
    /// </summary>
    /// <param name="fileName">文件名字（含有路径）</param>
    /// <returns></returns>
    public static bool CreateFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            FileStream fs = File.Create(fileName);
            fs.Close();
            fs.Dispose();
        }
        return true;

    }
    /// <summary>
    /// 复制目录
    /// </summary>
    /// <param name="fromDir">被复制的目录</param>
    /// <param name="toDir">复制到的目录</param>
    /// <param name="rootDir">被复制的根目录</param>
    /// <returns></returns>
    private static bool CopyDir(DirectoryInfo fromDir, string toDir, string rootDir)
    {
        string filePath = string.Empty;
        foreach (FileInfo f in fromDir.GetFiles())
        {
            filePath = toDir + f.FullName.Substring(rootDir.Length);
            string newDir = filePath.Substring(0, filePath.LastIndexOf("\\"));
            CreateDir(newDir);
            File.Copy(f.FullName, filePath, true);
        }

        foreach (DirectoryInfo dir in fromDir.GetDirectories())
        {
            CopyDir(dir, toDir, rootDir);
        }

        return true;
    }



    /// <summary>
    ///利用IO流删除文件
    /// </summary>
    /// <param name="path">文件路径</param>
    /// <returns>true：成功；false：失败</returns>
    public static bool DelFile(string path)
    {
        try
        {
            File.Delete(path);
            if (IsFile(path))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }

    /// <summary>
    /// 判断是否存在此文件
    /// </summary>
    /// <param name="path">文件路径</param>
    /// <returns>true：存在；false：不存在</returns>
    public static bool IsFile(string path)
    {
        try
        {
            if (!System.IO.File.Exists(path))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    /// <summary>
    /// 判断是否存在此文件目录
    /// </summary>
    /// <param name="path">文件目录路径</param>
    /// <returns>true：存在；false：不存在</returns>
    public static bool IsFileDirectory(string path)
    {
        try
        {
            if (!System.IO.Directory.Exists(path))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }



    
}


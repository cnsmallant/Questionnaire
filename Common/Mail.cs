using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;


    /// <summary>
    /// 发送电子邮件类
    /// </summary>
    public class Mail
    {
        /// <summary>
        /// 发送电子邮件函数
        /// </summary>
        /// <param name="txtHost">电子邮件服务主机名称</param>
        /// <param name="txtFrom">发送人地志</param>
        /// <param name="txtPass">发信人密码</param>
        /// <param name="txtTo">收信人地址</param>
        /// <param name="txtSubject">邮件标题</param>
        /// <param name="txtBody">邮件内容</param>
        /// <param name="isBodyHtml">是否采用HTML编码</param>
        /// <param name="priority">电子邮件的优先级别</param>
        /// <param name="encoding">内容采用的编码方式</param>
        /// <param name="files">附件（可选填）</param>
        /// <returns>操作结果</returns>
        public static string SendMail(string txtHost, string txtFrom, string txtPass, string txtTo, string txtSubject, string txtBody, bool isBodyHtml, MailPriority priority, System.Text.Encoding encoding, params string[] files)
        {
            //电子邮件附件
            Attachment data = null;
            //传送的电子邮件类
            MailMessage message = new MailMessage(txtFrom, txtTo);

            //设置标题
            message.Subject = txtSubject;
            //设置内容
            message.Body = txtBody;
            //是否采用HTML编码
            message.IsBodyHtml = isBodyHtml;
            //电子邮件的优先级别
            message.Priority = priority;
            //内容采用的编码方式
            message.BodyEncoding = encoding;
            try
            {
                //添加附件
                if (files.Length > 0 && files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        //实例话电子邮件附件，并设置类型
                        data = new Attachment(files[i], System.Net.Mime.MediaTypeNames.Application.Octet);
                        //实例邮件内容
                        System.Net.Mime.ContentDisposition disposition = data.ContentDisposition;
                        //取得建档日期
                        disposition.CreationDate = System.IO.File.GetCreationTime(files[i]);
                        //取得附件修改日期
                        disposition.ModificationDate = System.IO.File.GetLastWriteTime(files[i]);
                        //取得读取日期
                        disposition.ReadDate = System.IO.File.GetLastAccessTime(files[i]);
                        //设定文件名称
                        System.IO.FileInfo fi = new System.IO.FileInfo(files[i]);
                        disposition.FileName = fi.Name.ToString();
                        //添加附件
                        message.Attachments.Add(data);
                    }
                }
                //实例从送电子邮件类
                SmtpClient client = new SmtpClient();
                //设置电子邮件主机名称
                client.Host = txtHost;
                //取得寄信人认证
                client.Credentials = new NetworkCredential(txtFrom, txtPass);
                //发送电子邮件
                client.Send(message);
                return "OK";
            }
            catch (Exception Err)
            {
                //返回错误信息
                return Err.Message;
            }
            finally
            {
                //销毁电子邮件附件
                if (data != null)
                {
                    data.Dispose();
                }
                //销毁传送的电子邮件实例
                message.Dispose();
            }
        }

        /// <summary>
        /// 群发送电子邮件函数
        /// </summary>
        /// <param name="txtHost">电子邮件服务主机名称</param>
        /// <param name="txtFrom">发送人地志</param>
        /// <param name="txtPass">发信人密码</param>
        /// <param name="txtTo">收信人地址</param>
        /// <param name="txtSubject">邮件标题</param>
        /// <param name="txtBody">邮件内容</param>
        /// <param name="isBodyHtml">是否采用HTML编码</param>
        /// <param name="priority">电子邮件的优先级别</param>
        /// <param name="encoding">内容采用的编码方式</param>
        /// <param name="files">附件（可选填）</param>
        /// <returns>操作结果</returns>
        public static string MassSendMail(string txtHost, string txtFrom, string txtPass, string txtTo, string txtSubject, string txtBody, bool isBodyHtml, MailPriority priority, System.Text.Encoding encoding, params string[] files)
        {
            //电子邮件附件
            Attachment data = null;
            //传送的电子邮件类
            MailMessage message = new MailMessage();
            message.From = new MailAddress(txtFrom);
            message.CC.Add(txtTo);

            //设置标题
            message.Subject = txtSubject;
            //设置内容
            message.Body = txtBody;
            //是否采用HTML编码
            message.IsBodyHtml = isBodyHtml;
            //电子邮件的优先级别
            message.Priority = priority;
            //内容采用的编码方式
            message.BodyEncoding = encoding;
            try
            {
                //添加附件
                if (files.Length > 0 && files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        //实例话电子邮件附件，并设置类型
                        data = new Attachment(files[i], System.Net.Mime.MediaTypeNames.Application.Octet);
                        //实例邮件内容
                        System.Net.Mime.ContentDisposition disposition = data.ContentDisposition;
                        //取得建档日期
                        disposition.CreationDate = System.IO.File.GetCreationTime(files[i]);
                        //取得附件修改日期
                        disposition.ModificationDate = System.IO.File.GetLastWriteTime(files[i]);
                        //取得读取日期
                        disposition.ReadDate = System.IO.File.GetLastAccessTime(files[i]);
                        //设定文件名称
                        System.IO.FileInfo fi = new System.IO.FileInfo(files[i]);
                        disposition.FileName = fi.Name.ToString();
                        //添加附件
                        message.Attachments.Add(data);
                    }
                }
                //实例从送电子邮件类
                SmtpClient client = new SmtpClient();
                //设置电子邮件主机名称
                client.Host = txtHost;
                //取得寄信人认证
                client.Credentials = new NetworkCredential(txtFrom, txtPass);
                //发送电子邮件
                client.Send(message);
                return "OK";
            }
            catch (Exception Err)
            {
                //返回错误信息
                return Err.Message;
            }
            finally
            {
                //销毁电子邮件附件
                if (data != null)
                {
                    data.Dispose();
                }
                //销毁传送的电子邮件实例
                message.Dispose();
            }
        }

    }


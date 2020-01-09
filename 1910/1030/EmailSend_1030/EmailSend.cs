using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EmailSend_1030
{
    public class EmailSend
    {
        public void Send(string emailTo, string emailFrom, string emailName, string pwdFrom, string title, string Contents, bool ishtml)
        {
            MailMessage myMail = new MailMessage();
            myMail.To.Add(emailTo);
            myMail.From = new MailAddress(emailFrom, emailName, Encoding.UTF8);
            myMail.Subject = title;
            myMail.Body = Contents;
            myMail.BodyEncoding = Encoding.UTF8;
            myMail.IsBodyHtml = ishtml;
            myMail.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(emailFrom, pwdFrom);
            client.Port = 587; // Gmail works on this port
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true; //Gmail works on Server Secured Layer
            try
            {
                client.Send(myMail);
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
                HttpContext.Current.Response.Write(errorMessage);
            }
        }
    }
}

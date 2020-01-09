using EmailSend_1030;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1224_01_WebQuestBook
{
    public partial class Mail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Server.MapPath("주문예약메일.html"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fs, Encoding.Default);
            string tempstr = reader.ReadToEnd();

            tempstr = tempstr.Replace("$업체명", "업체명");
            tempstr = tempstr.Replace("$이메일", "이메일");
            tempstr = tempstr.Replace("$주소", "주소");
            // tempstr = tempstr.Replace("$신규현금가", dr.Item("pi_NewPriceAll"));
            // tempstr = tempstr.Replace("$신규할부가", dr.Item("pi_NewPriceDiv"));
            // tempstr = tempstr.Replace("$보낸사람", Textbox3.Text + "님께서 " + TextBox1.Text + "님께 상품을 추천합니다.");
            // tempstr = tempstr.Replace("$메세지", Textbox5.Text);

            MailMessage myMail = new MailMessage();
            myMail.To.Add("bhb0047@naver.com");
            myMail.From = new MailAddress("sun@inhee.co.kr", "구디마켓", System.Text.Encoding.UTF8); 
            myMail.Subject = "내가 보내는 폼메일";
            myMail.Body = tempstr;
            myMail.BodyEncoding = System.Text.Encoding.UTF8;
            myMail.IsBodyHtml = true;
            myMail.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("ihlee@anyform.co.kr", "******");
            client.Port = 587; // Gmail works on this port
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true; //Gmail works on Server Secured Layer
            client.Credentials = new NetworkCredential("bhb0047@gmail.com", "qiphvquryoupokcp");
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
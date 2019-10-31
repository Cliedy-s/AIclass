using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSend_1030
{
    public class EmailSend
    {
        public void Send(string emailTo, string emailFrom, string pwdFrom, string title, string content)
        {
            string emailSendFrom = ConfigurationManager.AppSettings["emailSendFrom"];
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false; // 시스템 인증 정보 x
                client.EnableSsl = true; // SSL 인증 사용
                client.DeliveryMethod = SmtpDeliveryMethod.Network; // Gmail 인증
                client.Credentials = new NetworkCredential(emailFrom, pwdFrom); // 2단계 인증을 쓸 경우 => 앱 비밀번호 생성,  pwd에 넣기

                MailAddress mailFrom = new MailAddress("bhb0047@gmail.com", "신소연", Encoding.UTF8); // 보내는 사람
                MailAddress mailTo = new MailAddress(emailTo);
                MailMessage message = new MailMessage(mailFrom, mailTo);

                message.Subject = title;
                message.Body = content;
                message.BodyEncoding = Encoding.UTF8;
                message.SubjectEncoding= Encoding.UTF8;

                client.Send(message);
                message.Dispose();
            }
            catch (Exception ee){
                throw ee;
            }
        }
    }
}

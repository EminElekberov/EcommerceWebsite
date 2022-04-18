using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Extension
{
    public interface IEmailService
    {
        void Send(string to, string subject, string html);
    }
    public class EmailService : IEmailService
    {
        public void Send(string to, string subject, string html)
        { 
            //create message
            MimeMessage email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("aspporto99@gmail.com"));//kimden email gedecek bura yaziriq 
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text=html};

            //send message
            SmtpClient smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com",587,SecureSocketOptions.StartTls);
            smtp.Authenticate("aspporto99@gmail.com", "aspnetc638");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}

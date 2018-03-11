using System.Net;
using System.Net.Mail;
using CarCmsWebApi.Models;

namespace CarCmsWebApi.Service
{
    public class EmailService
    {
        public void SendEmail(EmailApiModel mailModel)
        {
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = true,
                Credentials =
                    new NetworkCredential("mail", "pass")
            };
            var mailMessage = new MailMessage
            {
                Sender = new MailAddress("mail"),
                From = new MailAddress("mail"),
                To = { mailModel.To },
                Body = "tresc maila",
                IsBodyHtml = true
            };

            smtpClient.Send(mailMessage);
        }
    }
}
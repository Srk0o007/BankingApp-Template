using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SOSUDAPAYAPI.EmailServices
{
    /// <summary>
    /// 
    /// </summary>
    public class EmailService: IEmailService
    {
        private readonly IOptions<Email> mailSetting;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public EmailService(IOptions<Email> app)
        {
            mailSetting = app;
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="messageText"></param>
        /// <returns></returns>
        public async Task SendEmail(string email, string subject, string messageText)
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(email));
                message.From = new MailAddress(mailSetting.Value.FromEmail, mailSetting.Value.FromName);
                message.CC.Add(new MailAddress(mailSetting.Value.CCEmail, mailSetting.Value.CCName));
                //message.Bcc.Add(new MailAddress("rawatdinu@gmail.com", "BCC Name"));
                message.Subject = subject;
                message.Body = messageText;
                message.IsBodyHtml = true;

                using (var client = new SmtpClient(mailSetting.Value.Domain))
                {
                    client.Port = Convert.ToInt32(mailSetting.Value.Port);
                    client.Credentials = new NetworkCredential(mailSetting.Value.FromEmail, mailSetting.Value.Password);
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }
            await Task.CompletedTask;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOSUDAPAYAPI.EmailServices
{
   public interface IEmailService
    {
        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        Task SendEmail(string email, string subject, string message);
    }
}

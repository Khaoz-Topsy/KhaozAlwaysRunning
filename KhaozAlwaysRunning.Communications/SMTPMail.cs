using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KhaozAlwaysRunning.Communications
{
    public class SMTPMail
    {
        public static void Send(string Subject, string Message)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                string Email = SecretData.EmailAddress;
                string Address = SecretData.Address;
                string Password = SecretData.Password;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(Address, Password)
                };

                using (var message = new MailMessage(Address, Email) { Subject = Subject, Body = Message })
                {
                    smtp.Send(message);
                }

            }).Start();
        }
    }
}

using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using Common;
using Interfaces.Mailer;

namespace BusinessLogic.Mailer
{
    public class Mailer : IMailer
    {
        public override void SendEmail()
        {
            var client = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("branko@bauk.si", "MajesticView43")
            };

            var mm = new MailMessage("branko.bauk@gmail.com", "branko@bauk.si", "test", "test")
            {
                BodyEncoding = Encoding.UTF8,
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            };

            client.Send(mm);
         }

    }
}

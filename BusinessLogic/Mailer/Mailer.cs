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
        //public override void SendEmail()
        //{
        //    var client = new SmtpClient
        //    {
        //        Port = 587,
        //        Host = "smtp.gmail.com",
        //        EnableSsl = true,
        //        Timeout = 10000,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential("branko@bauk.si", "MajesticView43")
        //    };

        //    var mm = new MailMessage("branko.bauk@gmail.com", "branko@bauk.si", "test", "test")
        //    {
        //        BodyEncoding = Encoding.UTF8,
        //        DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
        //    };

        //    client.Send(mm);
        // }

        public override void SendEmail()
        {
            // Compose a message
            var mail = new MailMessage("branko.bauk@gmail.com", "branko@bauk.si")
            {
                Subject = "Hello",
                Body = "Testing some Mailgun awesomness"
            };

            // Send it!
            var client = new SmtpClient
            {
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("postmaster@sandbox9f0a4db277724415ac55aa359f74577b.mailgun.org", "6bebeecd07a65a243eb6216117655fd9"),
                Host = "sandbox9f0a4db277724415ac55aa359f74577b.mailgun.org"
            };

            client.Send(mail);
        }

    }
}

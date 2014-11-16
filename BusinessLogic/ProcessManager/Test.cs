using System;
using Common;
using Interfaces.Mailer;

namespace BusinessLogic.ProcessManager
{
    
    public class Test
    {
        private readonly IMailer _mailer;

        public Test(IMailer mailer)
        {
            _mailer = mailer;
        }
        public void StartProcess()
        {
            _mailer.SendEmail();
        }
    }
}

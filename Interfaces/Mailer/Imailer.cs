using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Mailer
{
    public abstract class IMailer
    {
        public abstract void SendEmail();
    }
}

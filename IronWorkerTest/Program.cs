using System;
using System.Linq;
using BusinessLogic.Mailer;
using BusinessLogic.ProcessManager;
using Interfaces.Mailer;
using IronSharp.Core;
using IronSharp.IronMQ;
using IronSharp.IronWorker;


namespace IronWorkerTest
{
    
    internal class Program
    {
        
        private static void Main()
        {
            var mailer = new Mailer();
            var processManager = new Test(mailer);
            processManager.StartProcess();

            
        }
    }
}

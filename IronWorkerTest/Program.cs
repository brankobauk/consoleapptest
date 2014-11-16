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
            //var mailer = new Mailer();
            //var processManager = new Test(mailer);
            //processManager.StartProcess();

            IronWorkerRestClient workerClient = IronSharp.IronWorker.Client.New();

            string taskId = workerClient.Tasks.Create("Test", new { Key = "Value" });

            Console.WriteLine("TaskID: {0}", taskId);

            TaskInfoCollection taskInfoCollection = workerClient.Tasks.List("Test");

            foreach (TaskInfo task in taskInfoCollection.Tasks)
            {
                Console.WriteLine(task.Inspect()); 
            }

            ScheduleOptions options = ScheduleBuilder.Build().
                Delay(TimeSpan.FromMinutes(1)).
                WithFrequency(TimeSpan.FromHours(1)).
                RunFor(TimeSpan.FromHours(3)).
                WithPriority(TaskPriority.Default);

            var payload = new
            {
                a = "b",
                c = new[] { 1, 2, 3 }
            };

            ScheduleIdCollection schedule = workerClient.Schedules.Create("Test", payload, options);

            Console.WriteLine(schedule.Inspect());

            workerClient.Schedules.Cancel(schedule.Schedules.First().Id);
        }
    }
}

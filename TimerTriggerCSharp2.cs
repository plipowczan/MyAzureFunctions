using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace Company.Function
{
    public static class TimerTriggerCSharp2
    {
        [FunctionName("TimerTriggerCSharp2")]
        public static object Run([TimerTrigger("0/10 * * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
            return new { message = "Message " + myTimer.ScheduleStatus, time = DateTime.Now };
        }
    }
}

using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp6
{
    public static class ServiceBusTopicTriggerFunction
    {
        [FunctionName("Function1")]
        public static void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}

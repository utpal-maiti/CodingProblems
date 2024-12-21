using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp9
{
    public static class RabbitMQTriggerFunction
    {
        [FunctionName("Function1")]
        public static void Run([RabbitMQTrigger("myqueue", ConnectionStringSetting = "QueueConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}

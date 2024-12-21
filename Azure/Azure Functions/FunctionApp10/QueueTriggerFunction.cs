using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp10
{
    public static class QueueTriggerFunction
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "StorageConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}

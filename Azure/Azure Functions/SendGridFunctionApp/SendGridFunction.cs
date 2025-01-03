// The 'From' and 'To' fields are automatically populated with the values specified by the binding settings.
//
// You can also optionally configure the default From/To addresses globally via host.config, e.g.:
//
// {
//   "sendGrid": {
//      "to": "user@host.com",
//      "from": "Azure Functions <samples@functions.com>"
//   }
// }
using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using SendGrid.Helpers.Mail;
using Microsoft.Extensions.Logging;

namespace FunctionApp8
{
    public static class SendGridFunction
    {
        [FunctionName("Function1")]
        [return: SendGrid(ApiKey = "", To = "{CustomerEmail}", From = "SenderEmail@org.com")]
        public static SendGridMessage Run([QueueTrigger("sampleMessages", Connection = "")]Order order, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed order: {order.OrderId}");

            SendGridMessage message = new SendGridMessage()
            {
                Subject = $"Thanks for your order (#{order.OrderId})!"
            };

            message.AddContent("text/plain", $"{order.CustomerName}, your order ({order.OrderId}) is being processed!");
            return message;
        }
    }
    public class Order
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
    }
}

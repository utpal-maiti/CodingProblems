using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection.Metadata;

using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace CosmosDBTriggerFunctionApp
{
    public static class CosmosDBTriggerFunction
    {
        [FunctionName("Function1")]
        public static void Run([CosmosDBTrigger(
            databaseName: "databaseName",
           containerName: "collectionName",
            Connection = "ConnectionStrings:CosmosDBConnection",
            LeaseConnection ="leases")]IReadOnlyList<Document> input, ILogger log)
        {
            if (input != null && input.Count > 0)
            {
                log.LogInformation("Documents modified " + input.Count);
                log.LogInformation("First document Id " + input[0].Name);
            }
        }
    }
}

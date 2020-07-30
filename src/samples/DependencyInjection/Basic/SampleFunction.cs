// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Microsoft.Azure.Functions.Samples.DependencyInjectionBasic
{
    public class SampleFunction
    {
        private readonly IGreeter _greeter;
        private readonly IOptions<SampleOptions> _options;

        public SampleFunction(IGreeter greeter, IOptions<SampleOptions> options)
        {
            _greeter = greeter;
            _options = options;
        }

        [FunctionName("SampleFunction")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            return name != null
                ? (ActionResult)new OkObjectResult(_greeter.CreateGreeting(name, _options.Value.SampleSetting))
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}

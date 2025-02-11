using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Snoopy.Function
{
    public class HttpAPI
    {
        private readonly ILogger<HttpAPI> _logger;

        public HttpAPI(ILogger<HttpAPI> logger)
        {
            _logger = logger;
        }

        [Function("HttpAPI")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

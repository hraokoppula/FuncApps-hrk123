using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FuncApps_hrk123;

public class FunctionOne
{
    private readonly ILogger<FunctionOne> _logger;

    public FunctionOne(ILogger<FunctionOne> logger)
    {
        _logger = logger;
    }

    [Function("FunctionOne")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions, FunctionOne!");
    }
}
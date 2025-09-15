using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FuncApps_hrk123;

public class FunctionTwo
{
    private readonly ILogger<FunctionTwo> _logger;

    public FunctionTwo(ILogger<FunctionTwo> logger)
    {
        _logger = logger;
    }

    [Function("FunctionTwo")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions, FuncTwo!");
    }
}
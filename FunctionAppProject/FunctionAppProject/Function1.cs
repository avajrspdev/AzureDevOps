using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DevOpsTestFuncApp
{
  public static class Function1
  {
    [FunctionName("TestFunction")]
    public static IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
        ILogger log)
    {
      log.LogInformation("C# HTTP trigger function processed a request.");

      IConfiguration config = new ConfigurationBuilder().AddEnvironmentVariables().Build();

      var response = new
      {
        MyCustomValue      = config["MyCustomValue"],
        MyConnectionString = config.GetConnectionString("MyConnectionString")
      };

      return new JsonResult(response);
    }
  }
}

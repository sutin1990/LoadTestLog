using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rest_Api_Test.Models;
using Formatting = Newtonsoft.Json.Formatting;

namespace Rest_Api_Test.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GetMockDataController : ControllerBase
{
    protected readonly ILogger<GetMockDataController> _logger;

    public GetMockDataController(ILogger<GetMockDataController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "QueryOrderByASCEmpId")]
    public IEnumerable<QueryOrderByASCEmpIdResponse> Get()
    {
        var response = new List<QueryOrderByASCEmpIdResponse>
        {
            new QueryOrderByASCEmpIdResponse
            {
                ASCCode = "code11",
                EmployeeId = Random.Shared.Next(1001, 10000).ToString(),
                DateFrom = "01/10/2024",
                DateTo = "02/10/2024",
                LocationCode = "1011kk",
            }
        };
        string message = $"Call QueryOrderByASCEmpId , Response: {response.ObjToJson()}";
        _logger.LogInformation(message);
        return response;
    }

    
}

public static class Conv_Extension
{
    public static string ObjToJson<T>(this T source, bool isIndented = false, bool isIgnoreNull = false)
    {
        var indented = isIndented ? Formatting.Indented : Formatting.None;
        if (isIgnoreNull)
        {
            return JsonConvert.SerializeObject(source, new JsonSerializerSettings
            {
                Formatting = indented,
                NullValueHandling = NullValueHandling.Ignore
            });
        }
        return JsonConvert.SerializeObject(source, indented);
    }
}

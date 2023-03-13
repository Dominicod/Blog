using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebApp.Controllers;

[Authorize]
public class TestController : BaseController<TestController>
{
    public TestController(ILogger logger, IHttpContextAccessor httpContextAccessor) : base(logger, httpContextAccessor) { }
    
    public JsonResult Test()
    {
        const string test = "hello";
        return Json(test);
    }
}
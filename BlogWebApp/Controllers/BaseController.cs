using Microsoft.AspNetCore.Mvc;

namespace BlogWebApp.Controllers;

public class BaseController : Controller
{
    protected readonly ILogger Logger;
    protected readonly IHttpContextAccessor HttpContextAccessor;

    public BaseController(ILogger logger, IHttpContextAccessor httpContextAccessor)
    {
        Logger = logger;
        HttpContextAccessor = httpContextAccessor;
    }
}
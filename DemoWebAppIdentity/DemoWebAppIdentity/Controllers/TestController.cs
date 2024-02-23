using Microsoft.AspNetCore.Mvc;

namespace DemoWebAppIdentity.Controllers;

public class TestController : Controller
{
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        _logger.LogError("This error happened!");

        return View();
    }
}
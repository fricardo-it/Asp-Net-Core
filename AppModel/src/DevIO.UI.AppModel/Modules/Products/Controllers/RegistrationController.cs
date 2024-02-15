using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.AppModel.Modules.Products.Controllers
{

    [Area("Products")]
    [Route("products")]
    public class RegistrationController : Controller
    {
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("search")]
        public IActionResult Search()
        {
            return View();
        }
    }
}

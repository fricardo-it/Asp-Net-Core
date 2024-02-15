using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.AppModel.Modules.Sales.Controllers
{
    [Area("Sales")]
    [Route("sales")]
    public class OrderController : Controller
    {
        [Route("order")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

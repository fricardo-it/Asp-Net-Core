using DevIO.UI.AppModel.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.AppModel.Controllers
{
    public class HomeController : Controller
    {
        // ---> Best Way to Inject dependency:

        private readonly IOrderRepository _orderRepository;

        public HomeController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            var order = _orderRepository.ObtainOrder();
            return View();
        }

        ////---------------------------------------------------

        //// ---> Without access constructor:

        //public IActionResult Index([FromServices] IOrderRepository _orderRepository)
        //{
        //    var order = _orderRepository.ObtainOrder();
        //    return View();
        //}
    }
}

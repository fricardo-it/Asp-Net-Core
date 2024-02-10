using DI_LifeCycle.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_LifeCycle.Controllers
{
    public class HomeController : Controller
    {
        public OperationService OperationService { get; set; }
        public OperationService OperationService2 { get; set; }

        public HomeController(OperationService operationService, OperationService operationService2)
        {

            OperationService = operationService;
            OperationService2 = operationService2;
        }

        public string Index() 
        {
            return
                "1st instance: " + Environment.NewLine +
                OperationService.Transient.OperationId + Environment.NewLine +
                OperationService.Scoped.OperationId + Environment.NewLine +
                OperationService.Singleton.OperationId + Environment.NewLine +
                OperationService.SingletonInstance.OperationId + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "2nd instance: " + Environment.NewLine +
                OperationService2.Transient.OperationId + Environment.NewLine +
                OperationService2.Scoped.OperationId + Environment.NewLine +
                OperationService2.Singleton.OperationId + Environment.NewLine +
                OperationService2.SingletonInstance.OperationId + Environment.NewLine;
        }

    }
}

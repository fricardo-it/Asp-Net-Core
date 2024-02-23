using DemoWebAppIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DemoWebAppIdentity.Extensions;
using KissLog;

namespace DemoWebAppIdentity.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        [AllowAnonymous]
        public IActionResult Index()
        {

            _logger.LogDebug("Hello world from dotnet6!");

             return View();
        }

        public IActionResult Privacy()
        {
            throw new Exception("Error");

            return View();
        }

        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Secret()
        {
            return View();
        }

        [Authorize(Policy = "AllowedToDelete")]
        public IActionResult SecretClaim()
        {
            return View("Secret");
        }

        [Authorize(Policy = "AllowedToWrite")]
        public IActionResult SecretClaimWrite()
        {
            return View("Secret");
        }

        [ClaimsAuthorize("Products","Read")]
        public IActionResult ClaimsCustom()
        {
            return View("Secret");
        }

        [Route("error/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelError = new ErrorViewModel();

            if (id == 500)
            {
                modelError.Message = "An error occurred! Try again later or contact our support. (Custom)";
                modelError.Title = "Error Occurred";
                modelError.ErrorCode = id;
            }
            else if (id == 404)
            {
                modelError.Message = "The page was not found! <br />If you have any questions, please contact our support. (Custom)";
                modelError.Title = "Ops! Page not found.";
                modelError.ErrorCode = id;
            }
            else if (id == 403)
            {
                modelError.Message = "You don't have the user rights to view this page. (Custom)";
                modelError.Title = "Access denied";
                modelError.ErrorCode = id;
            }
            else
            {
                return StatusCode(404);
            }

            return View("Error", modelError);
        }
    }
}
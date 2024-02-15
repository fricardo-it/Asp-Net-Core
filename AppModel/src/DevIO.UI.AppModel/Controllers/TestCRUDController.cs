using DevIO.UI.AppModel.Data;
using DevIO.UI.AppModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.AppModel.Controllers
{
    public class TestCRUDController : Controller
    {
        private readonly EFContext _context;

        public TestCRUDController(EFContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var client = new Client
            {
                FirstName = "Client",
                LastName = "1",
                Email = "client1@email.com",
                PhoneNumber = "1234567890",
                RegistrationDate = DateTime.Now
            };

            // C - insert
            _context.Clients.Add(client);
            _context.SaveChanges();  // --> return the NUMBER of affected records

            // R - read
            var client2 = _context.Clients.Find(client.Id);  
            var client3 = _context.Clients.FirstOrDefault(c => c.Email == "client1@email.com");
            var client4 = _context.Clients.Where(c => c.FirstName == "Client"); // all registers with name Client


            // U - update
            client.FirstName = "Client 1";
            _context.Clients.Update(client);
            _context.SaveChanges();

            // D - delete
            _context.Clients.Remove(client2); // --> not for Id, only by object
            _context.SaveChanges();



            return View("_Layout");
        }
    }
}

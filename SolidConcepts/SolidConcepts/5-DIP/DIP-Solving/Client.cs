using SOLIDConcepts._5_DIP.DIP_Solving.Interfaces;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SolidConcepts._5_DIP.DIP_Solving
{
    public class Client
    {
        private readonly IEmailServices _emailServices;
        private readonly ISINServices _sinServices;

        public Client(ISINServices sinServices, IEmailServices emailServices) 
        {
            _sinServices = sinServices;
            _emailServices = emailServices;
        }
        
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string SIN { get; set; }
        public DateTime RegistrationDate { get; set; }

        public bool IsValid() 
        {
            return _emailServices.IsValid(Email) && _sinServices.IsValid(SIN);   
        }

    }
}

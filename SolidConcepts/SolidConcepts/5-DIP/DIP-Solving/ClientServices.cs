using System.Data;
using SOLIDConcepts._5_DIP.DIP_Solving.Interfaces;

namespace SolidConcepts._5_DIP.DIP_Solving
{
    public class ClientServices : IClientServices
    {
        private readonly IClientRepository _clientRepository;
        private readonly IEmailServices _emailServices;

        public ClientServices(IClientRepository clientRespository, IEmailServices emailServices) 
        {
            _clientRepository = clientRespository;
            _emailServices = emailServices;
        }

        public string AddClient(Client client)
        {

            if (!client.IsValid())
            {
                return "Invalid client data";
            }

            _clientRepository.AddClient(client);
            _emailServices.SendEmail("email@email.com", client.Email, "Welcome", "Congratulations, you are registered!");

            return "Client registered successfully!";

        }
    }
}

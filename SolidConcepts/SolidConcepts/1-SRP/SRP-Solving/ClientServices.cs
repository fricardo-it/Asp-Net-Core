using System.Data;

namespace SolidConcepts._1_SPP.SPP_Solving
{
    public class ClientService
    {
        public string AddClient(Client client)
        {

            if (!client.IsValid())
            {
                return "Invalid client data";
            }

            var repo = new ClientRepository();
            repo.AddClient(client);

            EmailServices.Send("email@email.com", client.Email, "Welcome", "Congratulations, you are registered!");

            return "Client registered successfully!";

        }
    }
}

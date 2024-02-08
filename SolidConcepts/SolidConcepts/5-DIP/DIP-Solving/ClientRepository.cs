using SOLIDConcepts._5_DIP.DIP_Solving.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace SolidConcepts._5_DIP.DIP_Solving
{
    public class ClientRepository : IClientRepository
    {

        public void AddClient(Client client)
        {

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENT (Name, Email, SIN, RegistrationDate) VALUES (@name, @email, @sin, @registrationDate)";

                cmd.Parameters.AddWithValue("name", client.Name);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("sin", client.SIN);
                cmd.Parameters.AddWithValue("registrationDate", client.RegistrationDate);

                cn.Open();
                cmd.ExecuteNonQuery();

            }
        }
    }
}

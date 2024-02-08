using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SolidConcepts._1_SPP.SPP_Violation
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string SIN { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string AddClient(){

            if (!Email.Contains("@"))
            {
                return "Invalid Email";
            }

            if (SIN.Length != 10)
            {
                return "Invalid SIN number";
            }

            if (!Email.Contains("@"))
            {
                return "Invalid Email";
            }

            using (var cn = new SqlConnection()) 
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyConnection";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENT (Name, Email, SIN, RegistrationDate) VALUES (@name, @email, @sin, @registrationDate)";

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("sin", SIN);
                cmd.Parameters.AddWithValue("registrationDate", RegistrationDate);

                cn.Open();
                cmd.ExecuteNonQuery();

            }

            var mail = new MailMessage("email@email.com", Email);
            var client = new SmtpClient()
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome";
            mail.Body = "Congratulations! You are registered";
            client.Send(mail);

            return "Client registered successfully!";

        }
    }
}

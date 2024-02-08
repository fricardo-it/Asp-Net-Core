using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SolidConcepts._1_SPP.SPP_Solving
{
    public class EmailServices
    {

        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public static void Send(string from, string to, string subject, string msg)
        {
            var mail = new MailMessage(from, to);
            var client = new SmtpClient()
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = msg;
            client.Send(mail);
        }
        
    }
}

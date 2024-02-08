using SOLIDConcepts._5_DIP.DIP_Solving.Interfaces;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SolidConcepts._5_DIP.DIP_Solving
{
    public class EmailServices : IEmailServices
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(string from, string to, string subject, string message)
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
            mail.Body = message;
            client.Send(mail);
        }
    }
}

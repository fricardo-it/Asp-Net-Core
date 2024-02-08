using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SolidConcepts._5_DIP.DIP_Violation
{
    public class SINServices
    {
        public static bool IsValid(string sin)
        {
            return sin.Length == 10;
        }
    }
}

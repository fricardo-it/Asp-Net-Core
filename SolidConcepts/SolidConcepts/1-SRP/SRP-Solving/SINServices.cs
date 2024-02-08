using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SolidConcepts._1_SPP.SPP_Solving
{
    public class SINServices
    {
        public static bool IsValid(string sin)
        {
            return sin.Length == 10;
        }
    }
}

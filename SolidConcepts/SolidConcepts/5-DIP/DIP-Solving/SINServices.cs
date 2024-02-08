using SOLIDConcepts._5_DIP.DIP_Solving.Interfaces;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SolidConcepts._5_DIP.DIP_Solving
{
    public class SINServices : ISINServices
    {
        public bool IsValid(string sin)
        {
            return sin.Length == 10;
        }
    }
}

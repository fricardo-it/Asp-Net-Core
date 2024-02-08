using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDConcepts._5_DIP.DIP_Solving.Interfaces
{
    public interface IEmailServices
    {
        bool IsValid(string email);
        void SendEmail(string from, string to, string subject, string message);
    }
}

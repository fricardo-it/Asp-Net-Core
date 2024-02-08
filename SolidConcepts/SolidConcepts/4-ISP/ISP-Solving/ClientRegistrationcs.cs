using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConcepts._4_ISP.ISP_Solving
{
    public class ClientRegistration : IRegistrationClient
    {
        public void ValidateData()
        {
            // Validate documents
        }

        public void SaveRecord()
        {
            // insert record into DB
        }

        public void SendEmail()
        {
            // Send Email 
        }

    }
}

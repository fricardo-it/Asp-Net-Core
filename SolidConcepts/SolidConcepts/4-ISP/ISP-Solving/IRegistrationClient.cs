using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConcepts._4_ISP.ISP_Solving
{
    public interface IRegistrationClient
    {
        void ValidateData();
        void SaveRecord();
        void SendEmail();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConcepts._4_ISP.ISP_Violation
{
    public interface IRegistration
    {
        void ValidateData();
        void SaveRecord();
        void SendEmail();

    }
}

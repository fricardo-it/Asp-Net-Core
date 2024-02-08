using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConcepts._4_ISP.ISP_Violation
{
    public class ProductsRegistration : IRegistration
    {
        public void ValidateData()
        {

            // Validate values
        }

        public void SaveRecord()
        {
            // insert record into db
        }

        public void SendEmail()
        {
            // product doesnt has email

        }


    }
}

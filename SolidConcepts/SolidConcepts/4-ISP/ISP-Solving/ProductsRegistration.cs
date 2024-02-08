using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConcepts._4_ISP.ISP_Solving
{
    public class ProductsRegistration : IRegistrationProduct
    {
        public void ValidateData()
        {

            // Validate values
        }

        public void SaveRecord()
        {
            // insert record into db
        }


    }
}

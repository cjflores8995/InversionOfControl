using InversionOfControl.DataAccessLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.ServiceLayer
{
    public class DataAcessFactory
    {
        public static ICustomerDataAccess GetDataAccessObject()
        {
            return new CustomerDataAccess();
        }
    }
}

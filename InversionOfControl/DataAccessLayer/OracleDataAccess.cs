using InversionOfControl.ServiceLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.DataAccessLayer
{
    public class OracleDataAccess: ICustomerDataAccess
    {
        public OracleDataAccess()
        {

        }

        public string GetCustomerName(int id)
        {
            return string.Format($"ORACLE: Hola, NOMBRE_{id} APELLIDO_{id}");
        }
    }
}

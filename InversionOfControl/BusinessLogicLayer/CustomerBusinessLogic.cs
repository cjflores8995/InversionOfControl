using InversionOfControl.DataAccessLayer;
using InversionOfControl.ServiceLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.BusinessLogicLayer
{
    public class CustomerBusinessLogic
    {
        private readonly ICustomerDataAccess _customerDataAccess;

        public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
        {
            _customerDataAccess = customerDataAccess;
        }

        public string GetCustomerName(int id)
        {
            return _customerDataAccess.GetCustomerName(id);
        }
    }
}

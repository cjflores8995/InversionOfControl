using InversionOfControl.BusinessLogicLayer;
using InversionOfControl.ServiceLayer;

using System;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService _service = new CustomerService();

            Console.Write(_service.GetCustomerName(12));

            Console.ReadKey();
        }
    }
}

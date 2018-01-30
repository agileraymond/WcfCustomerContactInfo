using System;
using BusinessLayer.Contracts;

namespace BusinessLayer
{
    public class BusinessController : IBusinessController
    {
        public bool AddCustomer(Customer newCustomer)
        {
            return true;
        }
    }
}

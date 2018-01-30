using BusinessLayer.Contracts;
using BusinessLayer;

namespace WcfCustomerContactInfo
{
    public class CustomerService : ICustomerService
    {
        private readonly IBusinessController _businessController;

        public CustomerService(IBusinessController businessController)
        {
            _businessController = businessController;
        }

        public bool AddCustomer(Customer newCustomer)
        {
            return _businessController.AddCustomer(newCustomer);
        }
    }
}

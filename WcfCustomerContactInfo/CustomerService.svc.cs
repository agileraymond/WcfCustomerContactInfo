using WcfCustomerContactInfo.Contracts;

namespace WcfCustomerContactInfo
{
    public class CustomerService : ICustomerService
    {
        public bool AddCustomer(Customer newCustomer)
        {
            // TODO: validate and then call data layer so we can save customer to database
            return true;
        }
    }
}

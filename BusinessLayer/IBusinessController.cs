using BusinessLayer.Contracts;

namespace BusinessLayer
{
    public interface IBusinessController
    {
        bool AddCustomer(Customer newCustomer);
    }
}

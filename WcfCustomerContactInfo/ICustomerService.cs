using System.ServiceModel;
using BusinessLayer.Contracts;

namespace WcfCustomerContactInfo
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        bool AddCustomer(Customer newCustomer);        
    }    
}

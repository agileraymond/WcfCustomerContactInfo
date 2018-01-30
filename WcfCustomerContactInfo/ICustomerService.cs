using System.ServiceModel;
using WcfCustomerContactInfo.Contracts;

namespace WcfCustomerContactInfo
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        bool AddCustomer(Customer newCustomer);        
    }    
}

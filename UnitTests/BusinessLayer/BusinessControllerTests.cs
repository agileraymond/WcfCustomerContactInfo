using Xunit;
using BusinessLayer;
using BusinessLayer.Contracts;

namespace UnitTests
{
    public class BusinessControllerTest
    {
        [Fact]
        public void AddCustomer()
        {
            var businessController = new BusinessController();
            Assert.True(businessController.AddCustomer(new Customer()));
        }
    }
}

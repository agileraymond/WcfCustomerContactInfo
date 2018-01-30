using System.Runtime.Serialization;

namespace BusinessLayer.Contracts
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }

    }
}

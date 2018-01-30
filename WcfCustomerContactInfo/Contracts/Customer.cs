using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfCustomerContactInfo.Contracts
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }
    }
}

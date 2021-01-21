using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Charisma.Entities
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember(IsRequired = true)]
        public string Name { get; set; }

        [DataMember(IsRequired = true)]
        public string Address { get; set; }

        [DataMember(IsRequired = true)]
        public string Telephone { get; set; }

        [DataMember]
        public List<Order> OrderHistory { get; set; }
    }
}

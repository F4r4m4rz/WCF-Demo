using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Charisma.Entities
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember(IsRequired = true)]
        public Customer Customer { get; set; }

        [DataMember]
        public List<MenuItem> MenuItems { get; set; }
    }
}

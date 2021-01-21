using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Charisma.Entities
{
    [DataContract]
    public class MenuItem
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember(IsRequired = true)]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember(IsRequired = true)]
        public double Fee { get; set; }
    }
}

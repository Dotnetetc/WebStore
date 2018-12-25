using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Entities
{
    public class Attribute
    {
        public int AttributeId { get; set; }
        public int CategoryId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

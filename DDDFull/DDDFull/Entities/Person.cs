using System;
using System.Collections.Generic;
using System.Text;

namespace DDDFull.Entities
{
    class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public Address Address { get; set; }
    }
}

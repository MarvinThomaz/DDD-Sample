using System;
using System.Collections.Generic;
using System.Text;
using DDDFull.Services;
using DDDFull.Entities;

namespace DDDFull
{
    class Program
    {
        private readonly IPersonService _service;

        public Program(IPersonService service)
        {
            _service = service;
        }

        public void Run()
        {
            var person = new Person()
            {
                Name = "Marvin",
                Address = new Address() { Address = "Endereço louco, 100" }
            };

            _service.Create(person);
        }
    }
}

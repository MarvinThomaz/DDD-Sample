using System;
using System.Collections.Generic;
using System.Text;
using DDDFull.Common;
using DDDFull.Repositories;
using DDDFull.Entities;

namespace DDDFull.Services
{
    class PersonService : IPersonService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Person person)
        {
            using (_unitOfWork.BeginTransaction())
            {
                var personRepository = _unitOfWork.GetRepository<IPersonRepository>();
                var addressRepository = _unitOfWork.GetRepository<IAddressRepository>();

                personRepository.Create(person);
                addressRepository.Create(person.Address);
            }
        }
    }
}

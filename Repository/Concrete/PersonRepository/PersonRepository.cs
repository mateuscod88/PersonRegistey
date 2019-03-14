using Entity.Context;
using Entity.Entities;
using Repository.Concrete.PersonRepository.Interface;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Concrete.PersonRepository
{
    class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(PersonRegistryContext context)
            :base(context)
        {

        }
    }
}

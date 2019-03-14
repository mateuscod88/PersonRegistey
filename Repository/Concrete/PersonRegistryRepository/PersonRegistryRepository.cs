using Contracts.Interface;
using Entity.Context;
using Entity.Entities;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Concrete
{
    class PersonRegistryRepository : RepositoryBase<PersonRegister> , IPersonRegistryRepository
    {
        
        public PersonRegistryRepository(PersonRegistryContext context)
            : base(context)
        {

        }
    }
}

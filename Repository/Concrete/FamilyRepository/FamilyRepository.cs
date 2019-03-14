using Entity.Context;
using Entity.Entities;
using Repository.Concrete.FamilyRepository.Interface;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Concrete.FamilyRepository
{
    class FamilyRepository : RepositoryBase<Family>, IFamilyRepository
    {
        public FamilyRepository(PersonRegistryContext context) : base(context)
        {

        }
    }
}

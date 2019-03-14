using Entity.Context;
using Entity.Entities;
using Repository.Concrete.MarriageRepository.Interface;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Concrete.MarriageRepository
{
    public class MarriageRepository : RepositoryBase<Marriage> , IMarriageRepository
    {
        public MarriageRepository(PersonRegistryContext context) 
            : base(context)
        {

        }
    }
}

using Repository.Concrete;
using Repository.Concrete.FamilyRepository.Interface;
using Repository.Concrete.MarriageRepository.Interface;
using Repository.Concrete.PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.RepositoryWrapper.Interface
{
    public interface IRepositoryWrapper
    {

         IPersonRepository          Persons { get; }
         IPersonRegistryRepository  PersonRegisters { get; }
         IMarriageRepository        Marriages { get; }
         IFamilyRepository          Familys { get; }

    }
}

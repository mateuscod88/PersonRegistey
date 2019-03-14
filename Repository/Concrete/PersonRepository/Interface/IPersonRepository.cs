using Contracts.Interface;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Concrete.PersonRepository.Interface
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
    }
}

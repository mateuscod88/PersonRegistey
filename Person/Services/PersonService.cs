using Entity.Context;
using Person.Model;
using Repository.RepositoryWrapper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person.Services
{
    public class PersonService : IPersonService
    {
        private readonly IRepositoryWrapper _repository;
        public PersonService(IRepositoryWrapper repository)
        {
            _repository = repository;
        }
        public void CreatePerson(PersonViewModel personViewModel)
        {
            var a = _repository.Persons.FindAll();
        }
    }
}

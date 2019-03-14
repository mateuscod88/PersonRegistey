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
            Entity.Entities.Person person = new Entity.Entities.Person { FirstName = personViewModel.FirstName,LastName = personViewModel.LastName,BirthDate = personViewModel.BirthDate};
            _repository.Persons.Create(person);
            _repository.Persons.Save();
        }
        public PersonViewModel GetByNameAndBirthDate(string firstName, string lastName,DateTime birthDate)
        {
            return _repository.Persons.FindByCondition(person => person.FirstName == firstName && person.LastName == lastName && person.BirthDate == birthDate).Select(x => new PersonViewModel { FirstName = x.FirstName, LastName = x.LastName, BirthDate = x.BirthDate, ID = x.ID }).FirstOrDefault();
        }
        public PersonViewModel GetById(int id)
        {
            return _repository.Persons.FindByCondition(person => person.ID == id).Select(x => new PersonViewModel { FirstName = x.FirstName, LastName = x.LastName, BirthDate = x.BirthDate, ID = x.ID }).FirstOrDefault();
        }
        public PersonRelationshipsViewModel GetByIdWithRelationships(int id)
        {
            var parents = _repository.Familys.FindByCondition(family => family.Parent.ID == id)..ToList();
            var childrens = _repository.Familys.FindByCondition(family => family.Child.ID == id).Select(x => new PersonViewModel { ID = x.Child.ID, FirstName = x.Child.FirstName, LastName = x.Child.LastName, BirthDate = x.Child.BirthDate }).ToList();

            var personRelationshipsViewModel = _repository.Persons.FindByCondition(person => person.ID == id).Select(x => new PersonRelationshipsViewModel { FirstName = x.FirstName, LastName = x.LastName, BirthDate = x.BirthDate, ID = x.ID }).FirstOrDefault();
            personRelationshipsViewModel.Family.AddRange(parents);
            personRelationshipsViewModel.Family.AddRange(childrens);

            return personRelationshipsViewModel;
        }


    }
}

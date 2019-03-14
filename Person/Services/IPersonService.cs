using Person.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Services
{
    public interface IPersonService
    {
         void CreatePerson(PersonViewModel personViewModel);
        PersonViewModel GetByNameAndBirthDate(string firstName, string lastName,DateTime birthDate);
        PersonViewModel GetById(int id);
        PersonRelationshipsViewModel GetByIdWithRelationships(int id);
    }
}

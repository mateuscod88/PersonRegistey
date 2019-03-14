using Entity.Context;
using Person.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person.Services
{
    public class PersonService : IPersonService
    {
        private readonly PersonRegistryContext _context;
        public PersonService(PersonRegistryContext context)
        {
            _context = context;
        }
        public void CreatePerson(PersonViewModel personViewModel)
        {
            var a = _context.Persons.FirstOrDefault();
        }
    }
}

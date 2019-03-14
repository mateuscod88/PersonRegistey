using Entity.Context;
using Repository.Concrete;
using Repository.Concrete.FamilyRepository;
using Repository.Concrete.FamilyRepository.Interface;
using Repository.Concrete.MarriageRepository;
using Repository.Concrete.MarriageRepository.Interface;
using Repository.Concrete.PersonRepository;
using Repository.Concrete.PersonRepository.Interface;
using Repository.RepositoryWrapper.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.RepositoryWrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private PersonRegistryContext      _context;
        private IPersonRepository          _person;
        private IPersonRegistryRepository  _personRegister;
        private IMarriageRepository        _marriage;
        private IFamilyRepository          _family;

        public RepositoryWrapper(PersonRegistryContext context)
        {
            _context = context;
        }
        public IPersonRepository Persons
        {
            get
            {
                if(_person == null)
                {
                    _person = new PersonRepository(_context);
                }
                return _person;
            }
        }
        public IPersonRegistryRepository PersonRegisters
        {
            get
            {
                if (_personRegister == null)
                {
                    _personRegister = new PersonRegistryRepository(_context);
                }
                return _personRegister;
            }
        }
        public IMarriageRepository Marriages
        {
            get
            {
                if (_marriage == null)
                {
                    _marriage = new MarriageRepository(_context);
                }
                return _marriage;
            }
        }
        public IFamilyRepository Familys
        {
            get
            {
                if (_family == null)
                {
                    _family = new FamilyRepository(_context);
                }
                return _family;
            }
        }
    }
}

using Person.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Services
{
    public interface IPersonService
    {
         void CreatePerson(PersonViewModel personViewModel);
    }
}

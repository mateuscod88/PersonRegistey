using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Person.Model
{
    public class PersonRelationshipsViewModel : PersonViewModel
    {
        public List<PersonViewModel> Family { get; set; }
    }
}

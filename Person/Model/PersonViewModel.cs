using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Person.Model
{
    public class PersonViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Last name is required")]
        public string LastName { get; set; }

        [Range(typeof(DateTime), "1/1/1900", "1/1/2050",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime BirthDate { get; set; }
    }
}

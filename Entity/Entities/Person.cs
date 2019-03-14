using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Fill in person first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Fill in person last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Fill in person birthdate")]
        public DateTime BirthDate{ get; set; }
    }
}
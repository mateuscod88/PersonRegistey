using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Person.Model;
using Person.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]
    public class PersonRegistryController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonRegistryController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet("{id}",Name = "GetById")]
        public ActionResult<PersonViewModel> GetById(int id)
        {
            var person = _personService.GetById(id);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }
        [HttpGet( Name = "GetByNameAndBirthDate")]
        public ActionResult<PersonViewModel> GetByNameAndBirthDate([FromQuery]string firstName, [FromQuery]string lastName, [FromQuery]DateTime birthDate)
        {
            var person = _personService.GetByNameAndBirthDate(firstName,lastName,birthDate);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }

        [HttpPost(Name = "Create")]
        public IActionResult Create([FromBody]PersonViewModel personViewModel)
        {


            try
            {
                if (personViewModel == null)
                {
                    return BadRequest("person view model object is null");

                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                var person = _personService.GetByNameAndBirthDate(personViewModel.FirstName, personViewModel.LastName, personViewModel.BirthDate);
                if (person != null)
                {
                    return BadRequest("person already exist");
                }

                _personService.CreatePerson(personViewModel);
                person = _personService.GetByNameAndBirthDate(personViewModel.FirstName, personViewModel.LastName, personViewModel.BirthDate);

                return CreatedAtRoute("GetById", new { id = person.ID }, person);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
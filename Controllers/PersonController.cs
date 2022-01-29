using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XssValidator.Controllers
{

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }


    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        public PersonController()
        {

        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            return Ok();
        }

    }
}

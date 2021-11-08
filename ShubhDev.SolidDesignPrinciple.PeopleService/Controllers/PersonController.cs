using Microsoft.AspNetCore.Mvc;
using ShubhDev.SolidDesignPrinciples.Application.Contracts;
using ShubhDev.SolidDesignPrinciples.Application.Model;
using ShubhDev.SolidDesignPrinciples.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace ShubhDev.SolidDesignPrinciple.PeopleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        IPeopleProvider provider;

        public PeopleController(IPeopleProvider provider)
        {
            this.provider = provider;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return provider.GetPeople();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return provider.GetPeople().FirstOrDefault(p => p.Id == id);
        }
    }
}

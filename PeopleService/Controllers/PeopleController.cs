using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;
using netcore.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netcore.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private IPeopleRepository PeopleRepository { get; set; }
        public PeopleController(IPeopleRepository peopleRepository)
        {
            PeopleRepository = peopleRepository;
        }
        // GET: api/people
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return PeopleRepository.People();
        }

        // GET api/people/5
        [HttpGet("{id}")]
        public Person Get(Guid id)
        {
            return PeopleRepository.People().FirstOrDefault(e => e.Id == id);
        }

        // POST api/people
        [HttpPost]
        public void Post([FromBody]Person value)
        {
            PeopleRepository.Add(value);
        }

        // PUT api/people/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Person delta)
        {
            PeopleRepository.Update(id, delta);
        }

        // DELETE api/people/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            PeopleRepository.Delete(id);
        }
    }
}

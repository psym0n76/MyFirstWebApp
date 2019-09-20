using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApiOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {


        readonly List<Person> _people = new List<Person>();

        public PeopleController()
        {
            _people.Add(new Person() { FirstName = "Simon xxxxxxxxxxxxxxxxxxxxxxxxx", Id = 1, LastName = "Burton" });
            _people.Add(new Person() { FirstName = "Greg", Id = 2, LastName = "Jones" });
            _people.Add(new Person() { FirstName = "Peter", Id = 3, LastName = "Smith" });
        }

        // GET: api/People
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            //return new string[] { "value1", "value2" };
            return _people;
        }

        // GET: api/People/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/People
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/People/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

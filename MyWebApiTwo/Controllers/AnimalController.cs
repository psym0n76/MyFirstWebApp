using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiTwo;

namespace MyWebApiTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        readonly List<Animal> _animal = new List<Animal>();

        public AnimalController()
        {
            _animal.Add(new Animal() { Name = "Pig", Id = 1, Colour = "Red" });
            _animal.Add(new Animal() { Name = "Horse", Id = 2, Colour = "Green" });
            _animal.Add(new Animal() { Name = "Donkey", Id = 3, Colour = "Brown" });
        }

        // GET: api/People
        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            //return new string[] { "value1", "value2" };
            return _animal;
        }

    }
}
﻿using Microsoft.AspNetCore.Mvc;
using Myproject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private static List<City> _city = new List<City>();
        // GET: api/<CityController>
        [HttpGet]
        public IEnumerable<City> Get()
        {
            return _city;
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public ActionResult <City> Get(String name)
        {
            var course = _city.Find(s => s.Name == name);
            if (course == null)
                return NotFound();
            else
                return course;
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] City city1)
        {
            _city.Add(new City { Name = city1.Name,Count=city1.Count });
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public ActionResult  Put(int count, [FromBody] string name)
        {

            var course = _city.Find(s => s.Name == name);
            if (course == null)
                return NotFound();
            else
            {
                course.Count = count;
                 return Ok();
            }
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string name)
        {
            var course = _city.Find(s => s.Name == name);
            if (course == null)
                return NotFound();
            else
            {
                _city.Remove(course);
                return Ok();
            }
        }
    }
}

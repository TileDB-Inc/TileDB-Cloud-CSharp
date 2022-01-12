using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TestWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDataController : ControllerBase
    {
        private List<TestWebApi.Models.TestData> persons = new List<TestWebApi.Models.TestData> {
            new TestWebApi.Models.TestData {Id=1,FirstName="Peter",LastName="Peterson"},
            new TestWebApi.Models.TestData {Id=2,FirstName="Tom",LastName="Thomson"},
            new TestWebApi.Models.TestData {Id=3,FirstName="John",LastName="Johnson"}
        };

        // GET: api/<TestDataController>
        [HttpGet]
        public ActionResult<IEnumerable<TestWebApi.Models.TestData>> Get()
        {
            return persons;
        }

        // GET api/<TestDataController>/5
        [HttpGet("{id}")]
        public ActionResult<TestData> Get(int id)
        {
            TestData person = persons.FirstOrDefault(c => c.Id == id);
            if (person == null)
            {
                return NotFound(new { Message = "not found" });
            }
            return Ok(person);
        }

        // POST api/<TestDataController>
        [HttpPost]
        public ActionResult<IEnumerable<TestData>> Post(TestData newdata)
        {
            persons.Add(newdata);
            return persons;
        }

        // PUT api/<TestDataController>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<TestData>> Put(int id, TestData updatedata)
        {
            TestData person = persons.FirstOrDefault(c => c.Id == id);
            if (person == null)
            {
                return NotFound(new { Message = "not found" });
            }
            person.FirstName = updatedata.FirstName;
            person.LastName = updatedata.LastName;
            person.IsDeleted = updatedata.IsDeleted;
            return persons;
        }

        // DELETE api/<TestDataController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<TestData>> Delete(int id)
        {
            TestData person = persons.FirstOrDefault(c => c.Id == id);
            if (person == null)
            {
                return NotFound(new { Message = "not found" });
            }
            persons.Remove(person);
            return persons;
        }
    }
}

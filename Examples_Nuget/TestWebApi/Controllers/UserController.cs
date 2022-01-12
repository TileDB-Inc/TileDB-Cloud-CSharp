using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<TileDB.Cloud.Rest.Model.User> Get()
        {
            TileDB.Cloud.Rest.Model.User user = TileDB.Cloud.RestUtil.GetUser();
            if (user == null)
            {
                return NotFound(new { Message = "no user found" });
            }
             
            return user;
 
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<TileDB.Cloud.Rest.Model.User> Get(int id)
        {
            TileDB.Cloud.Rest.Model.User user = new TileDB.Cloud.Rest.Model.User(username: "testuser");
            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<TileDB.Cloud.Rest.Model.User> Post([FromBody] string value)
        {
            return NotFound(new { Message = "Not supported operation." });
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<TileDB.Cloud.Rest.Model.User> Put(int id, [FromBody] string value)
        {
            return NotFound(new { Message = "Not supported operation." });
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<TileDB.Cloud.Rest.Model.User> Delete(int id)
        {
            return NotFound(new { Message = "Not supported operation." });
        }
    }
}

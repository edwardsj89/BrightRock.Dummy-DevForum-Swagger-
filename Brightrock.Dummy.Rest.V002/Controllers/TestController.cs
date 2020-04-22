using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Brightrock.Dummy.Rest.V002.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public IHttpActionResult Post([FromBody]string value)
        {
            return Ok($"Value {value} posted successfully.");
        }

        // PUT: api/Test/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]string myValue)
        {
            return Ok($"Value {myValue} put successfully.");
        }

        // DELETE: api/Test/5
        public IHttpActionResult Delete(int id)
        {
            return Ok($"Value with ID {id} deleted successfully.");
        }
    }
}

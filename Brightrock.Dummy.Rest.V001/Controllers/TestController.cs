using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Brightrock.Dummy.Rest.V001.Controllers
{
    public class TestController : ApiController
    {
        public TestController()
        {
            
        }

        // GET: Test
        [HttpGet]
        [Route("test")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: Test/5
        [HttpGet]
        [Route("test/{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: Test
        [HttpPost]
        [Route("test")]
        public IHttpActionResult Post([FromBody]string value)
        {
            return Ok($"Post [test] Success! value = {value}");
        }

        // PUT: Test/5
        [HttpPut]
        [Route("test/{id:int}")]
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok($"Put [test/{id}] Success! value = {value}");
        }

        // DELETE: Test/5
        [HttpDelete]
        [Route("test/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            return Ok($"Delete [test/{id}] Success!");
        }
    }
}

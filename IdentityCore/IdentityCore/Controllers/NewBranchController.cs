using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewBranchController : ControllerBase
    {
        // GET: api/NewBranch
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1NewBranch", "value2NewBranch" };
        }

        // GET: api/NewBranch/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NewBranch
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/NewBranch/5
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

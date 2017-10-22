using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Miles.People.List;

namespace Miles.People.Core.Controllers
{
    [Produces("application/json")]
    [Route("api/People")]
    public class PeopleController : Controller
    {
        private readonly Company _company;

        public PeopleController()
        {
            _company = new Company();
        }

        // GET: api/People
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _company.GetEmployees();
        }

        // GET: api/People/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/People
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/People/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinsoftERP.API.DbContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinsoftERP.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ERPContext _context;

        public ValuesController(ERPContext context)
        {
            _context = context;
        }
        // GET api/values
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //return new string[] { "value1", "dsdsdsdvalue2" };
            var values = await _context.AccountTypeSubCodes.Select(x => new {x.Code, x.Description}).ToListAsync(); 

            return Ok(values);


        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

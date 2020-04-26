using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController: ControllerBase
    {
        private readonly DataContext _context;
        public PagesController(DataContext context)
        {
            _context = context;
        }

        // GET api/Pages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Page>>> Get()
        {
            var Pages = await _context.Pages.ToListAsync();
            return Ok(Pages);
        }

        
        // GET api/Pages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Page>> Get(Guid id)
        {
            var Page = await _context.Pages.FindAsync(id);
            return Ok(Page);
        }

        // POST api/Pages
        [HttpPost]
        public void Post([FromBody] string Page)
        {
        }

        // PUT api/Pages/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string Page)
        {
        }

        // DELETE api/Pages/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    }
}
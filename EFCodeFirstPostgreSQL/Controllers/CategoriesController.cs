using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCodeFirstPostgreSQL.EntityFramework;
using EFCodeFirstPostgreSQL.EntityFramework.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstPostgreSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private DBContext _context;
        public CategoriesController(DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Category>> Get()
        {
            var categories = _context.Categories.Include(x=>x.Products).ToList();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public ActionResult<Category> Get(int Id)
        {
            var category = _context.Categories.Where(x => x.Id == Id).FirstOrDefault();
            return Ok(category);
        }

        // POST: api/Categories
        [HttpPost]
        public void Post(string value)
        {
        }

        // PUT: api/Categories/5
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

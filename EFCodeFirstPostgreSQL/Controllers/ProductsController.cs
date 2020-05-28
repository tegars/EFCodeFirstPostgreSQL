using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCodeFirstPostgreSQL.EntityFramework;
using EFCodeFirstPostgreSQL.EntityFramework.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCodeFirstPostgreSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private DBContext _context;
        public ProductsController(DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int Id)
        {
            var product = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
            return Ok(product);
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

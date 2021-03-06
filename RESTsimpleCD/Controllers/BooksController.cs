using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RESTsimpleCD.Managers;
using RESTsimpleCD.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTsimpleCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksManager _manager = new BooksManager();
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public Book Post([FromBody] Book value)
        {
            return _manager.Add(value);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

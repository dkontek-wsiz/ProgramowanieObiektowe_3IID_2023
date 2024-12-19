using Lab2.Interfaces;
using Lab2.Lab6;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repository;

        public PersonController(IPersonRepository repository)
        {
            _repository = repository;
        }


        // GET: api/<BookController>
        [HttpGet]
        public List<Person> GetAll()
        {
            return _repository.GetAll();
        }

        // GET api/<BookController>/5
        [HttpGet]
        public ActionResult<Person> Get(int id)
        {
            return Ok(_repository.Get(id));
        }

        // POST api/<BookController>
        [HttpPost]
        public void Create(Person value)
        {
            _repository.Create(value);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Update(Person value)
        {
            _repository.Update(value);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        [HttpGet]
        public List<Book> GetBoorowedBooks(int id)
        {
            return _repository.GetBorrowedBook(id);
        }

        [HttpPost]

        public void BorrwBook(int id, Book book)
        {
            _repository.BorrowBook(id, book);
        }
    }
}

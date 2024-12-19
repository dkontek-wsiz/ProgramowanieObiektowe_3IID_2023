using Lab2.Interfaces;
using Lab2.Lab6;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _repository;

        public BookController(IBookRepository repository)
        {
            _repository = repository;
        }

    
        // GET: api/<BookController>
        [HttpGet]
        public List<Book> GetAll()
        {
            return _repository.GetAll();
        }

        // GET api/<BookController>/5
        [HttpGet]
        public ActionResult<Book> Get(long id)
        {
            return Ok(_repository.Get(id));
        }

        // POST api/<BookController>
        [HttpPost]
        public void Create(Book value)
        {
           _repository.Create(value);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Update(Book value)
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
        public List<Book> GetBookByAuthors(string author)
        {
            return _repository.GetBooksByAuthor(author);
        }

        [HttpGet]
        public List<Book> GetByYear(int year)
        {
            return _repository.GetBooksByPublishYear(year);
        }
    }
}

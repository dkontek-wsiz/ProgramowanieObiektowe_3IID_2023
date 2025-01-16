using Lab2.Interfaces;
using Lab2.Lab6;
using WebApplication1.Context;

namespace WebApplication1.Repositories
{
    public class EFPeronRepository(LibraryDbContext context) : IPersonRepository
    {
        public void BorrowBook(int id, Book book)
        {
            throw new NotImplementedException();
        }

        public void Create(Person entity)
        {
            context.Persons.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBorrowedBook(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}

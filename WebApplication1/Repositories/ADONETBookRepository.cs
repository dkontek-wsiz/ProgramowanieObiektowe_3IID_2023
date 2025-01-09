using Lab2.Interfaces;
using Lab2.Lab6;
using System.Configuration;
using System.Data.SQLite;

namespace WebApplication1.Repositories
{
    public class ADONETBookRepository(IConfiguration configuration) : IBookRepository
    {

        private readonly string _connectionString = configuration.GetConnectionString("DefaultConnection");

        private SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(_connectionString);
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            return connection;
        }

        public void Create(Book entity)
        {
            using var connection = GetConnection();

            string query = @"INSERT INTO Books (CreationTime, Title, Author, PublishDate)
 VALUES (@CreationTime, @Title, @Author, @PublishDate)";
            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@CreationTime", entity.CreationTime);
            command.Parameters.AddWithValue("@Title", entity.Title);
            command.Parameters.AddWithValue("@Author", entity.Author);
            command.Parameters.AddWithValue("@PublishDate", entity.PublishDate);
            command.ExecuteNonQuery();
        }

        public void Delete(long id)
        {
            using var connection = GetConnection();
            string query = "DELETE FROM Books WHERE Id = @Id";
            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }

        public Book Get(long id)
        {
            using var connection = GetConnection();
            string query = "SELECT * FROM Books WHERE Id = @Id";
            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Book
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CreationTime = Convert.ToDateTime(reader["CreationTime"]),
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    PublishDate = Convert.ToDateTime(reader["PublishDate"])
                };
            }
            return null;
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByPublishYear(int year)
        {
            var books = new List<Book>();
            using var connection = GetConnection();
            string query = @"SELECT * FROM Books
            WHERE strftime('%Y', PublishDate) = @Year";
            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Year", year.ToString());
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                books.Add(new Book
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CreationTime = Convert.ToDateTime(reader["CreationTime"]),
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    PublishDate = Convert.ToDateTime(reader["PublishDate"])
                });
            }
            return books;
        }

        public void Update(Book entity)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            string query = @"UPDATE Books
 SET CreationTime = @CreationTime,
 Title = @Title,
 Author = @Author,
 PublishDate = @PublishDate
 WHERE Id = @Id";
            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@CreationTime", entity.CreationTime);
            command.Parameters.AddWithValue("@Title", entity.Title);
            command.Parameters.AddWithValue("@Author", entity.Author);
            command.Parameters.AddWithValue("@PublishDate", entity.PublishDate);
            command.ExecuteNonQuery();

        }
    }
}

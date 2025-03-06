using Microsoft.Data.SqlClient;

namespace Part2.DesignPatters.DAODesignPattern
{
    public class BookDAO
    {
        private readonly string _connectionString = "server=(localdb)\\MSSQLLocalDB;database=BookManagementDB;Integrated Security=true";

        public BookEntity GetById(int id)
        {
            BookEntity product = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Books WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new BookEntity
                        {
                            Id = (int)reader["Id"],
                            Title = reader["Title"].ToString(),
                            AuthorName = reader["AuthorName"].ToString()
                        };
                    }
                }
            }
            return product;
        }
    }
}

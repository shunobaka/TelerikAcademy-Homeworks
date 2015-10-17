namespace BooksOperations
{
    using System;
    using MySql.Data.MySqlClient;

    public class BooksOperator
    {
        private const string ConnectionStringFormat = "Server = localhost; Database=library; Uid={0}; Pwd={1};";
        private static MySqlConnection dbcon;

        public static void Main()
        {
            Console.Write("Please enter local mysql username: ");
            var username = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();

            var connectionString = string.Format(BooksOperator.ConnectionStringFormat, username, password);
            Book book = new Book()
            {
                Title = "C# guru",
                Author = "Some Guy",
                PublishDate = DateTime.Now,
                ISBN = "439429342"
            };

            try {
                using (dbcon = new MySqlConnection(connectionString))
                {
                    dbcon.Open();

                    InsertBook(book);
                    FindByName(book.Title);
                    ListAllBooks();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Make sure you've run the query in the project folder to generate the database.");
                Console.WriteLine("Also make sure that the entered username and passwork are valid.");
            }
        }

        private static void InsertBook(Book book)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO Books(Title, Author, PublishDate, ISBN) VALUES (@title, @author, @publishDate, @isbn)", dbcon);
            command.Parameters.AddWithValue("@title", book.Title);
            command.Parameters.AddWithValue("@author", book.Author);
            command.Parameters.AddWithValue("@publishDate", book.PublishDate);
            command.Parameters.AddWithValue("@isbn", book.ISBN);

            command.ExecuteNonQuery();

            Console.WriteLine("Successfully added book to db!");
            Console.WriteLine();
        }

        private static void FindByName(string title)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Books WHERE Title = @title", dbcon);
            command.Parameters.AddWithValue("@title", title);
            var reader = command.ExecuteReader();

            Console.WriteLine("Found books by name " + title);
            Console.WriteLine();

            while (reader.Read())
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Title: " + (string)reader["Title"]);
                Console.WriteLine("Author: " + (string)reader["Author"]);
                Console.WriteLine("Publish date: " + reader["PublishDate"].ToString());
                Console.WriteLine("Isbn: " + (string)reader["Isbn"]);
                Console.WriteLine("---------------------");
            }

            reader.Dispose();
            Console.WriteLine();
        }

        private static void ListAllBooks()
        {
            MySqlCommand command = new MySqlCommand("SELECT Title, Author FROM Books", dbcon);
            var reader = command.ExecuteReader();

            Console.WriteLine("List of all books:");
            Console.WriteLine();

            while (reader.Read())
            {
                Console.WriteLine("Title: " + (string)reader["Title"]);
                Console.WriteLine("Author: " + (string)reader["Author"]);
                Console.WriteLine("---------------------");
            }

            reader.Dispose();
            Console.WriteLine();
        }
    }
}

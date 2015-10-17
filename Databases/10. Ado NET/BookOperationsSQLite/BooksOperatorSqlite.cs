namespace BooksOperationsSQLite
{
    using System;
    using System.Data.SQLite;

    public class BooksOperatorSqlite
    {
        private const string ConnectionString = "Data Source=../../Library.sqlite;Version=3;";
        private static SQLiteConnection dbcon;

        public static void Main()
        {
            Book book = new Book()
            {
                Title = "C# guru",
                Author = "Some Guy",
                PublishDate = DateTime.Now,
                ISBN = "439429342"
            };

            try
            {
                using (dbcon = new SQLiteConnection(BooksOperatorSqlite.ConnectionString))
                {
                    dbcon.Open();
                    // CreateDB();
                    // PopulateDB();
                    InsertBook(book);
                    FindByName(book.Title);
                    ListAllBooks();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("If database doesn't exist or isn't populated, uncomment the appropriate method above! (CreateDB or PopulateDb)");
                Console.WriteLine(ex);
            }
        }

        private static void InsertBook(Book book)
        {
            SQLiteCommand command = new SQLiteCommand("INSERT INTO Books(Title, Author, PublishDate, ISBN) VALUES (@title, @author, @publishDate, @isbn)", dbcon);
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
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Books WHERE Title = @title", dbcon);
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
            SQLiteCommand command = new SQLiteCommand("SELECT Title, Author FROM Books", dbcon);
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

        private static void CreateDB()
        {
            SQLiteCommand command = new SQLiteCommand("CREATE TABLE Books(id INT IDENTITY, Title varchar(80) default NULL, Author varchar(40) default NULL, PublishDate datetime, ISBN varchar(36) NOT NULL, PRIMARY KEY(id))", dbcon);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        private static void PopulateDB()
        {
            SQLiteCommand command = new SQLiteCommand("INSERT INTO Books(Title, Author, PublishDate, ISBN) VALUES (\"C#\", \"Some Guy\", '2015-12-02', \"DASDSDA433243\"), (\"Javascript is a woman\", \"Pavel Kolev\", '2133-02-20', \"EPIC-BOOK\"), (\"Just\", \"Another Book\", '1995-01-01', \"SOME-RANDOM-ISBN\"), (\"OhLook\", \"Thatis Book\", '1600-04-30', \"C57B4BE4-8E4F-E983-171C-4225F33D620D\");", dbcon);
            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}

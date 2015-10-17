namespace CategoriesNameAndDescription
{
    using System;
    using System.Data.SqlClient;

    public class NameAndDescriptionRetriever
    {
        private const string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        public static void Main()
        {
            using (SqlConnection dbcon = new SqlConnection(NameAndDescriptionRetriever.ConnectionString))
            {
                dbcon.Open();

                var command = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbcon);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Category: " + (string)reader["CategoryName"]);
                    Console.WriteLine("Description: " + (string)reader["Description"]);
                    Console.WriteLine();
                }
            }
        }
    }
}

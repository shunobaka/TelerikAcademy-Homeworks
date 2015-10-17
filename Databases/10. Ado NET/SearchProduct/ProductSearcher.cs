namespace SearchProduct
{
    using System;
    using System.Data.SqlClient;

    public class ProductSearcher
    {
        private const string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        public static void Main()
        {
            Console.Write("Enter what to search for: ");
            var search = Console.ReadLine();

            using (SqlConnection dbcon = new SqlConnection(ProductSearcher.ConnectionString))
            {
                dbcon.Open();
                var command = new SqlCommand("SELECT * FROM Products WHERE ProductName LIKE @pattern", dbcon);
                command.Parameters.AddWithValue("@pattern", "%" + search + "%");

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Product: " + (string)reader["ProductName"]);
                }
            }
        }
    }
}

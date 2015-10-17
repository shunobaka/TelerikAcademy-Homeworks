namespace ProductsInCategory
{
    using System;
    using System.Data.SqlClient;

    public class ProductsInCategoryRetriever
    {
        private const string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        public static void Main()
        {
            using (SqlConnection dbcon = new SqlConnection(ProductsInCategoryRetriever.ConnectionString))
            {
                dbcon.Open();

                var command = new SqlCommand("SELECT p.ProductName, c.CategoryName FROM Products p INNER JOIN Categories c ON p.CategoryId = c.CategoryId", dbcon);
                var reader = command.ExecuteReader();

                var previousCategory = "";

                while (reader.Read())
                {
                    string category = (string)reader["CategoryName"];
                    if (category != previousCategory)
                    {
                        previousCategory = category;
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Category \"{0}\":", category);
                    }

                    Console.WriteLine("  - " + (string)reader["ProductName"]);
                }
            }
        }
    }
}

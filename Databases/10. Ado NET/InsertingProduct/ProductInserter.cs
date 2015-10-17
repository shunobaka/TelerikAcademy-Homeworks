namespace InsertingProduct
{
    using System;
    using System.Data.SqlClient;

    public class ProductInserter
    {
        private const string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        public static void Main()
        {
            using (SqlConnection dbcon = new SqlConnection(ProductInserter.ConnectionString))
            {
                dbcon.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Products(ProductName, UnitPrice, QuantityPerUnit) VALUES (@productName, @unitPrice, @quantity)", dbcon);
                command.Parameters.AddWithValue("@quantity", "500 g");
                command.Parameters.AddWithValue("@productName", "Bob");
                command.Parameters.AddWithValue("@unitPrice", 3.50);

                command.ExecuteNonQuery();
            }

            Console.WriteLine("Product inserted successfully!");
        }
    }
}

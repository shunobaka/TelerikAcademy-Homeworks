namespace NumberOfRows
{
    using System;
    using System.Data.SqlClient;

    public class NumberOfRowsRetriever
    {
        private const string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        public static void Main()
        {
            using (SqlConnection dbcon = new SqlConnection(NumberOfRowsRetriever.ConnectionString))
            {
                dbcon.Open();
                var command = new SqlCommand("SELECT COUNT(*) FROM Categories", dbcon);
                var rowCount = command.ExecuteScalar();

                Console.WriteLine("There are " + (int)rowCount + " rows in table Categories.");
            }
        }
    }
}

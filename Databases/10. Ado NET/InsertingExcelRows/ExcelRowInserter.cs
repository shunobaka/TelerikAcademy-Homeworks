namespace InsertingExcelRows
{
    using System;
    using System.Data.OleDb;

    public class ExcelRowInserter
    {
        private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Results.xlsx;Extended Properties='Excel 8.0;HDR=Yes'";

        public static void Main()
        {
            using (OleDbConnection dbcon = new OleDbConnection(ExcelRowInserter.ConnectionString))
            {
                dbcon.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO [Sheet1$] (Name, Score) VALUES (@name, @score)", dbcon);
                command.Parameters.AddWithValue("@name", "Pesho Gosho");
                command.Parameters.AddWithValue("@score", "29");

                var reader = command.ExecuteNonQuery();
            }

            Console.WriteLine("Row inserted successfully!");
        }
    }
}

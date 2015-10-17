namespace ReadingNameAndScore
{
    using System;
    using System.Data.OleDb;

    public class ExcelReader
    {
        private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Results.xlsx;Extended Properties='Excel 8.0;HDR=Yes'";

        public static void Main()
        {
            using (OleDbConnection dbcon = new OleDbConnection(ExcelReader.ConnectionString))
            {
                dbcon.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM [Sheet1$]", dbcon);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("{0} --> {1}", (string)reader["Name"], (double)reader["Score"]);
                }
            }
        }
    }
}

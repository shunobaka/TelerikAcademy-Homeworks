namespace ExtractingImages
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using System.Drawing;

    public class ImageExtracter
    {
        private const string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        public static void Main()
        {
            using (SqlConnection dbcon = new SqlConnection(ImageExtracter.ConnectionString))
            {
                dbcon.Open();

                SqlCommand command = new SqlCommand("SELECT Picture FROM Categories", dbcon);
                var reader = command.ExecuteReader();
                var counter = 0;

                while (reader.Read())
                {
                    byte[] imageByteArray = (byte[])reader["Picture"];

                    const int oleMetaPictStartPosition = 78;
                    var memoryStream =
                        new MemoryStream(imageByteArray, oleMetaPictStartPosition,
                            imageByteArray.Length - oleMetaPictStartPosition);

                    using (memoryStream)
                    {
                        using (var image = Image.FromStream(memoryStream, true, true))
                        {
                            image.Save("../../picture" + (++counter) + ".jpg");
                        }
                    }
                }
            }

            Console.WriteLine("Images exported successfully!");
            Console.WriteLine("See project folder for results!");
        }
    }
}

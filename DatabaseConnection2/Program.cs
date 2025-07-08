using Microsoft.Data.SqlClient;

namespace DatabaseConnection2
{
    internal class Program
    {
        public class SfAuthor
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Birth_year { get; set; }
            public string Nationality { get; set; }
            public string Notable_work { get; set; }
        }

        // This is for MS SQL Connections
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string connectionString = "Server=GWENTSURFACE;Database=sf_authors;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM sf_authors";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine(reader);
                    }
                }
            }
        }
    }
}

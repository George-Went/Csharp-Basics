

using MySql.Data.MySqlClient;

namespace DatabaseConnection
{
    internal class Program
    {
        // THis is for mySQL Database Connections
        // To get sql working 

        // Select Tools | NuGet Package Manager | Manage NuGet Packages for Solution
        // Click "Browse"
        // Type MySQL.Data
        // Select MySQL.Data by Microsoft
        // On the panel on the right, check your project.
        // Click Install
        // Click OK to the next box that comes up

        static void Main(string[] args)
        {
            //test1();
            test2();
        }

        static void test1()
        {
            Console.WriteLine("Test 1 (singleton db connection)");

            var dbCon = DBConnection.Instance();
            dbCon.Server = "192.168.1.130";
            dbCon.DatabaseName = "sf_authors";
            dbCon.UserName = "george";
            dbCon.Password = "wilma";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "SELECT col1, col2 FROM authors";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["col1"]} | {reader["col2"]}");
                }
                dbCon.Close();
            }
        }

        static void test2()
        {
            Console.WriteLine("Hello, World!");

            string connectionString = "server=192.168.1.130;database=sf_authors;uid=george;pwd=wilma;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM authors";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write($"{reader.GetName(i)}: {reader.GetValue(i)}  ");
                            Console.WriteLine();
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
    }
}

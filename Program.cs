using System;
using MySqlConnector;

namespace _05._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;database=proba";
            MySqlConnection kapcsolat = new MySqlConnection(connectionString);
            kapcsolat.Open();
            string sql = "SELECT * FROM nev";
            MySqlCommand sqlCmd = new MySqlCommand(sql, kapcsolat);
            MySqlDataReader adatok = sqlCmd.ExecuteReader();
            while (adatok.Read())
            {
                Console.WriteLine(adatok[1]);
            }
            kapcsolat.Close();
        }
    }
}

using System;
using System.Data.SqlClient;
using static System.Console;

namespace ReadingFromDatabase
{
    public partial class Program
    {
        static private string GetConnectionString()
        {
            return "Data Source=DESKTOP-EPR1T48;Initial Catalog=TSQLV4;Trusted_Connection = True;";
        }

        private static void OpenSQLConnection(string command, string column)
        //(string command, string row, string whereFrom)
        {
            string connectionString = GetConnectionString();

            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    WriteLine($"State: {con.State}");
                    WriteLine($"ConnectionString: {con.ConnectionString}");


                    SqlCommand com = new SqlCommand(command, con);
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        WriteLine(String.Format("{0}", reader[column]));
                    }
                }
            }
            catch (Exception sex)
            {
                WriteLine("Exception code:" + sex);
            }
        }
    }
}

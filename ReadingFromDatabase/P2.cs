using System;
using System.Data.SqlClient;
using static System.Console;

namespace ReadingFromDatabase
{
    public partial class Program
    {
        static private string GetConnectionString()
        {            
            return "Data Source=DESKTOP-EPR1T48;Initial Catalog=CIAPAGI;Trusted_Connection = True;";
        }

        private static void SelectSQL(string command, string column, string table)
        //(string command, string row, string whereFrom)
        {
            string connectionString = GetConnectionString();
            string fullCommand = command + " " + column + " FROM " + table;

            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    WriteLine($"State: {con.State}");
                    WriteLine($"ConnectionString: {con.ConnectionString}");


                    SqlCommand com = new SqlCommand(fullCommand, con);
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        WriteLine(String.Format("{0}", reader[column]));
                    }
                    
                    con.Close();
                }
            }
            catch (Exception sex)
            {
                WriteLine("Exception code:" + sex);
            }
        }

        private static void ModifySQL(string command)
        //(string command, string row, string whereFrom)
        {
            string connectionString = GetConnectionString();
            string fullCommand = command;

            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    WriteLine($"State: {con.State}");
                    WriteLine($"ConnectionString: {con.ConnectionString}");


                    SqlCommand com = new SqlCommand(fullCommand, con);
                    //com.Connection.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Exception code: {ex}");
            }
        }
    }
}


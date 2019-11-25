using System;
using System.Data.SqlClient;
using static System.Console;

namespace ReadingFromDatabase
{
    public partial class Program
    {      
        static void Main(string[] args)
        {
            string row = "orderid";
            string table = "Sales.Orders";
            
            //SelectSQL($"SELECT", "orderid", "Sales.Orders");

            //ModifySQL("INSERT odjazdy (godzina, kierunek, typPociagu, przewoznik, skad) VALUES(0000, 'Test', 'Test2', 'Test3', 'Test4')");

            ReadKey();
        }
    }
}

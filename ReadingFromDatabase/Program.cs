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
            //string whereFrom = "Sales.Orders";

            //OpenSQLConnection(operation, row, whereFrom);*/

            OpenSQLConnection("SELECT orderid FROM Sales.Orders", row);
            
            

            ReadKey();
        }
    }
}

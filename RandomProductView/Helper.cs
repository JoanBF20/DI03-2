using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DI03_2
{
    class Helper
    {
        private static string cnnVal = "Server=(localdb)\\MSSQLLocalDB;Database=AdventureWorks2016;Trusted_Connection=True;";

        public static string CnnVal
        {
            get { return cnnVal; }
            set { cnnVal = value; }
        }
    }
}

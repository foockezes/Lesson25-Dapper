using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class AppConnection
    {
        public static string ConString = "" + @"Data source=.\SQLEXPRESS; " + "Initial catalog=Person; " + "Trusted_Connection = True;";
    }
}

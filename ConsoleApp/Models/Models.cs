using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace EFCoreConsoleApp
{
    public class Clients
    {
        public int Id { get; set; }
        public string Login { get; set; }
    }
}

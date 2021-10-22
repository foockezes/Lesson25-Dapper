using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;


namespace EFCoreConsoleApp
{
    public class ClientsReposetory : IClientsRepository
    {
        string ConString = "" + @"Data source=.\SQLEXPRESS; " + "Initial catalog=Person; " + "Trusted_Connection = True;";

        public async Task<Clients> Delete(string login)
        {
            using (var db = new SqlConnection(ConString))
            {
                var result = await db.QueryFirstOrDefaultAsync<Clients>(@"DELETE FROM [dbo].[Clients] WHERE Login = @Login", new { Login = login });
                return result;
            }
        }


        public async Task<Clients> Insert(string newLogin)
        {
            using (var db = new SqlConnection(ConString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                var result = await db.QueryFirstOrDefaultAsync(@"INSERT INTO [dbo].[Clients] ([Login]) VALUES (@Login)", new { Login = newLogin });
                return result;
            }
        }

        public async Task<IEnumerable<Clients>> Select()
        {
            using (var db = new SqlConnection(ConString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                var result = await db.QueryAsync<Clients>(@"SELECT * FROM [dbo].[Clients]");
                return result;
            }
        }

        public async Task<Clients> Update(string login, string newlogin)
        {
            using (var db = new SqlConnection(ConString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                var result = await db.QueryFirstOrDefaultAsync(@"UPDATE [dbo].[Clients] SET Login = @newLogin WHERE Login = @Login", new { NewLogin = newlogin, Login = login });
                return result;
            }
        }
    }
}

using LoginPageWithAuthentication.DapperModels;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace LoginPageWithAuthentication.DapperQueries
{
    /// <summary>
    /// Class containing queries to the dbo.AspNetUsers table.
    /// Utilizes the <see cref="User"/> class
    /// </summary>
    public class UserQueries
    {
        public IEnumerable<User> GetUsers()
        {
            using (IDbConnection db = new SqlConnection())
            {
                return db.Query<User>("Select * From Author");
            }
        }
    }
}
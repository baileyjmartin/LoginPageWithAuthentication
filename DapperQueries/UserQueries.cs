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
        /// <summary>
        /// Gets all of the users stored in the database
        /// </summary>
        /// <returns>IEnumerable containing all of the User data</returns>
        public IEnumerable<User> GetUsers()
        {
            using (IDbConnection db = new SqlConnection())
            {
                return db.Query<User>("Select * From Author");
            }
        }
    }
}
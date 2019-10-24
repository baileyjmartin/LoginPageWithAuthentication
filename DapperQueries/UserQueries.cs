using LoginPageWithAuthentication.DapperModels;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace LoginPageWithAuthentication.DapperQueries
{
    /// <summary>
    /// Class containing queries to the dbo.AspNetUsers table.
    /// Utilizes the <see cref="User"/> class
    /// </summary>
    public static class UserQueries
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DapperConnection"].ConnectionString;

        /// <summary>
        /// Gets all of the users stored in the database
        /// </summary>
        /// <returns>IEnumerable containing all of the User data</returns>
        public static List<User> GetUsers()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<User>("SELECT * FROM dbo.AspNetUsers").AsList();
            }
        }

        /// <summary>
        /// Deletes a specified user
        /// </summary>
        /// <param name="id">Id of the user to be deleted</param>
        /// <returns>Whether or not the deletion was successful</returns>
        public static bool DeleteUser(string id)
        {
            var sql = @"DELETE FROM dbo.AspNetUsers WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                try
                {
                    db.Execute(sql, new { Id = id });
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
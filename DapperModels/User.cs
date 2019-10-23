namespace LoginPageWithAuthentication.DapperModels
{
    /// <summary>
    /// Class utilized by Dapper to map to the dbo.AspNetUsers table
    /// </summary>
    public class User
    {
        /// <summary>
        /// Represents the User's Id in the database
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The Email the user signed up with
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The user's hashed password
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// The UserName the user signed up with
        /// </summary>
        public string UserName { get; set; }
    }
}
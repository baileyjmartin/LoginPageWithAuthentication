namespace LoginPageWithAuthentication.DapperModels
{
    /// <summary>
    /// Class utilized by Dapper to map to the dbo.AspNetUsers table
    /// </summary>
    public class User
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string UserName { get; set; }
    }
}
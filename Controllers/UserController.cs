using LoginPageWithAuthentication.DapperQueries;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace LoginPageWithAuthentication.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// Gets the list of all currently registered users
        /// </summary>
        /// <returns>List of users in JSON format</returns>
        [HttpGet]
        public string GetUserList()
        {
            return JsonConvert.SerializeObject(UserQueries.GetUsers());
        }

        /// <summary>
        /// Deletes a specified user
        /// </summary>
        /// <param name="id">Id of the user to be deleted</param>
        /// <returns>Whether or not the deletion was successful</returns>
        [HttpDelete]
        public bool DeleteUser(string id)
        {
            return UserQueries.DeleteUser(id);
        }
    }
}
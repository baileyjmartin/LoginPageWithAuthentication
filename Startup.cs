using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginPageWithAuthentication.Startup))]
namespace LoginPageWithAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitLabApplication.Startup))]
namespace GitLabApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
